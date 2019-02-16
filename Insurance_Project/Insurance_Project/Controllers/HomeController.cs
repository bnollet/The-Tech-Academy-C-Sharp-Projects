using System;
using System.Linq;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace Insurance_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = InsuranceSignIn; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsuranceInfo(string FirstName, string LastName, string Email, DateTime DOB, string CarMake, string Carmodel, int CarYear, int Tickets, string DUI, string Coverage)
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(CarMake)
                || string.IsNullOrEmpty(Carmodel) || CarYear==0)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (InsuranceSignInEntities db = new InsuranceSignInEntities())
                {

                    int dateDifference = (DateTime.Now.Year - DOB.Year);
                    int Price = 50;
                    decimal price = Price + (Tickets * 10);


                    if (dateDifference < 25)
                    {
                        price = (price + 25);
                    }
                    if (dateDifference < 18)
                    {
                        price = (price + 100);
                    }
                    if (dateDifference > 100)
                    {
                        price = (price + 100);
                    }

                    if (CarYear < 2000)
                    {
                        price = (price + 25);
                    }
                    if (CarYear > 2015)
                    {
                        price = (price + 25);
                    }
                    if (CarMake == "Porsche")
                    {
                        price = (price + 25);
                    }
                    if (CarMake.ToLower() == "porsche" && Carmodel.ToLower() == "Carrera")
                    {
                        price = (price + 50);
                    }
                    if (DUI.ToLower() == "yes")
                    {
                        price = price + (Decimal.Multiply(price, .25M));
                    }
                    if (Coverage.ToLower() == "full")
                    {
                        price = price + (Decimal.Multiply(price, .50M));
                    }

                    //if (Coverage.ToLower() == "collision")
                    //{
                    //    price = price;
                    //}

                    //Console.WriteLine(price);
                    //Console.ReadLine();


                    var insurancesignin = new InsuranceInfo();

                    insurancesignin.FirstName = FirstName;
                    insurancesignin.LastName = LastName;
                    insurancesignin.Email = Email;
                    insurancesignin.CarMake = CarMake;
                    insurancesignin.Carmodel = Carmodel;
                    insurancesignin.CarYear = Convert.ToString(CarYear);
                    insurancesignin.Tickets = Tickets;
                    insurancesignin.Coverage = Coverage;
                    insurancesignin.DOB = DOB;
                    insurancesignin.DUI = DUI;
                    insurancesignin.price = Convert.ToInt32(price);
                    // add price save -- db.price = price;

                    db.InsuranceInfoes.Add(insurancesignin);
                    db.SaveChanges();
                }
            }
            InsuranceSignInEntities _db = new InsuranceSignInEntities();
            return View("Admin", _db.InsuranceInfoes.ToList()); // View("Admin");
        }

        public ActionResult Admin()
        {
            using (InsuranceSignInEntities db = new InsuranceSignInEntities())
            {
                var insuranceinfoes = db.InsuranceInfoes.ToList();
                var insurancesignins = new List<InsuranceInfo>();
                foreach (var insuranceinfo in insuranceinfoes )
                {
                    var insurancesignin = new InsuranceInfo();
                    insurancesignin.FirstName = insuranceinfo.FirstName;
                    insurancesignin.LastName = insuranceinfo.LastName;
                    insurancesignin.Email = insuranceinfo.Email;
                    insurancesignin.CarMake = insuranceinfo.CarMake;
                    insurancesignin.Carmodel = insuranceinfo.Carmodel;
                    insurancesignin.CarYear = insuranceinfo.CarYear;
                    insurancesignin.Tickets = insuranceinfo.Tickets;
                    insurancesignin.DUI = insuranceinfo.DUI;
                    insurancesignin.DOB = insuranceinfo.DOB;
                    insurancesignin.Coverage = insuranceinfo.Coverage;
                    insurancesignin.price = insuranceinfo.price;
                    // add price -- db.price = insuranceinfo.price

                    insurancesignins.Add(insurancesignin);

                }
                // InsuranceSignInEntities _db = new InsuranceSignInEntities();
                return View(insurancesignins);
            }

        }
    }
}





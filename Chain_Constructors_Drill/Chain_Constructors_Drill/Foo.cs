using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Constructors_Drill
{
   public class Foo
    {
        private int id;
        private string name;
        public Foo() : this(0, "")
        {
        }
        public Foo(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Foo(int id) : this(id, "")
        {
        }
        public Foo(string name) : this(0, name)
        {
        }
    }
}

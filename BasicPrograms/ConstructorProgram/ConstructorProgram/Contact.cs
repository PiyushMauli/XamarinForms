using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorProgram
{
    public class Contact
    {
        public int Id;
        public string Name;
        public List<Orders> Order;

        public Contact()
        {
            Order = new List<Orders>();
        }

        public Contact(int Id)
            : this()
        {
            this.Id = Id;
        }

        public Contact(int Id,string Name)
            : this()
        {
            this.Id = Id;
            this.Name = Name;

            Console.WriteLine("{0}---{1}", Id, Name);
        }
    }
}

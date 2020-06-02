using System;

namespace ConstructorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var contact = new Contact();
            contact.Id = 1;
            contact.Name = "Piyush";
            var order = new Orders();
            contact.Order.Add(order);

            var contact1 = new Contact(1);

            var contact2 = new Contact(2, "Gaurav Jiwane");
        }
    }
}

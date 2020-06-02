using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            UtilityFriends utilityFriends = new UtilityFriends(new Gaurav());
        }
    }

    public class UtilityFriends
    {
        private IFriends _IFriend;
        public UtilityFriends(IFriends IFriend)
        {
            this._IFriend = IFriend;
            _IFriend.FirstName();
            _IFriend.LastName();
        }
    }

    public interface IFriends
    {
        public void FirstName();
        public void LastName();
    }
    public class Piyush : IFriends
    {
        public void FirstName()
        {
            Console.WriteLine("First Name is Piyush");
        }
        public void LastName()
        {
            Console.WriteLine("Last Name is Jiwane");
        }
    }
    public class Gaurav : IFriends
    {
        public void FirstName()
        {
            Console.WriteLine("First Name is Gaurav");
        }
        public void LastName()
        {
            Console.WriteLine("Last Name is Jiwnae");
        }
    }
}

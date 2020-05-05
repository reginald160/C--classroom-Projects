using System;

namespace GenericConstraint
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("James Stuart", "#25 Okpara, Avenue.");
            User user2 = new User("James Stuart", "#25 Okpara, Avenue.");
            User user3 = new User("James Stuart", "#25 Okpara, Avenue.");
            User user4 = new User("James Stuart", "#25 Okpara, Avenue.");
            User user5 = new User("James Stuart", "#25 Okpara, Avenue.");

            GenericClass<User> genericList  = new GenericClass<User>();
            genericList.Add(user1);
            genericList.Add(user2);
            genericList.Add(user3);
            genericList.Add(user4);
            genericList.Add(user5);

            User[] users = new User[5];
            users = genericList.GetAllUsers();


        }
    }
}

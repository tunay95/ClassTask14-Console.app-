using System;
using System.Text.RegularExpressions;


namespace ClassTask13
{
    internal class Company
    {
        User[] Users;
        public string Name { get; set; }

        public Company(string name)
        {

            Users = new User[0];
            Name = name;

        }
        public void Register(string name, string surname, string password)
        {
            string username = name + "." + surname;
            string email = username + "@gmail.com";

            foreach (User item in Users)
            {

                if (item.Username == username)
                {
                    Console.WriteLine("User tapildi");
                    return;
                }

            }
            Regex regex = new Regex("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$");
            if (regex.IsMatch(password))
            {

                Array.Resize(ref Users, Users.Length + 1);
                Users[Users.Length - 1] = new User(name, surname, username, email, password);

            }
            else
            {
                Console.WriteLine("Password should be more than 7 char and include at least 1 upper, 1 lower letter and 1 digit !");
            }

        }

        public void Login(string username, string password)
        {

            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].Username == username && Users[i].Password == password)
                {
                    Console.WriteLine("Login is successful");
                    return;
                }
                else
                {
                    Console.WriteLine("Username or password is incorrect");
                }


            }

        }
        public void GetAll()
        {
            foreach (User item in Users)
            {

                Console.WriteLine(item.Username);

            }

        }

        public User GetByUsername(string username)
        {
            foreach (User item in Users)
            {

                if (item.Username == username)
                {

                    return item;
                }


            }
            return null;

        }
        public void UpdateByUsername(string username)
        {
            User update = GetByUsername(username);

            Console.WriteLine("=======================OPTIONS=========================");
            Console.WriteLine(" a. Update name\r\n b. Update surname\r\n c. Update username\r\n d. Update email");
            Console.WriteLine("=======================================================");

            Console.WriteLine("");
            string input = Console.ReadLine();
            Console.WriteLine("");

            switch (input)
            
            {
                case "a":

                    Console.Write("Input Name : ");
                    Console.WriteLine("");

                    string NewName=Console.ReadLine();
                    update.Name = NewName;

                    break;

                case "b":

                    Console.Write("Input Surname : ");
                    Console.WriteLine("");

                    string NewSurname = Console.ReadLine();
                    update.Surname = NewSurname;

                    break;

                case "c":

                    Console.Write("Input Username : ");
                    Console.WriteLine("");

                    string NewUsername = Console.ReadLine();
                    update.Username = NewUsername;

                    break;

                case "d":

                    Console.Write("Input Email : ");
                    Console.WriteLine("");
                    string NewEmail = Console.ReadLine();
                    update.Email = NewEmail;

                    break;

                    default: Console.WriteLine("Enter Right Variant !! ");
                    Console.WriteLine("");

                    break;

            }        
        }

        public void DeleteByUsername(string username)
        {
            User[]temp = new User[Users.Length - 1];
            int index = 0;
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].Username != username)
                {
                    temp[index] = Users[i];
                    index++;
                    
                }
            }
            Users=temp;
        }
    }
}
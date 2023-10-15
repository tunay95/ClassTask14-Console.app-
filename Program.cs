using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace ClassTask13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("QaraYazi");

            do
            {
                Console.WriteLine("=======================OPTIONS=========================");
                Console.WriteLine("1. Register a user(to company)\r\n2. Login a user(to company)\r\n3. See all users in a company(GetAll)\r\n4. Get one user by username(GetByUsername)\r\n5. Update user's data(UpdateByUsername)\r\n a. Update name\r\n b. Update surname\r\n c. Update username\r\n d. Update email\r\n6. Delete user from company(DeleteByUsername)\r\n7. Exit");
                Console.WriteLine("=======================================================");
                Console.WriteLine("PLEASE SELECT YOUR OPTION : ");
                Console.WriteLine("");
                string input = Console.ReadLine();
                Console.WriteLine("");
                switch (input)
                {

                    case "1":

                        Console.Write("Enter Your Name : ");
                        string name = Console.ReadLine();
                        Console.WriteLine("");

                        Console.Write("Enter Your Surname : ");
                        string surname = Console.ReadLine();
                        Console.WriteLine("");

                        Console.Write("Enter Your Password : ");
                        string password = Console.ReadLine();
                        Console.WriteLine("");

                        company.Register(name, surname, password);

                        break;


                    case "2":

                        Console.Write("Enter Your Username : ");
                        string username = Console.ReadLine();
                        Console.WriteLine("");

                        Console.Write("Enter Your password : ");
                        string password2 = Console.ReadLine();
                        Console.WriteLine("");

                        company.Login( username,  password2);

                        break;

                    case "3":

                        company.GetAll();

                        break;

                    case "4":

                        Console.WriteLine("Enter Your Username : ");
                        Console.WriteLine("");

                        string username2 = Console.ReadLine();
                        Console.WriteLine("");

                        company.GetByUsername(username2);

                        break;

                    case "5":

                        Console.WriteLine("Enter Your Username : ");
                        Console.WriteLine("");

                        string username3 = Console.ReadLine();
                        Console.WriteLine("");

                        company.UpdateByUsername(username3);

                        break;

                    
                     case "6":

                        Console.WriteLine("Enter Your Username : ");
                        Console.WriteLine("");
                        string username4 = Console.ReadLine();

                        company.DeleteByUsername(username4);

                        break;

                    case "7":

                        return;

                    default:

                        break;

                }

            }

            while (true) ;
        }
    }
}
    
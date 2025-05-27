using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pishrafte;

class Program
{
    static Usermanager Usermanager = new Usermanager();
    static User currentUser;
    static List<BlockManager> blockManager = new List<BlockManager>();
    static List<DormitoryManager> dormitoryManagers = new List<DormitoryManager>();
    static List<Student> students = new List<Student>();
    static List<Equipment> equipments = new List<Equipment>();
    public enum UserRole
    {
        Student,
        BlockManager,
        DormManager,
        Admin
    }



    static void Login()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("     Welcome to Dorm Management     ");
        Console.WriteLine("====================================");
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Login");
        Console.WriteLine("2. Register");
        Console.WriteLine("0. Exit(Don't use)");
        int choise = Convert.ToInt32(Console.ReadLine());
        switch (choise)
        {
            case 0:
                break;
            case 1:
                Loginas();
                break;
            case 2:
                Registeras();
                break;
            default:
                string invalid;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Invalid option.");
                    Console.WriteLine("Enter [0] to return");
                    invalid = Console.ReadLine();
                } while (invalid != "0");
                Login();
                break;
        }
    }

    static void Loginas()
    {
        Console.Clear();
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("Login as:");
        Console.WriteLine("1. Student");
        Console.WriteLine("2. Block Manager");
        Console.WriteLine("3. Dorm Manager");
        Console.WriteLine("4. ADMIN");
        Console.WriteLine("5. Back");
        Console.WriteLine("0. Exit(Don't use)");
        int choise = Convert.ToInt32(Console.ReadLine());
        switch (choise)
        {
            case 0:
                break;
            case 1:
                Console.WriteLine("Enter your username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter your Password:");
                string password = Console.ReadLine();
                User tempUser = new User(username, password, UserRole.Student);
                if (Usermanager.isUserExists(tempUser) == "student")
                {
                    Usermanager.CurrentUser = tempUser;
                    Mainmenu();
                }
                else
                {
                    string invalid1;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid username or password.");
                        Console.WriteLine("Enter 1 to continue.");
                        invalid1 = Console.ReadLine();
                    } while (invalid1 != "1");
                    Loginas();
                }
                break;
            case 2:
                Console.WriteLine("Enter your username");
                Console.WriteLine("Enter your Password");
                break;
            case 3:
                Console.WriteLine("Enter your username");
                Console.WriteLine("Enter your Password");
                break;
            case 4:
                Console.WriteLine("Enter your username");
                Console.WriteLine("Enter your Password");
                break;
            case 5:
                Login();
                break;
            default:
                string invalid;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Invalid option.");
                    Console.WriteLine("Enter [0] to return");
                    invalid = Console.ReadLine();
                } while (invalid != "0");
                Loginas();
                break;
        }

    }



    static void Registeras()
    {
        Console.Clear();
        Console.WriteLine("Register as:");
        Console.WriteLine("1. Student");
        Console.WriteLine("2. Block Manager");
        Console.WriteLine("3. Dorm Manager");
        Console.WriteLine("4. Back");
        Console.WriteLine("0. Exit(Don't use)");
        int choise = Convert.ToInt32(Console.ReadLine());
        switch (choise)
        {
            case 0:
                break;
            case 1:




                Console.Clear();
                Console.WriteLine("=== Student Registration ===");

                Console.Write("Enter First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                string lastName = Console.ReadLine();

                Console.Write("Enter National ID Number: ");
                int nationalId;
                while (!int.TryParse(Console.ReadLine(), out nationalId))
                {
                    Console.Write("Invalid input. Please enter a valid National ID Number: ");
                }

                if (Usermanager.NationalIdExists(nationalId,students, dormitoryManagers,blockManager))
                {
                    Console.WriteLine("A user with this National ID already exists.");
                    return;
                }
                Console.Write("Enter PhoneNumber: ");
                int phonenumber;
                while (!int.TryParse(Console.ReadLine(), out phonenumber))
                {
                    Console.Write("Invalid input. Please enter a valid PhoneNumber: ");
                }

                if (Usermanager.PhonenumberExists(phonenumber, students, dormitoryManagers, blockManager))
                {
                    Console.WriteLine("A user with this phonenumber already exists.");
                    return;
                }

                Console.Write("Enter Address: ");
                string address = Console.ReadLine();

                Console.Write("Enter Age: ");
                int age;
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.Write("Invalid input. Please enter a valid Age: ");
                }

                Console.Write("Enter Student ID Number: ");
                int studentId;
                while (!int.TryParse(Console.ReadLine(), out studentId))
                {
                    Console.Write("Invalid input. Please enter a valid Student ID Number: ");
                }
                if (Usermanager.StudentIDNumberExists(studentId, students, blockManager))
                {
                    Console.WriteLine("A user with this phonenumber already exists.");
                    return;
                }

                Student student = new Student(firstName, lastName, nationalId, phonenumber, address, age, studentId);

                Console.WriteLine("Enter your username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter your Password:");
                string password = Console.ReadLine();
                User tempUser = new User(username, password, UserRole.Student);
                Usermanager.Addstudent(tempUser);
                students.Add(student);
                Console.WriteLine("✅ Student registered successfully!");
                int input;
                do
                {
                    Console.WriteLine("Please enter 1 to Login:");
                } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);
                Login();
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                Login();
                break;
            default:
                string invalid;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Invalid option.");
                    Console.WriteLine("Enter [0] to return");
                    invalid = Console.ReadLine();
                } while (invalid != "0") ;
Registeras();
break;
        }
    }



    static void Mainmenu()
{
    Console.Clear();
    Console.WriteLine("Please choose an option:");
    Console.WriteLine("1. Dormitory Management");
    Console.WriteLine("2. Block Management");
    Console.WriteLine("3. User Management");
    Console.WriteLine("4. Asset Management");
    Console.WriteLine("5. Reporting ");
    Console.WriteLine("6. Support");
    Console.WriteLine("7. Log Out");
    Console.WriteLine("0. Exit(Don't use)");
    int choise = Convert.ToInt32(Console.ReadLine());
    switch (choise)
    {
        case 0:
            break;
        case 1:
            DormitoryManagement();
            break;
        case 2:
            BlockManagement();
            break;
        case 3:
            UserManagement();
            break;
        case 4:
            AssetManagement();
            break;
        case 5:
            Reporting();
            break;
        case 6:
            Support();
            break;
        case 7:
            Login();
            break;
        default:
            string invalid;
            do
            {
                Console.Clear();
                Console.WriteLine("Invalid option.");
                Console.WriteLine("Enter [0] to return");
                invalid = Console.ReadLine();
            } while (invalid != "0");
            Mainmenu();
            break;
    }
}











static void DormitoryManagement()
{
    Console.Clear();
    Console.WriteLine("Please choose an option:");
    Console.WriteLine("1. Add New Dormitory");
    Console.WriteLine("2. Delete Dormitory");
    Console.WriteLine("3. Edit Dormitory Information");
    Console.WriteLine("4. View Dormitory List");
    Console.WriteLine("5. Back");
    Console.WriteLine("0. Exit(Don't use)");
    int choise = Convert.ToInt32(Console.ReadLine());
    switch (choise)
    {
        case 0:
            break;
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            Mainmenu();
            break;
    }


}









static void BlockManagement()
{ }








static void UserManagement()
{ }







static void AssetManagement()
{ }








static void Reporting()
{ }







static void Support()
{ }







static void Main(string[] args)
{
    Login();
}
}


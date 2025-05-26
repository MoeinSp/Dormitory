using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pishrafte;

class Program
{




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
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
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
                } while (invalid != "0");
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


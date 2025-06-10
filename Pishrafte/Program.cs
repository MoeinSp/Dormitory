using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Pishrafte;

class Program
{
    static Usermanager Usermanager = new Usermanager();
    static User currentUser;
    static List<BlockManager> blockManagers = new List<BlockManager>();
    static List<DormitoryManager> dormitoryManagers = new List<DormitoryManager>();
    static List<Student> students = new List<Student>();
    static List<Equipment> equipments = new List<Equipment>();
    static List<Dormitory> dormitories = new List<Dormitory>();
    static List<Block> blocks = new List<Block>();
    static List<Room> rooms = new List<Room>();
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
                Console.WriteLine("Enter your username:");
                username = Console.ReadLine();
                Console.WriteLine("Enter your Password:");
                password = Console.ReadLine();
                tempUser = new User(username, password, UserRole.BlockManager);
                if (Usermanager.isUserExists(tempUser) == "Block Manager")
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
            case 3:
                Console.WriteLine("Enter your username:");
                username = Console.ReadLine();
                Console.WriteLine("Enter your Password:");
                password = Console.ReadLine();
                tempUser = new User(username, password, UserRole.DormManager);
                if (Usermanager.isUserExists(tempUser) == "Dormitory Manager")
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
            case 4:
                Console.WriteLine("Enter your username:");
                username = Console.ReadLine();
                Console.WriteLine("Enter your Password:");
                password = Console.ReadLine();
                tempUser = new User(username, password, UserRole.Admin);
                if (Usermanager.isUserExists(tempUser) == "Admin")
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
            Wrong1:
                Console.Write("Enter National ID Number: ");
                int nationalId;
                while (!int.TryParse(Console.ReadLine(), out nationalId))
                {
                    Console.Write("Invalid input. Please enter a valid National ID Number: ");
                }

                if (Usermanager.NationalIdExists(nationalId, students, dormitoryManagers, blockManagers))
                {
                    Console.WriteLine("A user with this National ID already exists.");
                    goto Wrong1;
                }
            Wrong2:
                Console.Write("Enter PhoneNumber: ");
                int phonenumber;
                while (!int.TryParse(Console.ReadLine(), out phonenumber))
                {
                    Console.Write("Invalid input. Please enter a valid PhoneNumber: ");
                }

                if (Usermanager.PhonenumberExists(phonenumber, students, dormitoryManagers, blockManagers))
                {
                    Console.WriteLine("A user with this phonenumber already exists.");
                    goto Wrong2;
                }

                Console.Write("Enter Address: ");
                string address = Console.ReadLine();

                Console.Write("Enter Age: ");
                int age;
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.Write("Invalid input. Please enter a valid Age: ");
                }
            Wrong3:
                Console.Write("Enter Student ID Number: ");
                int studentId;
                while (!int.TryParse(Console.ReadLine(), out studentId))
                {
                    Console.Write("Invalid input. Please enter a valid Student ID Number: ");
                }
                if (Usermanager.StudentIDNumberExists(studentId, students))
                {
                    Console.WriteLine("A user with this phonenumber already exists.");
                    goto Wrong3;
                }

                Student student = new Student(firstName, lastName, nationalId, phonenumber, address, age, studentId);

                Console.WriteLine("Enter your username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter your Password:");
                string password = Console.ReadLine();
                User tempUser = new User(username, password, UserRole.Student);
                Usermanager.Addstudent(tempUser);
                students.Add(student);
                Console.WriteLine(" Student registered successfully!");
                int input;
                do
                {
                    Console.WriteLine("Please enter 1 to Login:");
                } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);
                Login();
                break;
            case 2:


                Console.Clear();
                Console.WriteLine("=== Block Manager Registration ===");

                Console.Write("Enter First Name: ");
                firstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                lastName = Console.ReadLine();
            Wrong7:
                Console.Write("Enter National ID Number: ");
                while (!int.TryParse(Console.ReadLine(), out nationalId))
                {
                    Console.Write("Invalid input. Please enter a valid National ID Number: ");
                }

                if (Usermanager.NationalIdExists(nationalId, students, dormitoryManagers, blockManagers))
                {
                    Console.WriteLine("A user with this National ID already exists.");
                    goto Wrong7;
                }
            Wrong8:
                Console.Write("Enter PhoneNumber: ");
                while (!int.TryParse(Console.ReadLine(), out phonenumber))
                {
                    Console.Write("Invalid input. Please enter a valid PhoneNumber: ");
                }

                if (Usermanager.PhonenumberExists(phonenumber, students, dormitoryManagers, blockManagers))
                {
                    Console.WriteLine("A user with this phonenumber already exists.");
                    goto Wrong8;
                }

                Console.Write("Enter Address: ");
                address = Console.ReadLine();

                Console.Write("Enter Age: ");
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.Write("Invalid input. Please enter a valid Age: ");
                }
            Wrong9:
                Console.Write("Enter Student ID Number: ");
                while (!int.TryParse(Console.ReadLine(), out studentId))
                {
                    Console.Write("Invalid input. Please enter a valid Student ID Number: ");
                }
                if (Usermanager.StudentIDNumberExists(studentId, students))
                {
                    Console.WriteLine("A user with this phonenumber already exists.");
                    goto Wrong9;
                }
                Console.Write("Enter Role: ");
                string role = Console.ReadLine();

                BlockManager blockManager = new BlockManager(firstName, lastName, nationalId, phonenumber, address, age, studentId, role);

                Console.WriteLine("Enter your username:");
                username = Console.ReadLine();
                Console.WriteLine("Enter your Password:");
                password = Console.ReadLine();
                tempUser = new User(username, password, UserRole.BlockManager);
                Usermanager.AddBlockmanager(tempUser);
                students.Add(new Student(firstName, lastName, nationalId, phonenumber, address, age, studentId));
                blockManagers.Add(blockManager);
                Console.WriteLine(" Block Manager registered successfully!");
                do
                {
                    Console.WriteLine("Please enter 1 to Login:");
                } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);
                Login();



                break;
            case 3:

                Console.Clear();
                Console.WriteLine("=== Dorm Manager Registration ===");

                Console.Write("Enter First Name: ");
                firstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                lastName = Console.ReadLine();
            Wrong5:
                Console.Write("Enter National ID Number: ");
                while (!int.TryParse(Console.ReadLine(), out nationalId))
                {
                    Console.Write("Invalid input. Please enter a valid National ID Number: ");
                }

                if (Usermanager.NationalIdExists(nationalId, students, dormitoryManagers, blockManagers))
                {
                    Console.WriteLine("A user with this National ID already exists.");
                    goto Wrong5;
                }
            Wrong6:
                Console.Write("Enter PhoneNumber: ");
                while (!int.TryParse(Console.ReadLine(), out phonenumber))
                {
                    Console.Write("Invalid input. Please enter a valid PhoneNumber: ");
                }

                if (Usermanager.PhonenumberExists(phonenumber, students, dormitoryManagers, blockManagers))
                {
                    Console.WriteLine("A user with this phonenumber already exists.");
                    goto Wrong6;
                }

                Console.Write("Enter Address: ");
                address = Console.ReadLine();

                Console.Write("Enter Age: ");
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.Write("Invalid input. Please enter a valid Age: ");
                }

                Console.Write("Enter Role: ");
                role = Console.ReadLine();

                DormitoryManager dormitoryManager = new DormitoryManager(firstName, lastName, nationalId, phonenumber, address, age, role);

                Console.WriteLine("Enter your username:");
                username = Console.ReadLine();
                Console.WriteLine("Enter your Password:");
                password = Console.ReadLine();
                tempUser = new User(username, password, UserRole.DormManager);
                Usermanager.AddDormitorymanager(tempUser);
                dormitoryManagers.Add(dormitoryManager);
                Console.WriteLine(" Dormitory Manager successfully!");
                do
                {
                    Console.WriteLine("Please enter 1 to Login:");
                } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);
                Login();



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
        Console.WriteLine("3. Person Management");
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
                PersonManagement();
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
                Console.Clear();
                var touple = Dormitory.CrateDormitory(dormitoryManagers, students, blockManagers);
                Dormitory dorm = touple.Item1;
                DormitoryManager dormitorymanager = touple.Item2;
                if (dormitorymanager != null)
                    dormitoryManagers.Add(dormitorymanager);
                dormitories.Add(dorm);
                int index = dorm.AssignDormitoryToManager(dormitoryManagers);
                dormitoryManagers[index].Dormitory = dorm;
                Console.WriteLine("Dormitory registered successfully");
                int input;
                do
                {
                    Console.WriteLine("Please enter 1 to continue:");
                } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);
                DormitoryManagement();
                break;
            case 2:
                if (dormitories.Count == 0)
                {
                    Console.WriteLine("No dormitory found.");
                    do
                    {
                        Console.WriteLine("Please enter 1 to continue:");
                    } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);

                    DormitoryManagement();
                }
                int aa = Dormitory.SelectDormitoryAllFromList(dormitories) - 1;
                if (dormitories[aa].DormitoryManager != null)
                {
                    DormitoryManager temp = dormitories[aa].DormitoryManager;
                    temp.Dormitory = null;
                    dormitoryManagers.Remove(dormitories[aa].DormitoryManager);
                    dormitoryManagers.Add(temp);
                    dormitories.Remove(dormitories[aa]);
                }
                else
                {
                    dormitories.RemoveAt(aa);
                }
                Console.WriteLine("Dormitory delete successfully.");
                do
                {
                    Console.WriteLine("Please enter 1 to continue:");
                } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);

                DormitoryManagement();
                break;
            case 3:
                Console.Clear();
                if (dormitories.Count > 0)
                {
                    Console.WriteLine("List of dormitory for change :");
                    Console.WriteLine();
                    dorm = Dormitory.ShowListDormitory(dormitories);
                    dormitorymanager = dorm.DormitoryManager;
                    Dormitory Changedorm = Dormitory.ChangeDormitory(dorm);
                    DormitoryManager changedormitorymanager = dormitorymanager;
                    changedormitorymanager.Dormitory = Changedorm;
                    dormitories.Remove(dorm);
                    dormitories.Add(Changedorm);
                    dormitoryManagers.Remove(dorm.DormitoryManager);
                    dormitoryManagers.Add(changedormitorymanager);
                }
                else
                    Console.WriteLine("No Dormitory found.");
                do
                {
                    Console.WriteLine("Please enter 1 to continue:");
                } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);
                DormitoryManagement();
                break;
            case 4:
                Console.Clear();
                if (dormitories.Count > 0)
                {
                    Console.WriteLine("List of dormitory :");
                    Console.WriteLine();
                    Dormitory Dorm = Dormitory.ShowListDormitory(dormitories);
                    Dormitory.Showdata(Dorm);
                }
                else
                    Console.WriteLine("No Dormitory found.");
                do
                {
                    Console.WriteLine("Please enter 1 to continue:");
                } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);
                DormitoryManagement();
                break;
            case 5:
                Mainmenu();
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
                DormitoryManagement();
                break;
        }


    }









    static void BlockManagement()
    {
        {
            Console.Clear();
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Add New Block");
            Console.WriteLine("2. Delete Block");
            Console.WriteLine("3. Edit Block Information");
            Console.WriteLine("4. View Block List");
            Console.WriteLine("5. Back");
            Console.WriteLine("0. Exit(Don't use)");
            int choise = Convert.ToInt32(Console.ReadLine());
        }
    }







    static void PersonManagement()
    {

        Console.Clear();
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Dormitory Managers Management");
        Console.WriteLine("2. Block Managers Management");
        Console.WriteLine("3. Student Management");
        Console.WriteLine("4. Back");
        Console.WriteLine("0. Exit(Don't use)");
        int choise = Convert.ToInt32(Console.ReadLine());
        switch (choise)
        {
            case 0:
                break;
            case 1:
                DormitoryManagersManagement();
                break;
            case 2:
                BlockManagersManagement();
                break;
            case 3:
                StudentManagement();
                break;
            case 4:
                Mainmenu();
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
                PersonManagement();
                break;
        }
    }

    static void StudentManagement()
    {
        Console.Clear();
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Add new student");
        Console.WriteLine("2. Delete student");
        Console.WriteLine("3. Edit student information");
        Console.WriteLine("4. Search by Name or Student ID ");
        Console.WriteLine("5. View Full Student Information");
        Console.WriteLine("6. Student Registration in Dormitory ");
        Console.WriteLine("7. Dormitory Reassignment ");
        Console.WriteLine("8. Back");
        Console.WriteLine("0. Exit(Don't use)");
        int choise = Convert.ToInt32(Console.ReadLine());
        switch (choise)
        {
            case 0:
                break;
            case 1:
                students.Add(Student.CrateStudent(dormitoryManagers, students, blockManagers));
                int input;
                do
                {
                    Console.WriteLine("Please enter 1 to continue:");
                } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);
                StudentManagement();
                break;
            case 2:
                BlockManagersManagement();
                break;
            case 3:
                StudentManagement();
                break;
            case 4:
                Student.SearchStudent(students);
                do
                {
                    Console.WriteLine("Please enter 1 to continue:");
                } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);
                StudentManagement();
                break;
            case 5:
                Student.FullStudentInformation(students);
                do
                {
                    Console.WriteLine("Please enter 1 to continue:");
                } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);
                StudentManagement();
                break;
            case 6:
                Student student = Student.SelectStudentFromAll(students);
                Dormitory Dormitory = Dormitory.ShowListDormitory(dormitories);
                Block Block = Dormitory.ShowDormitoryBlocks(student.Dormitory);
                Room Room = Block.ShowBlockRooms(student.Block.Rooms);
                if(Dormitory.capacity==0)
                {
                    Console.WriteLine("FULL");
                }
                else if (Room != null||Dormitory.capacity!=0)
                {
                    student.Dormitory = Dormitory;
                    student.Block = Block;
                    student.Room = Room;
                }
                do
                {
                    Console.WriteLine("Please enter 1 to continue:");
                } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);
                StudentManagement();
                break;
            case 7:
                student = Student.SelectStudentFromAll(students);
                if(student.Room==null)
                {
                    Console.WriteLine("The student has not previously registered in the dormitory.");
                    do
                    {
                        Console.WriteLine("Please enter 1 to continue:");
                    } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);
                    StudentManagement();
                }
                Dormitory = Dormitory.ShowListDormitory(dormitories);
                Block = Dormitory.ShowDormitoryBlocks(student.Dormitory);
                Room = Block.ShowBlockRooms(student.Block.Rooms);
                if (Dormitory.capacity == 0)
                {
                    Console.WriteLine("FULL");
                }
                else if (Room != null || Dormitory.capacity != 0)
                {
                    Room Oldroom = student.Room;
                    rooms.Remove(Oldroom);
                    student.Room.Students.Remove(student);
                    rooms.Add(student.Room);
                    student.Dormitory = Dormitory;
                    student.Block = Block;
                    student.Room = Room;
                    blocks.Remove(student.Block);
                    student.Block.Rooms.Remove()
                }
                do
                {
                    Console.WriteLine("Please enter 1 to continue:");
                } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);
                StudentManagement();
                break;
            case 8:
                PersonManagement();
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
                StudentManagement();
                break;
        }
    }




    static void BlockManagersManagement()
    {
        Console.Clear();
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Dormitory Managers Management");
        Console.WriteLine("2. Block Managers Management");
        Console.WriteLine("3. Student Management");
        Console.WriteLine("4. Back");
        Console.WriteLine("0. Exit(Don't use)");
        int choise = Convert.ToInt32(Console.ReadLine());
        switch (choise)
        {
            case 0:
                break;
            case 1:
                DormitoryManagersManagement();
                break;
            case 2:
                BlockManagersManagement();
                break;
            case 3:
                StudentManagement();
                break;
            case 4:
                Mainmenu();
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
                BlockManagersManagement();
                break;
        }
    }



    static void DormitoryManagersManagement()
    {
        Console.Clear();
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Add new Dormitory Manager");
        Console.WriteLine("2. Delete dormitory manager");
        Console.WriteLine("3. Edit dormitory manager information");
        Console.WriteLine("4. View the list of dormitory managers");
        Console.WriteLine("5. Back");
        Console.WriteLine("0. Exit(Don't use)");
        int choise = Convert.ToInt32(Console.ReadLine());
        switch (choise)
        {
            case 0:
                break;
            case 1:
                dormitoryManagers.Add(DormitoryManager.CrateDormitoryManager(dormitoryManagers, students, blockManagers));
                Console.WriteLine("No managers found.");
                int input;
                do
                {
                    Console.WriteLine("Please enter 1 to continue:");
                } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);

                DormitoryManagersManagement();
                break;
            case 2:
                if (dormitoryManagers.Count == 0)
                {
                    Console.WriteLine("No managers found.");
                    do
                    {
                        Console.WriteLine("Please enter 1 to continue:");
                    } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);

                    DormitoryManagersManagement();
                }
                int aa = DormitoryManager.ShowListDormitoryManager(dormitoryManagers) - 1;
                if (dormitoryManagers[aa].Dormitory != null)
                {
                    int a = Dormitory.IndexdDormitoryManager(dormitories, dormitoryManagers[aa]);
                    dormitories[a].DormitoryManager = null;
                    dormitoryManagers.RemoveAt(aa);
                }
                else
                {
                    dormitoryManagers.RemoveAt(aa);
                }
                Console.WriteLine("Dormitorymanger delete successfully.");
                do
                {
                    Console.WriteLine("Please enter 1 to continue:");
                } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);

                DormitoryManagersManagement();
                break;
            case 3:
                Console.Clear();
                if (dormitoryManagers.Count > 0)
                {
                    Console.WriteLine("List of dormitory manager for change :");
                    Console.WriteLine();
                    DormitoryManager dormitorymanager = DormitoryManager.SelectDormitoryManagerAllFromList(dormitoryManagers);
                    dormitoryManagers.Remove(dormitorymanager);
                    DormitoryManager changemanager = DormitoryManager.EditDormitoryManager(dormitorymanager);
                    if (dormitorymanager.Dormitory != null)
                    {
                        Dormitory dorm = dormitorymanager.Dormitory;
                        dormitories.Remove(dormitorymanager.Dormitory);
                        dorm.DormitoryManager = dormitorymanager;
                        dormitories.Add(dorm);
                        changemanager.Dormitory = dorm;
                    }
                    dormitoryManagers.Add(changemanager);
                }
                else if (dormitories.Count == 0)
                {
                    Console.WriteLine("No Dormitory manager found.");
                }
                do
                {
                    Console.WriteLine("Please enter 1 to continue:");
                } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);
                DormitoryManagersManagement();
                break;
            case 4:
                Console.Clear();
                if (dormitoryManagers.Count > 0)
                {
                    Console.WriteLine("List of managers");
                    Console.WriteLine();
                    DormitoryManager manager = DormitoryManager.SelectDormitoryManagerAllFromList(dormitoryManagers);
                    DormitoryManager.Showdata(manager);
                }
                else
                    Console.WriteLine("No managers found.");
                do
                {
                    Console.WriteLine("Please enter 1 to continue:");
                } while (!int.TryParse(Console.ReadLine(), out input) || input != 1);
                DormitoryManagersManagement();
                break;
            case 5:
                PersonManagement();
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
                DormitoryManagersManagement();
                break;
        }
    }


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


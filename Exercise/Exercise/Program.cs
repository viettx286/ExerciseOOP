using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Exercise
{
    class Program
    {
        static List<Staffs> StaffList = new List<Staffs>();
        static List<Managers> ManagerList = new List<Managers>();
        static List<Director> DirectorList = new List<Director>();


        public delegate void CheckFirstNameHandler();

        public static event CheckFirstNameHandler CheckFirstName;

        
        static void InputStaff()
        {
            Console.WriteLine("-------Staff---------");

            for (int i = 1; i <= 2; i++)
            {
                Staffs staff = new Staffs();
                string firstName;
                while (true)
                {
                    Console.WriteLine("Enter first name of staff {0} (Required, Not null)", i);
                    firstName = Console.ReadLine();
                    if (firstName == "Anh")
                    {
                        Console.WriteLine("Program exit");
                        Environment.Exit(0);
                    }

                    if (!String.IsNullOrEmpty(firstName))
                    {
                        staff.FirstName = firstName;
                        break;
                    }
                }

                String lastName;
                while (true)
                {
                    Console.WriteLine("Enter last name of staff {0} (Required, Not null)", i);
                    lastName = Console.ReadLine();
                    if (!String.IsNullOrEmpty(lastName))
                    {
                        staff.LastName = lastName;
                        break;
                    }
                }

                string numberOfDay;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter number Of workday of staff {0} (Requied is number", i);
                        numberOfDay = Console.ReadLine();

                        if (numberOfDay.All(char.IsDigit) && !String.IsNullOrEmpty(numberOfDay)) ;
                        {
                            staff.NumberOfWorkDay = Convert.ToInt32(numberOfDay);
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter a number, not enter char or string");
                        throw;
                    }
                }

                StaffList.Add(staff);
            }
        }

        static void InputManager()
        {
            Console.WriteLine("-------Manager---------");
            for (int i = 1; i <= 2; i++)
            {
                Managers manager = new Managers();
                string firstName;
                while (true)
                {
                    Console.WriteLine("Enter first name of manager {0} (Required, Not null)", i);
                    firstName = Console.ReadLine();
                    if (firstName == "Anh")
                    {
                        Console.WriteLine("Program exit");
                        Environment.Exit(0);
                    }

                    if (!String.IsNullOrEmpty(firstName))
                    {
                        manager.FirstName = firstName;
                        break;
                    }
                }

                String lastName;
                while (true)
                {
                    Console.WriteLine("Enter last name of manager {0} (Required, Not null)", i);
                    lastName = Console.ReadLine();
                    if (!String.IsNullOrEmpty(lastName))
                    {
                        manager.LastName = lastName;
                        break;
                    }
                }

                string numberOfDay;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter number Of workday of manager {0} (Requied is number", i);
                        numberOfDay = Console.ReadLine();

                        if (numberOfDay.All(char.IsDigit) && !String.IsNullOrEmpty(numberOfDay)) ;
                        {
                            manager.NumberOfWorkDay = Convert.ToInt32(numberOfDay);
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter a number, not enter char or string");
                        throw;
                    }
                }

                ManagerList.Add(manager);
            }
        }

        static void InputDirector()
        {
            Console.WriteLine("-------Director--------");
            for (int i = 1; i <= 2; i++)
            {
                Director director = new Director();
                string firstName;
                while (true)
                {
                    Console.WriteLine("Enter first name of director {0} (Required, Not null)", i);
                    firstName = Console.ReadLine();
                    if (firstName == "Anh")
                    {
                        Console.WriteLine("Program exit");
                        Environment.Exit(0);
                    }

                    if (!String.IsNullOrEmpty(firstName))
                    {
                        director.FirstName = firstName;
                        break;
                    }
                }

                String lastName;
                while (true)
                {
                    Console.WriteLine("Enter last name of director {0} (Required, Not null)", i);
                    lastName = Console.ReadLine();
                    if (!String.IsNullOrEmpty(lastName))
                    {
                        director.LastName = lastName;
                        break;
                    }
                }

                string numberOfDay;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter number Of workday of director {0} (Requied is number", i);
                        numberOfDay = Console.ReadLine();

                        if (numberOfDay.All(char.IsDigit) && !String.IsNullOrEmpty(numberOfDay)) ;
                        {
                            director.NumberOfWorkDay = Convert.ToInt32(numberOfDay);
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter a number, not enter char or string");
                        throw;
                    }
                }

                DirectorList.Add(director);
            }
        }

        static void WriteFile()
        {
            using (StreamWriter sw = new StreamWriter("exportfile.txt"))
            {
                foreach (Staffs s in StaffList)
                {
                    sw.WriteLine(s.ToString());
                }

                foreach (Managers m in ManagerList)
                {
                    sw.WriteLine(m.ToString());
                }

                foreach (Director d in DirectorList)
                {
                    sw.WriteLine(d.ToString());
                }
            }
        }

        static void FrintList()
        {
            foreach (Staffs staffs in StaffList)
            {
                Console.WriteLine(staffs.ToString());
            }

            foreach (Managers managers in ManagerList)
            {
                Console.WriteLine(managers.ToString());
            }

            foreach (Director directors in DirectorList)
            {
                Console.WriteLine(directors.ToString());
            }

            Thread.Sleep(30);
        }

        static void Main(string[] args)
        {
            InputStaff();
            InputManager();
            InputDirector();

            Thread newThread = new Thread(WriteFile);
            newThread.Start();
            FrintList();
        }
    }
}
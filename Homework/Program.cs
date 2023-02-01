namespace Homework
{
    class Program
    {


        static void Main(string[] args)
        {
            Headquarter headquarter = new Headquarter();
            headquarter = FileHelper.LoadFromFile();
            do
            {

                Helper.ShowMenu();
                int choice;
                while (true)
                {
                    Console.Write("Select option ->");

                    if (Int32.TryParse(Console.ReadLine(), out choice) &&
                        Enum.IsDefined<Menu>((Menu)choice))
                        break;


                    Console.WriteLine("Non existent Function");
                }

                Menu selectedItem = (Menu)choice;
                switch (selectedItem)
                {
                    case Menu.Add:
                        Console.WriteLine();
                        Console.Write("Enter employee Name -> ");
                        string name = Console.ReadLine();
                        Console.Write("Enter employee Lastname -> ");
                        string Lastname = Console.ReadLine();
                        Console.Write("Enter employee Salary -> ");
                        decimal salary = decimal.Parse(Console.ReadLine());
                        Helper.ShowDepMenu();
                        int depchoice;
                        while (true)
                        {
                            Console.Write("Enter employee Department ->");

                            if (Int32.TryParse(Console.ReadLine(), out depchoice) &&
                                Enum.IsDefined<Menu>((Menu)depchoice))
                                break;


                            Console.WriteLine("Non existent Function");
                        }
                        Headquarters headquarters = (Headquarters)depchoice;
                        string department = headquarters.ToString().AddSpaceBetween();
                        Employee employee = new Employee(department, name, Lastname, salary);
                        headquarter.Add(employee);
                        Console.WriteLine("----Employee added----");
                        FileHelper.SaveToFile(headquarter);
                        break;
                    case Menu.Find:
                        Console.Write("Enter Employee Name ->");
                        string Fname = Console.ReadLine();
                        Console.Write("Enter Employee LastName ->");
                        string Flastname = Console.ReadLine();
                        IEnumerable<Employee> employee1 = headquarter.Find(Fname, Flastname);

                        foreach (Employee item in employee1)
                        {

                            Console.WriteLine(item.ToString());

                        }
                        break;
                    case Menu.Remove:
                        Console.Write("Enter Employee Name ->");
                        string Rname = Console.ReadLine();
                        Console.Write("Enter Employee LastName ->");
                        string Rlastname = Console.ReadLine();
                        headquarter.Remove(Rname, Rlastname);
                        FileHelper.SaveToFile(headquarter);
                        break;
                    case Menu.ShowAll:
                        Console.WriteLine();
                        headquarter.ShowAll(headquarter);
                        break;
                    case Menu.ShowbyDepartment:
                        Helper.ShowDepMenu();
                        int choose;
                        while (true)
                        {
                            Console.Write("select item -> ");

                            if (Int32.TryParse(Console.ReadLine(), out choose) &&
                                Enum.IsDefined<Headquarters>((Headquarters)choose))
                                break;


                            Console.WriteLine("Non existing Function");
                        }
                        Headquarters chosen = (Headquarters)choose;
                        string dep = chosen.ToString();
                        IEnumerable<Employee> employee2 = headquarter.FindbyDep(dep);

                        foreach (Employee item in employee2)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        break;
                    case Menu.Save:
                        FileHelper.SaveToFile(headquarter);
                        break;
                    case Menu.Exit:
                        break;

                }
                Console.WriteLine();

            } while (true);


        }
    }
}
    

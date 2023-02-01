using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class FileHelper
    {

        const string FILENAME = "Companyemployees.txt";

        public static void SaveToFile(Headquarter headquarter)
        {
            using StreamWriter writer = new StreamWriter(FILENAME);

            foreach (Employee employee in headquarter)
            {
                writer.WriteLine(employee.ToFilestring());
            }
        }


        public static Headquarter LoadFromFile()
        {
            using StreamReader streamReader = new StreamReader(FILENAME);

            Headquarter newheadquarter = new Headquarter();

            string str;
            while ((str = streamReader.ReadLine()) != null)
            {

                newheadquarter.Add(Employee.Parse(str));
            }

            return newheadquarter;
        }
    }
}

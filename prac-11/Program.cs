using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_11
{
    enum Vacancies
    {
        Manager,
        Engineer,
        Designer,
        Developer
    }

    struct Employee
    {
        public string Name;         
        public Vacancies Vacancy;     
        public int[] HireDate;       
        public int Salary;      
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1;

            employee1.Name = "Акарыс Токталхан";
            employee1.Vacancy = Vacancies.Engineer;
            employee1.HireDate = new int[] { 202, 11, 15 };
            employee1.Salary = 5000000;

            Console.WriteLine($"Имя: {employee1.Name}");
            Console.WriteLine($"Вакансия: {employee1.Vacancy}");
            Console.WriteLine($"Дата приема на работу: {employee1.HireDate[0]}-{employee1.HireDate[1]}-{employee1.HireDate[2]}");
            Console.WriteLine($"Зарплата: {employee1.Salary}");

            Console.ReadLine();
        }
    }
}

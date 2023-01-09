using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Services
{
    public class PersonService
    {
        public List<Person> GetAllEmploye()
        {
            List<Person> persons = new List<Person>();
            Person pers1 = new Person()
            {
                Name = "Shaiq",
                Surname = "Kazimov",
                Address = "Sedmoy",
                Salary = 5000

            };

            Person pers2 = new Person()
            {
                Name = "Cavid",
                Surname = "Ismayilzade",
                Address = "Sulutepe",
                Salary = 5000

            };
            Person pers3 = new Person()
            {
                Name = "Murad",
                Surname = "Alizade",
                Address = "Hovsan",
                Salary = 3000

            };

            Person pers4 = new Person()
            {
                Name = "Kenan",
                Surname = "Alizade",
                Address = "2000",
                Salary = 5000

            };


            persons.Add(pers1);
            persons.Add(pers2);
            persons.Add(pers3);
            persons.Add(pers4);
            return persons;
        }

        public List<Person> GetPersonSalary(Predicate<Person> func, List<Person> persons)
        {

            var result = GetAllEmploye();
            List<Person> personall = new List<Person>();
            foreach (var item in personall)
            {
                if (func(item))
                {
                    personall.Add(item);
                }

            }
            return personall;

        }

        public void FilterSalary()
        {
            var persons= GetAllEmploye();
            foreach (var item in persons)
            {
                if (item.Salary > 1000)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}

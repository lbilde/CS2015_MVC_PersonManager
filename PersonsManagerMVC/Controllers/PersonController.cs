using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonsManagerMVC.Models;

namespace PersonsManagerMVC.Controllers
{
    public class PersonController : Controller
    {
        private List<Person> _persons = 
            new List<Person>();
        // GET: Person
        public string Index()
        {
            return "Hej verden";
        }

        public string Id(int? id)
        {
            var ost = $"Id was not smølf {id}";
            if (id.HasValue)
            {
                Console.WriteLine("osty" + ost);
            }
            return ost;
        }

        public string Create(int id, string name)
        {
            var person = new Person()
            {
                Id = id,
                Name = name
            };
            _persons.Add(person);
            var personsList = "";
            _persons.ForEach(x => 
            personsList = CreateLines(personsList, x));

            /*foreach (var x in _persons)
            {
                personsList += "br";
                personsList += $"{x.Id} - {x.Name}";
            }*/

            return personsList;
        }

        private string CreateLines(
            string personsList, Person p)
        {

            personsList += "<br>";
            personsList += $"{p.Id} - {p.Name}";
            return personsList;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoItApp.Models;

namespace TodoItApp.Data
{
    public class PeopleService
    {
        private static Person[] persons = new Person[0];

        public int Size()
        {
            return persons.Length;
        }

        public Person[] FindAll()
        {
            return persons;
        }

        public Person FindById(int personId)
        {
            for(int i = 0; i < persons.Length; i++)
            {
                if(persons[i].PersonId == personId)
                {
                    return persons[i];
                }
            }
            return null;
        }

        public Person CreatePerson(string firstName, string lastName)
        {
            Person person = new Person(PersonSequencer.NextPersonId(),firstName,lastName);
            
            Array.Resize<Person>(ref persons , persons.Length + 1);
            persons[persons.Length-1] = person;

            return person;
        }

        public void Clear()
        {
            persons = new Person[0];
        }
    }
}

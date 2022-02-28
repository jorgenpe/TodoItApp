using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoItApp.Models
{
    public class Person
    {
        private int personId;
        private string firstName;
        private string lastName;


        Person(int personId) 
        {
            this.personId = personId;                                                                                                       
        }
        Person(int personId, string firstName, string lastName) 
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public int PersonId { get { return personId; }  }   
        
        public string FirstName { get { return firstName;}set { this.firstName =value; } }

        public String LastName { get { return lastName;}set { this.lastName =value; } }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoItApp.Models
{
    public class Person
    {
        private readonly int personId;
        private string firstName;
        private string lastName;


        public Person(int personId) 
        {
            this.personId = personId;                                                                                                       
        }
        public Person(int personId, string firstName, string lastName) 
        {
            this.personId = personId;
            FirstName = firstName;
            LastName = lastName;
        }
        public int PersonId { get { return personId; }  }   
        
        public string FirstName { get { return firstName;}
            set
            {
                
                if (value == null || value.Trim() == "")
                {
                    throw new ArgumentException("The first name can't be empty or null!");
                }
                else
                {
                    this.firstName = value.Trim();
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value == null || value.Trim() == "")
                {
                    throw new ArgumentException("The last name can't be empty or null!");
                }
                else
                {
                    this.lastName = value.Trim();
                }
            }
        }
        public string FullName { get { return $"{firstName} {lastName}"; } }    

       
    }
}

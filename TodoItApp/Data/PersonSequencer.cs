using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoItApp.Data
{
    public class PersonSequencer
    {
        private static int personId; 
        
       
        public static int NextPersonId()
        {
            return ++personId;
        }

        public static void Reset()
        {
            personId = 0;
        }  
    }
}

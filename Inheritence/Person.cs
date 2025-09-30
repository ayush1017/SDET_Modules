using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal abstract class Person
    {
        private string idNumber;
        private string lastname;
        private string firstname;
        private int age;
        protected DateTime dob;
        
        public Person(string id, string lname, string fname,int anAge, DateTime dob)
        {
            idNumber = id;
            lastname=lname;
            firstname=fname;
            age=anAge;
            this.dob = dob;


        }

        public abstract string ExerCise();
       

    }
}

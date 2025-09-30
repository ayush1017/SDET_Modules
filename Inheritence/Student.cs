using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Student:Person
    {
        private string major;
        private string student_id;

        public Student(string major, string student_id,string id,string lname,string fname,int age, DateTime dob):
            base(id, lname, fname, age, dob)
        {
            this.major = major;
            this.student_id = student_id;


        }

        public override string ExerCise()
        {
            return "Yo Yo Honey Singh";
        }
        public void GetDob()
        {
            base.dob;
        }

    }
}

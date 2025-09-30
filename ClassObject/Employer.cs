using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    internal class Employer
    {
        private string fname;
        private string lname;
        private string date_of_hire;
        private string jobdescription;
        private string department;
        private int age;
        private int salary;

        public Employer(string fName, string lName, string date_of_hire, string jobDescription, string department, int salary)
        {
            FName = fName;
            LName = lName;
            Date_Of_Joining = date_of_hire;
            JobDescription = jobDescription;
            Department = department;
            Salary = salary;
        }

        public string FName { get { return fname; } 
            set { fname = value; }
        }
        public string LName { get { return lname; } 
            set { lname = value; }
        }
        public string Date_Of_Joining { get { return date_of_hire; } 
            set { date_of_hire = value; }
        }
        public string JobDescription { get { return jobdescription; } 
            set { jobdescription = value; }
        }
        public string Department { get { return department; } 
            set { department = value; }
        }
        public int Salary { get { return salary; } 
            set { 
                if (value > 10000)
                {
                    salary = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Afsos Yeh galat Jawab.");
                }
            }
        }

        public string FullName()
        {
            string result= FName + " " + LName;
            return result;
        }
        public string Format()
        {
            return $"{LName}, {FName}";
        }


    }
}

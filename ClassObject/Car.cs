using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    internal class Car
    {
        string color;
        int numberOfDoors;
        bool isConvertible;
          
        //Construnctor does not have to be a return type;

        public Car(string color, int numberOfDoors, bool isConvertible)
        {
            Color = color;
            NumberOfDoors = numberOfDoors;
            IsConvertible = isConvertible;
        }
        public string Color { get { return color; } set { color = value; } }
        public int NumberOfDoors { get { return numberOfDoors; } 
            
            set {
                if (value <= 4)
                {
                    numberOfDoors = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException("Number of doors cannot be more than 4.");
                }
            } }

        public bool IsConvertible { get { return isConvertible; } set { isConvertible = value; } }

        // Methods are verb like things which does the work.

        public void Acclerate()
        {
            Console.WriteLine("I am Accelerating");
        }

        public bool FamilyCar()
        {
            if(NumberOfDoors > 2)
            {
                return true;
            }
            else
            {
                return false;
            }   
        }

    }
}

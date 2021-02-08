using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVechicle, ICompany
    {
        public Car()
        {

        }
        public double EngineSize { get; set; } = 2.0;
        public string Make { get; set; } = "Honda"; 
        public string Model { get; set; } = "Accord 2.0T";
        public int SeatCount { get; set; } = 5;
        public string CompanyName { get; set; } = "Honda Motor Company";
        public string Motto { get; set; } = "Be the best";
        public bool HasChangedGears { get; set; }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward......");
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }

        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park......");
                HasChangedGears == false;
            }
            else
            {
                Console.WriteLine("Can't park unitll we change gears");
            }

        }
    }

 }
    




﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVechicle, ICompany
    {
        public Truck()
        {

        }
        public double EngineSize { get; set; } = 6.0;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "F-150";
        public int SeatCount { get; set; } = 5;
        public string CompanyName { get; set; } = "Ford Motor Company";
        public string Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; }

        public bool HasFourWheelDrive { get; set; } = true;

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void Drive()
        {
            if(HasFourWheelDrive == true)
            Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward......");
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
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park unitll we change gears");
            }

        }
    }
}

// Coding Exercise 22: Inheritance & Overriding - Animals
using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            List<int> legCounts = exercise.GetCountsOfAnimalsLegs();

            foreach (var count in legCounts)
            {
                Console.WriteLine(count);
            }
        }
    }

    public class Exercise
    {
        public List<int> GetCountsOfAnimalsLegs()
        {
            var animals = new List<Animal>
            {
                new Lion(),
                new Tiger(),
                new Duck(),
                new Spider()
            };
            
            var result = new List<int>();
            foreach (var animal in animals)
            {
                result.Add(animal.NumberOfLegs);
            }
            return result;
        }
    }
    
    public class Animal
    {
        public virtual int NumberOfLegs { get; } = 4;
    }

    public class Lion : Animal
    {
        // No need to override NumberOfLegs, as it defaults to 4 in the base class
    }

    public class Tiger : Animal
    {
        // No need to override NumberOfLegs, as it defaults to 4 in the base class
    }

    public class Duck : Animal
    {
        public override int NumberOfLegs { get; } = 2;
    }

    public class Spider : Animal
    {
        public override int NumberOfLegs { get; } = 8;
    }
}


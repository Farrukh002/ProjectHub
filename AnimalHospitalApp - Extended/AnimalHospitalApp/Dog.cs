﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHospitalApp
{
    internal class Dog : Animal
    {
        private int? feedPeriod;
        private int? legsMissing;
        private readonly int numberOfLegs = 4;
        public string DogSound { get; set; }
        public Dog(DateTime arrival, DateTime departure, Owner owner = null, int?
       chipId = null, int? age = null, Gender gender = Gender.Unknown,
        string name = NN, string sound = NS)
            : base(arrival, departure, owner, chipId, age, gender, name, sound) { }
        public Dog(DateTime arrival, DateTime departure, int? feedPeriod, int?
       legsMissing, Owner owner = null, string name = NN, int? chipId = null,
        int? age = null, Gender gender = Gender.Unknown, string dogSound = NS)
        : base(arrival, departure, owner, chipId, age, gender, name, dogSound)
        {
            DogSound = dogSound;
            this.feedPeriod = feedPeriod;
            this.legsMissing = legsMissing;
        }
        public int? getFeedPeriod()
        {
            return feedPeriod != null ? feedPeriod : null;
        }   
        public void setFeedPeriod(int period)
        {
            feedPeriod = period;
        }
        public int? getNumberOfLegs()
        {
            return legsMissing != null ? numberOfLegs - legsMissing : numberOfLegs;
        }
        public void setNumberOfLegs(int legs)
        {
            legsMissing = legs;
        }
        public override void makeSound()
        {
            Console.WriteLine($"{Name} says {DogSound}");
        }
        /*public new void makeSound()
        {
        Console.WriteLine($"{Name} says {Sound} and {DogSound}");
        }*/

    }
}

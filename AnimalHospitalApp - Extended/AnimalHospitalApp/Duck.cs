﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHospitalApp
{
    internal class Duck : Animal
    {
        private int? feedPeriod;
        private int? legsMissing;
        private readonly int numberOfLegs = 2;
        public string DuckSound { get; set; }
        public Duck(DateTime arrival, DateTime departure, Owner owner, int? chipId =
       null, int? age = null, Gender gender = Gender.Unknown,
        string name = NN, string sound = NS)
        : base(arrival, departure, owner, chipId, age, gender, name, sound) { }
        public Duck(DateTime arrival, DateTime departure, int? feedPeriod, int?
       legsMissing, Owner owner = null, string name = NN, int? chipId = null,
        int? age = null, Gender gender = Gender.Unknown, string duckSound = NS)
            : base(arrival, departure, owner, chipId, age, gender, name, duckSound)
        {
            DuckSound = duckSound;
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
            Console.WriteLine($"{Name} says {DuckSound}");
        }
        /*public new void makeSound()
        {
        Console.WriteLine($"{Name} says {Sound} and {DogSound}");
        }*/
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cat
{
    public class Cat
    {
        private int energy;
        private Random rng;
        Mood mood;
        Feed feed;
        public string Name{get;}

        private Cat()
        {
            rng = new Random();
            energy = rng.Next(101);
        }
        public Cat(string name,Mood mood, Feed feed )
        {
            Name=name;
            this.mood=mood;
            this.feed = feed;
        }
        public Cat(string name):this(name,Mood.Happy,Feed.AboutToExplode){}
       
    }
}
using System;

namespace Kohde.Assessment
{
    public class Human : Mammal
    {
        public string Gender { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + "Age: " + Age + " Gender" + Gender;
        }

        public override string GetDetails()
        {
            return this.ToString();
        }
    }
}
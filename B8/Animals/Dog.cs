using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace E01.Vererbung.Animals
{
    public class Dog : Animal
    {
        public override string Name { get { return "dog"; } }
        public override void WhoAreYou()
        {
            MessageBox.Show("I am a dog");
        }
        public override bool Likes(string food)
        {
            return food == "bones" || food == "meat";
        }
        public override void Speak()
        {
            MessageBox.Show("Wooff");
        }
    }
}

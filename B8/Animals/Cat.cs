using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace E01.Vererbung.Animals
{
    public class Cat : Animal
    {
        public override string Name { get { return "cat"; } }
        public override void WhoAreYou()
        {
            MessageBox.Show("I am a cat");
        }
        public override bool Likes(string food)
        {
            return food == "milk" || food == "fish";
        }
        public override void Speak()
        {
            MessageBox.Show("Meoow");
        }
    }
}

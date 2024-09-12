using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace E01.Vererbung.Animals
{
    public class Cow : Animal
    {
        public override string Name { get { return "cow"; } }
        public override void WhoAreYou()
        {
            MessageBox.Show("I am a cow");
        }
        public override bool Likes(string food)
        {
            return food == "grass";
        }
        public override void Speak()
        {
            MessageBox.Show("Moooh");
        }
    }
}

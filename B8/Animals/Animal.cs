using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace E01.Vererbung.Animals
{
    public class Animal
    {
        public virtual string Name { get { return "animal"; } }
        public virtual void WhoAreYou()
        {
            MessageBox.Show("I am an animal");
        }
        public virtual bool Likes(string food)
        {
            return false;
        }
        public virtual void Speak()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace E01.Vererbung.Animals
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Animal[] farm = {
                new Cow(),
                new Dog(),
                new Cow(),
                new Cat(),
                new Cat()
            };

            foreach (Animal a in farm)
            {
                a.Speak();
            }

            foreach (Animal a in farm)
            {
                if(a is Dog)
                {
                    a.Speak();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
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

namespace E01.Vererbung
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

        private void btnTanken_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Instanzierung
                Pkw audi = new Pkw("Audi Q5", "AG 12", true, 8.5f, true);
                audi.Tankinhalt = 80.0f;
                Lkw saurer = new Lkw("Saurer", "AG 14", true, 15.5f, 200.0f, 2);


                Auto.Benzinpreis = 1.50f;
                Auto.Dieselpreis = 2.0f;

                // Audi geht tanken
                audi.Tanken(70.0f);
                MessageBox.Show("Anzahl Liter "
                                + audi.Kraftstoffvorrat.ToString());
                audi.Fahren(100);
                MessageBox.Show("Anzahl Liter "
                                + audi.Kraftstoffvorrat.ToString());

                MessageBox.Show("Fahrtkosten: "
                                + audi.Fahrtkosten.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnFahren_Click(object sender, RoutedEventArgs e)
        {
            Auto AudiQ5 = new Pkw("AudiQ5", "AG 4711", true, 6.5f);
            AudiQ5.Fahren(10.0f);

            Lkw Saurer = new Lkw("Saurer", 15.0f, 120.0f, 2);
            Saurer.Tanken(100.0f);

            Pkw AudiQ3 = new Pkw("Audi Q3", "", false, 8.50f, true);



            try
            {
                Auto.Benzinpreis = 1.38f;
                Auto.Dieselpreis = 1.33f;

                AudiQ5.Tankinhalt = 75.0f;
                AudiQ5.Verbrauch = 6.5f;
                AudiQ5.Tanken(75);

                AudiQ5.Fahren(100.0f);

                MessageBox.Show("Fahrtkosten= " + AudiQ5.Fahrtkosten.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

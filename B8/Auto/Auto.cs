using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace E01.Vererbung
{
    // Aufgabe 1
    // Erweitere die Klasse Auto um die Eigenschaft Diesel vom Datentyp bool. Berücksichtige dies
    // auch bei den Konstruktoren, denn die Kraftstoffart muss zur Erzeugung von Auto-Objekten
    // mittels True oder False angegeben werden.

    // Aufgabe 2
    // Erweitere die Klasse Auto um die Methode Fahren(km) und berücksichtige dabei folgende
    // Anforderungen
    //
    // 1. Der Parameter km hat den Datentyp float
    // 2. Autos dürfen nur vorwärts fahren
    // 3. Autos dürfen nur fahren, wenn genug Kraftstoffvorrat für die Fahrstrecke vorhanden ist.
    // 4. Vermindere den Kraftstoffvorrat um den Krafftstoffverbrauch für die zurückgelegte Fahrstrecke
    public abstract class Auto
    {
        private string _kennzeichen = string.Empty;
        protected string _marke = string.Empty;
        private float _verbrauch = 0.0f;
        private float _tankinhalt = 0.0f;
        private float _kraftstoffvorrat = 0.0f;
        private float _fahrtkosten = 0.0f;
        private bool _diesel = false;

        private static float _benzinpreis = 0.0f;
        private static float _dieselpreis = 0.0f;

        /// <summary>
        /// Benzinpreis 
        /// </summary>
        public static float Benzinpreis
        {
            set 
            {
                if (value > 0.0f)
                {
                    Auto._benzinpreis = value;
                }
                else
                {
                    throw new Exception("Benzinpreis ist ungültig!");
                }
            }
        }

        public static float Dieselpreis
        {
            set
            {
                if (value > 0.0f)
                {
                    Auto._dieselpreis = value;
                }
                else
                {
                    throw new Exception("Dieselpreis ist ungültig!");
                }
            }
        }
        /// <summary>
        /// Standardkonstruktor
        /// </summary>
        public Auto()
        {
            _diesel = false;
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="marke"></param>
        /// <param name="kennzeichen"></param>
        public Auto(string marke, string kennzeichen, bool diesel)
            : this()
        {
            _marke = marke;
            _kennzeichen = kennzeichen;
            _diesel = diesel;
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="marke">Automarke z.B. Audi, BMW</param>
        /// <param name="kennzeichen">Auto Nummer, z.B ZH, AG</param>
        /// <param name="diesel">Ist ein Dieselfahrzeug</param>
        /// <param name="verbrauch">Spritverbrauch in [l]/100 [KM]</param>
        public Auto(string marke, string kennzeichen, bool diesel, float verbrauch)
            : this(marke, kennzeichen, diesel)
        {
            _verbrauch = verbrauch;
        }

        public Auto(string marke, string kennzeichen, bool diesel, float verbrauch, float tankinhalt)
            : this(marke, kennzeichen, diesel, verbrauch)
        {
            _tankinhalt = tankinhalt;
        }

        public float Fahrtkosten
        {
            get { return _fahrtkosten; }
        }

        public string Kennzeichen
        {
            get { return _kennzeichen; }
            set { _kennzeichen = value; }
        }

        public string Marke
        {
            get { return _marke; }
            set { _marke = value; }
        }

        public float Verbrauch
        {
            get { return _verbrauch; }
            set
            {
                if (value < 0.0f)
                {
                    throw new Exception("Der Verbrauch ist ungültig.");
                }
                _verbrauch = value; 
            }
        }

        public float Tankinhalt
        {
            get { return _tankinhalt; }
            set { _tankinhalt = value; }
        }

        /// <summary>
        /// Aktueller Tankinhalt in [l]
        /// </summary>
        public float Kraftstoffvorrat
        {
            get { return _kraftstoffvorrat; }
        }

        public virtual void Fahren(float km)
        {
            if (km < 0.0f)
            {
                throw new Exception("Parameter ist unzulässig, km muss > 0 sein!");
            }

            if (_kraftstoffvorrat < (_verbrauch * km / 100))
            {
                throw new Exception("Nicht genügend Sprit!");
            }

            _kraftstoffvorrat -= _verbrauch * km / 100;

            if(_diesel)
            {
                _fahrtkosten += _verbrauch * km / 100 * _dieselpreis;
            }
            else
            {
                _fahrtkosten += _verbrauch * km / 100 * _benzinpreis;
            }
        }

        public virtual void Tanken(float liter)
        {
            if (liter < 0.0f)
            {
                throw new Exception("unzulässiger Wert!");
            }

            if ((_kraftstoffvorrat + liter) > _tankinhalt)
            {
                throw new Exception("So viel passt nicht in den Tank");
            }
            else
            {
                _kraftstoffvorrat += liter;
            }
        }
    }
}

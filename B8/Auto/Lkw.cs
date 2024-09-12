using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01.Vererbung
{
    // Aufgabe
    // Ergänze die Subklasse Lkw mit dem Konstruktur 
    // Lkw(marke, verbrauch, tankinhalt, achszahl)
    // Ein Lkw ohne Angabe der Achszahl darf nicht instanziert werden.

    public class Lkw : Auto
    {
        private byte _achszahl = 0;

        public Lkw(string marke, float verbrauch, float tankinhalt, byte achszahl)
            :base(marke, "", false, verbrauch, tankinhalt)
        {
            _achszahl = achszahl;
        }

        public Lkw(string marke, string kennzeichen, bool diesel, float verbrauch, float tankinhalt)
            : base(marke, kennzeichen, diesel, verbrauch, tankinhalt)
        {
            _achszahl = 2;
        }

        public Lkw(string marke, string kennzeichen, bool diesel, float verbrauch, float tankinhalt, byte achszahl)
            : this(marke, kennzeichen, diesel, verbrauch, tankinhalt)
        {
            if (achszahl < 2)
            {
                throw new Exception("Achszahl ist ungültig");
            }
            _achszahl = achszahl;
        }
    }
}

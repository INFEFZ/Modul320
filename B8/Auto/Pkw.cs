using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01.Vererbung
{
    // Subklassen
    public class Pkw : Auto
    {
        private bool _vignette = false;

        public Pkw()
            : base()
        {
            _vignette = false;
        }

        public Pkw(string marke, string kennzeichen, bool diesel, float verbrauch)
            : base(marke, kennzeichen, diesel, verbrauch)
        {
            _vignette = false;
        }

        public Pkw(string marke, string kennzeichen, bool diesel, float verbrauch, bool vignette)
            : this(marke, kennzeichen, diesel, verbrauch)
        {
            _vignette = vignette;
        }

        public override void Fahren(float km)
        {
            if (_vignette)
            {
                base.Fahren(km);
            }
            else
            {
                throw new Exception("Keine Vignette vorhanden.");
            }
        }
    }
}

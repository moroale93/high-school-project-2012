using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ControllerDispositivoRotazioneWebcam
{
    public class CPosizione
    {
        private Point pos;
        private string name;

        public CPosizione(string Nome, Point Posizione)
        {
            pos = Posizione;
            name = Nome;
        }

        public Point Posizione
        {
            get { return pos; }
        }

        public string Nome
        {
            get { return name; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numeral_Converter
{
    class RomanConverter : INotifyPropertyChanged
    {
        string lblOut;
        string txtIn;
        public string TxtIn
        {
            get { return txtIn; }
            set { txtIn = value; }
        }

        public string LblOut
        {
            get { return lblOut; }
            set { lblOut = value; propertyChanged(); }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void propertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

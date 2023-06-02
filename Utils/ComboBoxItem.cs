using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDisplay.Utils
{
    internal class ComboBoxItem
    {
        public string Text { get; set; }
        public string Id { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDisplay
{
    internal class ClickableLabel : Label
    {
        public ClickableLabel() : base()
        {
            AutoSize = true;
            Cursor = Cursors.Hand;
            BorderStyle = BorderStyle.FixedSingle;
        }
    }
}

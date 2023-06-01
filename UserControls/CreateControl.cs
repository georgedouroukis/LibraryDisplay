using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDisplay.UserControls
{
    public partial class CreateControl : UserControl
    {
        private LibraryForm parentForm;
        public CreateControl(LibraryForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            createPanel.Dock = DockStyle.Fill;
        }

        private void homeButtonCreatePanel_Click(object sender, EventArgs e)
        {
            parentForm.homeControl.BringToFront();
        }
    }
}

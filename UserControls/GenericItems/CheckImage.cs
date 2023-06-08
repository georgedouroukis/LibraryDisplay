using LibraryDisplay.Models;
using LibraryDisplay.Network;
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
    public partial class CheckImage : Form
    {
        string imageUrl;
        public CheckImage(string url)
        {
            InitializeComponent();
            checkImageGeneral.Dock = DockStyle.Fill;
            this.imageUrl = url;
            this.Visible = true;
        }

        private async void CheckImage_Load(object sender, EventArgs e)
        {
            Image image = await ImageHandler.GetImageFromUrl(imageUrl);
            this.Text = imageUrl;
            this.ClientSize = image.Size;
            checkImageGeneral.Image = image;
        }

        private void CheckImage_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


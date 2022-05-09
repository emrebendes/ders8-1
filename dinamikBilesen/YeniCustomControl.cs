using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinamikBilesen
{
    public partial class YeniCustomControl : Panel
    {
        PictureBox PictureBox;
        public YeniCustomControl()
        {
            InitializeComponent();
            PictureBox = new PictureBox();
            this.Controls.Add(PictureBox);  
        }
  
        public string ImageFile {
            set
            { 
                Image image = Image.FromFile(value);
                PictureBox.Image = image;

            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}

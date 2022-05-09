using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinamikBilesen.tasarımlar
{
    internal class tasınabilirButon:Button
    {

        Point lokasyon;


        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                lokasyon = e.Location;
                this.Size = new Size(this.Size.Width+10, this.Size.Height+10);
                this.BackColor = Color.White;
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
             if (e.Button == MouseButtons.Left)
             {
                this.Left += e.X-lokasyon.X;
                this.Top +=e.Y-lokasyon.Y;
             } 
             else if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                menu.Items.Add("Kapat", null, new EventHandler(this.kapatMetod));
                menu.Items.Add("programı Kapat", null, new EventHandler(this.programKapatMetod));
                this.ContextMenuStrip= menu;
            }

             base.OnMouseMove(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Size = new Size(this.Size.Width - 10, this.Size.Height - 10);
                this.BackColor = Color.Transparent;
            }
            base.OnMouseUp(e);
        }
        public void kapatMetod(object sender,EventArgs e) 
        {
            this.Dispose();
        }
        public void programKapatMetod(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

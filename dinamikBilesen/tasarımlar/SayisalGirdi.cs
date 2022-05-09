using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dinamikBilesen.tasarımlar
{
    internal class SayisalGirdi : TextBox
    {
        public SayisalGirdi() {
            this.Text = "0";
        }

        
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Regex r = new Regex(@"^-?[0-9]*(\.[0-9]*)?");
            Match m = r.Match(this.Text);
            if (m.Success)
                this.Text = m.Value;
            this.Select(this.Text.Length, 0);
        }
    }
}

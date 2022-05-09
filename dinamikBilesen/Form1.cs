namespace dinamikBilesen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tasýnabilirButon1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(sayisalGirdi1.Text);
           //int m = (int)numericUpDown1.Value;
            if (groupBox1.Controls.Count>0)
                foreach (Control c in groupBox1.Controls)
                    c.Dispose();
            for (int i = 1; i < n+1; i++)
            {
                TextBox tb = new TextBox();
                //tb.Text = i.ToString();
                tb.Location = new Point(10, 43 * (i + 1));
                //tb.Name = "tb" + i;
                groupBox1.Controls.Add(tb);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.FileDialog openFileDialog1 = new OpenFileDialog();
            /*openFileDialog1.ShowDialog();
            yeniCustomControl1.ImageFile = openFileDialog1.FileName;*/
        }
    }
}
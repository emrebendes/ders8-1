namespace dinamikBilesen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sayisalGirdi1 = new dinamikBilesen.tasarımlar.SayisalGirdi();
            this.tasınabilirButon1 = new dinamikBilesen.tasarımlar.tasınabilirButon();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.userControl11 = new dinamikBilesen.UserControl1();
            this.SuspendLayout();
            // 
            // sayisalGirdi1
            // 
            this.sayisalGirdi1.Location = new System.Drawing.Point(214, 18);
            this.sayisalGirdi1.Margin = new System.Windows.Forms.Padding(4);
            this.sayisalGirdi1.Name = "sayisalGirdi1";
            this.sayisalGirdi1.Size = new System.Drawing.Size(223, 43);
            this.sayisalGirdi1.TabIndex = 0;
            this.sayisalGirdi1.Text = "0";
            // 
            // tasınabilirButon1
            // 
            this.tasınabilirButon1.Location = new System.Drawing.Point(28, 14);
            this.tasınabilirButon1.Margin = new System.Windows.Forms.Padding(4);
            this.tasınabilirButon1.Name = "tasınabilirButon1";
            this.tasınabilirButon1.Size = new System.Drawing.Size(168, 50);
            this.tasınabilirButon1.TabIndex = 1;
            this.tasınabilirButon1.Text = "tasınabilirButon1";
            this.tasınabilirButon1.UseVisualStyleBackColor = true;
            this.tasınabilirButon1.Click += new System.EventHandler(this.tasınabilirButon1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(18, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(450, 539);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "katsayılar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "resim aç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(496, 110);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1251, 1534);
            this.userControl11.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2008, 881);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tasınabilirButon1);
            this.Controls.Add(this.sayisalGirdi1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private tasarımlar.SayisalGirdi sayisalGirdi1;
        private tasarımlar.tasınabilirButon tasınabilirButon1;
        private GroupBox groupBox1;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UserControl1 userControl11;
    }
}
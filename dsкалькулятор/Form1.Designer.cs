using System.Windows.Forms;

namespace dsкалькулятор
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(46, 46, 46);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("OptimusPrinceps", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(96, 99);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(71, 32);
            textBox1.TabIndex = 1;
            textBox1.MouseEnter += textBox1_MouseEnter;
            textBox1.MouseLeave += textBox1_MouseLeave;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(46, 46, 46);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("OptimusPrinceps", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(96, 276);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(71, 32);
            textBox2.TabIndex = 2;
            textBox2.MouseEnter += textBox2_MouseEnter;
            textBox2.MouseLeave += textBox2_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("OptimusPrinceps", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(46, 44);
            label1.Name = "label1";
            label1.Size = new Size(171, 32);
            label1.TabIndex = 3;
            label1.Text = "Your Level";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("OptimusPrinceps", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(20, 218);
            label2.Name = "label2";
            label2.Size = new Size(222, 32);
            label2.TabIndex = 4;
            label2.Text = "Required Level";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(46, 46, 46);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("OptimusPrinceps", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(359, 99);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(157, 32);
            textBox3.TabIndex = 5;
            textBox3.MouseEnter += textBox3_MouseEnter;
            textBox3.MouseLeave += textBox3_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.soul_png;
            pictureBox1.Location = new Point(378, 236);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("OptimusPrinceps", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(394, 44);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 7;
            label3.Text = "Souls";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("OptimusPrinceps", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Cornsilk;
            label4.Location = new Point(366, 218);
            label4.Name = "label4";
            label4.Size = new Size(142, 32);
            label4.TabIndex = 8;
            label4.Text = "Use Souls";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.free_icon_mute_4345771;
            pictureBox2.Location = new Point(749, 402);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1660854410_1_kartinkin_net_p_oboi_na_rabochii_stol_dark_souls_krasivo_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Soul Calculator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabPage tabPage3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
    }
}

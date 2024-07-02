using System.Windows.Forms;

namespace WinFormsApp2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponentForm2(int temp)
        {

            TableLayoutPanel tableLayoutPanel2;
            PictureBox pictureBox1;

            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;

            for (int i = 0; i < 4; i++)
            {

                tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
                tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            }

            tableLayoutPanel2.Size = new Size(800, 450);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            tableLayoutPanel2.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(203, 3);
            pictureBox1.Name = "pictureBox1";
            tableLayoutPanel2.SetRowSpan(pictureBox1, 4);
            pictureBox1.Size = new Size(394, 444);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel2);
            Name = "Form2";
            Text = "Fun_Cat";
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            this.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
            ResumeLayout(false);
            if (temp == 0)
            {
                pictureBox1.Image = Properties.Resources.Aboba;

            }
            else if (temp == 1)
            {

                pictureBox1.Image = Properties.Resources.CAT;
            }
            else if (temp == 2)
            {
                pictureBox1.Image = Properties.Resources.Lil_guy;
            }






        }
    }
}

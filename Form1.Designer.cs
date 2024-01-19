namespace CarProject
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            Car = new PictureBox();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            Gas = new Panel();
            label2 = new Label();
            brake = new Panel();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Car).BeginInit();
            Gas.SuspendLayout();
            brake.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(Car);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 984);
            panel1.TabIndex = 0;
            // 
            // Car
            // 
            Car.Image = Properties.Resources.top_view_car_123292;
            Car.Location = new Point(105, 693);
            Car.Margin = new Padding(4);
            Car.Name = "Car";
            Car.Size = new Size(123, 214);
            Car.SizeMode = PictureBoxSizeMode.StretchImage;
            Car.TabIndex = 0;
            Car.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLightLight;
            panel5.Location = new Point(157, 764);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(22, 151);
            panel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Location = new Point(157, 515);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(22, 157);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Location = new Point(157, 262);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(22, 151);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(157, 17);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(22, 154);
            panel2.TabIndex = 1;
            // 
            // Gas
            // 
            Gas.BackColor = Color.DarkGreen;
            Gas.Controls.Add(label2);
            Gas.Location = new Point(440, 515);
            Gas.Margin = new Padding(4);
            Gas.Name = "Gas";
            Gas.Size = new Size(359, 309);
            Gas.TabIndex = 1;
            Gas.MouseEnter += Gas_MouseEnter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(152, 150);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 31);
            label2.TabIndex = 1;
            label2.Text = "GAS";
            // 
            // brake
            // 
            brake.BackColor = Color.DarkRed;
            brake.Controls.Add(label1);
            brake.Location = new Point(440, 104);
            brake.Margin = new Padding(4);
            brake.Name = "brake";
            brake.Size = new Size(359, 309);
            brake.TabIndex = 2;
            brake.MouseEnter += brake_MouseEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(133, 137);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 31);
            label1.TabIndex = 0;
            label1.Text = "BRAKE";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 984);
            Controls.Add(brake);
            Controls.Add(Gas);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "CarControl";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Car).EndInit();
            Gas.ResumeLayout(false);
            Gas.PerformLayout();
            brake.ResumeLayout(false);
            brake.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private PictureBox Car;
        private Panel Gas;
        private Panel brake;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label1;
    }
}
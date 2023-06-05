namespace Anket.winforms
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
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            textBox1=new TextBox();
            textBox2=new TextBox();
            textBox3=new TextBox();
            label5=new Label();
            label6=new Label();
            label7=new Label();
            textBox4=new TextBox();
            textBox5=new TextBox();
            textBox6=new TextBox();
            label8=new Label();
            dateTimePicker1=new DateTimePicker();
            label9=new Label();
            radioButton1=new RadioButton();
            radioButton2=new RadioButton();
            button1=new Button();
            button2=new Button();
            textBox7=new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor=SystemColors.HotTrack;
            label1.BorderStyle=BorderStyle.FixedSingle;
            label1.FlatStyle=FlatStyle.Popup;
            label1.ForeColor=SystemColors.ControlLightLight;
            label1.Location=new Point(12, 9);
            label1.Name="label1";
            label1.Size=new Size(392, 25);
            label1.TabIndex=0;
            label1.Text="Anket";
            label1.TextAlign=ContentAlignment.MiddleCenter;
            label1.UseCompatibleTextRendering=true;
            label1.Click+=label1_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(12, 78);
            label2.Name="label2";
            label2.Size=new Size(67, 20);
            label2.TabIndex=1;
            label2.Text="Surname";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(12, 113);
            label3.Name="label3";
            label3.Size=new Size(49, 20);
            label3.TabIndex=2;
            label3.Text="Name";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(12, 144);
            label4.Name="label4";
            label4.Size=new Size(93, 20);
            label4.TabIndex=3;
            label4.Text="Father Name";
            // 
            // textBox1
            // 
            textBox1.BackColor=SystemColors.ButtonFace;
            textBox1.Location=new Point(109, 71);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(284, 27);
            textBox1.TabIndex=4;
            // 
            // textBox2
            // 
            textBox2.BackColor=SystemColors.ButtonFace;
            textBox2.Location=new Point(109, 104);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(284, 27);
            textBox2.TabIndex=5;
            // 
            // textBox3
            // 
            textBox3.BackColor=SystemColors.ButtonFace;
            textBox3.Location=new Point(111, 137);
            textBox3.Name="textBox3";
            textBox3.Size=new Size(284, 27);
            textBox3.TabIndex=6;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(12, 270);
            label5.Name="label5";
            label5.Size=new Size(34, 20);
            label5.TabIndex=7;
            label5.Text="City";
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point(12, 233);
            label6.Name="label6";
            label6.Size=new Size(60, 20);
            label6.TabIndex=8;
            label6.Text="Country";
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Location=new Point(12, 304);
            label7.Name="label7";
            label7.Size=new Size(50, 20);
            label7.TabIndex=9;
            label7.Text="Phone";
            // 
            // textBox4
            // 
            textBox4.BackColor=SystemColors.ButtonFace;
            textBox4.Location=new Point(111, 230);
            textBox4.Name="textBox4";
            textBox4.Size=new Size(284, 27);
            textBox4.TabIndex=10;
            // 
            // textBox5
            // 
            textBox5.BackColor=SystemColors.ButtonFace;
            textBox5.Location=new Point(111, 263);
            textBox5.Name="textBox5";
            textBox5.Size=new Size(284, 27);
            textBox5.TabIndex=11;
            // 
            // textBox6
            // 
            textBox6.BackColor=SystemColors.ButtonFace;
            textBox6.Location=new Point(111, 296);
            textBox6.Name="textBox6";
            textBox6.Size=new Size(284, 27);
            textBox6.TabIndex=12;
            // 
            // label8
            // 
            label8.AutoSize=true;
            label8.Location=new Point(12, 378);
            label8.Name="label8";
            label8.Size=new Size(100, 20);
            label8.TabIndex=13;
            label8.Text="Birthday Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor=SystemColors.AppWorkspace;
            dateTimePicker1.CalendarMonthBackground=SystemColors.MenuText;
            dateTimePicker1.Location=new Point(146, 371);
            dateTimePicker1.Name="dateTimePicker1";
            dateTimePicker1.Size=new Size(247, 27);
            dateTimePicker1.TabIndex=14;
            // 
            // label9
            // 
            label9.AutoSize=true;
            label9.Location=new Point(12, 428);
            label9.Name="label9";
            label9.Size=new Size(57, 20);
            label9.TabIndex=15;
            label9.Text="Gender";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize=true;
            radioButton1.Location=new Point(145, 427);
            radioButton1.Name="radioButton1";
            radioButton1.Size=new Size(63, 24);
            radioButton1.TabIndex=16;
            radioButton1.TabStop=true;
            radioButton1.Text="Male";
            radioButton1.UseVisualStyleBackColor=true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize=true;
            radioButton2.Location=new Point(251, 428);
            radioButton2.Name="radioButton2";
            radioButton2.Size=new Size(78, 24);
            radioButton2.TabIndex=17;
            radioButton2.TabStop=true;
            radioButton2.Text="Female";
            radioButton2.UseVisualStyleBackColor=true;
            // 
            // button1
            // 
            button1.BackColor=SystemColors.MenuHighlight;
            button1.ForeColor=SystemColors.ButtonFace;
            button1.Location=new Point(12, 489);
            button1.Name="button1";
            button1.Size=new Size(392, 29);
            button1.TabIndex=18;
            button1.Text="Save";
            button1.UseVisualStyleBackColor=false;
            // 
            // button2
            // 
            button2.BackColor=SystemColors.MenuHighlight;
            button2.ForeColor=SystemColors.HighlightText;
            button2.Location=new Point(224, 37);
            button2.Name="button2";
            button2.Size=new Size(180, 31);
            button2.TabIndex=19;
            button2.Text="Load";
            button2.UseVisualStyleBackColor=false;
            button2.Click+=button2_Click;
            // 
            // textBox7
            // 
            textBox7.BackColor=SystemColors.MenuHighlight;
            textBox7.ForeColor=SystemColors.Window;
            textBox7.Location=new Point(12, 37);
            textBox7.Name="textBox7";
            textBox7.Size=new Size(196, 27);
            textBox7.TabIndex=20;
            textBox7.Text="Ismayil";
            textBox7.TextAlign=HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(416, 707);
            Controls.Add(textBox7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label9);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle=FormBorderStyle.FixedToolWindow;
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Button button2;
        private TextBox textBox7;
    }
}
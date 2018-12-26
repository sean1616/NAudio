namespace NoiseFilter_TestModule
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Start_Tone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBox_Frequency = new System.Windows.Forms.TextBox();
            this.TxtBox_Amplitude = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Stop_Tone = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Start_Tone
            // 
            this.Btn_Start_Tone.Location = new System.Drawing.Point(32, 74);
            this.Btn_Start_Tone.Name = "Btn_Start_Tone";
            this.Btn_Start_Tone.Size = new System.Drawing.Size(142, 23);
            this.Btn_Start_Tone.TabIndex = 0;
            this.Btn_Start_Tone.Text = "Start Tone";
            this.Btn_Start_Tone.UseVisualStyleBackColor = true;
            this.Btn_Start_Tone.Click += new System.EventHandler(this.Btn_Start_Tone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frequency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amplitude";
            // 
            // TxtBox_Frequency
            // 
            this.TxtBox_Frequency.Location = new System.Drawing.Point(91, 21);
            this.TxtBox_Frequency.Name = "TxtBox_Frequency";
            this.TxtBox_Frequency.Size = new System.Drawing.Size(83, 22);
            this.TxtBox_Frequency.TabIndex = 4;
            this.TxtBox_Frequency.Text = "3000";
            // 
            // TxtBox_Amplitude
            // 
            this.TxtBox_Amplitude.Location = new System.Drawing.Point(91, 46);
            this.TxtBox_Amplitude.Name = "TxtBox_Amplitude";
            this.TxtBox_Amplitude.Size = new System.Drawing.Size(83, 22);
            this.TxtBox_Amplitude.TabIndex = 5;
            this.TxtBox_Amplitude.Text = "0.05";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Stop_Tone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Btn_Start_Tone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtBox_Amplitude);
            this.groupBox1.Controls.Add(this.TxtBox_Frequency);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tone Test";
            // 
            // Btn_Stop_Tone
            // 
            this.Btn_Stop_Tone.Location = new System.Drawing.Point(32, 103);
            this.Btn_Stop_Tone.Name = "Btn_Stop_Tone";
            this.Btn_Stop_Tone.Size = new System.Drawing.Size(142, 23);
            this.Btn_Stop_Tone.TabIndex = 9;
            this.Btn_Stop_Tone.Text = "Stop Tone";
            this.Btn_Stop_Tone.UseVisualStyleBackColor = true;
            this.Btn_Stop_Tone.Click += new System.EventHandler(this.Btn_Stop_Tone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Start_Tone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBox_Frequency;
        private System.Windows.Forms.TextBox TxtBox_Amplitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Stop_Tone;
    }
}


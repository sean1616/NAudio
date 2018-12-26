﻿namespace drawing
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_selection = new System.Windows.Forms.PictureBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.btn_zoom_in_x = new System.Windows.Forms.Button();
            this.btn_zoom_out_x = new System.Windows.Forms.Button();
            this.btn_zoom_out_y = new System.Windows.Forms.Button();
            this.btn_zoom_in_y = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.timer_init = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_selection)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pic_selection);
            this.panel1.Controls.Add(this.hScrollBar1);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Controls.Add(this.btn_zoom_in_x);
            this.panel1.Controls.Add(this.btn_zoom_out_x);
            this.panel1.Controls.Add(this.btn_zoom_out_y);
            this.panel1.Controls.Add(this.btn_zoom_in_y);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 460);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pic_selection
            // 
            this.pic_selection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pic_selection.Location = new System.Drawing.Point(583, 376);
            this.pic_selection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_selection.Name = "pic_selection";
            this.pic_selection.Size = new System.Drawing.Size(74, 56);
            this.pic_selection.TabIndex = 7;
            this.pic_selection.TabStop = false;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 50;
            this.hScrollBar1.Location = new System.Drawing.Point(170, 348);
            this.hScrollBar1.Maximum = 5000;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(262, 26);
            this.hScrollBar1.TabIndex = 6;
            this.hScrollBar1.Value = 50;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 50;
            this.vScrollBar1.Location = new System.Drawing.Point(524, 136);
            this.vScrollBar1.Maximum = 5000;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 173);
            this.vScrollBar1.TabIndex = 5;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // btn_zoom_in_x
            // 
            this.btn_zoom_in_x.Font = new System.Drawing.Font("Wingdings 3", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_zoom_in_x.Location = new System.Drawing.Point(278, 396);
            this.btn_zoom_in_x.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_zoom_in_x.Name = "btn_zoom_in_x";
            this.btn_zoom_in_x.Size = new System.Drawing.Size(19, 19);
            this.btn_zoom_in_x.TabIndex = 4;
            this.btn_zoom_in_x.TabStop = false;
            this.btn_zoom_in_x.Text = "u";
            this.btn_zoom_in_x.UseVisualStyleBackColor = true;
            this.btn_zoom_in_x.Click += new System.EventHandler(this.btn_zoom_in_x_Click);
            this.btn_zoom_in_x.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Focus_Reset);
            // 
            // btn_zoom_out_x
            // 
            this.btn_zoom_out_x.Font = new System.Drawing.Font("Wingdings 3", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_zoom_out_x.Location = new System.Drawing.Point(248, 396);
            this.btn_zoom_out_x.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_zoom_out_x.Name = "btn_zoom_out_x";
            this.btn_zoom_out_x.Size = new System.Drawing.Size(19, 19);
            this.btn_zoom_out_x.TabIndex = 3;
            this.btn_zoom_out_x.TabStop = false;
            this.btn_zoom_out_x.Text = "t";
            this.btn_zoom_out_x.UseVisualStyleBackColor = true;
            this.btn_zoom_out_x.Click += new System.EventHandler(this.btn_zoom_out_x_Click);
            this.btn_zoom_out_x.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Focus_Reset);
            // 
            // btn_zoom_out_y
            // 
            this.btn_zoom_out_y.Font = new System.Drawing.Font("Wingdings 3", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_zoom_out_y.Location = new System.Drawing.Point(61, 206);
            this.btn_zoom_out_y.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_zoom_out_y.Name = "btn_zoom_out_y";
            this.btn_zoom_out_y.Size = new System.Drawing.Size(19, 19);
            this.btn_zoom_out_y.TabIndex = 2;
            this.btn_zoom_out_y.TabStop = false;
            this.btn_zoom_out_y.Text = "q";
            this.btn_zoom_out_y.UseVisualStyleBackColor = true;
            this.btn_zoom_out_y.Click += new System.EventHandler(this.btn_zoom_out_y_Click);
            this.btn_zoom_out_y.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Focus_Reset);
            // 
            // btn_zoom_in_y
            // 
            this.btn_zoom_in_y.Font = new System.Drawing.Font("Wingdings 3", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_zoom_in_y.Location = new System.Drawing.Point(61, 176);
            this.btn_zoom_in_y.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_zoom_in_y.Name = "btn_zoom_in_y";
            this.btn_zoom_in_y.Size = new System.Drawing.Size(19, 19);
            this.btn_zoom_in_y.TabIndex = 1;
            this.btn_zoom_in_y.TabStop = false;
            this.btn_zoom_in_y.Text = "p";
            this.btn_zoom_in_y.Click += new System.EventHandler(this.btn_zoom_in_y_Click);
            this.btn_zoom_in_y.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Focus_Reset);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 539);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 71);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 17);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "http://www.GitHub.com/SWHarden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "C# Data Visualization Demo";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(3, 8);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(114, 26);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "DataView";
            // 
            // timer_init
            // 
            this.timer_init.Enabled = true;
            this.timer_init.Interval = 1;
            this.timer_init.Tick += new System.EventHandler(this.timer_init_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 539);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.layout);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_selection)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button btn_zoom_in_x;
        private System.Windows.Forms.Button btn_zoom_out_x;
        private System.Windows.Forms.Button btn_zoom_out_y;
        private System.Windows.Forms.Button btn_zoom_in_y;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer_init;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pic_selection;
    }
}


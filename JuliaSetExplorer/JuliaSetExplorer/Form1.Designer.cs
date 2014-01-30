namespace JuliaSetExplorer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRender = new System.Windows.Forms.Button();
            this.nmImaginary = new System.Windows.Forms.NumericUpDown();
            this.nmReal = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnRandom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmImaginary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmReal)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnRandom);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRender);
            this.panel1.Controls.Add(this.nmImaginary);
            this.panel1.Controls.Add(this.nmReal);
            this.panel1.Location = new System.Drawing.Point(518, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 193);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(4, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(172, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(4, 94);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(172, 25);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Imaginary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Real";
            // 
            // btnRender
            // 
            this.btnRender.Location = new System.Drawing.Point(4, 61);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(172, 25);
            this.btnRender.TabIndex = 2;
            this.btnRender.Text = "Render";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // nmImaginary
            // 
            this.nmImaginary.DecimalPlaces = 6;
            this.nmImaginary.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmImaginary.Location = new System.Drawing.Point(4, 32);
            this.nmImaginary.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmImaginary.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.nmImaginary.Name = "nmImaginary";
            this.nmImaginary.Size = new System.Drawing.Size(120, 20);
            this.nmImaginary.TabIndex = 1;
            // 
            // nmReal
            // 
            this.nmReal.DecimalPlaces = 6;
            this.nmReal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmReal.Location = new System.Drawing.Point(4, 4);
            this.nmReal.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmReal.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.nmReal.Name = "nmReal";
            this.nmReal.Size = new System.Drawing.Size(120, 20);
            this.nmReal.TabIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "\".bmp\"";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(4, 156);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(172, 23);
            this.btnRandom.TabIndex = 7;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Julia Set Explorer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmImaginary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmReal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.NumericUpDown nmImaginary;
        private System.Windows.Forms.NumericUpDown nmReal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnRandom;
    }
}


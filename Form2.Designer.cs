namespace codeChallenge5
{
    partial class MathVersion1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbt_Modulus = new System.Windows.Forms.RadioButton();
            this.rbt_Division = new System.Windows.Forms.RadioButton();
            this.rbt_Multiplication = new System.Windows.Forms.RadioButton();
            this.rbt_Subtraction = new System.Windows.Forms.RadioButton();
            this.rbt_Addition = new System.Windows.Forms.RadioButton();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_CLear = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInput2);
            this.groupBox1.Controls.Add(this.txtInput1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Andale Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(31, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data";
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(253, 58);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInput2.Size = new System.Drawing.Size(149, 29);
            this.txtInput2.TabIndex = 4;
            this.txtInput2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(253, 26);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(149, 29);
            this.txtInput1.TabIndex = 2;
            this.txtInput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Second Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter First Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbt_Modulus);
            this.groupBox2.Controls.Add(this.rbt_Division);
            this.groupBox2.Controls.Add(this.rbt_Multiplication);
            this.groupBox2.Controls.Add(this.rbt_Subtraction);
            this.groupBox2.Controls.Add(this.rbt_Addition);
            this.groupBox2.Font = new System.Drawing.Font("Andale Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(31, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 269);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Operation";
            // 
            // rbt_Modulus
            // 
            this.rbt_Modulus.AutoSize = true;
            this.rbt_Modulus.Location = new System.Drawing.Point(28, 175);
            this.rbt_Modulus.Name = "rbt_Modulus";
            this.rbt_Modulus.Size = new System.Drawing.Size(105, 25);
            this.rbt_Modulus.TabIndex = 10;
            this.rbt_Modulus.TabStop = true;
            this.rbt_Modulus.Text = "Modulus";
            this.rbt_Modulus.UseVisualStyleBackColor = true;
            // 
            // rbt_Division
            // 
            this.rbt_Division.AutoSize = true;
            this.rbt_Division.Location = new System.Drawing.Point(28, 140);
            this.rbt_Division.Name = "rbt_Division";
            this.rbt_Division.Size = new System.Drawing.Size(116, 25);
            this.rbt_Division.TabIndex = 9;
            this.rbt_Division.TabStop = true;
            this.rbt_Division.Text = "Division";
            this.rbt_Division.UseVisualStyleBackColor = true;
            // 
            // rbt_Multiplication
            // 
            this.rbt_Multiplication.AutoSize = true;
            this.rbt_Multiplication.Location = new System.Drawing.Point(28, 105);
            this.rbt_Multiplication.Name = "rbt_Multiplication";
            this.rbt_Multiplication.Size = new System.Drawing.Size(182, 25);
            this.rbt_Multiplication.TabIndex = 8;
            this.rbt_Multiplication.TabStop = true;
            this.rbt_Multiplication.Text = "Multiplication";
            this.rbt_Multiplication.UseVisualStyleBackColor = true;
            // 
            // rbt_Subtraction
            // 
            this.rbt_Subtraction.AutoSize = true;
            this.rbt_Subtraction.Location = new System.Drawing.Point(28, 70);
            this.rbt_Subtraction.Name = "rbt_Subtraction";
            this.rbt_Subtraction.Size = new System.Drawing.Size(149, 25);
            this.rbt_Subtraction.TabIndex = 7;
            this.rbt_Subtraction.TabStop = true;
            this.rbt_Subtraction.Text = "Subtraction";
            this.rbt_Subtraction.UseVisualStyleBackColor = true;
            // 
            // rbt_Addition
            // 
            this.rbt_Addition.AutoSize = true;
            this.rbt_Addition.Font = new System.Drawing.Font("Andale Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt_Addition.Location = new System.Drawing.Point(28, 35);
            this.rbt_Addition.Name = "rbt_Addition";
            this.rbt_Addition.Size = new System.Drawing.Size(116, 25);
            this.rbt_Addition.TabIndex = 6;
            this.rbt_Addition.TabStop = true;
            this.rbt_Addition.Text = "Addition";
            this.rbt_Addition.UseVisualStyleBackColor = true;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Font = new System.Drawing.Font("Andale Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Calculate.Location = new System.Drawing.Point(327, 183);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(124, 50);
            this.btn_Calculate.TabIndex = 11;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_CLear
            // 
            this.btn_CLear.Font = new System.Drawing.Font("Andale Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CLear.Location = new System.Drawing.Point(327, 243);
            this.btn_CLear.Name = "btn_CLear";
            this.btn_CLear.Size = new System.Drawing.Size(124, 50);
            this.btn_CLear.TabIndex = 12;
            this.btn_CLear.Text = "Clear";
            this.btn_CLear.UseVisualStyleBackColor = true;
            this.btn_CLear.Click += new System.EventHandler(this.btn_CLear_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Andale Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Close.Location = new System.Drawing.Point(327, 392);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(124, 50);
            this.btn_Close.TabIndex = 13;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // MathVersion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_CLear);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MathVersion1";
            this.Text = "Math Version 1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_Calculate;
        private Button btn_CLear;
        private Button btn_Close;
        private Label label2;
        private Label label1;
        private RadioButton rbt_Addition;
        private RadioButton rbt_Subtraction;
        private TextBox txtInput2;
        private TextBox txtInput1;
        private RadioButton rbt_Modulus;
        private RadioButton rbt_Division;
        private RadioButton rbt_Multiplication;
    }
}
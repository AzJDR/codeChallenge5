namespace codeChallenge5
{
    partial class Main
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
            this.btn_MathV1 = new System.Windows.Forms.Button();
            this.btn_MathV2 = new System.Windows.Forms.Button();
            this.btn_FPC = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MathV1
            // 
            this.btn_MathV1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_MathV1.Location = new System.Drawing.Point(90, 119);
            this.btn_MathV1.Name = "btn_MathV1";
            this.btn_MathV1.Size = new System.Drawing.Size(300, 100);
            this.btn_MathV1.TabIndex = 0;
            this.btn_MathV1.Text = "Math Operations";
            this.btn_MathV1.UseVisualStyleBackColor = true;
            this.btn_MathV1.Click += new System.EventHandler(this.btn_MathV1_Click);
            // 
            // btn_MathV2
            // 
            this.btn_MathV2.Location = new System.Drawing.Point(90, 225);
            this.btn_MathV2.Name = "btn_MathV2";
            this.btn_MathV2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_MathV2.Size = new System.Drawing.Size(300, 100);
            this.btn_MathV2.TabIndex = 1;
            this.btn_MathV2.Text = "Math Operations Version 2";
            this.btn_MathV2.UseVisualStyleBackColor = true;
            this.btn_MathV2.Click += new System.EventHandler(this.btn_MathV2_Click);
            // 
            // btn_FPC
            // 
            this.btn_FPC.Location = new System.Drawing.Point(90, 331);
            this.btn_FPC.Name = "btn_FPC";
            this.btn_FPC.Size = new System.Drawing.Size(300, 100);
            this.btn_FPC.TabIndex = 2;
            this.btn_FPC.Text = "Font Property Changer";
            this.btn_FPC.UseVisualStyleBackColor = true;
            this.btn_FPC.Click += new System.EventHandler(this.btn_FPC_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(356, 508);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(116, 41);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_FPC);
            this.Controls.Add(this.btn_MathV2);
            this.Controls.Add(this.btn_MathV1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_MathV1;
        private Button btn_MathV2;
        private Button btn_FPC;
        private Button btn_Exit;
    }
}
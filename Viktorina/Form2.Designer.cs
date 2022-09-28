
namespace Viktorina
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butAtbilde3 = new System.Windows.Forms.Button();
            this.butAtbilde2 = new System.Windows.Forms.Button();
            this.butAtbilde1 = new System.Windows.Forms.Button();
            this.labJautajums = new System.Windows.Forms.Label();
            this.labPunkti = new System.Windows.Forms.Label();
            this.labPiemers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butAtbilde3
            // 
            this.butAtbilde3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAtbilde3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butAtbilde3.Location = new System.Drawing.Point(29, 371);
            this.butAtbilde3.Name = "butAtbilde3";
            this.butAtbilde3.Size = new System.Drawing.Size(731, 48);
            this.butAtbilde3.TabIndex = 11;
            this.butAtbilde3.TabStop = false;
            this.butAtbilde3.Text = "3. atbilde";
            this.butAtbilde3.UseVisualStyleBackColor = true;
            this.butAtbilde3.Click += new System.EventHandler(this.butAtbilde3_Click);
            // 
            // butAtbilde2
            // 
            this.butAtbilde2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAtbilde2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butAtbilde2.Location = new System.Drawing.Point(29, 305);
            this.butAtbilde2.Name = "butAtbilde2";
            this.butAtbilde2.Size = new System.Drawing.Size(731, 48);
            this.butAtbilde2.TabIndex = 10;
            this.butAtbilde2.TabStop = false;
            this.butAtbilde2.Text = "2. atbilde";
            this.butAtbilde2.UseVisualStyleBackColor = true;
            this.butAtbilde2.Click += new System.EventHandler(this.butAtbilde2_Click);
            // 
            // butAtbilde1
            // 
            this.butAtbilde1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAtbilde1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butAtbilde1.Location = new System.Drawing.Point(29, 241);
            this.butAtbilde1.Name = "butAtbilde1";
            this.butAtbilde1.Size = new System.Drawing.Size(731, 48);
            this.butAtbilde1.TabIndex = 9;
            this.butAtbilde1.TabStop = false;
            this.butAtbilde1.Text = "1. atbilde";
            this.butAtbilde1.UseVisualStyleBackColor = true;
            this.butAtbilde1.Click += new System.EventHandler(this.butAtbilde1_Click);
            // 
            // labJautajums
            // 
            this.labJautajums.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labJautajums.ForeColor = System.Drawing.Color.Maroon;
            this.labJautajums.Location = new System.Drawing.Point(29, 102);
            this.labJautajums.Name = "labJautajums";
            this.labJautajums.Size = new System.Drawing.Size(731, 96);
            this.labJautajums.TabIndex = 8;
            this.labJautajums.Text = "Jautājums";
            this.labJautajums.Click += new System.EventHandler(this.labJautajums_Click);
            // 
            // labPunkti
            // 
            this.labPunkti.AutoSize = true;
            this.labPunkti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPunkti.Location = new System.Drawing.Point(687, 42);
            this.labPunkti.Name = "labPunkti";
            this.labPunkti.Size = new System.Drawing.Size(73, 20);
            this.labPunkti.TabIndex = 7;
            this.labPunkti.Text = "0 punkti";
            this.labPunkti.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labPiemers
            // 
            this.labPiemers.AutoSize = true;
            this.labPiemers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPiemers.Location = new System.Drawing.Point(25, 42);
            this.labPiemers.Name = "labPiemers";
            this.labPiemers.Size = new System.Drawing.Size(175, 20);
            this.labPiemers.TabIndex = 6;
            this.labPiemers.Text = "1. no 10 jautājumiem";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.butAtbilde3);
            this.Controls.Add(this.butAtbilde2);
            this.Controls.Add(this.butAtbilde1);
            this.Controls.Add(this.labJautajums);
            this.Controls.Add(this.labPunkti);
            this.Controls.Add(this.labPiemers);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Viktorīna";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAtbilde3;
        private System.Windows.Forms.Button butAtbilde2;
        private System.Windows.Forms.Button butAtbilde1;
        private System.Windows.Forms.Label labJautajums;
        private System.Windows.Forms.Label labPunkti;
        private System.Windows.Forms.Label labPiemers;
    }
}

namespace Viktorina
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
            this.butSakt = new System.Windows.Forms.Button();
            this.labVirsraksts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butSakt
            // 
            this.butSakt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butSakt.ForeColor = System.Drawing.Color.Maroon;
            this.butSakt.Location = new System.Drawing.Point(341, 373);
            this.butSakt.Name = "butSakt";
            this.butSakt.Size = new System.Drawing.Size(97, 42);
            this.butSakt.TabIndex = 3;
            this.butSakt.Text = "Sākt";
            this.butSakt.UseVisualStyleBackColor = true;
            this.butSakt.Click += new System.EventHandler(this.butSakt_Click);
            // 
            // labVirsraksts
            // 
            this.labVirsraksts.AutoSize = true;
            this.labVirsraksts.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labVirsraksts.ForeColor = System.Drawing.Color.Maroon;
            this.labVirsraksts.Location = new System.Drawing.Point(132, 22);
            this.labVirsraksts.Name = "labVirsraksts";
            this.labVirsraksts.Size = new System.Drawing.Size(520, 55);
            this.labVirsraksts.TabIndex = 2;
            this.labVirsraksts.Text = "Ko Tu zini par Latviju?";
            this.labVirsraksts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Viktorina.Properties.Resources.Latvija;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.butSakt);
            this.Controls.Add(this.labVirsraksts);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Viktorīna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSakt;
        private System.Windows.Forms.Label labVirsraksts;
    }
}


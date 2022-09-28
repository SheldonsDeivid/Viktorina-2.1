
namespace Viktorina
{
    partial class Form3
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
            this.labRezultats = new System.Windows.Forms.Label();
            this.labVirsraksts = new System.Windows.Forms.Label();
            this.labUzmundrinajums = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labRezultats
            // 
            this.labRezultats.BackColor = System.Drawing.Color.Transparent;
            this.labRezultats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labRezultats.Location = new System.Drawing.Point(26, 319);
            this.labRezultats.Name = "labRezultats";
            this.labRezultats.Size = new System.Drawing.Size(716, 91);
            this.labRezultats.TabIndex = 4;
            this.labRezultats.Text = "Rezultāts";
            this.labRezultats.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labRezultats.Click += new System.EventHandler(this.labRezultats_Click);
            // 
            // labVirsraksts
            // 
            this.labVirsraksts.AutoSize = true;
            this.labVirsraksts.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labVirsraksts.ForeColor = System.Drawing.Color.Maroon;
            this.labVirsraksts.Location = new System.Drawing.Point(128, 21);
            this.labVirsraksts.Name = "labVirsraksts";
            this.labVirsraksts.Size = new System.Drawing.Size(520, 55);
            this.labVirsraksts.TabIndex = 3;
            this.labVirsraksts.Text = "Ko Tu zini par Latviju?";
            // 
            // labUzmundrinajums
            // 
            this.labUzmundrinajums.BackColor = System.Drawing.Color.Transparent;
            this.labUzmundrinajums.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labUzmundrinajums.Location = new System.Drawing.Point(12, 366);
            this.labUzmundrinajums.Name = "labUzmundrinajums";
            this.labUzmundrinajums.Size = new System.Drawing.Size(760, 73);
            this.labUzmundrinajums.TabIndex = 5;
            this.labUzmundrinajums.Text = "Uzmundrinajums";
            this.labUzmundrinajums.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Viktorina.Properties.Resources.Latvija;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.labUzmundrinajums);
            this.Controls.Add(this.labRezultats);
            this.Controls.Add(this.labVirsraksts);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Viktorīna";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labRezultats;
        private System.Windows.Forms.Label labVirsraksts;
        private System.Windows.Forms.Label labUzmundrinajums;
    }
}
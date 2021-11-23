
namespace drustvo
{
    partial class Tiskanje
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtod = new System.Windows.Forms.DateTimePicker();
            this.dtdo = new System.Windows.Forms.DateTimePicker();
            this.btnnatisni = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "od dat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "do datum";
            // 
            // dtod
            // 
            this.dtod.Location = new System.Drawing.Point(139, 31);
            this.dtod.Name = "dtod";
            this.dtod.Size = new System.Drawing.Size(200, 20);
            this.dtod.TabIndex = 2;
            // 
            // dtdo
            // 
            this.dtdo.Location = new System.Drawing.Point(549, 39);
            this.dtdo.Name = "dtdo";
            this.dtdo.Size = new System.Drawing.Size(200, 20);
            this.dtdo.TabIndex = 3;
            // 
            // btnnatisni
            // 
            this.btnnatisni.Location = new System.Drawing.Point(57, 149);
            this.btnnatisni.Name = "btnnatisni";
            this.btnnatisni.Size = new System.Drawing.Size(75, 23);
            this.btnnatisni.TabIndex = 4;
            this.btnnatisni.Text = "button1";
            this.btnnatisni.UseVisualStyleBackColor = true;
            this.btnnatisni.Click += new System.EventHandler(this.btnnatisni_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Tiskanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnnatisni);
            this.Controls.Add(this.dtdo);
            this.Controls.Add(this.dtod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tiskanje";
            this.Text = "Tiskanje";
            this.Load += new System.EventHandler(this.Tiskanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtod;
        private System.Windows.Forms.DateTimePicker dtdo;
        private System.Windows.Forms.Button btnnatisni;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
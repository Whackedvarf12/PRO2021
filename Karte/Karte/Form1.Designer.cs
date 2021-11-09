
namespace Karte
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kup1 = new System.Windows.Forms.ListBox();
            this.kup2 = new System.Windows.Forms.ListBox();
            this.ltor = new System.Windows.Forms.Button();
            this.rtol = new System.Windows.Forms.Button();
            this.pon1 = new System.Windows.Forms.Button();
            this.pon2 = new System.Windows.Forms.Button();
            this.mes1 = new System.Windows.Forms.Button();
            this.mes2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kup1
            // 
            this.kup1.FormattingEnabled = true;
            this.kup1.Location = new System.Drawing.Point(334, 43);
            this.kup1.Name = "kup1";
            this.kup1.Size = new System.Drawing.Size(120, 277);
            this.kup1.TabIndex = 2;
            // 
            // kup2
            // 
            this.kup2.FormattingEnabled = true;
            this.kup2.Location = new System.Drawing.Point(619, 43);
            this.kup2.Name = "kup2";
            this.kup2.Size = new System.Drawing.Size(120, 277);
            this.kup2.TabIndex = 3;
            // 
            // ltor
            // 
            this.ltor.Location = new System.Drawing.Point(496, 138);
            this.ltor.Name = "ltor";
            this.ltor.Size = new System.Drawing.Size(75, 23);
            this.ltor.TabIndex = 4;
            this.ltor.Text = ">>";
            this.ltor.UseVisualStyleBackColor = true;
            this.ltor.Click += new System.EventHandler(this.ltor_Click);
            // 
            // rtol
            // 
            this.rtol.Location = new System.Drawing.Point(496, 193);
            this.rtol.Name = "rtol";
            this.rtol.Size = new System.Drawing.Size(75, 23);
            this.rtol.TabIndex = 5;
            this.rtol.Text = "<<";
            this.rtol.UseVisualStyleBackColor = true;
            this.rtol.Click += new System.EventHandler(this.rtol_Click);
            // 
            // pon1
            // 
            this.pon1.Location = new System.Drawing.Point(334, 343);
            this.pon1.Name = "pon1";
            this.pon1.Size = new System.Drawing.Size(75, 23);
            this.pon1.TabIndex = 6;
            this.pon1.Text = "Ponastavi";
            this.pon1.UseVisualStyleBackColor = true;
            this.pon1.Click += new System.EventHandler(this.pon1_Click);
            // 
            // pon2
            // 
            this.pon2.Location = new System.Drawing.Point(619, 342);
            this.pon2.Name = "pon2";
            this.pon2.Size = new System.Drawing.Size(75, 23);
            this.pon2.TabIndex = 7;
            this.pon2.Text = "Ponastavi";
            this.pon2.UseVisualStyleBackColor = true;
            this.pon2.Click += new System.EventHandler(this.pon2_Click);
            // 
            // mes1
            // 
            this.mes1.Location = new System.Drawing.Point(334, 399);
            this.mes1.Name = "mes1";
            this.mes1.Size = new System.Drawing.Size(75, 23);
            this.mes1.TabIndex = 8;
            this.mes1.Text = "Mešaj";
            this.mes1.UseVisualStyleBackColor = true;
            this.mes1.Click += new System.EventHandler(this.mes1_Click);
            // 
            // mes2
            // 
            this.mes2.Location = new System.Drawing.Point(619, 399);
            this.mes2.Name = "mes2";
            this.mes2.Size = new System.Drawing.Size(75, 23);
            this.mes2.TabIndex = 9;
            this.mes2.Text = "Mešaj";
            this.mes2.UseVisualStyleBackColor = true;
            this.mes2.Click += new System.EventHandler(this.mes2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mes2);
            this.Controls.Add(this.mes1);
            this.Controls.Add(this.pon2);
            this.Controls.Add(this.pon1);
            this.Controls.Add(this.rtol);
            this.Controls.Add(this.ltor);
            this.Controls.Add(this.kup2);
            this.Controls.Add(this.kup1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox kup1;
        private System.Windows.Forms.ListBox kup2;
        private System.Windows.Forms.Button ltor;
        private System.Windows.Forms.Button rtol;
        private System.Windows.Forms.Button pon1;
        private System.Windows.Forms.Button pon2;
        private System.Windows.Forms.Button mes1;
        private System.Windows.Forms.Button mes2;
    }
}


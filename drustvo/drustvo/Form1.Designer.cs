
namespace drustvo
{
    partial class Vnos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtzast = new System.Windows.Forms.TextBox();
            this.txtnamen = new System.Windows.Forms.TextBox();
            this.txtznesek = new System.Windows.Forms.TextBox();
            this.txtopomba = new System.Windows.Forms.TextBox();
            this.btnvnos = new System.Windows.Forms.Button();
            this.txtstatus = new System.Windows.Forms.Label();
            this.datumpolje = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "zap st";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "namen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "znesek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "opomba";
            // 
            // txtzast
            // 
            this.txtzast.Location = new System.Drawing.Point(120, 29);
            this.txtzast.Name = "txtzast";
            this.txtzast.Size = new System.Drawing.Size(100, 20);
            this.txtzast.TabIndex = 5;
            // 
            // txtnamen
            // 
            this.txtnamen.Location = new System.Drawing.Point(120, 91);
            this.txtnamen.Name = "txtnamen";
            this.txtnamen.Size = new System.Drawing.Size(100, 20);
            this.txtnamen.TabIndex = 6;
            // 
            // txtznesek
            // 
            this.txtznesek.Location = new System.Drawing.Point(120, 126);
            this.txtznesek.Name = "txtznesek";
            this.txtznesek.Size = new System.Drawing.Size(100, 20);
            this.txtznesek.TabIndex = 7;
            // 
            // txtopomba
            // 
            this.txtopomba.Location = new System.Drawing.Point(120, 155);
            this.txtopomba.Multiline = true;
            this.txtopomba.Name = "txtopomba";
            this.txtopomba.Size = new System.Drawing.Size(463, 162);
            this.txtopomba.TabIndex = 8;
            // 
            // btnvnos
            // 
            this.btnvnos.Location = new System.Drawing.Point(120, 344);
            this.btnvnos.Name = "btnvnos";
            this.btnvnos.Size = new System.Drawing.Size(75, 23);
            this.btnvnos.TabIndex = 9;
            this.btnvnos.Text = "vnesi";
            this.btnvnos.UseVisualStyleBackColor = true;
            this.btnvnos.Click += new System.EventHandler(this.btnvnos_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.AutoSize = true;
            this.txtstatus.Location = new System.Drawing.Point(120, 397);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(35, 13);
            this.txtstatus.TabIndex = 10;
            this.txtstatus.Text = "status";
            // 
            // datumpolje
            // 
            this.datumpolje.Location = new System.Drawing.Point(120, 58);
            this.datumpolje.Name = "datumpolje";
            this.datumpolje.Size = new System.Drawing.Size(200, 20);
            this.datumpolje.TabIndex = 11;
            // 
            // Vnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datumpolje);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.btnvnos);
            this.Controls.Add(this.txtopomba);
            this.Controls.Add(this.txtznesek);
            this.Controls.Add(this.txtnamen);
            this.Controls.Add(this.txtzast);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Vnos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtzast;
        private System.Windows.Forms.TextBox txtnamen;
        private System.Windows.Forms.TextBox txtznesek;
        private System.Windows.Forms.TextBox txtopomba;
        private System.Windows.Forms.Button btnvnos;
        private System.Windows.Forms.Label txtstatus;
        private System.Windows.Forms.DateTimePicker datumpolje;
    }
}


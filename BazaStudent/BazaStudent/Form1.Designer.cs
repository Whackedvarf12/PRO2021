
namespace BazaStudent
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
            this.predmettxt = new System.Windows.Forms.TextBox();
            this.studenttxt = new System.Windows.Forms.TextBox();
            this.predmetbtn = new System.Windows.Forms.Button();
            this.studentbtn = new System.Windows.Forms.Button();
            this.vsipredmetibtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // predmettxt
            // 
            this.predmettxt.Location = new System.Drawing.Point(179, 44);
            this.predmettxt.Name = "predmettxt";
            this.predmettxt.Size = new System.Drawing.Size(100, 20);
            this.predmettxt.TabIndex = 0;
            // 
            // studenttxt
            // 
            this.studenttxt.Location = new System.Drawing.Point(179, 99);
            this.studenttxt.Name = "studenttxt";
            this.studenttxt.Size = new System.Drawing.Size(100, 20);
            this.studenttxt.TabIndex = 1;
            // 
            // predmetbtn
            // 
            this.predmetbtn.Location = new System.Drawing.Point(492, 44);
            this.predmetbtn.Name = "predmetbtn";
            this.predmetbtn.Size = new System.Drawing.Size(75, 23);
            this.predmetbtn.TabIndex = 2;
            this.predmetbtn.Text = "button1";
            this.predmetbtn.UseVisualStyleBackColor = true;
            this.predmetbtn.Click += new System.EventHandler(this.predmetbtn_Click);
            // 
            // studentbtn
            // 
            this.studentbtn.Location = new System.Drawing.Point(492, 99);
            this.studentbtn.Name = "studentbtn";
            this.studentbtn.Size = new System.Drawing.Size(75, 23);
            this.studentbtn.TabIndex = 3;
            this.studentbtn.Text = "button2";
            this.studentbtn.UseVisualStyleBackColor = true;
            // 
            // vsipredmetibtn
            // 
            this.vsipredmetibtn.Location = new System.Drawing.Point(179, 153);
            this.vsipredmetibtn.Name = "vsipredmetibtn";
            this.vsipredmetibtn.Size = new System.Drawing.Size(75, 23);
            this.vsipredmetibtn.TabIndex = 4;
            this.vsipredmetibtn.Text = "button1";
            this.vsipredmetibtn.UseVisualStyleBackColor = true;
            this.vsipredmetibtn.Click += new System.EventHandler(this.vsipredmetibtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rez:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vsipredmetibtn);
            this.Controls.Add(this.studentbtn);
            this.Controls.Add(this.predmetbtn);
            this.Controls.Add(this.studenttxt);
            this.Controls.Add(this.predmettxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox predmettxt;
        private System.Windows.Forms.TextBox studenttxt;
        private System.Windows.Forms.Button predmetbtn;
        private System.Windows.Forms.Button studentbtn;
        private System.Windows.Forms.Button vsipredmetibtn;
        private System.Windows.Forms.Label label1;
    }
}


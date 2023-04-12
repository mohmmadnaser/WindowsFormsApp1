namespace WindowsFormsApp2
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
            this.textname = new System.Windows.Forms.TextBox();
            this.btnforname = new System.Windows.Forms.Button();
            this.btnforage = new System.Windows.Forms.Button();
            this.btnforSkills = new System.Windows.Forms.Button();
            this.btnExperience = new System.Windows.Forms.Button();
            this.textage = new System.Windows.Forms.TextBox();
            this.textskills = new System.Windows.Forms.TextBox();
            this.textExperience = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(208, 49);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(300, 22);
            this.textname.TabIndex = 0;
            this.textname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textname_KeyPress);
            // 
            // btnforname
            // 
            this.btnforname.Location = new System.Drawing.Point(116, 47);
            this.btnforname.Name = "btnforname";
            this.btnforname.Size = new System.Drawing.Size(75, 23);
            this.btnforname.TabIndex = 1;
            this.btnforname.Text = "Name";
            this.btnforname.UseVisualStyleBackColor = true;
            // 
            // btnforage
            // 
            this.btnforage.Location = new System.Drawing.Point(116, 108);
            this.btnforage.Name = "btnforage";
            this.btnforage.Size = new System.Drawing.Size(75, 23);
            this.btnforage.TabIndex = 2;
            this.btnforage.Text = "Age";
            this.btnforage.UseVisualStyleBackColor = true;
            // 
            // btnforSkills
            // 
            this.btnforSkills.Location = new System.Drawing.Point(116, 171);
            this.btnforSkills.Name = "btnforSkills";
            this.btnforSkills.Size = new System.Drawing.Size(75, 23);
            this.btnforSkills.TabIndex = 3;
            this.btnforSkills.Text = "Skills";
            this.btnforSkills.UseVisualStyleBackColor = true;
            // 
            // btnExperience
            // 
            this.btnExperience.Location = new System.Drawing.Point(12, 234);
            this.btnExperience.Name = "btnExperience";
            this.btnExperience.Size = new System.Drawing.Size(179, 36);
            this.btnExperience.TabIndex = 4;
            this.btnExperience.Text = "Experience from a year";
            this.btnExperience.UseVisualStyleBackColor = true;
            // 
            // textage
            // 
            this.textage.Location = new System.Drawing.Point(208, 108);
            this.textage.Name = "textage";
            this.textage.Size = new System.Drawing.Size(300, 22);
            this.textage.TabIndex = 5;
            this.textage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textage_KeyPress);
            // 
            // textskills
            // 
            this.textskills.Location = new System.Drawing.Point(208, 172);
            this.textskills.Name = "textskills";
            this.textskills.Size = new System.Drawing.Size(300, 22);
            this.textskills.TabIndex = 6;
            this.textskills.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textskills_KeyPress);
            // 
            // textExperience
            // 
            this.textExperience.Location = new System.Drawing.Point(208, 235);
            this.textExperience.Name = "textExperience";
            this.textExperience.Size = new System.Drawing.Size(300, 22);
            this.textExperience.TabIndex = 7;
            this.textExperience.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textExperience_KeyPress);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(280, 306);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(143, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.textExperience);
            this.Controls.Add(this.textskills);
            this.Controls.Add(this.textage);
            this.Controls.Add(this.btnExperience);
            this.Controls.Add(this.btnforSkills);
            this.Controls.Add(this.btnforage);
            this.Controls.Add(this.btnforname);
            this.Controls.Add(this.textname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Button btnforname;
        private System.Windows.Forms.Button btnforage;
        private System.Windows.Forms.Button btnforSkills;
        private System.Windows.Forms.Button btnExperience;
        private System.Windows.Forms.TextBox textage;
        private System.Windows.Forms.TextBox textskills;
        private System.Windows.Forms.TextBox textExperience;
        private System.Windows.Forms.Button btnPrint;
    }
}


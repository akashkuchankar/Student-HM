namespace Student_HM
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
            this.btnbinarywrite = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.Label();
            this.txtstudentrollno = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.Label();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.txtpercentage = new System.Windows.Forms.TextBox();
            this.btnbinaryread = new System.Windows.Forms.Button();
            this.btnXmlwrite = new System.Windows.Forms.Button();
            this.btnXmlread = new System.Windows.Forms.Button();
            this.btnsoapwrite = new System.Windows.Forms.Button();
            this.btnsoapread = new System.Windows.Forms.Button();
            this.btnjsonwrite = new System.Windows.Forms.Button();
            this.btnjsonread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbinarywrite
            // 
            this.btnbinarywrite.Location = new System.Drawing.Point(452, 37);
            this.btnbinarywrite.Name = "btnbinarywrite";
            this.btnbinarywrite.Size = new System.Drawing.Size(118, 23);
            this.btnbinarywrite.TabIndex = 0;
            this.btnbinarywrite.Text = "binary write";
            this.btnbinarywrite.UseVisualStyleBackColor = true;
            this.btnbinarywrite.Click += new System.EventHandler(this.btnbinarywrite_Click);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Location = new System.Drawing.Point(102, 53);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(86, 16);
            this.text1.TabIndex = 1;
            this.text1.Text = "student rollno";
            // 
            // txtstudentrollno
            // 
            this.txtstudentrollno.Location = new System.Drawing.Point(217, 47);
            this.txtstudentrollno.Name = "txtstudentrollno";
            this.txtstudentrollno.Size = new System.Drawing.Size(163, 22);
            this.txtstudentrollno.TabIndex = 2;
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Location = new System.Drawing.Point(102, 135);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(87, 16);
            this.text2.TabIndex = 3;
            this.text2.Text = "student name";
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Location = new System.Drawing.Point(102, 202);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(76, 16);
            this.text3.TabIndex = 4;
            this.text3.Text = "percentage";
            // 
            // txtstudentname
            // 
            this.txtstudentname.Location = new System.Drawing.Point(217, 129);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(163, 22);
            this.txtstudentname.TabIndex = 5;
            // 
            // txtpercentage
            // 
            this.txtpercentage.Location = new System.Drawing.Point(217, 196);
            this.txtpercentage.Name = "txtpercentage";
            this.txtpercentage.Size = new System.Drawing.Size(163, 22);
            this.txtpercentage.TabIndex = 6;
            // 
            // btnbinaryread
            // 
            this.btnbinaryread.Location = new System.Drawing.Point(617, 37);
            this.btnbinaryread.Name = "btnbinaryread";
            this.btnbinaryread.Size = new System.Drawing.Size(117, 32);
            this.btnbinaryread.TabIndex = 7;
            this.btnbinaryread.Text = "binary read";
            this.btnbinaryread.UseVisualStyleBackColor = true;
            this.btnbinaryread.Click += new System.EventHandler(this.btnbinaryread_Click);
            // 
            // btnXmlwrite
            // 
            this.btnXmlwrite.Location = new System.Drawing.Point(452, 111);
            this.btnXmlwrite.Name = "btnXmlwrite";
            this.btnXmlwrite.Size = new System.Drawing.Size(118, 23);
            this.btnXmlwrite.TabIndex = 8;
            this.btnXmlwrite.Text = "Xml write";
            this.btnXmlwrite.UseVisualStyleBackColor = true;
            this.btnXmlwrite.Click += new System.EventHandler(this.btnXmlwrite_Click);
            // 
            // btnXmlread
            // 
            this.btnXmlread.Location = new System.Drawing.Point(608, 111);
            this.btnXmlread.Name = "btnXmlread";
            this.btnXmlread.Size = new System.Drawing.Size(126, 23);
            this.btnXmlread.TabIndex = 9;
            this.btnXmlread.Text = "Xml read";
            this.btnXmlread.UseVisualStyleBackColor = true;
            this.btnXmlread.Click += new System.EventHandler(this.btnXmlread_Click);
            // 
            // btnsoapwrite
            // 
            this.btnsoapwrite.Location = new System.Drawing.Point(452, 185);
            this.btnsoapwrite.Name = "btnsoapwrite";
            this.btnsoapwrite.Size = new System.Drawing.Size(118, 23);
            this.btnsoapwrite.TabIndex = 10;
            this.btnsoapwrite.Text = "soap write";
            this.btnsoapwrite.UseVisualStyleBackColor = true;
            this.btnsoapwrite.Click += new System.EventHandler(this.btnsoapwrite_Click);
            // 
            // btnsoapread
            // 
            this.btnsoapread.Location = new System.Drawing.Point(617, 185);
            this.btnsoapread.Name = "btnsoapread";
            this.btnsoapread.Size = new System.Drawing.Size(122, 23);
            this.btnsoapread.TabIndex = 11;
            this.btnsoapread.Text = "soap read";
            this.btnsoapread.UseVisualStyleBackColor = true;
            this.btnsoapread.Click += new System.EventHandler(this.btnsoapread_Click);
            // 
            // btnjsonwrite
            // 
            this.btnjsonwrite.Location = new System.Drawing.Point(452, 272);
            this.btnjsonwrite.Name = "btnjsonwrite";
            this.btnjsonwrite.Size = new System.Drawing.Size(118, 23);
            this.btnjsonwrite.TabIndex = 12;
            this.btnjsonwrite.Text = "json write";
            this.btnjsonwrite.UseVisualStyleBackColor = true;
            this.btnjsonwrite.Click += new System.EventHandler(this.btnjsonwrite_Click);
            // 
            // btnjsonread
            // 
            this.btnjsonread.Location = new System.Drawing.Point(608, 272);
            this.btnjsonread.Name = "btnjsonread";
            this.btnjsonread.Size = new System.Drawing.Size(139, 23);
            this.btnjsonread.TabIndex = 13;
            this.btnjsonread.Text = "json read";
            this.btnjsonread.UseVisualStyleBackColor = true;
            this.btnjsonread.Click += new System.EventHandler(this.btnjsonread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnjsonread);
            this.Controls.Add(this.btnjsonwrite);
            this.Controls.Add(this.btnsoapread);
            this.Controls.Add(this.btnsoapwrite);
            this.Controls.Add(this.btnXmlread);
            this.Controls.Add(this.btnXmlwrite);
            this.Controls.Add(this.btnbinaryread);
            this.Controls.Add(this.txtpercentage);
            this.Controls.Add(this.txtstudentname);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.txtstudentrollno);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.btnbinarywrite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbinarywrite;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.TextBox txtstudentrollno;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.TextBox txtpercentage;
        private System.Windows.Forms.Button btnbinaryread;
        private System.Windows.Forms.Button btnXmlwrite;
        private System.Windows.Forms.Button btnXmlread;
        private System.Windows.Forms.Button btnsoapwrite;
        private System.Windows.Forms.Button btnsoapread;
        private System.Windows.Forms.Button btnjsonwrite;
        private System.Windows.Forms.Button btnjsonread;
    }
}


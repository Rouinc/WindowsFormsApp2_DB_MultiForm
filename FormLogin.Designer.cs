namespace WindowsFormsApp2_DB_MultiForm
{
    partial class FormLogin
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
            this.buttonlogin = new System.Windows.Forms.Button();
            this.labeluser = new System.Windows.Forms.Label();
            this.textboxuser = new System.Windows.Forms.TextBox();
            this.textboxpassw = new System.Windows.Forms.TextBox();
            this.labelpassw = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonedit = new System.Windows.Forms.Button();
            this.textboxgender = new System.Windows.Forms.TextBox();
            this.labelgender = new System.Windows.Forms.Label();
            this.textboxstatus = new System.Windows.Forms.TextBox();
            this.labelstatus = new System.Windows.Forms.Label();
            this.textboxkodejenis = new System.Windows.Forms.TextBox();
            this.labelkodejenis = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonadd2 = new System.Windows.Forms.Button();
            this.buttonedit2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 240);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(9, 10);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(110, 198);
            this.buttonlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(98, 35);
            this.buttonlogin.TabIndex = 1;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Location = new System.Drawing.Point(27, 82);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(43, 20);
            this.labeluser.TabIndex = 2;
            this.labeluser.Text = "User";
            // 
            // textboxuser
            // 
            this.textboxuser.Location = new System.Drawing.Point(110, 76);
            this.textboxuser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxuser.Name = "textboxuser";
            this.textboxuser.Size = new System.Drawing.Size(165, 26);
            this.textboxuser.TabIndex = 3;
            this.textboxuser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textboxpassw
            // 
            this.textboxpassw.Location = new System.Drawing.Point(110, 111);
            this.textboxpassw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxpassw.Name = "textboxpassw";
            this.textboxpassw.Size = new System.Drawing.Size(165, 26);
            this.textboxpassw.TabIndex = 5;
            // 
            // labelpassw
            // 
            this.labelpassw.AutoSize = true;
            this.labelpassw.Location = new System.Drawing.Point(27, 118);
            this.labelpassw.Name = "labelpassw";
            this.labelpassw.Size = new System.Drawing.Size(78, 20);
            this.labelpassw.TabIndex = 4;
            this.labelpassw.Text = "Password";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(36, 492);
            this.buttonadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(84, 29);
            this.buttonadd.TabIndex = 7;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonedit
            // 
            this.buttonedit.Location = new System.Drawing.Point(127, 492);
            this.buttonedit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonedit.Name = "buttonedit";
            this.buttonedit.Size = new System.Drawing.Size(84, 29);
            this.buttonedit.TabIndex = 8;
            this.buttonedit.Text = "Edit";
            this.buttonedit.UseVisualStyleBackColor = true;
            this.buttonedit.Click += new System.EventHandler(this.button5_Click);
            // 
            // textboxgender
            // 
            this.textboxgender.Location = new System.Drawing.Point(110, 146);
            this.textboxgender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxgender.Name = "textboxgender";
            this.textboxgender.Size = new System.Drawing.Size(165, 26);
            this.textboxgender.TabIndex = 10;
            // 
            // labelgender
            // 
            this.labelgender.AutoSize = true;
            this.labelgender.Location = new System.Drawing.Point(27, 152);
            this.labelgender.Name = "labelgender";
            this.labelgender.Size = new System.Drawing.Size(63, 20);
            this.labelgender.TabIndex = 9;
            this.labelgender.Text = "Gender";
            // 
            // textboxstatus
            // 
            this.textboxstatus.Location = new System.Drawing.Point(289, 79);
            this.textboxstatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxstatus.Name = "textboxstatus";
            this.textboxstatus.Size = new System.Drawing.Size(112, 26);
            this.textboxstatus.TabIndex = 11;
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Location = new System.Drawing.Point(288, 52);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(110, 20);
            this.labelstatus.TabIndex = 12;
            this.labelstatus.Text = "Status Barista";
            // 
            // textboxkodejenis
            // 
            this.textboxkodejenis.Location = new System.Drawing.Point(298, 165);
            this.textboxkodejenis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxkodejenis.Name = "textboxkodejenis";
            this.textboxkodejenis.Size = new System.Drawing.Size(112, 26);
            this.textboxkodejenis.TabIndex = 13;
            // 
            // labelkodejenis
            // 
            this.labelkodejenis.AutoSize = true;
            this.labelkodejenis.Location = new System.Drawing.Point(305, 134);
            this.labelkodejenis.Name = "labelkodejenis";
            this.labelkodejenis.Size = new System.Drawing.Size(87, 20);
            this.labelkodejenis.TabIndex = 14;
            this.labelkodejenis.Text = "Kode Jenis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Menu Barista";
            // 
            // buttonadd2
            // 
            this.buttonadd2.Location = new System.Drawing.Point(489, 502);
            this.buttonadd2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonadd2.Name = "buttonadd2";
            this.buttonadd2.Size = new System.Drawing.Size(84, 29);
            this.buttonadd2.TabIndex = 16;
            this.buttonadd2.Text = "Add";
            this.buttonadd2.UseVisualStyleBackColor = true;
            this.buttonadd2.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonedit2
            // 
            this.buttonedit2.Location = new System.Drawing.Point(580, 502);
            this.buttonedit2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonedit2.Name = "buttonedit2";
            this.buttonedit2.Size = new System.Drawing.Size(84, 29);
            this.buttonedit2.TabIndex = 17;
            this.buttonedit2.Text = "Edit";
            this.buttonedit2.UseVisualStyleBackColor = true;
            this.buttonedit2.Click += new System.EventHandler(this.button7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Jobs Barista";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonedit2);
            this.Controls.Add(this.buttonadd2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelkodejenis);
            this.Controls.Add(this.textboxkodejenis);
            this.Controls.Add(this.labelstatus);
            this.Controls.Add(this.textboxstatus);
            this.Controls.Add(this.textboxgender);
            this.Controls.Add(this.labelgender);
            this.Controls.Add(this.buttonedit);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textboxpassw);
            this.Controls.Add(this.labelpassw);
            this.Controls.Add(this.textboxuser);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLogin";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.TextBox textboxuser;
        private System.Windows.Forms.TextBox textboxpassw;
        private System.Windows.Forms.Label labelpassw;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonedit;
        private System.Windows.Forms.TextBox textboxgender;
        private System.Windows.Forms.Label labelgender;
        private System.Windows.Forms.TextBox textboxstatus;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.TextBox textboxkodejenis;
        private System.Windows.Forms.Label labelkodejenis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonadd2;
        private System.Windows.Forms.Button buttonedit2;
        private System.Windows.Forms.Label label7;
    }
}
//All images taken from http://www.iconarchive.com/
//Backgroud image from https://wallpaperdata.com/light-blue-background.html/7?lang=fy
namespace MonkeyPuzzleMaker
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.uIDTBox = new System.Windows.Forms.TextBox();
            this.pWordTBox = new System.Windows.Forms.TextBox();
            this.pWordLbl = new System.Windows.Forms.Label();
            this.uIDLbl = new System.Windows.Forms.Label();
            this.signInBut = new System.Windows.Forms.Button();
            this.bg_AuthoriseLogin = new System.ComponentModel.BackgroundWorker();
            this.pb_Authorise = new System.Windows.Forms.ProgressBar();
            this.lbl_Authorise = new System.Windows.Forms.Label();
            this.lbl_Percent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uIDTBox
            // 
            this.uIDTBox.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.uIDTBox.Location = new System.Drawing.Point(164, 22);
            this.uIDTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uIDTBox.Name = "uIDTBox";
            this.uIDTBox.Size = new System.Drawing.Size(259, 29);
            this.uIDTBox.TabIndex = 2;
            this.uIDTBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            // 
            // pWordTBox
            // 
            this.pWordTBox.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.pWordTBox.Location = new System.Drawing.Point(164, 81);
            this.pWordTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pWordTBox.Name = "pWordTBox";
            this.pWordTBox.PasswordChar = '*';
            this.pWordTBox.Size = new System.Drawing.Size(259, 29);
            this.pWordTBox.TabIndex = 3;
            this.pWordTBox.UseSystemPasswordChar = true;
            this.pWordTBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            // 
            // pWordLbl
            // 
            this.pWordLbl.AutoSize = true;
            this.pWordLbl.BackColor = System.Drawing.Color.Transparent;
            this.pWordLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.pWordLbl.Location = new System.Drawing.Point(44, 84);
            this.pWordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pWordLbl.Name = "pWordLbl";
            this.pWordLbl.Size = new System.Drawing.Size(78, 22);
            this.pWordLbl.TabIndex = 4;
            this.pWordLbl.Text = "Password:";
            // 
            // uIDLbl
            // 
            this.uIDLbl.AutoSize = true;
            this.uIDLbl.BackColor = System.Drawing.Color.Transparent;
            this.uIDLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.uIDLbl.Location = new System.Drawing.Point(55, 25);
            this.uIDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uIDLbl.Name = "uIDLbl";
            this.uIDLbl.Size = new System.Drawing.Size(67, 22);
            this.uIDLbl.TabIndex = 5;
            this.uIDLbl.Text = "User ID:";
            // 
            // signInBut
            // 
            this.signInBut.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.signInBut.Location = new System.Drawing.Point(342, 125);
            this.signInBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signInBut.Name = "signInBut";
            this.signInBut.Size = new System.Drawing.Size(82, 37);
            this.signInBut.TabIndex = 7;
            this.signInBut.Text = "Sign In";
            this.signInBut.UseVisualStyleBackColor = true;
            this.signInBut.Click += new System.EventHandler(this.signInBut_Click);
            // 
            // bg_AuthoriseLogin
            // 
            this.bg_AuthoriseLogin.WorkerReportsProgress = true;
            this.bg_AuthoriseLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_AuthoriseLogin_DoWork);
            this.bg_AuthoriseLogin.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bg_AuthoriseLogin_ProgressChanged);
            this.bg_AuthoriseLogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bg_AuthoriseLogin_RunWorkerCompleted);
            // 
            // pb_Authorise
            // 
            this.pb_Authorise.Location = new System.Drawing.Point(164, 118);
            this.pb_Authorise.Name = "pb_Authorise";
            this.pb_Authorise.Size = new System.Drawing.Size(181, 23);
            this.pb_Authorise.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_Authorise.TabIndex = 8;
            this.pb_Authorise.Visible = false;
            // 
            // lbl_Authorise
            // 
            this.lbl_Authorise.AutoSize = true;
            this.lbl_Authorise.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Authorise.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.lbl_Authorise.Location = new System.Drawing.Point(190, 148);
            this.lbl_Authorise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Authorise.Name = "lbl_Authorise";
            this.lbl_Authorise.Size = new System.Drawing.Size(133, 22);
            this.lbl_Authorise.TabIndex = 9;
            this.lbl_Authorise.Text = "Authorising Login";
            this.lbl_Authorise.Visible = false;
            // 
            // lbl_Percent
            // 
            this.lbl_Percent.AutoSize = true;
            this.lbl_Percent.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Percent.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.lbl_Percent.Location = new System.Drawing.Point(366, 118);
            this.lbl_Percent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Percent.Name = "lbl_Percent";
            this.lbl_Percent.Size = new System.Drawing.Size(35, 22);
            this.lbl_Percent.TabIndex = 10;
            this.lbl_Percent.Text = "0 %";
            this.lbl_Percent.Visible = false;
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MonkeyPuzzleMaker.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 179);
            this.Controls.Add(this.lbl_Percent);
            this.Controls.Add(this.lbl_Authorise);
            this.Controls.Add(this.pb_Authorise);
            this.Controls.Add(this.signInBut);
            this.Controls.Add(this.uIDLbl);
            this.Controls.Add(this.pWordLbl);
            this.Controls.Add(this.pWordTBox);
            this.Controls.Add(this.uIDTBox);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uIDTBox;
        private System.Windows.Forms.TextBox pWordTBox;
        private System.Windows.Forms.Label pWordLbl;
        private System.Windows.Forms.Label uIDLbl;
        private System.Windows.Forms.Button signInBut;
        private System.ComponentModel.BackgroundWorker bg_AuthoriseLogin;
        private System.Windows.Forms.ProgressBar pb_Authorise;
        private System.Windows.Forms.Label lbl_Authorise;
        private System.Windows.Forms.Label lbl_Percent;
    }
}


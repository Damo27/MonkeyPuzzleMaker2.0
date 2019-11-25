//All images taken from http://www.iconarchive.com/
//Backgroud image from https://wallpaperdata.com/light-blue-background.html/7?lang=fy
namespace MonkeyPuzzleMaker
{
    partial class AddUserFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserFrm));
            this.userIDTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.accessGrpCbox = new System.Windows.Forms.ComboBox();
            this.useIdlbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.accGroupLbl = new System.Windows.Forms.Label();
            this.addUserButt = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // userIDTxt
            // 
            this.userIDTxt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDTxt.Location = new System.Drawing.Point(202, 38);
            this.userIDTxt.Name = "userIDTxt";
            this.userIDTxt.Size = new System.Drawing.Size(201, 29);
            this.userIDTxt.TabIndex = 0;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(202, 98);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(201, 29);
            this.nameTxt.TabIndex = 1;
            // 
            // surnameTxt
            // 
            this.surnameTxt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTxt.Location = new System.Drawing.Point(202, 166);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(201, 29);
            this.surnameTxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(202, 236);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(201, 29);
            this.passwordTxt.TabIndex = 3;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // accessGrpCbox
            // 
            this.accessGrpCbox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessGrpCbox.FormattingEnabled = true;
            this.accessGrpCbox.Items.AddRange(new object[] {
            "Administrator",
            "Lecturer",
            "Student"});
            this.accessGrpCbox.Location = new System.Drawing.Point(202, 303);
            this.accessGrpCbox.Name = "accessGrpCbox";
            this.accessGrpCbox.Size = new System.Drawing.Size(151, 30);
            this.accessGrpCbox.TabIndex = 4;
            // 
            // useIdlbl
            // 
            this.useIdlbl.AutoSize = true;
            this.useIdlbl.BackColor = System.Drawing.Color.Transparent;
            this.useIdlbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useIdlbl.Location = new System.Drawing.Point(96, 41);
            this.useIdlbl.Name = "useIdlbl";
            this.useIdlbl.Size = new System.Drawing.Size(67, 22);
            this.useIdlbl.TabIndex = 5;
            this.useIdlbl.Text = "User ID:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(107, 101);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(56, 22);
            this.nameLbl.TabIndex = 6;
            this.nameLbl.Text = "Name:";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.BackColor = System.Drawing.Color.Transparent;
            this.surnameLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLbl.Location = new System.Drawing.Point(87, 169);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(76, 22);
            this.surnameLbl.TabIndex = 7;
            this.surnameLbl.Text = "Surname:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(85, 239);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(78, 22);
            this.passwordLbl.TabIndex = 8;
            this.passwordLbl.Text = "Password:";
            // 
            // accGroupLbl
            // 
            this.accGroupLbl.AutoSize = true;
            this.accGroupLbl.BackColor = System.Drawing.Color.Transparent;
            this.accGroupLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accGroupLbl.Location = new System.Drawing.Point(57, 306);
            this.accGroupLbl.Name = "accGroupLbl";
            this.accGroupLbl.Size = new System.Drawing.Size(106, 22);
            this.accGroupLbl.TabIndex = 9;
            this.accGroupLbl.Text = "Access Group:";
            // 
            // addUserButt
            // 
            this.addUserButt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserButt.Location = new System.Drawing.Point(446, 279);
            this.addUserButt.Name = "addUserButt";
            this.addUserButt.Size = new System.Drawing.Size(186, 76);
            this.addUserButt.TabIndex = 5;
            this.addUserButt.Text = "Add User";
            this.addUserButt.UseVisualStyleBackColor = true;
            this.addUserButt.Click += new System.EventHandler(this.addUserButt_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::MonkeyPuzzleMaker.Properties.Resources.AddUser1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(474, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 116);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // AddUserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MonkeyPuzzleMaker.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 379);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.addUserButt);
            this.Controls.Add(this.accGroupLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.useIdlbl);
            this.Controls.Add(this.accessGrpCbox);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.userIDTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUserFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monkey Puzzle Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userIDTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.ComboBox accessGrpCbox;
        private System.Windows.Forms.Label useIdlbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label accGroupLbl;
        private System.Windows.Forms.Button addUserButt;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
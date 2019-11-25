//All images taken from http://www.iconarchive.com/
//Backgroud image from https://wallpaperdata.com/light-blue-background.html/7?lang=fy
namespace MonkeyPuzzleMaker
{
    partial class DeleteFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteFrm));
            this.adminCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.delUserPicBox = new System.Windows.Forms.PictureBox();
            this.deleteButt = new System.Windows.Forms.Button();
            this.delTestPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.delUserPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delTestPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // adminCheckedListBox
            // 
            this.adminCheckedListBox.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminCheckedListBox.FormattingEnabled = true;
            this.adminCheckedListBox.Location = new System.Drawing.Point(62, 23);
            this.adminCheckedListBox.Name = "adminCheckedListBox";
            this.adminCheckedListBox.Size = new System.Drawing.Size(200, 324);
            this.adminCheckedListBox.TabIndex = 0;
            // 
            // delUserPicBox
            // 
            this.delUserPicBox.BackColor = System.Drawing.Color.Transparent;
            this.delUserPicBox.BackgroundImage = global::MonkeyPuzzleMaker.Properties.Resources.RemoveUser;
            this.delUserPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delUserPicBox.Location = new System.Drawing.Point(406, 52);
            this.delUserPicBox.Name = "delUserPicBox";
            this.delUserPicBox.Size = new System.Drawing.Size(138, 134);
            this.delUserPicBox.TabIndex = 5;
            this.delUserPicBox.TabStop = false;
            this.delUserPicBox.Visible = false;
            // 
            // deleteButt
            // 
            this.deleteButt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButt.Location = new System.Drawing.Point(356, 244);
            this.deleteButt.Name = "deleteButt";
            this.deleteButt.Size = new System.Drawing.Size(217, 88);
            this.deleteButt.TabIndex = 6;
            this.deleteButt.Text = "Delete";
            this.deleteButt.UseVisualStyleBackColor = true;
            this.deleteButt.Click += new System.EventHandler(this.deleteButt_Click);
            // 
            // delTestPicBox
            // 
            this.delTestPicBox.BackColor = System.Drawing.Color.Transparent;
            this.delTestPicBox.BackgroundImage = global::MonkeyPuzzleMaker.Properties.Resources.DeleteTest;
            this.delTestPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delTestPicBox.Location = new System.Drawing.Point(406, 52);
            this.delTestPicBox.Name = "delTestPicBox";
            this.delTestPicBox.Size = new System.Drawing.Size(138, 134);
            this.delTestPicBox.TabIndex = 7;
            this.delTestPicBox.TabStop = false;
            this.delTestPicBox.Visible = false;
            // 
            // DeleteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MonkeyPuzzleMaker.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 379);
            this.Controls.Add(this.delTestPicBox);
            this.Controls.Add(this.deleteButt);
            this.Controls.Add(this.delUserPicBox);
            this.Controls.Add(this.adminCheckedListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monkey Puzzle Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.delUserPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delTestPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox adminCheckedListBox;
        private System.Windows.Forms.PictureBox delUserPicBox;
        private System.Windows.Forms.Button deleteButt;
        private System.Windows.Forms.PictureBox delTestPicBox;
    }
}
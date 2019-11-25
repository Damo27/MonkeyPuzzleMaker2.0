//All images taken from http://www.iconarchive.com/
//Backgroud image from https://wallpaperdata.com/light-blue-background.html/7?lang=fy
namespace MonkeyPuzzleMaker
{
    partial class LecturerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerFrm));
            this.lecFrmMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTestButt = new System.Windows.Forms.Button();
            this.editTestButt = new System.Windows.Forms.Button();
            this.markRepButt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lecFrmMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lecFrmMenuStrip
            // 
            this.lecFrmMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lecFrmMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.lecFrmMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.lecFrmMenuStrip.Name = "lecFrmMenuStrip";
            this.lecFrmMenuStrip.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            this.lecFrmMenuStrip.Size = new System.Drawing.Size(804, 34);
            this.lecFrmMenuStrip.TabIndex = 0;
            this.lecFrmMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTestToolStripMenuItem,
            this.editTestToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newTestToolStripMenuItem
            // 
            this.newTestToolStripMenuItem.Name = "newTestToolStripMenuItem";
            this.newTestToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.newTestToolStripMenuItem.Text = "New Test";
            this.newTestToolStripMenuItem.Click += new System.EventHandler(this.NewTestToolStripMenuItem_Click);
            // 
            // editTestToolStripMenuItem
            // 
            this.editTestToolStripMenuItem.Name = "editTestToolStripMenuItem";
            this.editTestToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.editTestToolStripMenuItem.Text = "Edit Test";
            this.editTestToolStripMenuItem.Click += new System.EventHandler(this.editTestToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.viewToolStripMenuItem.Text = "View Marksheet";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // newTestButt
            // 
            this.newTestButt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTestButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newTestButt.Location = new System.Drawing.Point(370, 86);
            this.newTestButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newTestButt.Name = "newTestButt";
            this.newTestButt.Size = new System.Drawing.Size(186, 76);
            this.newTestButt.TabIndex = 1;
            this.newTestButt.Text = "Create New Test";
            this.newTestButt.UseVisualStyleBackColor = true;
            this.newTestButt.Click += new System.EventHandler(this.newTestButt_Click);
            // 
            // editTestButt
            // 
            this.editTestButt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTestButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editTestButt.Location = new System.Drawing.Point(370, 219);
            this.editTestButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editTestButt.Name = "editTestButt";
            this.editTestButt.Size = new System.Drawing.Size(186, 76);
            this.editTestButt.TabIndex = 2;
            this.editTestButt.Text = "Edit Test";
            this.editTestButt.UseVisualStyleBackColor = true;
            this.editTestButt.Click += new System.EventHandler(this.editTestButt_Click);
            // 
            // markRepButt
            // 
            this.markRepButt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markRepButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.markRepButt.Location = new System.Drawing.Point(370, 359);
            this.markRepButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.markRepButt.Name = "markRepButt";
            this.markRepButt.Size = new System.Drawing.Size(186, 76);
            this.markRepButt.TabIndex = 3;
            this.markRepButt.Text = "Marks Report";
            this.markRepButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.markRepButt.UseVisualStyleBackColor = true;
            this.markRepButt.Click += new System.EventHandler(this.markRepButt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MonkeyPuzzleMaker.Properties.Resources.EditATest;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(220, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 116);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::MonkeyPuzzleMaker.Properties.Resources.CreateTest;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(220, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 116);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::MonkeyPuzzleMaker.Properties.Resources.Tick;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(220, 342);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(118, 116);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // LecturerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.BackgroundImage = global::MonkeyPuzzleMaker.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 499);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.markRepButt);
            this.Controls.Add(this.editTestButt);
            this.Controls.Add(this.newTestButt);
            this.Controls.Add(this.lecFrmMenuStrip);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.lecFrmMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LecturerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monkey Puzzle Maker";
            this.lecFrmMenuStrip.ResumeLayout(false);
            this.lecFrmMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip lecFrmMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button newTestButt;
        private System.Windows.Forms.Button editTestButt;
        private System.Windows.Forms.Button markRepButt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
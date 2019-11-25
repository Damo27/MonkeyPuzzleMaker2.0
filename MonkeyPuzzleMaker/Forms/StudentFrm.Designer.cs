//All images taken from http://www.iconarchive.com/
//Backgroud image from https://wallpaperdata.com/light-blue-background.html/7?lang=fy
namespace MonkeyPuzzleMaker.Forms
{
    partial class StudentFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentFrm));
            this.studentFrmMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMarksButt = new System.Windows.Forms.Button();
            this.takeTestButt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.studentFrmMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // studentFrmMenuStrip
            // 
            this.studentFrmMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.studentFrmMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.studentFrmMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.studentFrmMenuStrip.Name = "studentFrmMenuStrip";
            this.studentFrmMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.studentFrmMenuStrip.Size = new System.Drawing.Size(644, 25);
            this.studentFrmMenuStrip.TabIndex = 0;
            this.studentFrmMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takeTestToolStripMenuItem,
            this.viewMarksToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // viewMarksToolStripMenuItem
            // 
            this.viewMarksToolStripMenuItem.Name = "viewMarksToolStripMenuItem";
            this.viewMarksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewMarksToolStripMenuItem.Text = "View Marks";
            this.viewMarksToolStripMenuItem.Click += new System.EventHandler(this.viewMarksToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewMarksButt
            // 
            this.viewMarksButt.Location = new System.Drawing.Point(293, 228);
            this.viewMarksButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewMarksButt.Name = "viewMarksButt";
            this.viewMarksButt.Size = new System.Drawing.Size(186, 76);
            this.viewMarksButt.TabIndex = 2;
            this.viewMarksButt.Text = "View your Marks";
            this.viewMarksButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewMarksButt.UseVisualStyleBackColor = true;
            this.viewMarksButt.Click += new System.EventHandler(this.viewMarksButt_Click);
            // 
            // takeTestButt
            // 
            this.takeTestButt.Location = new System.Drawing.Point(293, 89);
            this.takeTestButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.takeTestButt.Name = "takeTestButt";
            this.takeTestButt.Size = new System.Drawing.Size(186, 76);
            this.takeTestButt.TabIndex = 1;
            this.takeTestButt.Text = "Take a Test";
            this.takeTestButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.takeTestButt.UseVisualStyleBackColor = true;
            this.takeTestButt.Click += new System.EventHandler(this.takeTestButt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MonkeyPuzzleMaker.Properties.Resources.CreateTest;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(135, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 116);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::MonkeyPuzzleMaker.Properties.Resources.Tick;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(135, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 116);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // StudentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 379);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.viewMarksButt);
            this.Controls.Add(this.takeTestButt);
            this.Controls.Add(this.studentFrmMenuStrip);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.studentFrmMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monkey Puzzle Taker";
            this.studentFrmMenuStrip.ResumeLayout(false);
            this.studentFrmMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip studentFrmMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button takeTestButt;
        private System.Windows.Forms.Button viewMarksButt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
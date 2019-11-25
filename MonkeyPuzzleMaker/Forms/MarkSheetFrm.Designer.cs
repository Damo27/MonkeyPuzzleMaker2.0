//All images taken from http://www.iconarchive.com/
//Backgroud image from https://wallpaperdata.com/light-blue-background.html/7?lang=fy
namespace MonkeyPuzzleMaker
{
    partial class MarkSheetFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkSheetFrm));
            this.testsCbox = new System.Windows.Forms.ComboBox();
            this.selectTestLbl = new System.Windows.Forms.Label();
            this.openSheetButt = new System.Windows.Forms.Button();
            this.saveSheetButt = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // testsCbox
            // 
            this.testsCbox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testsCbox.FormattingEnabled = true;
            this.testsCbox.Location = new System.Drawing.Point(303, 87);
            this.testsCbox.Name = "testsCbox";
            this.testsCbox.Size = new System.Drawing.Size(199, 30);
            this.testsCbox.TabIndex = 0;
            // 
            // selectTestLbl
            // 
            this.selectTestLbl.AutoSize = true;
            this.selectTestLbl.BackColor = System.Drawing.Color.Transparent;
            this.selectTestLbl.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTestLbl.Location = new System.Drawing.Point(304, 33);
            this.selectTestLbl.Name = "selectTestLbl";
            this.selectTestLbl.Size = new System.Drawing.Size(198, 28);
            this.selectTestLbl.TabIndex = 1;
            this.selectTestLbl.Text = "Please Select a Test:";
            // 
            // openSheetButt
            // 
            this.openSheetButt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSheetButt.Location = new System.Drawing.Point(351, 189);
            this.openSheetButt.Name = "openSheetButt";
            this.openSheetButt.Size = new System.Drawing.Size(186, 76);
            this.openSheetButt.TabIndex = 2;
            this.openSheetButt.Text = "Print Mark Sheet";
            this.openSheetButt.UseVisualStyleBackColor = true;
            this.openSheetButt.Click += new System.EventHandler(this.openSheetButt_Click);
            // 
            // saveSheetButt
            // 
            this.saveSheetButt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSheetButt.Location = new System.Drawing.Point(351, 349);
            this.saveSheetButt.Name = "saveSheetButt";
            this.saveSheetButt.Size = new System.Drawing.Size(186, 76);
            this.saveSheetButt.TabIndex = 3;
            this.saveSheetButt.Text = "Save Mark Sheet";
            this.saveSheetButt.UseVisualStyleBackColor = true;
            this.saveSheetButt.Click += new System.EventHandler(this.saveSheetButt_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckPathExists = false;
            this.saveFileDialog1.DefaultExt = "\"txt\"";
            this.saveFileDialog1.FileName = "MarkSheet.txt";
            this.saveFileDialog1.Filter = "\"Text files (*.txt)|*.txt|All files (*.*)|*.*\"";
            this.saveFileDialog1.FilterIndex = 2;
            this.saveFileDialog1.InitialDirectory = "Environment.SpecialFolder.MyDocuments";
            this.saveFileDialog1.Title = "Save Mark Sheet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MonkeyPuzzleMaker.Properties.Resources.Save;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(195, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 116);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::MonkeyPuzzleMaker.Properties.Resources.print;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(195, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 116);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // MarkSheetFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MonkeyPuzzleMaker.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 499);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saveSheetButt);
            this.Controls.Add(this.openSheetButt);
            this.Controls.Add(this.selectTestLbl);
            this.Controls.Add(this.testsCbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MarkSheetFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monkey Puzzle Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox testsCbox;
        private System.Windows.Forms.Label selectTestLbl;
        private System.Windows.Forms.Button openSheetButt;
        private System.Windows.Forms.Button saveSheetButt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
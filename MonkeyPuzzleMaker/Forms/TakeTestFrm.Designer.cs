//All images taken from http://www.iconarchive.com/
//Backgroud image from https://wallpaperdata.com/light-blue-background.html/7?lang=fy
namespace MonkeyPuzzleMaker.Forms
{
    partial class TakeTestFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeTestFrm));
            this.testsCbox = new System.Windows.Forms.ComboBox();
            this.questionNumLbl = new System.Windows.Forms.Label();
            this.ansARb = new System.Windows.Forms.RadioButton();
            this.ansBRb = new System.Windows.Forms.RadioButton();
            this.ansCRb = new System.Windows.Forms.RadioButton();
            this.ansDRb = new System.Windows.Forms.RadioButton();
            this.radButtPnl = new System.Windows.Forms.Panel();
            this.testAnsLbl = new System.Windows.Forms.Label();
            this.correctAnsLbl = new System.Windows.Forms.Label();
            this.learnerAnsLbl = new System.Windows.Forms.Label();
            this.youAnsLbl = new System.Windows.Forms.Label();
            this.nextQuestButt = new System.Windows.Forms.Button();
            this.backButt = new System.Windows.Forms.Button();
            this.questionLbl = new System.Windows.Forms.Label();
            this.radButtPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // testsCbox
            // 
            this.testsCbox.FormattingEnabled = true;
            this.testsCbox.Location = new System.Drawing.Point(281, 70);
            this.testsCbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testsCbox.Name = "testsCbox";
            this.testsCbox.Size = new System.Drawing.Size(222, 30);
            this.testsCbox.TabIndex = 0;
            this.testsCbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TakeTest_KeyDown);
            // 
            // questionNumLbl
            // 
            this.questionNumLbl.AutoSize = true;
            this.questionNumLbl.BackColor = System.Drawing.Color.Transparent;
            this.questionNumLbl.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNumLbl.Location = new System.Drawing.Point(288, 27);
            this.questionNumLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionNumLbl.Name = "questionNumLbl";
            this.questionNumLbl.Size = new System.Drawing.Size(203, 28);
            this.questionNumLbl.TabIndex = 1;
            this.questionNumLbl.Text = "Please Select a Test: ";
            // 
            // ansARb
            // 
            this.ansARb.AutoSize = true;
            this.ansARb.Location = new System.Drawing.Point(36, 5);
            this.ansARb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ansARb.Name = "ansARb";
            this.ansARb.Size = new System.Drawing.Size(47, 26);
            this.ansARb.TabIndex = 2;
            this.ansARb.TabStop = true;
            this.ansARb.Text = "A) ";
            this.ansARb.UseVisualStyleBackColor = true;
            this.ansARb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TakeTest_KeyDown);
            // 
            // ansBRb
            // 
            this.ansBRb.AutoSize = true;
            this.ansBRb.Location = new System.Drawing.Point(36, 69);
            this.ansBRb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ansBRb.Name = "ansBRb";
            this.ansBRb.Size = new System.Drawing.Size(47, 26);
            this.ansBRb.TabIndex = 3;
            this.ansBRb.TabStop = true;
            this.ansBRb.Text = "B) ";
            this.ansBRb.UseVisualStyleBackColor = true;
            this.ansBRb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TakeTest_KeyDown);
            // 
            // ansCRb
            // 
            this.ansCRb.AutoSize = true;
            this.ansCRb.Location = new System.Drawing.Point(36, 135);
            this.ansCRb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ansCRb.Name = "ansCRb";
            this.ansCRb.Size = new System.Drawing.Size(48, 26);
            this.ansCRb.TabIndex = 4;
            this.ansCRb.TabStop = true;
            this.ansCRb.Text = "C) ";
            this.ansCRb.UseVisualStyleBackColor = true;
            this.ansCRb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TakeTest_KeyDown);
            // 
            // ansDRb
            // 
            this.ansDRb.AutoSize = true;
            this.ansDRb.Location = new System.Drawing.Point(36, 203);
            this.ansDRb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ansDRb.Name = "ansDRb";
            this.ansDRb.Size = new System.Drawing.Size(49, 26);
            this.ansDRb.TabIndex = 5;
            this.ansDRb.TabStop = true;
            this.ansDRb.Text = "D) ";
            this.ansDRb.UseVisualStyleBackColor = true;
            this.ansDRb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TakeTest_KeyDown);
            // 
            // radButtPnl
            // 
            this.radButtPnl.BackColor = System.Drawing.Color.Transparent;
            this.radButtPnl.Controls.Add(this.testAnsLbl);
            this.radButtPnl.Controls.Add(this.correctAnsLbl);
            this.radButtPnl.Controls.Add(this.learnerAnsLbl);
            this.radButtPnl.Controls.Add(this.youAnsLbl);
            this.radButtPnl.Controls.Add(this.ansDRb);
            this.radButtPnl.Controls.Add(this.ansCRb);
            this.radButtPnl.Controls.Add(this.ansBRb);
            this.radButtPnl.Controls.Add(this.ansARb);
            this.radButtPnl.Location = new System.Drawing.Point(79, 132);
            this.radButtPnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radButtPnl.Name = "radButtPnl";
            this.radButtPnl.Size = new System.Drawing.Size(597, 239);
            this.radButtPnl.TabIndex = 6;
            this.radButtPnl.Visible = false;
            // 
            // testAnsLbl
            // 
            this.testAnsLbl.AutoSize = true;
            this.testAnsLbl.Location = new System.Drawing.Point(170, 206);
            this.testAnsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.testAnsLbl.Name = "testAnsLbl";
            this.testAnsLbl.Size = new System.Drawing.Size(126, 22);
            this.testAnsLbl.TabIndex = 9;
            this.testAnsLbl.Text = "\"Correct Answer\"";
            this.testAnsLbl.Visible = false;
            // 
            // correctAnsLbl
            // 
            this.correctAnsLbl.AutoSize = true;
            this.correctAnsLbl.Location = new System.Drawing.Point(118, 139);
            this.correctAnsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.correctAnsLbl.Name = "correctAnsLbl";
            this.correctAnsLbl.Size = new System.Drawing.Size(116, 22);
            this.correctAnsLbl.TabIndex = 8;
            this.correctAnsLbl.Text = "Correct answer:";
            this.correctAnsLbl.Visible = false;
            // 
            // learnerAnsLbl
            // 
            this.learnerAnsLbl.AutoSize = true;
            this.learnerAnsLbl.Location = new System.Drawing.Point(170, 73);
            this.learnerAnsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.learnerAnsLbl.Name = "learnerAnsLbl";
            this.learnerAnsLbl.Size = new System.Drawing.Size(129, 22);
            this.learnerAnsLbl.TabIndex = 7;
            this.learnerAnsLbl.Text = "\"Learner Answer\"";
            this.learnerAnsLbl.Visible = false;
            // 
            // youAnsLbl
            // 
            this.youAnsLbl.AutoSize = true;
            this.youAnsLbl.Location = new System.Drawing.Point(118, 8);
            this.youAnsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.youAnsLbl.Name = "youAnsLbl";
            this.youAnsLbl.Size = new System.Drawing.Size(99, 22);
            this.youAnsLbl.TabIndex = 6;
            this.youAnsLbl.Text = "Your answer:";
            this.youAnsLbl.Visible = false;
            // 
            // nextQuestButt
            // 
            this.nextQuestButt.Location = new System.Drawing.Point(587, 415);
            this.nextQuestButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextQuestButt.Name = "nextQuestButt";
            this.nextQuestButt.Size = new System.Drawing.Size(165, 39);
            this.nextQuestButt.TabIndex = 7;
            this.nextQuestButt.Text = "Take Test";
            this.nextQuestButt.UseVisualStyleBackColor = true;
            this.nextQuestButt.Click += new System.EventHandler(this.nextQuestButt_Click);
            // 
            // backButt
            // 
            this.backButt.Location = new System.Drawing.Point(405, 415);
            this.backButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(112, 39);
            this.backButt.TabIndex = 8;
            this.backButt.Text = "Back";
            this.backButt.UseVisualStyleBackColor = true;
            this.backButt.Visible = false;
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.BackColor = System.Drawing.Color.Transparent;
            this.questionLbl.Location = new System.Drawing.Point(75, 78);
            this.questionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(78, 22);
            this.questionLbl.TabIndex = 9;
            this.questionLbl.Text = "Question?";
            this.questionLbl.Visible = false;
            // 
            // TakeTestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 499);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.backButt);
            this.Controls.Add(this.nextQuestButt);
            this.Controls.Add(this.radButtPnl);
            this.Controls.Add(this.questionNumLbl);
            this.Controls.Add(this.testsCbox);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TakeTestFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Take a Test";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TakeTest_KeyDown);
            this.radButtPnl.ResumeLayout(false);
            this.radButtPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox testsCbox;
        private System.Windows.Forms.Label questionNumLbl;
        private System.Windows.Forms.RadioButton ansARb;
        private System.Windows.Forms.RadioButton ansBRb;
        private System.Windows.Forms.RadioButton ansCRb;
        private System.Windows.Forms.RadioButton ansDRb;
        private System.Windows.Forms.Panel radButtPnl;
        private System.Windows.Forms.Button nextQuestButt;
        private System.Windows.Forms.Button backButt;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Label testAnsLbl;
        private System.Windows.Forms.Label correctAnsLbl;
        private System.Windows.Forms.Label learnerAnsLbl;
        private System.Windows.Forms.Label youAnsLbl;
    }
}
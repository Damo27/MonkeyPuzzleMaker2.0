//All images taken from http://www.iconarchive.com/
//Backgroud image from https://wallpaperdata.com/light-blue-background.html/7?lang=fy
namespace MonkeyPuzzleMaker
{
    partial class NewTestFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTestFrm));
            this.questionLbl = new System.Windows.Forms.Label();
            this.answersLbl = new System.Windows.Forms.Label();
            this.ansALbl = new System.Windows.Forms.Label();
            this.ansBLbl = new System.Windows.Forms.Label();
            this.ansCLbl = new System.Windows.Forms.Label();
            this.ansDLbl = new System.Windows.Forms.Label();
            this.questionTxt = new System.Windows.Forms.TextBox();
            this.ansATxt = new System.Windows.Forms.TextBox();
            this.ansBTxt = new System.Windows.Forms.TextBox();
            this.ansCTxt = new System.Windows.Forms.TextBox();
            this.ansDTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.correctAnsPnl = new System.Windows.Forms.Panel();
            this.ansDRB = new System.Windows.Forms.RadioButton();
            this.ansCRB = new System.Windows.Forms.RadioButton();
            this.ansBRB = new System.Windows.Forms.RadioButton();
            this.ansARB = new System.Windows.Forms.RadioButton();
            this.nextQuesButt = new System.Windows.Forms.Button();
            this.saveAndExitButt = new System.Windows.Forms.Button();
            this.saveNameButt = new System.Windows.Forms.Button();
            this.answersPnl = new System.Windows.Forms.Panel();
            this.correctAnsPnl.SuspendLayout();
            this.answersPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.BackColor = System.Drawing.Color.Transparent;
            this.questionLbl.Location = new System.Drawing.Point(42, 22);
            this.questionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(86, 22);
            this.questionLbl.TabIndex = 0;
            this.questionLbl.Text = "Test Name:";
            // 
            // answersLbl
            // 
            this.answersLbl.AutoSize = true;
            this.answersLbl.Location = new System.Drawing.Point(14, 12);
            this.answersLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.answersLbl.Name = "answersLbl";
            this.answersLbl.Size = new System.Drawing.Size(128, 22);
            this.answersLbl.TabIndex = 1;
            this.answersLbl.Text = "Possible Answers:";
            // 
            // ansALbl
            // 
            this.ansALbl.AutoSize = true;
            this.ansALbl.Location = new System.Drawing.Point(10, 69);
            this.ansALbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ansALbl.Name = "ansALbl";
            this.ansALbl.Size = new System.Drawing.Size(25, 22);
            this.ansALbl.TabIndex = 2;
            this.ansALbl.Text = "A)";
            // 
            // ansBLbl
            // 
            this.ansBLbl.AutoSize = true;
            this.ansBLbl.Location = new System.Drawing.Point(10, 139);
            this.ansBLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ansBLbl.Name = "ansBLbl";
            this.ansBLbl.Size = new System.Drawing.Size(25, 22);
            this.ansBLbl.TabIndex = 3;
            this.ansBLbl.Text = "B)";
            // 
            // ansCLbl
            // 
            this.ansCLbl.AutoSize = true;
            this.ansCLbl.Location = new System.Drawing.Point(10, 203);
            this.ansCLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ansCLbl.Name = "ansCLbl";
            this.ansCLbl.Size = new System.Drawing.Size(26, 22);
            this.ansCLbl.TabIndex = 4;
            this.ansCLbl.Text = "C)";
            // 
            // ansDLbl
            // 
            this.ansDLbl.AutoSize = true;
            this.ansDLbl.Location = new System.Drawing.Point(9, 274);
            this.ansDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ansDLbl.Name = "ansDLbl";
            this.ansDLbl.Size = new System.Drawing.Size(27, 22);
            this.ansDLbl.TabIndex = 5;
            this.ansDLbl.Text = "D)";
            // 
            // questionTxt
            // 
            this.questionTxt.Location = new System.Drawing.Point(165, 19);
            this.questionTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.questionTxt.Name = "questionTxt";
            this.questionTxt.Size = new System.Drawing.Size(442, 29);
            this.questionTxt.TabIndex = 6;
            this.questionTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewTestFrm_KeyDown);
            // 
            // ansATxt
            // 
            this.ansATxt.Location = new System.Drawing.Point(99, 64);
            this.ansATxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ansATxt.Name = "ansATxt";
            this.ansATxt.Size = new System.Drawing.Size(442, 29);
            this.ansATxt.TabIndex = 8;
            this.ansATxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewTestFrm_KeyDown);
            // 
            // ansBTxt
            // 
            this.ansBTxt.Location = new System.Drawing.Point(99, 134);
            this.ansBTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ansBTxt.Name = "ansBTxt";
            this.ansBTxt.Size = new System.Drawing.Size(442, 29);
            this.ansBTxt.TabIndex = 9;
            this.ansBTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewTestFrm_KeyDown);
            // 
            // ansCTxt
            // 
            this.ansCTxt.Location = new System.Drawing.Point(99, 198);
            this.ansCTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ansCTxt.Name = "ansCTxt";
            this.ansCTxt.Size = new System.Drawing.Size(442, 29);
            this.ansCTxt.TabIndex = 10;
            this.ansCTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewTestFrm_KeyDown);
            // 
            // ansDTxt
            // 
            this.ansDTxt.Location = new System.Drawing.Point(99, 269);
            this.ansDTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ansDTxt.Name = "ansDTxt";
            this.ansDTxt.Size = new System.Drawing.Size(442, 29);
            this.ansDTxt.TabIndex = 11;
            this.ansDTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewTestFrm_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select Correct Answer";
            // 
            // correctAnsPnl
            // 
            this.correctAnsPnl.Controls.Add(this.ansDRB);
            this.correctAnsPnl.Controls.Add(this.ansCRB);
            this.correctAnsPnl.Controls.Add(this.ansBRB);
            this.correctAnsPnl.Controls.Add(this.ansARB);
            this.correctAnsPnl.Location = new System.Drawing.Point(582, 61);
            this.correctAnsPnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.correctAnsPnl.Name = "correctAnsPnl";
            this.correctAnsPnl.Size = new System.Drawing.Size(170, 240);
            this.correctAnsPnl.TabIndex = 12;
            // 
            // ansDRB
            // 
            this.ansDRB.AutoSize = true;
            this.ansDRB.Location = new System.Drawing.Point(72, 210);
            this.ansDRB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ansDRB.Name = "ansDRB";
            this.ansDRB.Size = new System.Drawing.Size(14, 13);
            this.ansDRB.TabIndex = 3;
            this.ansDRB.UseVisualStyleBackColor = true;
            // 
            // ansCRB
            // 
            this.ansCRB.AutoSize = true;
            this.ansCRB.Location = new System.Drawing.Point(72, 139);
            this.ansCRB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ansCRB.Name = "ansCRB";
            this.ansCRB.Size = new System.Drawing.Size(14, 13);
            this.ansCRB.TabIndex = 2;
            this.ansCRB.UseVisualStyleBackColor = true;
            // 
            // ansBRB
            // 
            this.ansBRB.AutoSize = true;
            this.ansBRB.Location = new System.Drawing.Point(72, 74);
            this.ansBRB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ansBRB.Name = "ansBRB";
            this.ansBRB.Size = new System.Drawing.Size(14, 13);
            this.ansBRB.TabIndex = 1;
            this.ansBRB.UseVisualStyleBackColor = true;
            // 
            // ansARB
            // 
            this.ansARB.AutoSize = true;
            this.ansARB.Location = new System.Drawing.Point(72, 5);
            this.ansARB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ansARB.Name = "ansARB";
            this.ansARB.Size = new System.Drawing.Size(14, 13);
            this.ansARB.TabIndex = 0;
            this.ansARB.UseVisualStyleBackColor = true;
            // 
            // nextQuesButt
            // 
            this.nextQuesButt.Location = new System.Drawing.Point(614, 421);
            this.nextQuesButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextQuesButt.Name = "nextQuesButt";
            this.nextQuesButt.Size = new System.Drawing.Size(170, 39);
            this.nextQuesButt.TabIndex = 13;
            this.nextQuesButt.Text = "Save Question";
            this.nextQuesButt.UseVisualStyleBackColor = true;
            this.nextQuesButt.Visible = false;
            this.nextQuesButt.Click += new System.EventHandler(this.nextQuesButt_Click);
            // 
            // saveAndExitButt
            // 
            this.saveAndExitButt.Location = new System.Drawing.Point(405, 421);
            this.saveAndExitButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveAndExitButt.Name = "saveAndExitButt";
            this.saveAndExitButt.Size = new System.Drawing.Size(170, 39);
            this.saveAndExitButt.TabIndex = 14;
            this.saveAndExitButt.Text = "Save Test and Exit";
            this.saveAndExitButt.UseVisualStyleBackColor = true;
            this.saveAndExitButt.Visible = false;
            this.saveAndExitButt.Click += new System.EventHandler(this.saveAndExitButt_Click);
            // 
            // saveNameButt
            // 
            this.saveNameButt.Location = new System.Drawing.Point(46, 421);
            this.saveNameButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveNameButt.Name = "saveNameButt";
            this.saveNameButt.Size = new System.Drawing.Size(170, 39);
            this.saveNameButt.TabIndex = 15;
            this.saveNameButt.Text = "Next";
            this.saveNameButt.UseVisualStyleBackColor = true;
            this.saveNameButt.Click += new System.EventHandler(this.saveNameButt_Click);
            // 
            // answersPnl
            // 
            this.answersPnl.BackColor = System.Drawing.Color.Transparent;
            this.answersPnl.Controls.Add(this.correctAnsPnl);
            this.answersPnl.Controls.Add(this.label1);
            this.answersPnl.Controls.Add(this.ansDTxt);
            this.answersPnl.Controls.Add(this.ansCTxt);
            this.answersPnl.Controls.Add(this.ansBTxt);
            this.answersPnl.Controls.Add(this.ansATxt);
            this.answersPnl.Controls.Add(this.ansDLbl);
            this.answersPnl.Controls.Add(this.ansCLbl);
            this.answersPnl.Controls.Add(this.ansBLbl);
            this.answersPnl.Controls.Add(this.ansALbl);
            this.answersPnl.Controls.Add(this.answersLbl);
            this.answersPnl.Location = new System.Drawing.Point(32, 71);
            this.answersPnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.answersPnl.Name = "answersPnl";
            this.answersPnl.Size = new System.Drawing.Size(766, 325);
            this.answersPnl.TabIndex = 7;
            this.answersPnl.Visible = false;
            // 
            // NewTestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 499);
            this.Controls.Add(this.answersPnl);
            this.Controls.Add(this.saveNameButt);
            this.Controls.Add(this.saveAndExitButt);
            this.Controls.Add(this.nextQuesButt);
            this.Controls.Add(this.questionTxt);
            this.Controls.Add(this.questionLbl);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewTestFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Test";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewTestFrm_KeyDown);
            this.correctAnsPnl.ResumeLayout(false);
            this.correctAnsPnl.PerformLayout();
            this.answersPnl.ResumeLayout(false);
            this.answersPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Label answersLbl;
        private System.Windows.Forms.Label ansALbl;
        private System.Windows.Forms.Label ansBLbl;
        private System.Windows.Forms.Label ansCLbl;
        private System.Windows.Forms.Label ansDLbl;
        private System.Windows.Forms.TextBox questionTxt;
        private System.Windows.Forms.TextBox ansATxt;
        private System.Windows.Forms.TextBox ansBTxt;
        private System.Windows.Forms.TextBox ansCTxt;
        private System.Windows.Forms.TextBox ansDTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel correctAnsPnl;
        private System.Windows.Forms.RadioButton ansDRB;
        private System.Windows.Forms.RadioButton ansCRB;
        private System.Windows.Forms.RadioButton ansBRB;
        private System.Windows.Forms.RadioButton ansARB;
        private System.Windows.Forms.Button nextQuesButt;
        private System.Windows.Forms.Button saveAndExitButt;
        private System.Windows.Forms.Button saveNameButt;
        private System.Windows.Forms.Panel answersPnl;
    }
}
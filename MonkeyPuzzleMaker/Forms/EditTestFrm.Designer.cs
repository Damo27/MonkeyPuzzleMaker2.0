namespace MonkeyPuzzleMaker.Forms
{
    partial class EditTestFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTestFrm));
            this.dg_Questions = new System.Windows.Forms.DataGridView();
            this.saveChangesButt = new System.Windows.Forms.Button();
            this.testLbl = new System.Windows.Forms.Label();
            this.testCBox = new System.Windows.Forms.ComboBox();
            this.testIDLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Questions)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Questions
            // 
            this.dg_Questions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Questions.Location = new System.Drawing.Point(36, 76);
            this.dg_Questions.Name = "dg_Questions";
            this.dg_Questions.Size = new System.Drawing.Size(827, 174);
            this.dg_Questions.TabIndex = 0;
            // 
            // saveChangesButt
            // 
            this.saveChangesButt.Location = new System.Drawing.Point(406, 272);
            this.saveChangesButt.Name = "saveChangesButt";
            this.saveChangesButt.Size = new System.Drawing.Size(139, 39);
            this.saveChangesButt.TabIndex = 1;
            this.saveChangesButt.Text = "Save Changes";
            this.saveChangesButt.UseVisualStyleBackColor = true;
            this.saveChangesButt.Click += new System.EventHandler(this.saveChangesButt_Click);
            // 
            // testLbl
            // 
            this.testLbl.AutoSize = true;
            this.testLbl.BackColor = System.Drawing.Color.Transparent;
            this.testLbl.Location = new System.Drawing.Point(32, 29);
            this.testLbl.Name = "testLbl";
            this.testLbl.Size = new System.Drawing.Size(40, 22);
            this.testLbl.TabIndex = 2;
            this.testLbl.Text = "Test:";
            // 
            // testCBox
            // 
            this.testCBox.FormattingEnabled = true;
            this.testCBox.Location = new System.Drawing.Point(87, 26);
            this.testCBox.Name = "testCBox";
            this.testCBox.Size = new System.Drawing.Size(361, 30);
            this.testCBox.TabIndex = 3;
            this.testCBox.SelectedIndexChanged += new System.EventHandler(this.testCBox_SelectedIndexChanged);
            // 
            // testIDLbl
            // 
            this.testIDLbl.AutoSize = true;
            this.testIDLbl.BackColor = System.Drawing.Color.Transparent;
            this.testIDLbl.Location = new System.Drawing.Point(562, 29);
            this.testIDLbl.Name = "testIDLbl";
            this.testIDLbl.Size = new System.Drawing.Size(61, 22);
            this.testIDLbl.TabIndex = 4;
            this.testIDLbl.Text = "TestID: ";
            // 
            // EditTestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MonkeyPuzzleMaker.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 338);
            this.Controls.Add(this.testIDLbl);
            this.Controls.Add(this.testCBox);
            this.Controls.Add(this.testLbl);
            this.Controls.Add(this.saveChangesButt);
            this.Controls.Add(this.dg_Questions);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditTestFrm";
            this.Text = "EditTestFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Questions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Questions;
        private System.Windows.Forms.Button saveChangesButt;
        private System.Windows.Forms.Label testLbl;
        private System.Windows.Forms.ComboBox testCBox;
        private System.Windows.Forms.Label testIDLbl;
    }
}
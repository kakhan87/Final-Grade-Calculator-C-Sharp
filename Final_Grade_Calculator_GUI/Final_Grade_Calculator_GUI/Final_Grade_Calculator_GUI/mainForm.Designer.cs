namespace Assignment2
{
    partial class mainForm
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
            this.quizMarkTextBox = new System.Windows.Forms.TextBox();
            this.quizMarkLabel = new System.Windows.Forms.Label();
            this.transferTextButton = new System.Windows.Forms.Button();
            this.midTermMarkTextBox = new System.Windows.Forms.TextBox();
            this.midTermMark = new System.Windows.Forms.Label();
            this.finalExamMarkTextBox = new System.Windows.Forms.TextBox();
            this.finalExamMarkLabel = new System.Windows.Forms.Label();
            this.multiLineROTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.finalScoreLabel = new System.Windows.Forms.Label();
            this.letterGradeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dropCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // quizMarkTextBox
            // 
            this.quizMarkTextBox.Location = new System.Drawing.Point(130, 34);
            this.quizMarkTextBox.Name = "quizMarkTextBox";
            this.quizMarkTextBox.Size = new System.Drawing.Size(101, 20);
            this.quizMarkTextBox.TabIndex = 1;
            // 
            // quizMarkLabel
            // 
            this.quizMarkLabel.AutoSize = true;
            this.quizMarkLabel.Location = new System.Drawing.Point(40, 37);
            this.quizMarkLabel.Name = "quizMarkLabel";
            this.quizMarkLabel.Size = new System.Drawing.Size(58, 13);
            this.quizMarkLabel.TabIndex = 0;
            this.quizMarkLabel.Text = "Quiz Mark:";
            // 
            // transferTextButton
            // 
            this.transferTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferTextButton.Location = new System.Drawing.Point(247, 31);
            this.transferTextButton.Name = "transferTextButton";
            this.transferTextButton.Size = new System.Drawing.Size(34, 29);
            this.transferTextButton.TabIndex = 2;
            this.transferTextButton.Text = "➙";
            this.transferTextButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.transferTextButton.UseVisualStyleBackColor = true;
            this.transferTextButton.Click += new System.EventHandler(this.transferTextButton_Click);
            // 
            // midTermMarkTextBox
            // 
            this.midTermMarkTextBox.Location = new System.Drawing.Point(130, 101);
            this.midTermMarkTextBox.Name = "midTermMarkTextBox";
            this.midTermMarkTextBox.Size = new System.Drawing.Size(101, 20);
            this.midTermMarkTextBox.TabIndex = 4;
            // 
            // midTermMark
            // 
            this.midTermMark.AutoSize = true;
            this.midTermMark.Location = new System.Drawing.Point(19, 104);
            this.midTermMark.Name = "midTermMark";
            this.midTermMark.Size = new System.Drawing.Size(81, 13);
            this.midTermMark.TabIndex = 0;
            this.midTermMark.Text = "Mid-Term Mark:";
            // 
            // finalExamMarkTextBox
            // 
            this.finalExamMarkTextBox.Location = new System.Drawing.Point(130, 137);
            this.finalExamMarkTextBox.Name = "finalExamMarkTextBox";
            this.finalExamMarkTextBox.Size = new System.Drawing.Size(101, 20);
            this.finalExamMarkTextBox.TabIndex = 5;
            // 
            // finalExamMarkLabel
            // 
            this.finalExamMarkLabel.AutoSize = true;
            this.finalExamMarkLabel.Location = new System.Drawing.Point(13, 140);
            this.finalExamMarkLabel.Name = "finalExamMarkLabel";
            this.finalExamMarkLabel.Size = new System.Drawing.Size(88, 13);
            this.finalExamMarkLabel.TabIndex = 0;
            this.finalExamMarkLabel.Text = "Final Exam Mark:";
            // 
            // multiLineROTextBox
            // 
            this.multiLineROTextBox.Location = new System.Drawing.Point(306, 31);
            this.multiLineROTextBox.Multiline = true;
            this.multiLineROTextBox.Name = "multiLineROTextBox";
            this.multiLineROTextBox.ReadOnly = true;
            this.multiLineROTextBox.Size = new System.Drawing.Size(55, 190);
            this.multiLineROTextBox.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(16, 168);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(103, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "&Calculate Grade";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(16, 201);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(103, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(16, 232);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(103, 23);
            this.quitButton.TabIndex = 8;
            this.quitButton.TabStop = false;
            this.quitButton.Text = "&Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // finalScoreLabel
            // 
            this.finalScoreLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.finalScoreLabel.Location = new System.Drawing.Point(125, 173);
            this.finalScoreLabel.Name = "finalScoreLabel";
            this.finalScoreLabel.Size = new System.Drawing.Size(60, 23);
            this.finalScoreLabel.TabIndex = 0;
            this.finalScoreLabel.Text = "Final Score";
            this.finalScoreLabel.Visible = false;
            // 
            // letterGradeLabel
            // 
            this.letterGradeLabel.Location = new System.Drawing.Point(191, 173);
            this.letterGradeLabel.Name = "letterGradeLabel";
            this.letterGradeLabel.Size = new System.Drawing.Size(69, 23);
            this.letterGradeLabel.TabIndex = 0;
            this.letterGradeLabel.Text = "Letter Grade";
            this.letterGradeLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quizzes";
            // 
            // dropCheckBox
            // 
            this.dropCheckBox.AutoSize = true;
            this.dropCheckBox.Location = new System.Drawing.Point(130, 69);
            this.dropCheckBox.Name = "dropCheckBox";
            this.dropCheckBox.Size = new System.Drawing.Size(167, 17);
            this.dropCheckBox.TabIndex = 3;
            this.dropCheckBox.Text = "Drop Lowest/Highest Quizzes";
            this.dropCheckBox.UseVisualStyleBackColor = true;
            this.dropCheckBox.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            // 
            // mainForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 267);
            this.Controls.Add(this.dropCheckBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.multiLineROTextBox);
            this.Controls.Add(this.transferTextButton);
            this.Controls.Add(this.letterGradeLabel);
            this.Controls.Add(this.finalScoreLabel);
            this.Controls.Add(this.finalExamMarkLabel);
            this.Controls.Add(this.finalExamMarkTextBox);
            this.Controls.Add(this.midTermMark);
            this.Controls.Add(this.midTermMarkTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quizMarkLabel);
            this.Controls.Add(this.quizMarkTextBox);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Final Grade Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox quizMarkTextBox;
        private System.Windows.Forms.Label quizMarkLabel;
        private System.Windows.Forms.Button transferTextButton;
        private System.Windows.Forms.TextBox midTermMarkTextBox;
        private System.Windows.Forms.Label midTermMark;
        private System.Windows.Forms.TextBox finalExamMarkTextBox;
        private System.Windows.Forms.Label finalExamMarkLabel;
        private System.Windows.Forms.TextBox multiLineROTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label finalScoreLabel;
        private System.Windows.Forms.Label letterGradeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox dropCheckBox;
    }
}


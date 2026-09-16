namespace TeamQuizApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            questionLabel = new Label();
            answerButton1 = new Button();
            answerButton2 = new Button();
            answerButton3 = new Button();
            answerButton4 = new Button();
            logListBox = new ListBox();
            SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new Point(60, 66);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(50, 20);
            questionLabel.TabIndex = 0;
            questionLabel.Text = "label1";
            // 
            // answerButton1
            // 
            answerButton1.Location = new Point(62, 145);
            answerButton1.Name = "answerButton1";
            answerButton1.Size = new Size(94, 29);
            answerButton1.TabIndex = 1;
            answerButton1.Text = "button1";
            answerButton1.UseVisualStyleBackColor = true;
            // 
            // answerButton2
            // 
            answerButton2.Location = new Point(62, 220);
            answerButton2.Name = "answerButton2";
            answerButton2.Size = new Size(94, 29);
            answerButton2.TabIndex = 2;
            answerButton2.Text = "button2";
            answerButton2.UseVisualStyleBackColor = true;
            // 
            // answerButton3
            // 
            answerButton3.Location = new Point(62, 289);
            answerButton3.Name = "answerButton3";
            answerButton3.Size = new Size(94, 29);
            answerButton3.TabIndex = 3;
            answerButton3.Text = "button3";
            answerButton3.UseVisualStyleBackColor = true;
            // 
            // answerButton4
            // 
            answerButton4.Location = new Point(60, 362);
            answerButton4.Name = "answerButton4";
            answerButton4.Size = new Size(94, 29);
            answerButton4.TabIndex = 4;
            answerButton4.Text = "button4";
            answerButton4.UseVisualStyleBackColor = true;
            // 
            // logListBox
            // 
            logListBox.FormattingEnabled = true;
            logListBox.Location = new Point(324, 102);
            logListBox.Name = "logListBox";
            logListBox.Size = new Size(301, 284);
            logListBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logListBox);
            Controls.Add(answerButton4);
            Controls.Add(answerButton3);
            Controls.Add(answerButton2);
            Controls.Add(answerButton1);
            Controls.Add(questionLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionLabel;
        private Button answerButton1;
        private Button answerButton2;
        private Button answerButton3;
        private Button answerButton4;
        private ListBox logListBox;
    }
}

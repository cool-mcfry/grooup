namespace memory_task
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
            Easy = new Button();
            Medium = new Button();
            Hard = new Button();
            Start = new Button();
            WordsList = new ListBox();
            Answers = new TextBox();
            info = new Label();
            submit = new Button();
            score1 = new Button();
            score2 = new Button();
            SuspendLayout();
            // 
            // Easy
            // 
            Easy.Location = new Point(14, 16);
            Easy.Margin = new Padding(3, 4, 3, 4);
            Easy.Name = "Easy";
            Easy.Size = new Size(86, 31);
            Easy.TabIndex = 0;
            Easy.Text = "Easy";
            Easy.UseVisualStyleBackColor = true;
            Easy.Click += Easy_Click;
            // 
            // Medium
            // 
            Medium.Location = new Point(106, 16);
            Medium.Margin = new Padding(3, 4, 3, 4);
            Medium.Name = "Medium";
            Medium.Size = new Size(86, 31);
            Medium.TabIndex = 1;
            Medium.Text = "Medium";
            Medium.UseVisualStyleBackColor = true;
            Medium.Click += Medium_Click;
            // 
            // Hard
            // 
            Hard.Location = new Point(199, 16);
            Hard.Margin = new Padding(3, 4, 3, 4);
            Hard.Name = "Hard";
            Hard.Size = new Size(86, 31);
            Hard.TabIndex = 2;
            Hard.Text = "Hard";
            Hard.UseVisualStyleBackColor = true;
            Hard.Click += Hard_Click;
            // 
            // Start
            // 
            Start.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Start.Location = new Point(389, 175);
            Start.Margin = new Padding(3, 4, 3, 4);
            Start.Name = "Start";
            Start.Size = new Size(184, 136);
            Start.TabIndex = 3;
            Start.Text = "Click To Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // WordsList
            // 
            WordsList.FormattingEnabled = true;
            WordsList.Location = new Point(435, 175);
            WordsList.Margin = new Padding(3, 4, 3, 4);
            WordsList.Name = "WordsList";
            WordsList.Size = new Size(137, 124);
            WordsList.TabIndex = 4;
            // 
            // Answers
            // 
            Answers.Location = new Point(314, 175);
            Answers.Margin = new Padding(3, 4, 3, 4);
            Answers.Multiline = true;
            Answers.Name = "Answers";
            Answers.Size = new Size(114, 124);
            Answers.TabIndex = 5;
            // 
            // info
            // 
            info.AutoSize = true;
            info.Location = new Point(129, 125);
            info.Name = "info";
            info.Size = new Size(0, 20);
            info.TabIndex = 6;
            // 
            // submit
            // 
            submit.Location = new Point(389, 329);
            submit.Margin = new Padding(3, 4, 3, 4);
            submit.Name = "submit";
            submit.Size = new Size(86, 31);
            submit.TabIndex = 7;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // score1
            // 
            score1.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            score1.Location = new Point(668, 15);
            score1.Name = "score1";
            score1.Size = new Size(203, 55);
            score1.TabIndex = 8;
            score1.Text = "SCORE";
            score1.UseVisualStyleBackColor = true;
            // 
            // score2
            // 
            score2.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            score2.Location = new Point(668, 76);
            score2.Name = "score2";
            score2.Size = new Size(203, 69);
            score2.TabIndex = 9;
            score2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(score2);
            Controls.Add(score1);
            Controls.Add(submit);
            Controls.Add(info);
            Controls.Add(Answers);
            Controls.Add(WordsList);
            Controls.Add(Start);
            Controls.Add(Hard);
            Controls.Add(Medium);
            Controls.Add(Easy);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Easy;
        private Button Medium;
        private Button Hard;
        private Button Start;
        private ListBox WordsList;
        private TextBox Answers;
        private Label info;
        private Button submit;
        private Button score1;
        private Button score2;
    }
}

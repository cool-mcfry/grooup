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
            SuspendLayout();
            // 
            // Easy
            // 
            Easy.Location = new Point(12, 12);
            Easy.Name = "Easy";
            Easy.Size = new Size(75, 23);
            Easy.TabIndex = 0;
            Easy.Text = "Easy";
            Easy.UseVisualStyleBackColor = true;
            Easy.Click += Easy_Click;
            // 
            // Medium
            // 
            Medium.Location = new Point(93, 12);
            Medium.Name = "Medium";
            Medium.Size = new Size(75, 23);
            Medium.TabIndex = 1;
            Medium.Text = "Medium";
            Medium.UseVisualStyleBackColor = true;
            Medium.Click += Medium_Click;
            // 
            // Hard
            // 
            Hard.Location = new Point(174, 12);
            Hard.Name = "Hard";
            Hard.Size = new Size(75, 23);
            Hard.TabIndex = 2;
            Hard.Text = "Hard";
            Hard.UseVisualStyleBackColor = true;
            Hard.Click += Hard_Click;
            // 
            // Start
            // 
            Start.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Start.Location = new Point(340, 131);
            Start.Name = "Start";
            Start.Size = new Size(161, 102);
            Start.TabIndex = 3;
            Start.Text = "Click To Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // WordsList
            // 
            WordsList.FormattingEnabled = true;
            WordsList.ItemHeight = 15;
            WordsList.Location = new Point(381, 131);
            WordsList.Name = "WordsList";
            WordsList.Size = new Size(120, 79);
            WordsList.TabIndex = 4;
            // 
            // Answers
            // 
            Answers.Location = new Point(275, 131);
            Answers.Multiline = true;
            Answers.Name = "Answers";
            Answers.Size = new Size(100, 79);
            Answers.TabIndex = 5;
            // 
            // info
            // 
            info.AutoSize = true;
            info.Location = new Point(249, 94);
            info.Name = "info";
            info.Size = new Size(0, 15);
            info.TabIndex = 6;
            // 
            // submit
            // 
            submit.Location = new Point(340, 216);
            submit.Name = "submit";
            submit.Size = new Size(75, 23);
            submit.TabIndex = 7;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submit);
            Controls.Add(info);
            Controls.Add(Answers);
            Controls.Add(WordsList);
            Controls.Add(Start);
            Controls.Add(Hard);
            Controls.Add(Medium);
            Controls.Add(Easy);
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
    }
}

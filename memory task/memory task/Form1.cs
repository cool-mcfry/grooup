using System.Diagnostics;
using System.Windows.Forms;
namespace memory_task
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        string mode = "";
        double currentScore = 0;
        double score = 0;
        List<string> words = new List<string>();
        public Form1()
        {
            InitializeComponent();
            Easy.Hide();
            Medium.Hide();
            Hard.Hide();
            WordsList.Hide();
            Answers.Hide();
            submit.Hide();
            timer.Tick += clearList;
        }
        void clearList(object sender, EventArgs e)
        {
            if (WordsList.Items != null)
            {
                WordsList.Items.Clear();
                info.Text = "write your answer in the text box given with each word being on a new line";
                Answers.Show();
                submit.Show();
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start.Hide();
            Easy.Show();
            Medium.Show();
            Hard.Show();
        }

        private void Easy_Click(object sender, EventArgs e)
        {
            mode = "easy";
            Easy.Hide();
            Medium.Hide();
            Hard.Hide();
            easyMode();
            timer.Interval = 10000;
        }
        public void easyMode()
        {
            WordsList.Show();
            WordsList.Items.AddRange(File.ReadAllLines("easywords.txt"));
            foreach (string s in WordsList.Items)
            {
                words.Add(s);
            }
            timer.Start();
        }

        private void Medium_Click(object sender, EventArgs e)
        {
            mode = "medium";
            Easy.Hide();
            Medium.Hide();
            Hard.Hide();
            mediumMode();
            timer.Interval = 8000;
        }
        public void mediumMode()
        {
            WordsList.Show();
            WordsList.Items.AddRange(File.ReadAllLines("mediumwords.txt"));
            foreach (string s in WordsList.Items)
            {
                words.Add(s);
            }
            timer.Start();
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            mode = "hard";
            Easy.Hide();
            Medium.Hide();
            Hard.Hide();
            hardMode();
            timer.Interval = 5000;
        }
        public void hardMode()
        {
            WordsList.Show();
            WordsList.Items.AddRange(File.ReadAllLines("hardwords.txt"));
            foreach (string s in WordsList.Items)
            {
                words.Add(s);
            }
            timer.Start();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            timer.Stop();
            string[] answers = Answers.Text.Split('\n');
            check(answers);
        }
        public void check(string[] answers)
        {
            for (int i = 0; i < answers.Length; i++)
            {
               
                foreach (string s in words)
                {
                    
                    if (s.ToLower() == answers[i].ToLower().Trim())
                    {
                        score = score +1;
                    }
                }
            }
            Debug.WriteLine(words.Count);
            Debug.WriteLine(score);
            updateScore();
        }
        public void updateScore()
        {
            
            if (mode == "easy")
            {
                currentScore = currentScore + Math.Pow(score, 2);
            }

            if (mode == "medium")
            {
                currentScore = currentScore + Math.Pow(score, 3);
            }

            if (mode == "hard")
            {
                currentScore = currentScore+ Math.Pow(score, 4);
            }
            Debug.WriteLine(currentScore);
            score = 0;
            Debug.WriteLine(score);
            score2.Text = currentScore.ToString();
            endGame();
        }
        public void endGame()
        {
            words.Clear();
            Answers.Clear();
            WordsList.Hide();
            Answers.Hide();
            submit.Hide();
            Start.Show();
            info.Hide();
            Start.Text = "play again";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using static System.Object;
using System.Drawing;
using System.Linq;
using System.Windows.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection;
using System.Reflection.Emit;
using System.Windows;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private int player;

        int score_player1 = 0;

        int score_player2 = 0;

        private MediaPlayer backgroundMusicPlayer = new MediaPlayer();

        private string currentSoundPath = @"C:\Users\user\source\repos\C#\Tic-Tac-Toe\Tic-Tac-Toe\Resources\main-menu-1.wav";

        private string secondSoundPath = @"C:\Users\user\source\repos\C#\Tic-Tac-Toe\Tic-Tac-Toe\Resources\main-menu-2.wav";
        public Form1()
        {
            InitializeComponent();

            Button_White();

            backgroundMusicPlayer.Open(new Uri(currentSoundPath));

            backgroundMusicPlayer.Volume = 0.1;

            backgroundMusicPlayer.MediaEnded += (sender, e) => backgroundMusicPlayer.Position = TimeSpan.Zero;

            backgroundMusicPlayer.Play();

            label6.ForeColor = System.Drawing.Color.Green;
        }

        public delegate void ChangeMusicDelegate();

        public event ChangeMusicDelegate OnChangeMusic;
        private void Change_music1()
        {
            if (backgroundMusicPlayer.Source.LocalPath == currentSoundPath)
            {
                backgroundMusicPlayer.Open(new Uri(secondSoundPath));

                backgroundMusicPlayer.Play();
            }
        }
        private void Change_music2()
        {
            if (backgroundMusicPlayer.Source.LocalPath != currentSoundPath)
            {
                backgroundMusicPlayer.Open(new Uri(currentSoundPath));

                backgroundMusicPlayer.Play();
            }
        }
        public MediaPlayer GetMediaPlayer()
        {
            return backgroundMusicPlayer;
        }
        public void Public_Change_music1()
        {
            Change_music1();
        }
        public void Public_Change_music2()
        {
            Change_music2();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            switch (player)
            {
                case (1):
                    {
                        sender.GetType().GetProperty("Text").SetValue(sender, "O");

                        player = 0;

                        label6.ForeColor = System.Drawing.Color.Green;

                        label7.ForeColor = System.Drawing.Color.White;

                        break;
                    }
                case (0):
                    {
                        sender.GetType().GetProperty("Text").SetValue(sender, "X");

                        player = 1;

                        label6.ForeColor = System.Drawing.Color.White;

                        label7.ForeColor = System.Drawing.Color.Green;

                        break;
                    }
            }

            sender.GetType().GetProperty("Enabled").SetValue(sender, false);

            Check_Win();
        }
        private void Check_Win()
        {
            int num = 0;

            bool isDraw = false;

            if (button1 != null && button1.Text == "")
            {
                num++;
            }

            if (button2 != null && button2.Text == "")
            {
                num++;
            }

            if (button3 != null && button3.Text == "")
            {
                num++;
            }

            if (button4 != null && button4.Text == "")
            {
                num++;
            }

            if (button5 != null && button5.Text == "")
            {
                num++;
            }

            if (button6 != null && button6.Text == "")
            {
                num++;
            }

            if (button7 != null && button7.Text == "")
            {
                num++;
            }

            if (button8 != null && button8.Text == "")
            {
                num++;
            }

            if (button9 != null && button9.Text == "")
            {
                num++;
            }

            if (num == 1)
            {
                if ((button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") ||
                    (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "") ||
                    (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != ""))
                {
                    isDraw = true;
                }
                else if ((button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "") ||
                         (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") ||
                         (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != ""))
                {
                    isDraw = true;
                }
                else if ((button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") ||
                         (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != ""))
                {
                    isDraw = true;
                }
                else
                {
                    isDraw = false;
                }
            }

            if (isDraw == false && num == 1)
            {
                MessageBox.Show("Ничья!");

                ButtonEnabled_False();
            }

            if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text != "")
                {
                    if (isDraw == false)
                    {
                        if (player == 1)
                        {
                            score_player1++;

                            MessageBox.Show("Победил Игрок 1!");

                            label9.Text = score_player1.ToString();

                            ButtonEnabled_False();
                        }
                        else if (player == 0)
                        {
                            score_player2++;

                            MessageBox.Show("Победил Игрок 2!");

                            label8.Text = score_player2.ToString();

                            ButtonEnabled_False();
                        }
                    }
                }
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text != "")
                {
                    if (isDraw == false)
                    {
                        if (player == 1)
                        {
                            score_player1++;

                            MessageBox.Show("Победил Игрок 1!");

                            label9.Text = score_player1.ToString();

                            ButtonEnabled_False();
                        }
                        else if (player == 0)
                        {
                            score_player2++;

                            MessageBox.Show("Победил Игрок 2!");

                            label8.Text = score_player2.ToString();

                            ButtonEnabled_False();
                        }
                    }
                }
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text != "")
                {
                    if (isDraw == false)
                    {
                        if (player == 1)
                        {
                            score_player1++;

                            MessageBox.Show("Победил Игрок 1!");

                            label9.Text = score_player1.ToString();

                            ButtonEnabled_False();
                        }
                        else if (player == 0)
                        {
                            score_player2++;

                            MessageBox.Show("Победил Игрок 2!");

                            label8.Text = score_player2.ToString();

                            ButtonEnabled_False();
                        }
                    }
                }
            }
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text != "")
                {
                    if (isDraw == false)
                    {
                        if (player == 1)
                        {
                            score_player1++;

                            MessageBox.Show("Победил Игрок 1!");

                            label9.Text = score_player1.ToString();

                            ButtonEnabled_False();
                        }
                        else if (player == 0)
                        {
                            score_player2++;

                            MessageBox.Show("Победил Игрок 2!");

                            label8.Text = score_player2.ToString();

                            ButtonEnabled_False();
                        }
                    }
                }
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text != "")
                {
                    if (isDraw == false)
                    {
                        if (player == 1)
                        {
                            score_player1++;

                            MessageBox.Show("Победил Игрок 1!");

                            label9.Text = score_player1.ToString();

                            ButtonEnabled_False();
                        }
                        else if (player == 0)
                        {
                            score_player2++;

                            MessageBox.Show("Победил Игрок 2!");

                            label8.Text = score_player2.ToString();

                            ButtonEnabled_False();
                        }
                    }
                }
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text != "")
                {
                    if (isDraw == false)
                    {
                        if (player == 1)
                        {
                            score_player1++;

                            MessageBox.Show("Победил Игрок 1!");

                            label9.Text = score_player1.ToString();

                            ButtonEnabled_False();
                        }
                        else if (player == 0)
                        {
                            score_player2++;

                            MessageBox.Show("Победил Игрок 2!");

                            label8.Text = score_player2.ToString();

                            ButtonEnabled_False();
                        }
                    }
                }
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text != "")
                {
                    if (isDraw == false)
                    {
                        if (player == 1)
                        {
                            score_player1++;

                            MessageBox.Show("Победил Игрок 1!");

                            label9.Text = score_player1.ToString();

                            ButtonEnabled_False();
                        }
                        else if (player == 0)
                        {
                            score_player2++;

                            MessageBox.Show("Победил Игрок 2!");

                            label8.Text = score_player2.ToString();

                            ButtonEnabled_False();
                        }
                    }
                }
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text != "")
                {
                    if (isDraw == false)
                    {
                        if (player == 1)
                        {
                            score_player1++;

                            MessageBox.Show("Победил Игрок 1!");

                            label9.Text = score_player1.ToString();

                            ButtonEnabled_False();
                        }
                        else if (player == 0)
                        {
                            score_player2++;

                            MessageBox.Show("Победил Игрок 2!");

                            label8.Text = score_player2.ToString();

                            ButtonEnabled_False();
                        }
                    }
                }
            }
            num = 0;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Form1 form = new Form1();
            if (e.KeyCode == Keys.Escape)
            {
                form.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
        private void Label5_MouseEnter(object sender, EventArgs e)
        {
            string soundPath = @"C:\Users\user\source\repos\C#\Tic-Tac-Toe\Tic-Tac-Toe\Resources\Text_sound.wav";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundPath);

            player.Play();

            label5.ForeColor = System.Drawing.Color.Crimson;
        }
        private void Label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = SystemColors.Control;
        }
        private void Label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Label3_MouseEnter(object sender, EventArgs e)
        {
            string soundPath = @"C:\Users\user\source\repos\C#\Tic-Tac-Toe\Tic-Tac-Toe\Resources\Text_sound.wav";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundPath);

            player.Play();

            label3.ForeColor = System.Drawing.Color.Green;
        }
        private void Label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = SystemColors.Control;
        }
        private void Label4_Click(object sender, EventArgs e)
        {
            ButtonEnabled_True();

            Button_Space();

            player = 0;

            label6.ForeColor = System.Drawing.Color.Green;
            label7.ForeColor = System.Drawing.Color.White;

            label3.Enabled = true;

            Button_White();

        }
        private void Label4_MouseEnter(object sender, EventArgs e)
        {
            string soundPath = @"C:\Users\user\source\repos\C#\Tic-Tac-Toe\Tic-Tac-Toe\Resources\Text_sound.wav";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundPath);

            player.Play();

            label4.ForeColor = System.Drawing.Color.Crimson;
        }
        private void Label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = SystemColors.Control;
        }
        private void Правила_Click(object sender, EventArgs e)
        {
            Rules rule = new Rules();

            rule.ShowDialog();
        }
        private void Правила_MouseEnter(object sender, EventArgs e)
        {
            string soundPath = @"C:\Users\user\source\repos\C#\Tic-Tac-Toe\Tic-Tac-Toe\Resources\Text_sound.wav";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundPath);

            player.Play();

            Правила.ForeColor = System.Drawing.Color.Yellow;
        }
        private void Правила_MouseLeave(object sender, EventArgs e)
        {
            Правила.ForeColor = SystemColors.Control;
        }
        private void Label3_Click(object sender, EventArgs e)
        {
            this.Hide();

            backgroundMusicPlayer.Stop();

            Form1 form = new Form1();

            form.ShowDialog();

            this.Close();

            ButtonEnabled_False();

            Button_Space();

            label9.Text = "0";
            label8.Text = "0";

            Button_White();

        }
        private void Label10_Click(object sender, EventArgs e)
        {
            Sound sound = new Sound(this);

            sound.ShowDialog();
        }
        private void Label10_MouseEnter(object sender, EventArgs e)
        {
            string soundPath = @"C:\Users\user\source\repos\C#\Tic-Tac-Toe\Tic-Tac-Toe\Resources\Text_sound.wav";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundPath);

            player.Play();

            label10.ForeColor = System.Drawing.Color.Yellow;
        }
        private void Label10_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = SystemColors.Control;
        }
        private void ButtonEnabled_True()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }
        private void ButtonEnabled_False()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        private void Button_Space()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
        private void Button_White()
        {
            button1.BackColor = System.Drawing.Color.White;
            button2.BackColor = System.Drawing.Color.White;
            button3.BackColor = System.Drawing.Color.White;
            button4.BackColor = System.Drawing.Color.White;
            button5.BackColor = System.Drawing.Color.White;
            button6.BackColor = System.Drawing.Color.White;
            button7.BackColor = System.Drawing.Color.White;
            button8.BackColor = System.Drawing.Color.White;
            button9.BackColor = System.Drawing.Color.White;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Sound : Form
    {
        private Form1 form;
        public Sound(Form1 form)
        {
            InitializeComponent();

            this.form = form;

            this.form.OnChangeMusic += new Form1.ChangeMusicDelegate(Form_OnChangeMusic1);

            this.form.OnChangeMusic += new Form1.ChangeMusicDelegate(Form_OnChangeMusic2);
        }
        private void Form_OnChangeMusic1()
        {
            form.Public_Change_music1();
        }
        private void Form_OnChangeMusic2()
        {
            form.Public_Change_music2();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Form_OnChangeMusic1();
        }
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            string soundPath = @"C:\Users\user\source\repos\C#\Tic-Tac-Toe\Tic-Tac-Toe\Resources\Text_sound.wav";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundPath);

            player.Play();

            label3.ForeColor = System.Drawing.Color.DarkOrange;
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = SystemColors.Control;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Form_OnChangeMusic2();
        }
        private void label4_MouseEnter(object sender, EventArgs e)
        {
            string soundPath = @"C:\Users\user\source\repos\C#\Tic-Tac-Toe\Tic-Tac-Toe\Resources\Text_sound.wav";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundPath);

            player.Play();

            label4.ForeColor = System.Drawing.Color.DarkOrange;
        }
        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = SystemColors.Control;
        }
        private void label8_Click(object sender, EventArgs e)
        {
            form.GetMediaPlayer().Stop();
        }
        private void label8_MouseEnter(object sender, EventArgs e)
        {
            string soundPath = @"C:\Users\user\source\repos\C#\Tic-Tac-Toe\Tic-Tac-Toe\Resources\Text_sound.wav";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundPath);

            player.Play();

            label8.ForeColor = System.Drawing.Color.Crimson;
        }
        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = SystemColors.Control;
        }
        private void label6_Click(object sender, EventArgs e)
        {
            form.GetMediaPlayer().Play();
        }
        private void label6_MouseEnter(object sender, EventArgs e)
        {
            string soundPath = @"C:\Users\user\source\repos\C#\Tic-Tac-Toe\Tic-Tac-Toe\Resources\Text_sound.wav";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundPath);

            player.Play();

            label6.ForeColor = System.Drawing.Color.Green;
        }
        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = SystemColors.Control;
        }
        private void textBox1_TextChanged(object sender, KeyEventArgs e)
        {

            if (e.KeyCode != Keys.Back && e.KeyCode != Keys.Enter && (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) &&
                (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9))
            {
                e.SuppressKeyPress = true;
            }

            if (e.Shift && ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)))
            {
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                int number;

                if (int.TryParse(textBox1.Text, out number) && number >= 1 && number <= 100)
                {
                    Change_music_volume(number);
                }
                else
                {
                    MessageBox.Show("Введите число от 1 до 100.");
                }
                e.SuppressKeyPress = true;
            }
        }
        private void Change_music_volume(int volume)
        {
            form.GetMediaPlayer().Volume = volume / 100.0;
        }

        private void Sound_Load(object sender, EventArgs e)
        {

        }
    }
}

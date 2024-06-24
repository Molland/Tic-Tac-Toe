using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.Правила = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Счет = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1662, 826);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(833, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(821, 812);
            this.panel4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel18);
            this.panel6.Controls.Add(this.panel20);
            this.panel6.Controls.Add(this.panel21);
            this.panel6.Controls.Add(this.panel19);
            this.panel6.Controls.Add(this.panel17);
            this.panel6.Location = new System.Drawing.Point(6, 413);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(807, 385);
            this.panel6.TabIndex = 1;
            // 
            // panel18
            // 
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Controls.Add(this.label10);
            this.panel18.Location = new System.Drawing.Point(402, 162);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(388, 100);
            this.panel18.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Starseed Pro", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(101, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 84);
            this.label10.TabIndex = 1;
            this.label10.Text = "Звук";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            this.label10.MouseEnter += new System.EventHandler(this.Label10_MouseEnter);
            this.label10.MouseLeave += new System.EventHandler(this.Label10_MouseLeave);
            // 
            // panel20
            // 
            this.panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel20.Controls.Add(this.label5);
            this.panel20.Location = new System.Drawing.Point(402, 269);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(388, 100);
            this.panel20.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Starseed Pro", 42F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(80, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 84);
            this.label5.TabIndex = 0;
            this.label5.Text = "Выход";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            this.label5.MouseEnter += new System.EventHandler(this.Label5_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.Label5_MouseLeave);
            // 
            // panel21
            // 
            this.panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel21.Controls.Add(this.label4);
            this.panel21.Location = new System.Drawing.Point(12, 269);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(384, 100);
            this.panel21.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Starseed Pro", 42F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(82, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 84);
            this.label4.TabIndex = 0;
            this.label4.Text = "Сброс";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            this.label4.MouseEnter += new System.EventHandler(this.Label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.Label4_MouseLeave);
            // 
            // panel19
            // 
            this.panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel19.Controls.Add(this.Правила);
            this.panel19.Location = new System.Drawing.Point(12, 162);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(384, 100);
            this.panel19.TabIndex = 2;
            // 
            // Правила
            // 
            this.Правила.AutoSize = true;
            this.Правила.Font = new System.Drawing.Font("Starseed Pro", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Правила.ForeColor = System.Drawing.SystemColors.Control;
            this.Правила.Location = new System.Drawing.Point(55, 0);
            this.Правила.Name = "Правила";
            this.Правила.Size = new System.Drawing.Size(280, 84);
            this.Правила.TabIndex = 0;
            this.Правила.Text = "Правила";
            this.Правила.Click += new System.EventHandler(this.Правила_Click);
            this.Правила.MouseEnter += new System.EventHandler(this.Правила_MouseEnter);
            this.Правила.MouseLeave += new System.EventHandler(this.Правила_MouseLeave);
            // 
            // panel17
            // 
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Controls.Add(this.label3);
            this.panel17.Location = new System.Drawing.Point(12, 56);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(778, 100);
            this.panel17.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Starseed Pro", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(180, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 84);
            this.label3.TabIndex = 0;
            this.label3.Text = "Новая игра";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            this.label3.MouseEnter += new System.EventHandler(this.Label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.Label3_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.Счет);
            this.panel5.Location = new System.Drawing.Point(6, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(807, 385);
            this.panel5.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Starseed Pro", 42F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(593, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 84);
            this.label8.TabIndex = 4;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Starseed Pro", 42F);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(593, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 84);
            this.label9.TabIndex = 3;
            this.label9.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Starseed Pro", 42F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(27, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(455, 84);
            this.label7.TabIndex = 2;
            this.label7.Text = "Игрок 2 (o): ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Starseed Pro", 42F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(27, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(455, 84);
            this.label6.TabIndex = 1;
            this.label6.Text = "Игрок 1 (x): ";
            // 
            // Счет
            // 
            this.Счет.AutoSize = true;
            this.Счет.Font = new System.Drawing.Font("Starseed Pro", 42F);
            this.Счет.ForeColor = System.Drawing.SystemColors.Control;
            this.Счет.Location = new System.Drawing.Point(307, -1);
            this.Счет.Name = "Счет";
            this.Счет.Size = new System.Drawing.Size(175, 84);
            this.Счет.TabIndex = 0;
            this.Счет.Text = "Счет";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel16);
            this.panel3.Controls.Add(this.panel15);
            this.panel3.Controls.Add(this.panel14);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(821, 812);
            this.panel3.TabIndex = 1;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Starseed Pro", 42F);
            this.button9.Location = new System.Drawing.Point(560, 577);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(227, 214);
            this.button9.TabIndex = 99;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Starseed Pro", 42F);
            this.button8.Location = new System.Drawing.Point(294, 577);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(227, 214);
            this.button8.TabIndex = 98;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Starseed Pro", 42F);
            this.button7.Location = new System.Drawing.Point(29, 577);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(227, 214);
            this.button7.TabIndex = 97;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Starseed Pro", 42F);
            this.button6.Location = new System.Drawing.Point(560, 340);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(227, 214);
            this.button6.TabIndex = 96;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Starseed Pro", 42F);
            this.button4.Location = new System.Drawing.Point(29, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 214);
            this.button4.TabIndex = 95;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Starseed Pro", 42F);
            this.button5.Location = new System.Drawing.Point(294, 340);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(227, 214);
            this.button5.TabIndex = 94;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Starseed Pro", 42F);
            this.button3.Location = new System.Drawing.Point(560, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 214);
            this.button3.TabIndex = 93;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Starseed Pro", 42F);
            this.button2.Location = new System.Drawing.Point(294, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 214);
            this.button2.TabIndex = 92;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Starseed Pro", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(157, -7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 80);
            this.label2.TabIndex = 91;
            this.label2.Text = "| Поле Брани |";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Location = new System.Drawing.Point(19, 560);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(243, 10);
            this.panel10.TabIndex = 90;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Location = new System.Drawing.Point(553, 560);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(240, 10);
            this.panel11.TabIndex = 89;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(19, 316);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(243, 10);
            this.panel9.TabIndex = 88;
            // 
            // panel16
            // 
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Location = new System.Drawing.Point(276, 560);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(263, 10);
            this.panel16.TabIndex = 86;
            // 
            // panel15
            // 
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Location = new System.Drawing.Point(276, 316);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(263, 10);
            this.panel15.TabIndex = 85;
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Location = new System.Drawing.Point(553, 316);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(240, 10);
            this.panel14.TabIndex = 84;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.panel13);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Location = new System.Drawing.Point(262, 88);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(15, 710);
            this.panel8.TabIndex = 82;
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Location = new System.Drawing.Point(17, 225);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(256, 10);
            this.panel13.TabIndex = 84;
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Location = new System.Drawing.Point(13, 225);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(256, 10);
            this.panel12.TabIndex = 84;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(538, 86);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(15, 712);
            this.panel7.TabIndex = 81;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Starseed Pro", 42F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(29, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 214);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1662, 92);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Starseed Pro", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1636, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Крестики-нолики 2.0                        v0.0.1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Tic_Tac_Toe.Properties.Resources._123;
            this.pictureBox2.Location = new System.Drawing.Point(3, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1827, 79);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Крестики-нолики 2.0 (Ультра-супер-мега-окончательное издание)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label Правила;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Счет;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
    }
}


﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        //
        int m;
        int count = 0;
        int count1 = 0;
        string v;
        string d;
        string z;
        //
        string[] a = new string[5];
        string[] b = new string[5];
        string[] c = new string[5];
        public Form1()
        {
            InitializeComponent();

            //Объявление масивов
            //1 массив
            v = "дверь";
            a[0] = "д";
            a[1] = "в";
            a[2] = "е";
            a[3] = "р";
            a[4] = "ь";
            //2 массив
            d = "форма";
            b[0] = "ф";
            b[1] = "о";
            b[2] = "р";
            b[3] = "м";
            b[4] = "а";
            //3 массив
            z = "ведро";
            c[0] = "в";
            c[1] = "е";
            c[2] = "д";
            c[3] = "р";
            c[4] = "о";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m == 1)
            {
                //1 слово
                if(textBox1.Text == v)
                { MessageBox.Show("Вы победили!"); }
                if (textBox1.Text == a[0])
                { label1.Text = a[0]; count++; }
                if (textBox1.Text == a[1])
                { label2.Text = a[1]; count++; }
                if (textBox1.Text == a[2])
                { label3.Text = a[2]; count++; }
                if (textBox1.Text == a[3])
                { label4.Text = a[3]; count++; }
                if (textBox1.Text == a[4])
                { label5.Text = a[4]; count++; }
                if (count >= 5)
                {
                    MessageBox.Show("Вы победили!");
                }
            }
            //2 слово
            if (m == 2)
            {
                if(textBox1.Text == d)
                { MessageBox.Show("Вы победили!"); }
                if (textBox1.Text == b[0])
                { label1.Text = b[0]; count++; }
                if (textBox1.Text == b[1])
                { label2.Text = b[1]; count++; }
                if (textBox1.Text == b[2])
                { label3.Text = b[2]; count++; }
                if (textBox1.Text == b[3])
                { label4.Text = b[3]; count++; }
                if (textBox1.Text == b[4])
                { label5.Text = b[4]; count++; }
                if(count >= 5)
                {
                    MessageBox.Show("Вы победили!");
                }
            }
            //3 слово
            if (m == 3)
            {
                if(textBox1.Text == z)
                { MessageBox.Show("Вы победили!"); }
                if (textBox1.Text == c[0])
                { label1.Text = c[0]; count++; }
                if (textBox1.Text == c[1])
                { label2.Text = c[1]; count++; }
                if (textBox1.Text == c[2])
                { label3.Text = c[2]; count++; }
                if (textBox1.Text == c[3])
                { label4.Text = c[3]; count++; }
                if (textBox1.Text == c[4])
                { label5.Text = c[4]; count++; }
                if(count>= 5)
                {
                    MessageBox.Show("Вы победили!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            m = r.Next(1, 3);
            if (m==1)
            {
                MessageBox.Show("Это есть в каждом доме, здании и в каждом авто, этим мы пользуемся по несколько раз в день.");
            }
            if(m==2)
            {
                MessageBox.Show("Это имеет несколько значений - в одном случаи мы используем это во время готовки на кухне, во втором случаи в качестве одежды и третьем в программировании.");
            }
            if(m==3)
            {
                MessageBox.Show("Предмет домашней утвари, широко используемый в садоводстве и в хозяйстве.");
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(m==1)
            {
                if (count1 == 0)
                {
                    MessageBox.Show("Не скажу!");
                    count1++;
                }
                if(count1 == 1)
                {
                    MessageBox.Show("Нет!");
                    count1++;
                }
                if(count1 == 2)
                {
                    MessageBox.Show("Ладно... это ДВЕРЬ");
                    count1 = 0;
                }
            }
            if(m == 2)
            {
                if (count1 == 0)
                {
                    MessageBox.Show("Не скажу!");
                    count1++;
                }
                if (count1 == 1)
                {
                    MessageBox.Show("Нет!");
                    count1++;
                }
                if (count1 == 2)
                {
                    MessageBox.Show("Ладно... это ФОРМА");
                    count1 = 0;
                }
            }
            if(m == 3)
            {
                if (count1 == 0)
                {
                    MessageBox.Show("Не скажу!");
                    count1++;
                }
                if (count1 == 1)
                {
                    MessageBox.Show("Нет!");
                    count1++;
                }
                if (count1 == 2)
                {
                    MessageBox.Show("Ладно... это ВЕДРО");
                    count1 = 0;
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задачи_от_дяди_Димы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int GetHammingDistance(string s, string t)
        {
            int distance = 0;
            if (s.Length != t.Length)
            {
                return -1;
            }

            for (int i = 0; i < s.Length; i++) 
            {
                if (s[i] != t[i]) distance += 1;
            }

            return distance;
        }

        static string ROT13(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            char[] buffer = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                
                char c = input[i];
                
                if (c >= 97 && c <= 122)
                {
                    int j = c + 13;
                    if (j > 122) j -= 26;
                    buffer[i] = (char)j;
                }
                else if (c >= 65 && c <= 90)
                {
                    int j = c + 13;
                    if (j > 90) j -= 26;
                    buffer[i] = (char)j;
                }
                else if (c >= 1040 && c <=1071) 
                {
                    int j = c + 13;
                    if (j > 1071) j -= 32;
                    buffer[i] = (char)j;
                }
                else if (c >= 1072 && c <= 1103)
                {
                    int j = c + 13;
                    if (j > 1103) j -= 32;
                    buffer[i] = (char)j;
                }
                else
                {
                    buffer[i] = (char)c;
                }
            }
            return new string(buffer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = ROT13(richTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int d = GetHammingDistance(richTextBox1.Text, richTextBox2.Text);
            if (d == -1) label3.Text = "Ошиька";
            else label3.Text = $"Расстояние: {d}";
        }
    }
}

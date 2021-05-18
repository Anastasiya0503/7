using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translate
{
    public partial class Form1 : Form
    {
        Dictionary<char, string> dic = new Dictionary<char, string>();
        public Form1()
        {
            InitializeComponent();
            
            dic.Add('а', "a");
            dic.Add('б', "b");
            dic.Add('в', "v");
            dic.Add('г', "g");
            dic.Add('д', "d");
            dic.Add('е', "e");
            dic.Add('ё', "yo");
            dic.Add('ж', "jh");
            dic.Add('з', "z");
            dic.Add('и', "i");
            dic.Add('к', "k");
            dic.Add('л', "l");
            dic.Add('м', "m");
            dic.Add('н', "n");
            dic.Add('о', "o");
            dic.Add('п', "p");
            dic.Add('р', "r");
            dic.Add('с', "s");
            dic.Add('т', "t");
            dic.Add('у', "u");
            dic.Add('ф', "f");
            dic.Add('х', "h");
            dic.Add('ц', "c");
            dic.Add('ч', "ch");
            dic.Add('ш', "sh");
            dic.Add('щ', "shh");
            dic.Add('ь', "");
            dic.Add('ы', "y");
            dic.Add('ъ', "");
            dic.Add('э', "e");
            dic.Add('ю', "yu");
            dic.Add('я', "ya");

            dic.Add('А', "А");
            dic.Add('Б', "B");
            dic.Add('В', "V");
            dic.Add('Г', "G");
            dic.Add('Д', "D");
            dic.Add('Е', "E");
            dic.Add('Ё', "Yo");
            dic.Add('Ж', "Jh");
            dic.Add('З', "Z");
            dic.Add('И', "I");
            dic.Add('К', "K");
            dic.Add('Л', "L");
            dic.Add('М', "M");
            dic.Add('Н', "N");
            dic.Add('О', "O");
            dic.Add('П', "P");
            dic.Add('Р', "R");
            dic.Add('С', "S");
            dic.Add('Т', "T");
            dic.Add('У', "U");
            dic.Add('Ф', "F");
            dic.Add('Х', "H");
            dic.Add('Ц', "C");
            dic.Add('Ч', "Ch");
            dic.Add('Ш', "Sh");
            dic.Add('Щ', "Shh");
            dic.Add('Ы', "Y");
            dic.Add('Э', "E");
            dic.Add('Ю', "Yu");
            dic.Add('Я', "Ya");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            foreach (char ch in textBox1.Text)
            {
                try
                {
                    textBox2.Text += dic[ch];
                }
                catch (KeyNotFoundException ex)
                {
                    textBox2.Text += ch;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace lab_8
{
    public partial class Form1 : Form
    {
        string songPath, textPath;
        string text;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            songPath = openFileDialog1.FileName;
            label1.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.SoundLocation = songPath;                        
            player.Play();
            label2.Text = text;
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.ShowDialog();
            textPath = openFileDialog1.FileName;
            label3.Text = textPath;
            using (StreamReader stream = new StreamReader(textPath))
            {
               
                
                    text = stream.ReadToEnd();
                             
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.Stop();    
        }
    }
}

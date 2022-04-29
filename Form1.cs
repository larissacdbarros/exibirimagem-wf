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

namespace Aula30_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog pastaSelecionada = new FolderBrowserDialog();
            //alterando a propriedade para exibir o botão nova pasta
            pastaSelecionada.ShowNewFolderButton = true;

            DialogResult result = pastaSelecionada.ShowDialog();
            if(result == DialogResult.OK)
            {
                textBox1.Text = pastaSelecionada.SelectedPath;
                Environment.SpecialFolder root = pastaSelecionada.RootFolder;

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(textBox1.Text + "\\" + listBox1.SelectedItem);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string nomeDiretorio = textBox1.Text;

            DirectoryInfo diretorio = new DirectoryInfo(textBox1.Text);
            FileInfo[] Arquivos = diretorio.GetFiles("*.*");

            foreach (FileInfo file in Arquivos)
            {
                listBox1.Items.Add(file.ToString());

            }
        }
    }
}

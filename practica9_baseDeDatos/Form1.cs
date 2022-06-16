using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica9_baseDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'basededatos1DataSet.ESCUELAS' Puede moverla o quitarla según sea necesario.
            this.eSCUELASTableAdapter.Fill(this.basededatos1DataSet.ESCUELAS);

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.eSCUELASTableAdapter.INSERTA(int.Parse(textBox1.Text), textBox2.Text,textBox3.Text,textBox4.Text);
            this.eSCUELASTableAdapter.Fill(this.basededatos1DataSet.ESCUELAS);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Entornos
{
    public partial class Form1 : Form
    {
        private List<string> socios = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tListaSocios.Text = "";
            string socioAñadir="";
            socioAñadir = tNombre.ToString();
            socios.Add(socioAñadir);
            string aux = "";
            for(int i = 0; i < socios.Count; i++)
            {
                aux += socios[i] + " ,";
            }
            tListaSocios.Text = aux;
        }
    }
}

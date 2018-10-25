using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Lab_12
{
    public delegate void AgregarComidaDelegate(string NombrE, int protes, int gras, int carbsh);
    public delegate void EliminarComidaDelegate(Comida comidass);

    public partial class Form1 : Form
    {
        public event AgregarComidaDelegate OnAgregarComida;
        public event EliminarComidaDelegate OnEliminarComida;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (OnAgregarComida != null)
            {
                OnAgregarComida.Invoke(NombreTextbox.Text, int.Parse(ProteinasTextbox.Text), int.Parse(GrasasTextbox.Text), int.Parse(CarbsTextbox.Text));
            }
        }

        public void AgregarComida(Comida comida)
        {
            ComidasListbox.Items.Add(comida);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            //ComidasListbox.Items.RemoveAt(ComidasListbox.SelectedIndex); 
            if (OnEliminarComida != null)
            {
                OnEliminarComida.Invoke((Comida)ComidasListbox.SelectedItem);
            }
        }
        public void EliminarComida(Comida comida)
        {
            ComidasListbox.Items.Remove(comida);
        }
    }
}

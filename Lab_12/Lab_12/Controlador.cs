using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Lab_12
{
    class Controlador
    {
        public Form1 form1;
        private ListaComida Comidas;

        public Controlador()
        {
            Comidas = new ListaComida();
        }

        public void OnAgregarComida(string NombrE, int protes, int gras, int carbsh)
        {
            Comida comida = new Comida(NombrE,protes,gras,carbsh);
            Comidas.Agregar(comida);
            form1.AgregarComida(comida);
        }
        public void OnEliminarComida(Comida comida)
        {
            Comidas.Eliminar(comida);
            form1.EliminarComida(comida);
        }
    }
}

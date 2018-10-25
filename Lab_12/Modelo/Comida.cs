using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Comida
    {
        string Nombre;
        int Carbohidratos;
        int Proteinas;
        int Grasas;

        public Comida(string Nombre, int Carbs, int Prot, int Gra)
        {
            this.Nombre = Nombre;
            Carbohidratos = Carbs;
            Proteinas = Prot;
            Grasas = Gra;
        }

        public int Calorias()
        {
            int x;
            x = 4 * Carbohidratos + 4 * Proteinas + 9 * Grasas;
            return x;
        }
        public override string ToString()
        {
            return $"{Nombre} (Carbohidratos:{Carbohidratos}, Proteinas:{Proteinas}, Grasas{Grasas}, Calorias: {Calorias()})";
        }
    }
}

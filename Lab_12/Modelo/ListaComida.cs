using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace Modelo
{
    [Serializable]
    public class ListaComida
    {
        List<Comida> comidas;

        public ListaComida()
        {
            comidas = new List<Comida>();
        }

        public void Agregar(Comida comida)
        {
            comidas.Add(comida);
        }
        public void Eliminar(Comida comida)
        {
            comidas.Remove(comida);
        }

        public void Serializarcomida()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Miarchivo.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            formatter.Serialize(stream, this.comidas);
        }
    }
}

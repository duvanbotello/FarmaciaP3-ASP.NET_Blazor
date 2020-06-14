using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaciaP3.Data
{
    public class Respuestas
    {
        public int Exito { get; set; }
        public string Mensaje { get; set; }
        public List<Cliente> Data { get; set; }
    }
}

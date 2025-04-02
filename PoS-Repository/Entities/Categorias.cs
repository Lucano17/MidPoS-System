using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoS_Repository.Entities
{
    public class Categorias
    {
        public int Id_Categorias { get; set; }
        public string Nombre { get; set; }
        public Medidas RefMedida { get; set; }
        public int Activo { get; set; }
    }
}

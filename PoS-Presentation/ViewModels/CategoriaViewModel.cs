using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoS_Presentation.ViewModels
{
    public class CategoriaViewModel
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public int IdMedida { get; set; }
        public string Medida { get; set; }
        public int Activo { get; set; }
        public string Habilitado { get; set; }
    }
}

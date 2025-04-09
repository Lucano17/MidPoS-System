using PoS_Presentation.Utilities.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoS_Presentation.Utilities
{
    public static class CustomComboBox
    {
        public static void InsertarItems(this ComboBox combo, OpcionCmbBox[] items)
        {
            combo.Items.AddRange(items);
            combo.DisplayMember = "Texto";
            combo.ValueMember = "Valor";
            combo.SelectedIndex = 0;
        }

        public static void EstablecerValor(this ComboBox combo, int valor)
        {
            foreach (OpcionCmbBox opcion in combo.Items)
            {

                if (opcion.Valor == valor)
                {
                    combo.SelectedItem = opcion;
                    break;
                }
            }
        }
    }
}

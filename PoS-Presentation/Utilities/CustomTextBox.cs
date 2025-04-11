

namespace PoS_Presentation.Utilities
{
    public static class CustomTextBox
    {
        public static void ValidarNumero(this TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    // TODO: Controlar que solamente se pueda poner un solo '.'
                    // y también que la ',' se tome como un punto.
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            };
        }
    }
}

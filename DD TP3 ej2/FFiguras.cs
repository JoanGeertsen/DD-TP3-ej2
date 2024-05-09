using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DD_TP3_ej2
{
    public partial class FFiguras : Form
    {
        #region Atributos
        private Circulo[] aCirculos;
        private Rectangulo[] aRectangulos;
        private Cuadrado[] aCuadrados;
        private Triangulo[] aTriangulos;
        private int cantCirculos;
        private int cantRectangulos;
        private int cantCuadrados;
        private int cantTriangulos;
        private int max = 50;
        #endregion
        public FFiguras()
        {
            InitializeComponent();
            aCirculos = new Circulo[max]; cantCirculos = 0;
            aRectangulos = new Rectangulo[max]; cantRectangulos = 0;
            aCuadrados = new Cuadrado[max]; cantCuadrados = 0;
            aTriangulos = new Triangulo[max]; cantTriangulos = 0;
            asignarKeyPress(); asignarValidaciones(); //Tal vez mover esto a un Load o algo similar
        }

        #region Funcionalidades
        private void actualizarElementosVisibles(GroupBox gb, Label l)
        {
            gbCirculo.Visible = true; gbCuadrado.Visible = false; gbTriangulo.Visible = false; gbRectangulo.Visible = false;
            gb.Visible = true;
            lCantidadCirculos.Visible = false; lCantidadCuadrados.Visible = false; lCantidadTriangulos.Visible = false; lCantidadRectangulos.Visible = false;
            l.Visible = true;
            errorProvider.Clear();
        }

        private void rbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            actualizarElementosVisibles(gbCirculo, lCantidadCirculos);
        }

        private void rbCuadrado_CheckedChanged(object sender, EventArgs e)
        {
            actualizarElementosVisibles(gbCuadrado, lCantidadCuadrados);
        }
        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            actualizarElementosVisibles(gbTriangulo, lCantidadTriangulos);
        }
        private void rbRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            actualizarElementosVisibles(gbRectangulo, lCantidadRectangulos);
        }
        #endregion

        #region validación de capos

        private void asignarValidaciones()
        {
            tRadioCirculo.Leave += TextBox_Leave;
            tLado1.Leave += TextBox_Leave;
            tLado2.Leave += TextBox_Leave;
            tLado1Triangulo.Leave += TextBox_Leave;
            tLado2Triangulo.Leave += TextBox_Leave;
            tLado3Triangulo.Leave += TextBox_Leave;
            tLadoCuadrado.Leave += TextBox_Leave;
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length<=0 || int.Parse(textBox.Text) <= 0)           
                errorProvider.SetError(textBox, "Valor invalido");        
            else        
                errorProvider.SetError(textBox, "");         
        }

        #endregion

        #region KeyPress
        private void asignarKeyPress()
        {
            tRadioCirculo.KeyPress += TextBox_KeyPress;
            tLado1.KeyPress += TextBox_KeyPress;
            tLado2.KeyPress += TextBox_KeyPress;
            tLado1Triangulo.KeyPress += TextBox_KeyPress;
            tLado2Triangulo.KeyPress += TextBox_KeyPress;
            tLado3Triangulo.KeyPress += TextBox_KeyPress;
            tLadoCuadrado.KeyPress += TextBox_KeyPress;
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
        #endregion
    }
}
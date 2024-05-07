using System.Runtime.CompilerServices;

namespace DD_TP3_ej2
{
    public partial class FFiguras : Form
    {
        public FFiguras()
        {
            InitializeComponent();
        }
        private void actualizarElementosVisibles(GroupBox gb, Label l)
        {
            gbCirculo.Visible = true; gbCuadrado.Visible = false; gbTriangulo.Visible = false; gbRectangulo.Visible = false;
            gb.Visible = true;
            lCantidadCirculos.Visible = false; lCantidadCuadrados.Visible = false; lCantidadTriangulos.Visible = false; lCantidadRectangulos.Visible = false;
            l.Visible = true;
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

    }
}
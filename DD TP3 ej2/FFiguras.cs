using System.Runtime.CompilerServices;

namespace DD_TP3_ej2
{
    public partial class FFiguras : Form
    {
        public FFiguras()
        {
            InitializeComponent();
        }

        private void rbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            gbCirculo.Visible = true; gbCuadrado.Visible = false; gbTriangulo.Visible = false; gbRectangulo.Visible = false;
        }

        private void rbCuadrado_CheckedChanged(object sender, EventArgs e)
        {
            gbCirculo.Visible = false; gbCuadrado.Visible = true; gbTriangulo.Visible = false; gbRectangulo.Visible = false;
        }

        private void rbRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            //gbCirculo.Visible = false; gbCuadrado.true = false; gbTriangulo.Visible = false; gbRectangulo.Visible = false;
        }

        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            // MostrarGroupBox(sender, e);
        }
    }
}
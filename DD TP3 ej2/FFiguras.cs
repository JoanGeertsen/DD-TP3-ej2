using System.Runtime.CompilerServices;

namespace DD_TP3_ej2
{
    public partial class FFiguras : Form
    {
        public FFiguras()
        {
            InitializeComponent();
        }
        private void mostrarGroupBox(GroupBox gb)
        {
            gbCirculo.Visible = true; gbCuadrado.Visible = false; gbTriangulo.Visible = false; gbRectangulo.Visible = false;
            gb.Visible = true;
        }

        private void rbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            mostrarGroupBox(gbCirculo);
        }

        private void rbCuadrado_CheckedChanged(object sender, EventArgs e)
        {
            mostrarGroupBox(gbCuadrado);                       
        }
        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            mostrarGroupBox(gbTriangulo);           
        }
        private void rbRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            mostrarGroupBox(gbRectangulo);            
        }

    }
}
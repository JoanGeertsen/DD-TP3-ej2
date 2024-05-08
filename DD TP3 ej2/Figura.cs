using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_TP3_ej2
{
    internal class Figura
    {
        #region Atributos
        private int cantVertices; //Dice real pero no tiene sentido
        #endregion

        #region constructores
        public Figura()
        {
            cantVertices = 0;
        }
        public Figura(int cantVertices)
        {
            this.cantVertices = (cantVertices > 0) ? cantVertices : 0;
        }
        #endregion

        #region Property
        public int CantVertices
        {
            get { return cantVertices; }
            set { cantVertices = (value > 0) ? value : 0; }
        }
        #endregion

        #region Consutlas
        public void perimetro()
        {
            //No tiene sentido...
        }
        public void area()
        {
            //No tiene sentido...
        }

        public string mostrar()
        {
            return $"Cantidad de Vérties: {cantVertices}";
        }
        #endregion
    }
}

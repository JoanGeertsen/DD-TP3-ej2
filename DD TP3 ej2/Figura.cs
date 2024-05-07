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
        public Figura(int cantVertices)
        {
            this.cantVertices = (cantVertices > 0) ? cantVertices : 0;
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
        #endregion
    }
}

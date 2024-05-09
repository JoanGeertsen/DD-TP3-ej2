using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_TP3_ej2
{
    internal abstract class Figura
    {
        #region Atributos
        private int cantVertices; //Dice real pero no tiene sentido
        #endregion       

        #region Property
        public int CantVertices
        {
            get { return cantVertices; }
            set { cantVertices = (value > 0) ? value : 0; }
        }
        #endregion

        #region Consutlas
        public abstract double perimetro();
        public abstract double area();
        public abstract string mostrar();    
        #endregion
    }
}

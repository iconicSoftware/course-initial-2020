using System;

namespace Desktop
{
    public class Articulo
    {

    #region propiedades
       private int _id;
       private string _nombre;
       private double _costo;
    #endregion

    #region constructores
        public Articulo(){}
    #endregion
       
    #region getter and setter
        public void setId(int id) {
            this._id = id;
        }

        public int getId(){
            return this._id;
        }

        public void setNombre(string nombre) {
            this._nombre = nombre;
        }

        public string getNombre(){
            return this._nombre;
        }

        public void setCosto(double costo) {
            this._costo = costo;
        }

        public double getCosto(){
            return this._costo;
        }
    #endregion

    #region methods
        public string showArticulo(){
            return _id + " - " + _nombre + " - $" + _costo;
        }
    #endregion

    }
    
}

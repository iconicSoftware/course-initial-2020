using System;

namespace Desktop
{
    
    public interface IFiguraGeometrica
    {
        double Area();
        double Perimetro();        
    }

    public class Cuadrado : IFiguraGeometrica {

        public double Area() {
            return 10.0;
        }

        public double Perimetro() {
            return 5.0;
        }

    }

    public class Triangulo : IFiguraGeometrica {

        public double Area() {
            return 5.0;
        }

        public double Perimetro() {
            return 7.0;
        }

    }

        
}

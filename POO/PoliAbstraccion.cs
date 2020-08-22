using System;

namespace Desktop
{
    public abstract class PerroAbs
    {
        public virtual string ladrar() {
            return "Perro ladrando";
        }

        public virtual double liquidacionSueldo(double pagoDia, int dias) {
            return pagoDia * dias;
        }
        public abstract string Dormir();
    }

    public class Mantenimiento: PerroAbs {
        // public override string ladrar() {
        //     return "Chihuahua Ladrando";
        // }

        public override string Dormir() {
            return "Chihuahua Ladrando";
        }
    }
    public class Secretaria: PerroAbs {
        public override string ladrar() {
            return "Bulldog Ladrando";
        }

        public override string Dormir() {
            return "Bulldog Ladrando";
        }
    }

    public class Gerente: PerroAbs {
        public override string ladrar() {
            return "Bulldog Ladrando";
        }

        public override string Dormir() {
            return "Bulldog Ladrando";
        }

        public virtual double liquidacionSueldo(double pagoDia, int dias, double incentivo) {
            return (pagoDia * dias) + incentivo;
        }
    }
}

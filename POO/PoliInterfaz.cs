using System;

namespace Desktop
{
    public interface IPerro
    {
        string ladrar();
        string dormir();
    }

    public class ChihuahuaI: IPerro {
        public string ladrar(){
            return "Chihuaha ladrando";
        }

        public string dormir(){
            return "Chihuaha durmiendo";
        }
    }
    public class BulldogI: IPerro {
        public string ladrar(){
            return "Bulldog ladrando";
        }

        public string dormir(){
            return "Bulldog durmiendo";
        }
    }
}

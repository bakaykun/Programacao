using static System.Console;
namespace ExemploConstrutores.models{
    public class Data{
        /*public int Dia { 
            
            get {
                return this.Dia;
            }
            
            set { 
                if(value < 1 || value >= 31){
                    this.Dia = value;
                }
            } 
        }*/

        private int Dia;
        
        public Data(int dia){
            this.Dia = dia;
        }
        public int GetDia(){
            return Dia;
        }

        public int SetDia(int dia){
            return this.Dia = dia;
        }


        public void MostrarData(){
            if (this.Dia >= 1 && this.Dia <= 31){
                WriteLine($"{this.Dia}\n");
            } else {
                WriteLine("Algo deu errado, tente novamente \n");
            }
        }

    }
}
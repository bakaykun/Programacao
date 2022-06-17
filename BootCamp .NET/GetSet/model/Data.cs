using static System.Console;
namespace GetSet.model{
    public class Data{
        public bool certo = false;
        public int Dia { 
            
            get {
                return this.Dia;
            }
            
            set { 
                if(value < 1 && value >= 31){
                    this.Dia = value;
                    certo = true;
                }
            } 
        }

        public int Mes { 
            
            get {
                return this.Mes;
            } 
            
            set{
                if( value < 1 && value <=12){
                    this.Mes = value;
                    certo = true;
                }
            } 
        }

        public int Ano { 
            get{
                return this.Ano;
            } 
            
            set {
                if(value > 1){
                    this.Ano = value;
                    certo = true;
                }
            } 
        }

        public void MostrarData(){
            if (certo == true){
                WriteLine($"{this.Dia}/{this.Mes}/{this.Ano}\n");
            } else {
                WriteLine("\nAlgo deu errado, tente novamente");
            }
        }
    }
}
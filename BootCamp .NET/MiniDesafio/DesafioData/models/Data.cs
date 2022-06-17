using System;
namespace DesafioData.models{
    public class Data{
        private string DataCompleta;

        public Data(string dataCompleta){
            this.DataCompleta = dataCompleta;
        }
        public string GetData(){
            return this.DataCompleta;
        }

        public void SetData(string dataCompleta){
            if(dataCompleta != null){
                this.DataCompleta = dataCompleta;
            }
        }

        public void SepararData(string dataCompleta){
            int hoje, mes, ano;
            int tamanho = this.DataCompleta.Length;
            int[] dia = new int[tamanho];
            char[] dataParcial = new char[tamanho];

            for ( int i = 0; i < tamanho; i++){
                
                dataParcial[i] = this.DataCompleta[i];

                if(dataParcial[i].Equals('/')){    
                    dataParcial[i] = ' ';
                }

                if(!dataParcial[i].Equals(' ')){
                    dia[i] = int.Parse(dataParcial[i].ToString());
                }

            }

            System.Console.WriteLine(" ");
            System.Console.WriteLine("Data sem separador: ");

            for (int i = 0; i < tamanho; i++){
                System.Console.Write(dataParcial[i]);
            }

            System.Console.WriteLine(" ");
            System.Console.WriteLine(" ");
            System.Console.WriteLine($"O dia foi {dia[0]}{dia[1]}");
            System.Console.WriteLine($"o mes foi {dia[3]}{dia[4]}");
            System.Console.WriteLine($"O ano foi {dia[6]}{dia[7]}{dia[8]}{dia[9]}");
            System.Console.WriteLine(" ");
        }

        public void ApresentarData(){
            System.Console.WriteLine($"A data digitada foi: {this.DataCompleta}");
        }
    }
}
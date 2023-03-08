using static System.Console;


namespace ExCinco {

    class Prgram {

        static void Main() {
            int count= 0, left= 0, rigth= 0, up= 0, down = 0;
            string[] numbers = ReadLine().Split(' ');
            int l = int.Parse(numbers[0]);
            int c = int.Parse(numbers[1]);
    
            int[,] matriz = new int[l,c];

            for (int i = 0; i < l; i++){

                string[] matNumbers = ReadLine().Split(' ');

                for (int j = 0; j < c; j++){
                    matriz[i,j] = int.Parse(matNumbers[j]);
                }
            }
            WriteLine("\n");

            for(int i = 0; i < l; i++) {
                for(int j = 0; j < c; j++){
                    Write(" " + matriz[i,j]);
                }
                Write("\n");
            }

            WriteLine(" ");

            int numForSearch = int.Parse(ReadLine());

            foreach (int item in matriz){
                if (numForSearch == item){
                    count++;
                }
            }
            for(int i = 0; i < l; i++) {
                for(int j = 0; j < c; j++){

                    if (numForSearch == matriz[i,j]){    
                        Write($"O numero está na posiçã {i},{j}\n e {count}");
                   }
                }
            }




        }
    }
}
                                         
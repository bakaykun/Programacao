using System;
using System.Collections.Generic;
using static System.Console;

namespace NonAula {

    class Program {

        static void Main() {

            List<string> list = new List<string>();

            Write("Input a name numbers: ");
            int n = int.Parse(ReadLine());

            Write("\n The List name is: ");
            for (int i = 0; i < n; i++){
                list.Add(ReadLine());
            }

            Write("\n");

            foreach(string nome in list){

                WriteLine(nome);
            }


        }

    }
}

using System;
using static System.Console;
using AulaQuatorze.entities;
using AulaQuatorze.entities.exception;
using static System.Globalization.CultureInfo;

namespace NonAula {

    class Program {

        static void Main() {

            try{
                Write("Número do Quarto: ");
                int nQ = int.Parse(ReadLine());

                Write("Data de chegada: (dd/MM/yyyy)");
                DateTime chegada = DateTime.ParseExact(ReadLine(), "dd/MM/yyyy", InvariantCulture);

                Write("Data de saida: (dd/MM/yyyy)");
                DateTime saida = DateTime.ParseExact(ReadLine(), "dd/MM/yyyy", InvariantCulture);

                Reserva rs = new Reserva(nQ, chegada, saida);
                Write(rs);
            }
            catch (ExcessaoDominio e)
            {
                WriteLine(", apenas F " + e.Message);
            }
        }

    }
}

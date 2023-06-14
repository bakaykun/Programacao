using System;
using AulaQuatorze.entities.exception;

namespace AulaQuatorze.entities
{
    public class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime Chegada { get; set; }
        public DateTime Saida { get; set; }

        public Reserva() 
        {

        }

        public Reserva(int numeroQuarto, DateTime chegada, DateTime saida)
        {
            if (saida <= chegada)
            {
                throw new ExcessaoDominio ("A data de saida precisa ser depois da data de entrada");
            }
            NumeroQuarto = numeroQuarto;
            Chegada = chegada;
            Saida = saida;
        }

        public int Duracao()
        {
            TimeSpan duracao = Saida.Subtract(Chegada);
            return (int)duracao.TotalDays;
        }

        public void AtualizarData(DateTime chegada, DateTime saida)
        {
            DateTime now = DateTime.Now;

            if ( chegada < now || saida < now)
            {
                throw new ExcessaoDominio("As datas só podem ser atualizadas para o futuro");
            }
            if (saida <= chegada)
            {
                throw new ExcessaoDominio ("A data de saida precisa ser depois da data de entrada");
            }
            
            Chegada = chegada;
            Saida = saida;
        }

        public override string ToString()
        {
            return "Numero do quarto: " + NumeroQuarto +
                ", data de chegada: " + Chegada + ", Data de saida " + 
                Saida + ", " + Duracao() + " dias";
        }


    }
}
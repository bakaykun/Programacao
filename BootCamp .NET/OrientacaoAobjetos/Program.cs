using System;
using OrientacaoAobjetos.ArquivoBase;

namespace OrientacaoAobjetos{
    class Program {
        static void Main(string[] args){
            Pessoa usuario = new Pessoa("kelvin patrick", "90/18/1699", 
            111111111111, "Notificação Preferida", "Sertanejo", 3.36);

            usuario.ExibeInformacao();
            
        }
    }
}

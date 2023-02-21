using System;

namespace SetimaAula {
    public class ContaBancaria {
        private string _nome;
        private int _numContaBancaria;
        private double _saldo;

        public ContaBancaria (string nome, int contaBancaria) {
            this._nome = nome;
            this._numContaBancaria = contaBancaria;
        }

        public string Nome {
            get {
                return _nome;
            }
            set {
                if (value != null && value.Length > 3)
                    _nome = value;
                else 
                    System.Console.WriteLine("[Nome curto ou nulo, tente novamente]");
            }
        }

        public int NumContaBancaria {
            get {
                return _numContaBancaria;
            }
            set {
                if(value > 100 && value < 10000){
                    _numContaBancaria = value;
                } else {
                    System.Console.WriteLine("[Conta não encontrada, verifique os dados /n E tente novamente !]");
                }
            }
        }

        public double Saldo{
            get {
                return _saldo;
            }
            set{
                if (value > 0){
                    _saldo = value;
                } else {
                    _saldo = 0;
                }
            }
        }

        public void Deposito(double deposito){
            _saldo+=deposito;
        }

        public void Saque(double saque){
            _saldo-=saque;
            _saldo-=5;

        }

        public override string ToString() {
            return $"\n[Conta: {_numContaBancaria}]\n" + 
                $"Titular: {_nome} \n" + 
                $"Saldo: R$ {_saldo.ToString("F2", System.Globalization.CultureInfo.InstalledUICulture)} \n";
        }
    }
}
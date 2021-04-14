using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;

                ;
                return;

            }
        }

        public bool Sacar(double Valor)
        {
            if (this._saldo < Valor)
            {
                return false;
            }
            else
            {
                this._saldo -= Valor;
                return true;
            }
        }

        public void Depositar(double Valor)
        {
            this._saldo += Valor;
        }


    }

}
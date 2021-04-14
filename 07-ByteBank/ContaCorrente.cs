using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }


        private int _agencia;
        public int Agencia 
        { 
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
                return;

            }
        }

        private int _numero;
        public int Numero 
        {
            get
            {
                return _numero;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _numero = value;
                return;

            }
        }
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
                return;

            }
        }

        public ContaCorrente (int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
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

        public bool Transferir (double Valor, ContaCorrente ContaDestino)
        {
            if (this.Saldo < Valor)
            {
                return false;
            }
            else
            {
                this.Saldo -= Valor;
                ContaDestino.Depositar(Valor);
                return true;
            }



        }


    }

}
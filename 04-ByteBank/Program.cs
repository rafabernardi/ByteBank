﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";
            Console.WriteLine(contaDoBruno.saldo);
            bool resultadoSacar = contaDoBruno.Sacar(50);
            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSacar);

            contaDoBruno.Depositar(150);
            Console.WriteLine(contaDoBruno.saldo);
            Console.ReadLine();
        }
    }
}

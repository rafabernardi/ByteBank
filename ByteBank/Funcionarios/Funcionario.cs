﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionario { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public virtual void AumentarSalario()
        {
           // Salario = Salario + (Salario * 0.1);
           // Salario = Salario * 1.1;
            Salario *= 1.1;
        }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando Funcionário");
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionario++;
        }
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}

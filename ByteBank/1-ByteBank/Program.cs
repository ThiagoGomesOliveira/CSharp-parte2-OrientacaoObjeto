﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente minhaConta = new ContaCorrente();
            minhaConta.saldo = 500;
            Console.WriteLine(minhaConta.saldo);

            minhaConta.saldo += 200;

            Console.WriteLine(minhaConta.saldo);
            Console.ReadLine();

        }
    }
}

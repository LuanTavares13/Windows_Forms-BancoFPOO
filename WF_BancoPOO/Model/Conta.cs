using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_BancoPOO.Model
{
    public class Conta
    {
        public double saldo { get; set; }
        public double limite { get; set; }
        public int numero { get; set; }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public void Sacar(double valor)
        {
            this.saldo -= valor;
        }
    }
}

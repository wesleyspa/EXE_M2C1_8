using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_M2C1_8
{
    class ContaCorrente
    {
        public ContaCorrente(Cliente p_dono, int p_numConta)
        {
            this.dono = p_dono;
            this._numConta = p_numConta;
        }

        
        public decimal saldo { get; set; }

        private Cliente _dono;
        public Cliente dono
        {
            get
            {
                return this._dono;
            }
            set
            {
                this._dono = value;
            }
        }

        private int _numConta;
        public int numConta
        {
            get
            {
                return this._numConta;
            }
            set
            {
                this._numConta = value;
            }
        }
       

        public void GetSaldo()
        {
            Console.WriteLine("Saldo da conta {0}", this._saldo);           
        }
    }
}
 
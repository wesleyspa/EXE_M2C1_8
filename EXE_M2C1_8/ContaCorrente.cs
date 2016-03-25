namespace EXE_M2C1_8
{
    public class ContaCorrente : OperacaoBancaria
    {

        public ContaCorrente(ContaCorrente clone)
        {
        }

        public ContaCorrente(Cliente p_dono, int p_numConta)
        {
            this.dono = p_dono;
            this._numConta = p_numConta;
        }


        public ContaCorrente Clone()
        {
            return new ContaCorrente(this);
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


    }
}

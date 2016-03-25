namespace EXE_M2C1_8
{
    public class Cliente
    {
        public Cliente(string p_nome)
        {
            this.nome = p_nome;
        }

        private string _nome;
        public string nome
        {
            get
            {
                return this._nome;
            }
            set
            {
                this._nome = value;
            }
        }

    }
}

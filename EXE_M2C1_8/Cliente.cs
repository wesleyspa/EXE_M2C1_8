using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_M2C1_8
{
    class Cliente
    {
        public Cliente(string p_nome, int p_idade)
        {
            this.nome = p_nome;
            this.idade = p_idade;
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

        private int _idade;
        public int idade
        {
            get
            {   
                return this._idade;
            }
            set
            {
                this._idade = value;
            }
        }

    }
}

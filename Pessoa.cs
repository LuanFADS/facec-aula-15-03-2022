using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula.Entidade
{
    class Pessoa
    {
        public string Nome {get; private set; }

        public Pessoa(string nome)
        {
            Nome = nome ??
                    throw new ArgumentNullException(nameof(Nome));
        }
    }
}

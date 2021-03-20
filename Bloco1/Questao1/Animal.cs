using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    public class Animal : IAnimal
    {
        public String NomeEspecie { get; set; }
        public String NomeAnimal { get; set; }

        public string GetNomeAnimal()
        {
            return NomeAnimal;
        }

        public string GetNomeEspecie()
        {
            return NomeEspecie;
        }

    }
}

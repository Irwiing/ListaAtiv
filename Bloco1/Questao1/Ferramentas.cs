using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    public class Ferramentas : IFerramentas
    {
        public string[] ClassificaEspecies(IAnimal[] completo)
        {
            List<string> animais = new List<string>();
            List<IAnimal> listAnimais = completo.ToList();
            int i = 0;
            while(listAnimais.Count != 0)
            {
                animais.Add(listAnimais.First().GetNomeEspecie());
                listAnimais.RemoveAll(animal => animal.GetNomeEspecie().Equals(animais[i]));
                i++;
            }
            
            return animais.ToArray();
        }

        public IAnimal[] FiltraEspecie(IAnimal[] completo, string especieFiltrar)
        {
            List<IAnimal> especies = new List<IAnimal>();
            foreach (var animal in completo)
            {
                if (animal.GetNomeEspecie().Equals(especieFiltrar))
                {
                    especies.Add(animal);
                }
            }
            return especies.ToArray();
        }


    }
}

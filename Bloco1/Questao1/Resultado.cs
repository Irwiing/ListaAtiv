using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    public class Resultado
    {
        public string NomeEspecie { get; set; }
        public int Quantidade { get; set; }

        public static Resultado[] GetQuantidadeEspecies(IAnimal[] animais, IFerramentas ferramenta)
        {
            List<Resultado> resultados = new List<Resultado>();
            string[] especies = ferramenta.ClassificaEspecies(animais);

            foreach (var especie in especies)
            {
                IAnimal[] filtro = ferramenta.FiltraEspecie(animais, especie);
                Resultado resultado = new Resultado
                {
                    NomeEspecie = especie,
                    Quantidade = filtro.Length
                };
                resultados.Add(resultado);
            }

            return resultados.ToArray();
        }
    }
}

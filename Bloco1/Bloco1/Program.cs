using Questao1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloco1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal() { NomeEspecie = "Terrestre", NomeAnimal = "Cachorro" };
            Animal animal2 = new Animal() { NomeEspecie = "Terrestre", NomeAnimal = "Gato" };
            Animal animal3 = new Animal() { NomeEspecie = "Aquatico", NomeAnimal = "Baleia" };
            Animal animal4 = new Animal() { NomeEspecie = "Aquatico", NomeAnimal = "Foca" };
            Animal animal5 = new Animal() { NomeEspecie = "Voador", NomeAnimal = "Pardal" };

            IAnimal[] animais = new Animal[] { animal1, animal2, animal3, animal4, animal5 };

            Ferramentas ferramentas = new Ferramentas();

            Resultado[] resultadosAnimais = Resultado.GetQuantidadeEspecies(animais, ferramentas);

            foreach (var resultadoAnimal in resultadosAnimais)
            {
                Console.WriteLine($"{resultadoAnimal.NomeEspecie}, {resultadoAnimal.Quantidade}");
            }

            Console.ReadKey();
        }
    }
}

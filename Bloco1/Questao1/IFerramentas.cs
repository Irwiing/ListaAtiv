using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    public interface IFerramentas
    {
        IAnimal[] FiltraEspecie(IAnimal[] completo, String especieFiltrar);

        String[] ClassificaEspecies(IAnimal[] completo);
    }
}

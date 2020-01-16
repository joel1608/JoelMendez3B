using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategy.Clases
{
    interface Candidatos//Definimos una interface que contenga astronauta, cartero, funcionario e ideal.
    {

        string getNombre();//Cuando llamémos a getNombre, llamaremos al nombre que tenga la el candidato
        string Cuenta();//todas las estrategias cuentan con el mismo método  
    }
}

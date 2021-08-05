using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Shared
{
    public static class Helper
    {
        public static bool VerificaIdadeRisco(int idade) 
        {
            if (idade >= 18) return true;
            else return false;
        }

        public static bool VerificaNomeDeRisco(String nome) 
        {
            if (nome == "corona") return false;
            else return true;
        }
    }
}

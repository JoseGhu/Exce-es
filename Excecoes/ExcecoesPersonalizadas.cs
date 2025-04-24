using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    public class NegativoExcecao : Exception
    {
        public NegativoExcecao() { }

        public NegativoExcecao(string menssage) : base(menssage) { }

        public NegativoExcecao(string menssage, Exception inner) : base(menssage, inner) { }

    }

    public class ImparExcecao : Exception
    {
        public ImparExcecao(string menssage) : base(menssage) { }

    }

    class ExcecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if (valor < 0)
            {
                throw new NegativoExcecao("Numero negativo... :(");
            }

            if(valor % 2 == 1)
            {
                throw new ImparExcecao("Valor impar... :(");
            }

            return valor;
        }

        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());
            }
            catch (NegativoExcecao ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ImparExcecao ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

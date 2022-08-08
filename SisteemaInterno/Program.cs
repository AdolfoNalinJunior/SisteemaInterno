using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisteemaInterno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2021, 8, 8);
            DateTime dataCorrente = DateTime.Now;
            TimeSpan diferenca = dataCorrente - dataFimPagamento;

            string mensagem = "Vencimento em: " + GetIntervaloDeTempoLegivel(diferenca);

            Console.WriteLine(mensagem);
        }

        static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        {
            if (timeSpan.Days > 30)
            {
                int quantidadeMeses = timeSpan.Days / 30;
                if (quantidadeMeses == 1)
                {
                    return "1 mes";
                }
                else
                {
                    return quantidadeMeses + " meses";
                }
            }
            return timeSpan.Days + " dias";
        }
    }
}

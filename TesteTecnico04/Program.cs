using System;

namespace testeTecnico02 {
    class Program {
        static void Main(string[] args) {
            decimal faturamentoTotal = 0;
            decimal faturamentoSP = 67836.43M;
            decimal faturamentoRJ = 36678.66M;
            decimal faturamentoMG = 29229.88M;
            decimal faturamentoES = 27165.48M;
            decimal faturamentoOutros = 19849.53M;

            faturamentoTotal = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

            decimal percentualSP = (faturamentoSP / faturamentoTotal) * 100;
            decimal percentualRJ = (faturamentoRJ / faturamentoTotal) * 100;
            decimal percentualMG = (faturamentoMG / faturamentoTotal) * 100;
            decimal percentualES = (faturamentoES / faturamentoTotal) * 100;
            decimal percentualOutros = (faturamentoOutros / faturamentoTotal) * 100;

            Console.WriteLine("Percentual de representação do estado de SP: {0}%", percentualSP);
            Console.WriteLine("Percentual de representação do estado do RJ: {0}%", percentualRJ);
            Console.WriteLine("Percentual de representação do estado de MG: {0}%", percentualMG);
            Console.WriteLine("Percentual de representação do estado do ES: {0}%", percentualES);
            Console.WriteLine("Percentual de representação dos demais estados: {0}%", percentualOutros);
        }
    }

}
    

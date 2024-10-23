using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> _historico;

        public Calculadora()
        {
            _historico = new List<string>();
        }
        public int Somar(int num1, int num2)
        {
            int res = num1 + num2;
            _historico.Insert(0, StringDeHistorico('+', num1, num2, res));
            return res;
        }

        public int Subtrair(int num1, int num2)
        {
            int res = num1 - num2;
            _historico.Insert(0, StringDeHistorico('-', num1, num2, res));
            return res;
        }

        public int Multiplicar(int num1, int num2)
        {
            int res = num1 * num2;
            _historico.Insert(0, StringDeHistorico('*', num1, num2, res));
            return res;
        }

        public int Dividir(int num1, int num2)
        {
            int res = num1 / num2;
            _historico.Insert(0, StringDeHistorico('/', num1, num2, res));
            return res;
        }

        public List<string> HistoricoDeResultados()
        {
            _historico.RemoveRange(3, _historico.Count - 3);
            return _historico;
        }

        private string StringDeHistorico(char operacao, float num1, float num2, float resultado)
        {
            return $"{num1} {operacao} {num2} = {resultado}";
        }
    }
}

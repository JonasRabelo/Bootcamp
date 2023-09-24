using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        public List<string> _historico { get; set; }

        public Calculadora()
        {
            _historico = new List<string>() { "", "", "" };
        }

        public void AtualizarHistorico(int val1, int val2, string resul, string sinal)
        {
            if (sinal == "R")
            {
                _historico.Insert(0, $"Raiz de {val1} = {resul}");
            }
            else if (sinal == "%") 
            {
                _historico.Insert(0, $"{val1} corresponde a {resul}% de {val2}");
            }
            else if (sinal == "P")
            {
                _historico.Insert(0, $"{val1} elevado a {val2} = {resul}");
            }
            else
            {
                _historico.Insert(0, $"{val1} {sinal} {val2} = {resul}");
            }
            _historico.RemoveAt(3);
        }

        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;

            AtualizarHistorico(val1, val2, $"{res}", "+");

            return res;
        }

        public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;

            AtualizarHistorico(val1, val2, $"{res}", "*");

            return res;
        }

        public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;

            AtualizarHistorico(val1, val2, $"{res}", "-");

            return res;
        }

        public int Dividir(int val1, int val2)
        {
            var res = val1 / val2;

            AtualizarHistorico(val1, val2, $"{res}", "/");

            return res;
        }

        public List<string> Historico()
        {
            _historico.RemoveRange(3, _historico.Count - 3);
            return _historico;
        }

        public int Pontencia(int val1, int val2)
        {
            var res = (int)Math.Pow(val1, val2);

            AtualizarHistorico(val1, val2, $"{res}", "P");

            return res;
        }

        public double Raiz(int value)
        {
            var res = Math.Sqrt(value);
            AtualizarHistorico(value, 0, $"{res}", "R");

            return res;
        }

        public double Porcentagem(int val1, int val2)
        {
            var res = ( (double) val1 / val2) * 100;

            AtualizarHistorico(val1, val2, $"{res}", "%");
            
            return res;
        
        }

    }
}

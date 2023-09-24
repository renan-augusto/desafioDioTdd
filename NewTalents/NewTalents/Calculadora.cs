using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listaHistorico;

        private string Data;


        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            Data = data;
        }
        public int Somar(int x, int y)
        {
            int res = x + y;
            listaHistorico.Insert(0, "Val: " + res + " - data" + Data);

            return res;
        }

        public int Subtrair(int x, int y) 
        {  
            int res = x - y;
            listaHistorico.Insert(0, "Val: " + res + " - data" + Data);

            return res; 
        }

        public int Multiplicar(int x, int y) 
        {   
            int res = x * y;
            listaHistorico.Insert(0, "Val: " + res + " - data" + Data);

            return res;
        }
        public int Dividir (int x, int y)
        {
            int res = x / y;
            listaHistorico.Insert(0, "Val: " + res + " - data" + Data);

            return res;
        }

        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3); 

            return listaHistorico;
        }
    }
}

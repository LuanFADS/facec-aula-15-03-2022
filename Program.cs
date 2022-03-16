using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = facec_lista_de_exercicios_tres_15_03_2022;

namespace facec_lista_de_exercicios_tres_15_03_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tipo de valor
            //string nome1 = "Juliano";
            //string nome2 = nome1;

            //nome1 = "João";

            //Console.WriteLine($"{nameof(nome1)}:{nome1}");
            //Console.WriteLine($"{nameof(nome2)}:{nome2}");

            //Console.ReadLine();
            #endregion Tipo de valor 

            #region Tipo de referencia
            //E.Pessoa pessoa = new E.Pessoa()
            //{
            //    Nome = "Luan"
            //};

            //pessoa.Nome = "Luan";
           
            E.Pessoa pessoa = new E.Pessoa("Luan");

            Console.WriteLine($"{nameof(pessoa)}:" + $"{pessoa.Nome}");

            Console.ReadLine();

            #endregion Tipo de referencia
        }
    }
}

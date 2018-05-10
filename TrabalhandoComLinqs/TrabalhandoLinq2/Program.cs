using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoLinq2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cidades = new List<string>();

            cidades.Add("São Paulo");
            cidades.Add("Fortaleza");
            cidades.Add("Porto Alegre");
            cidades.Add("Belo Horizonte");
            cidades.Add("Campinas");
            cidades.Add("Riberão Preto");
            cidades.Add("São Roque");
            cidades.Add("Rio de Janeiro");
            cidades.Add("Itapetininga");

            Console.WriteLine(BuscarComForeach(cidades, "Belo Horizonte"));
            Console.WriteLine(BuscarComLinq(cidades, "Rio de Janeiro"));
            Console.WriteLine(BuscarComLambda(cidades, "Campinas"));

            BuscarLista(cidades, "S").ForEach(x => Console.WriteLine(x));


            Console.ReadKey();
        }

        public static string BuscarComForeach(List<string> lista, string termo)
        {
            foreach (string item in lista)
            {
                if (item.Equals(termo))
                    return item;
            }

            return null;
        }

        public static string BuscarComLinq(List<string> lista, string termo)
        {
            var busca = (from item in lista where item.Equals(termo)
                         select item).First();
            return busca;
        }

        public static string BuscarComLambda(List<string> lista, string termo)
        {
            return lista.First(x => x.Equals(termo));
        }

        public static List<string> BuscarLista(List<string> lista, string termo)
        {
            return lista.Where(x => x.Contains(termo)).ToList();
        }

    }
}

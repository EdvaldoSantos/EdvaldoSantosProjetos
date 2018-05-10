using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComLinqs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> times = new List<string>();
            times.Add("São Paulo");
            times.Add("Atletico Mineiro");
            times.Add("Atletico Paranaense");
            times.Add("Cruzeiro");
            times.Add("Corinthians");
            times.Add("América Mineiro");
            times.Add("Santos");
            times.Add("Palmeiras");
            times.Add("Bahia");
            times.Add("Sport ");
            times.Add("Vitória");
            times.Add("Paraná");
            times.Add("Flamengo");
            times.Add("Fluminese");
            times.Add("Vasco");
            times.Add("Botafogo");
            times.Add("Internacional");
            times.Add("Gremio");
            times.Add("Ceará");
            times.Add("Chapecoense");

            Console.WriteLine(BuscarPrimeiroComForeach(times, "São Paulo"));
            Console.WriteLine(BuscarPrimeiroComLinq(times, "Chapecoense"));
            Console.WriteLine(BuscarPrimeiroComExpressaoLambda(times, "Paraná"));
            BuscarLista(times, "S").ForEach(x => Console.WriteLine(x));
            BuscarLista(times, "F").ForEach(x => Console.WriteLine(x));
            BuscarListaLambda(times, "A").ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }

        public static string BuscarPrimeiroComForeach(List<string> lista, string termo)
        {
            foreach (string item in lista)
            {
                if (item.Equals(termo))
                    return item;
            }

            return null;
        }

        public static string BuscarPrimeiroComLinq(List<string> lista, string termo)
        {
            return (from item in lista
                    where item.Equals(termo)
                    select item).First();
        }

        public static string BuscarPrimeiroComExpressaoLambda(List<string> lista, string termo)
        {
            return lista.First(x => x.Equals(termo));
        }

        public static List<string> BuscarLista(List<string> lista, string termo)
        {
            return (from item in lista
                    where item.Contains(termo)
                    select item).ToList();
        }

        public static List<string> BuscarListaLambda(List<string> lista, string termo)
        {
            return lista.Where(x => x.Contains(termo)).ToList();
        }
    }
}

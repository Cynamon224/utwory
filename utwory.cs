using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utwory
{
    class Program
    {
        interface IUtwor
        {
            public string autor
            {
                get;
                set;
            }
            public string gatunek
            {
                get;
                set;
            }
            public decimal czas_trwania
            {
                get;
                set;
            }
            public int czas_powstania
            {
                get;
                set;
            }

            public void wyswietl_informacje();


        }
        public class Utwor : IUtwor
        {
            public string autor
            {
                get;
                set;
            }
            public string gatunek
            {
                get;
                set;
            }
            public decimal czas_trwania
            {
                get;
                set;
            }
            public int czas_powstania
            {
                get;
                set;
            }
            public Utwor(string autor1, string gatunek1, decimal czas_trwania1, int czas_powstania1)
            {
                autor = autor1;
                gatunek = gatunek1;
                czas_trwania = czas_trwania1;
                czas_powstania = czas_powstania1;
            }
            public void wyswietl_informacje()
            {
                Console.WriteLine("Autor:{0}",autor);
                Console.WriteLine("Gatunek:{0}",gatunek);
                Console.WriteLine("Czas powstania:{0}",czas_powstania);
                Console.WriteLine("Czas trwania:{0} min \n",czas_trwania);
            }
            public virtual int home_office()
            {
                Console.WriteLine("Utwor nie zostal opublikowany");
                return 0;
            }
        }
        public class Utwor_opublikowany : Utwor
        {
            public int data_publikacji { get; set; }


            public Utwor_opublikowany(int data_publikacji1, string autor, string gatunek, decimal czas_trwania, int czas_powstania)
                : base(autor, gatunek, czas_trwania, czas_powstania)
            {
                data_publikacji = data_publikacji1;

            }
            public override int home_office()
            {
                Console.WriteLine("Data publikacji {0}", data_publikacji);
                return 1;
            }
        }
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();

            Utwor u1 = new Utwor("Jan", "jazz", 3, 1992);
            lista.Add((u1.home_office()).ToString());
            u1.wyswietl_informacje();


            Utwor_opublikowany u2 = new Utwor_opublikowany(1998, "Tomasz", "rock", 4, 1981);
            lista.Add((u2.home_office()).ToString());

            u2.wyswietl_informacje();


        }
    }
}

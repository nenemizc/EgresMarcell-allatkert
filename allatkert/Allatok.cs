using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatkert
{
	internal class Allatok
	{
        public class Allat
        {
            public string name { get; set; }
            public int sebesseg {  get; set; }
        }

        Random random = new Random();

        private int meret;
        private int toltottseg;

		List<Hideg> hidegAllatok = new List<Hideg>();
		List<Mediterrán> mediterranAllatok = new List<Mediterrán>();
        List<Meleg> melegAllatok = new List<Meleg>();
        List<Tropusi> tropusiAllatok = new List<Tropusi>();
        List<Vizi> viziAllatok = new List<Vizi>();

        public Allatok()
        {
            meret = random.Next(5,16);
        }

        public void Osszeir()
        {
            hidegAllatok.Add(new Hideg());
            mediterranAllatok.Add(new Mediterrán());
            melegAllatok.Add(new Meleg());
            tropusiAllatok.Add(new Tropusi());
            viziAllatok.Add(new Vizi());
        }

        public void telitettseg()
        {
            int ossz = hidegAllatok.Count + mediterranAllatok.Count + melegAllatok.Count + tropusiAllatok.Count + viziAllatok.Count;
            toltottseg = ossz;
            for (int i = 0; i < meret; i++)
            {
                if (toltottseg > i)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(" ");
                }
                Console.ResetColor();
            }
            Console.WriteLine();
           
        }

        public void Verseny()
        {
            List<Allat> allatok = new List<Allat>
            {
                new Allat {name = hidegAllatok[0].Name, sebesseg = hidegAllatok[0].Sebesseg},
                new Allat {name = mediterranAllatok[0].Name, sebesseg = mediterranAllatok[0].Sebesseg},
                new Allat {name = melegAllatok[0].Name, sebesseg = melegAllatok[0].Sebesseg},
                new Allat {name = tropusiAllatok[0].Name, sebesseg = tropusiAllatok[0].Sebesseg},
                new Allat {name = viziAllatok[0].Name, sebesseg = viziAllatok[0].Sebesseg}
            };

            int menes = 10;
            int menes2 = 10;
            int menes3 = 10;
            int menes4 = 10;
            int menes5 = 10;

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.Clear();

                Console.WriteLine(allatok[0].name);
                Console.SetCursorPosition(menes, 0);
                Console.WriteLine("O");
                menes += allatok[0].sebesseg;

                Console.SetCursorPosition(0, 1);
                Console.WriteLine(allatok[1].name);
                Console.SetCursorPosition(menes2, 1);
                Console.WriteLine("O");
                menes2 += allatok[1].sebesseg;

                Console.SetCursorPosition(0, 2);
                Console.WriteLine(allatok[2].name);
                Console.SetCursorPosition(menes3, 2);
                Console.WriteLine("O");
                menes3 += allatok[2].sebesseg;

                Console.SetCursorPosition(0, 3);
                Console.WriteLine(allatok[3].name);
                Console.SetCursorPosition(menes4, 3);
                Console.WriteLine("O");
                menes4 += allatok[3].sebesseg;

                Console.SetCursorPosition(0, 4);
                Console.WriteLine(allatok[4].name);
                Console.SetCursorPosition(menes5, 4);
                Console.WriteLine("O");
                menes5 += allatok[4].sebesseg;
            }
        }

    }
}

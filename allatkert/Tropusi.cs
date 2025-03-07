using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatkert
{
	internal class Tropusi
	{
		private string name;
		private int sebesseg;
		private int suly;
		private string eloHely;

		public Tropusi()
		{
			name = "majom";
			sebesseg = 4;
			suly = 4;
			eloHely = "tropusi";
		}

        public string Name { get => name; set => name = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public int Suly { get => suly; set => suly = value; }
        public string EloHely { get => eloHely; set => eloHely = value; }
    }
}

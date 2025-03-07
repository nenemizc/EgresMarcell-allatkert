using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatkert
{
	internal class Mediterrán
	{
		private string name;
		private int sebesseg;
		private int suly;
		private string eloHely;

		public Mediterrán()
		{
			name = "teknős";
			sebesseg = 1;
			suly = 3;
			eloHely = "mediterrán";
		}

        public string Name { get => name; set => name = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public int Suly { get => suly; set => suly = value; }
        public string EloHely { get => eloHely; set => eloHely = value; }
    }
}

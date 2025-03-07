using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatkert
{
	internal class Vizi
	{
		private string name;
		private int sebesseg;
		private int suly;
		private string eloHely;

		public Vizi()
		{
			name = "hal";
			sebesseg = 2;
			suly = 1;
			eloHely = "víz";
		}

        public string Name { get => name; set => name = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public int Suly { get => suly; set => suly = value; }
        public string EloHely { get => eloHely; set => eloHely = value; }
    }
}

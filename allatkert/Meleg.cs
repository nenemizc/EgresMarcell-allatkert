﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatkert
{
	internal class Meleg
	{
		private string name;
		private int sebesseg;
		private int suly;
		private string eloHely;

		public Meleg()
		{
			name = "kalahari";
			sebesseg = 3;
			suly = 2;
			eloHely = "meleg";
		}

        public string Name { get => name; set => name = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public int Suly { get => suly; set => suly = value; }
        public string EloHely { get => eloHely; set => eloHely = value; }
    }
}

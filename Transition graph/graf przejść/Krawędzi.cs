using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf_przejść
{
	class Krawędzi
	{
		public int waga;
		public Węzeł4 początek;
		public Węzeł4 koniec;

		public Krawędzi(int waga, Węzeł4 początek, Węzeł4 koniec)
		{
			this.waga = waga;
			this.początek = początek;
			this.koniec = koniec;
		}
	}
}

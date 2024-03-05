using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm_Kruskala
{
	internal class Krawędzi
	{
		public int waga;
		public Węzeł początek;
		public Węzeł koniec;
	
		public Krawędzi(int waga, Węzeł początek, Węzeł koniec)
		{
			this.waga = waga;
			this.początek = początek;
			this.koniec = koniec;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf_przejść
{
	class Element
	{
		public int dystans;
		public Węzeł4 poprzednik;
	}
	class GrafZ
	{
		List<Węzeł4> węzły;
		List<Krawędzi> krawędzie;
		private string komunikat;

		public GrafZ()
		{
			węzły = new List<Węzeł4>();
			krawędzie = new List<Krawędzi>();
			komunikat = "";
		}

		public String DostańKomunikat()
		{
			return komunikat;
		}

		public Węzeł4 DostańWęzeł(int indeks)
		{
			return węzły[indeks];
		}

		public void Dodaj(int waga, int początek, int koniec)
		{
			Węzeł4 wPoczątek = ZnajdźWęzeł(początek) ?? DodajWęzeł(początek);
			Węzeł4 wKoniec = ZnajdźWęzeł(koniec) ?? DodajWęzeł(koniec);

			if (ZnajdźKrawędź(wPoczątek, wKoniec) == null && ZnajdźKrawędź(wKoniec, wPoczątek) == null)
			{
				DodajKrawędź(waga, wPoczątek, wKoniec);
			}
		}

		private Węzeł4 DodajWęzeł(int wartość)
		{
			Węzeł4 w = new Węzeł4(wartość);
			węzły.Add(w);
			return w;
		}

		private void DodajKrawędź(int waga, Węzeł4 początek, Węzeł4 koniec)
		{
			Krawędzi k = new Krawędzi(waga, początek, koniec);
			krawędzie.Add(k);
		}

		private Krawędzi ZnajdźKrawędź(Węzeł4 początek, Węzeł4 koniec)
		{
			foreach (var k in krawędzie)
			{
				if (k.początek == początek && k.koniec == koniec)
				{
					return k;
				}
			}
			return null;
		}

		private Węzeł4 ZnajdźWęzeł(int wartość)
		{
			foreach (var w in węzły)
			{
				if (w.wartość == wartość)
				{
					return w;
				}
			}
			return null;
		}

		/*ZnajdźMin(Dictionary<Węzeł4, Element> tabela, Label<Węzeł4> Q)
		{
			var min = tabelka[Q[object]];
			for(var w in Q)
			{
				if (tabelka[w].dystans < min.dystans)
				{
					min.tabelka[w];
				}
			}
			return min;
		}*/

		public void Dijkstra(Węzeł4 start)
		{
			Dictionary<Węzeł4, Element> tabela = new Dictionary<Węzeł4, Element>();
			foreach (var węzeł in węzły)
			{
				tabela[węzeł] = new Element { dystans = int.MaxValue, poprzednik = null };
			}

			tabela[start].dystans = 0;

			List<Węzeł4> Q = new List<Węzeł4>(węzły);

			while (Q.Count > 0)
			{
				var u = ZnajdźMin(tabela, Q);
				Q.Remove(u);

				foreach (var krawędź in krawędzie)
				{
					if (krawędź.początek == u && Q.Contains(krawędź.koniec))
					{
						var alt = tabela[u].dystans + krawędź.waga;
						if (alt < tabela[krawędź.koniec].dystans)
						{
							tabela[krawędź.koniec].dystans = alt;
							tabela[krawędź.koniec].poprzednik = u;
						}
					}
				}
			}

			foreach (var węzeł in węzły)
			{
				WyświetlNajkrótsząŚcieżkę(start, węzeł, tabela);
			}
		}

		private Węzeł4 ZnajdźMin(Dictionary<Węzeł4, Element> tabela, List<Węzeł4> Q)
		{
			var min = Q[0];
			foreach (var w in Q)
			{
				if (tabela[w].dystans < tabela[min].dystans)
				{
					min = w;
				}
			}
			return min;
		}

		private void WyświetlNajkrótsząŚcieżkę(Węzeł4 wierzchołekStartowy, Węzeł4 wierzchołekKońcowy, Dictionary<Węzeł4, Element> tabela)
		{
			// Konstruuj komunikat dotyczący najkrótszej ścieżki
			komunikat += $"\nDojście do wierzchołka {wierzchołekKońcowy.wartość}: ";

			List<Węzeł4> ścieżka = new List<Węzeł4>();
			Węzeł4 bieżący = wierzchołekKońcowy;
			
			// Rekonstrukcja ścieżki z poprzedników
			while (bieżący != null)
			{
				ścieżka.Insert(0, bieżący);
				bieżący = tabela[bieżący].poprzednik;
			}

			
			// Wyświetlanie ścieżki lub informacji o jej braku
			if (ścieżka.Count == 0 || ścieżka[0] != wierzchołekStartowy)
			{
				komunikat += "Brak ścieżki.";
			}
			else
			{
				for (int i = 0; i < ścieżka.Count - 1; i++)
				{
					komunikat += $"{ścieżka[i].wartość}–";
				}

				komunikat += $"{ścieżka[ścieżka.Count - 1].wartość}, koszt {tabela[wierzchołekKońcowy].dystans}";
			}
		}

	}
}

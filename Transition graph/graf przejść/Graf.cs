using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf_przejść
{
	class Graf
	{
		List<Węzeł4> węzły;
		List<Krawędzi> krawędzie;
		private List<int> WagiKrok;
		private string komunikat;

		public Graf()
		{
			węzły = new List<Węzeł4>();
			krawędzie = new List<Krawędzi>();
			WagiKrok = new List<int>();
			komunikat = "";
		}

		public String DostańKomunikat()
		{
			return komunikat;
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
		public void Dijkstra(int startowy)
		{
			int ilośćWęzłów = węzły.Count;
			int[] kosztyDojścia = new int[ilośćWęzłów];
			int[] poprzednicy = new int[ilośćWęzłów];
			bool[] odwiedzone = new bool[ilośćWęzłów];

			// Inicjalizacja tablic kosztów i poprzedników
			for (int i = 0; i < ilośćWęzłów; i++)
			{
				kosztyDojścia[i] = int.MaxValue; // Ustawienie początkowych kosztów na "nieskończoność"
				poprzednicy[i] = -1; // Brak poprzednika dla każdego węzła
			}

			// Koszt dojścia do startowego węzła ustawiony na 0
			kosztyDojścia[startowy] = 0;

			// Główna pętla algorytmu Dijkstry
			for (int i = 0; i < ilośćWęzłów - 1; i++)
			{
				// Znajdź węzeł o najmniejszym koszcie dojścia
				int aktualnyWęzeł = ZnajdźMinimumWagę(kosztyDojścia, odwiedzone);
				odwiedzone[aktualnyWęzeł] = true;

				// Aktualizuj koszty dojścia sąsiadów aktualnego węzła
				foreach (var krawędź in krawędzie)
				{
					if (krawędź.początek.wartość == aktualnyWęzeł)
					{
						int sąsiedniWęzeł = krawędź.koniec.wartość;
						int nowyKoszt = kosztyDojścia[aktualnyWęzeł] + krawędź.waga;

						if (nowyKoszt < kosztyDojścia[sąsiedniWęzeł])
						{
							kosztyDojścia[sąsiedniWęzeł] = nowyKoszt;
							poprzednicy[sąsiedniWęzeł] = aktualnyWęzeł;
						}
					}
				}
			}

			// Wyświetl najkrótszą ścieżkę z węzła startowego do pozostałych węzłów
			for (int i = 0; i < ilośćWęzłów; i++)
			{
				WyświetlNajkrótsząŚcieżkę(startowy, węzły[i], poprzednicy, kosztyDojścia);

			}
		}
		private void WyświetlNajkrótsząŚcieżkę(int wierzchołekStartowy, Węzeł4 wierzchołekKońcowy, int[] poprzednicy, int[] kosztyDojścia)
		{
			// Konstruuj komunikat dotyczący najkrótszej ścieżki
			komunikat += $"\nDojście do wierzchołka {wierzchołekKońcowy.wartość}: ";

			List<int> ścieżka = new List<int>();
			int bieżący = wierzchołekKońcowy.wartość;

			// Rekonstrukcja ścieżki z poprzedników
			while (bieżący != -1)
			{
				ścieżka.Insert(0, bieżący);
				bieżący = poprzednicy[bieżący];
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
					komunikat += $"{ścieżka[i]}–";
				}

				komunikat += $"{ścieżka[ścieżka.Count - 1]}, koszt {kosztyDojścia[wierzchołekKońcowy.wartość]}";
			}
		}

		private int ZnajdźMinimumWagę(int[] kosztyDojścia, bool[] odwiedzone)
		{
			// Znajdź indeks węzła o najmniejszym koszcie dojścia
			int minimum = int.MaxValue;
			int indeksMinimum = -1;

			for (int i = 0; i < węzły.Count; i++)
			{
				if (!odwiedzone[i] && kosztyDojścia[i] < minimum)
				{
					minimum = kosztyDojścia[i];
					indeksMinimum = i;
				}
			}

			return indeksMinimum;
		}


	}
}

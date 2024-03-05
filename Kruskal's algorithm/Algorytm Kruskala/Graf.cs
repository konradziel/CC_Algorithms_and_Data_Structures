using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm_Kruskala
{
	class Graf
	{
		List<Węzeł> węzły;
		List<Krawędzi> krawędzie;
		private string komunikat;

		public Graf()
		{
			węzły = new List<Węzeł>();
			krawędzie = new List<Krawędzi>();
			komunikat = "";
		}

		public Graf(Krawędzi krawędź)
		{
			węzły = new List<Węzeł>();
			krawędzie = new List<Krawędzi>();
			komunikat = "";

			Dodaj(krawędź);
		}

		public String DostańKomunikat()
		{
			return komunikat;
		}

		public Węzeł DostańWęzeł(int indeks)
		{
			return węzły[indeks];
		}

		public void Dodaj(int waga, int początek, int koniec)
		{
			Węzeł wPoczątek = ZnajdźWęzeł(początek) ?? DodajWęzeł(początek);
			Węzeł wKoniec = ZnajdźWęzeł(koniec) ?? DodajWęzeł(koniec);

			if (ZnajdźKrawędź(wPoczątek, wKoniec) == null && ZnajdźKrawędź(wKoniec, wPoczątek) == null)
			{
				DodajKrawędź(waga, wPoczątek, wKoniec);
			}
		}

		public void Dodaj(Krawędzi k)
		{
			Węzeł wPoczątek = ZnajdźWęzeł(k.początek.wartość) ?? DodajWęzeł(k.początek.wartość);
			Węzeł wKoniec = ZnajdźWęzeł(k.koniec.wartość) ?? DodajWęzeł(k.koniec.wartość);

			if (ZnajdźKrawędź(wPoczątek, wKoniec) == null && ZnajdźKrawędź(wKoniec, wPoczątek) == null)
			{
				DodajKrawędź(k.waga, wPoczątek, wKoniec);
			}
		}

		private Węzeł DodajWęzeł(int wartość)
		{
			Węzeł w = new Węzeł(wartość);
			węzły.Add(w);
			return w;
		}

		private void DodajKrawędź(int waga, Węzeł początek, Węzeł koniec)
		{
			Krawędzi k = new Krawędzi(waga, początek, koniec);
			krawędzie.Add(k);
		}

		private Krawędzi ZnajdźKrawędź(Węzeł początek, Węzeł koniec)
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

		private Węzeł ZnajdźWęzeł(int wartość)
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

		//komendy
		public Graf AlgorytmKruskala()
		{
			krawędzie = this.krawędzie.OrderBy(k => k.waga);
			List<Graf> grafy = new List<Graf>();
			Dictionary<Krawędzi, bool> dodaneK = new Dictionary<Krawędzi, bool>();

			foreach(var k in krawędzie)
			{
				dodaneK[k] = false;
			}

			Graf minDrzewoRoz = new Graf(krawędzie[0]);
			grafy.Add(minDrzewoRoz);
			

			for (int g = 0; g < grafy.Count(); g++)
			{
				for (int i = 1; i < krawędzie.Count(); i++)
				{
					switch (grafy[g].Sprawdź(krawędzie[i]))
					{
						case 2:
							grafy.Add(new Graf(krawędzie[i]));						
							dodaneK[krawędzie[i]] = true;
							break;
						case 1:
							grafy[g].Dodaj(krawędzie[i]);
							dodaneK[krawędzie[i]] = true;
							break;
						case 0:
							if (grafy[g].węzły.Contains(krawędzie[i].początek) && grafy[g].węzły.Contains(krawędzie[i].koniec))
							{
								break;
							}

							while (dodaneK[krawędzie[i]]==false)
							{
								int z = 0;
								if (z >= grafy.Count())
								{
									break;
								}
								if (z == g)
								{
									break;
								}
								else if(grafy[g].węzły.Contains(krawędzie[i].początek) && grafy[z].węzły.Contains(krawędzie[i].koniec))
								{
									foreach(var k in grafy[z].krawędzie)
									{
										grafy[g].Dodaj(k);
									}
									grafy[g].Dodaj(krawędzie[i]);
									grafy.Remove(grafy[z]);						
								}
								else if (grafy[z].węzły.Contains(krawędzie[i].początek) && grafy[g].węzły.Contains(krawędzie[i].koniec))
								{
									foreach (var k in grafy[z].krawędzie)
									{
										grafy[g].Dodaj(k);
									}
									grafy[g].Dodaj(krawędzie[i]);
									grafy.Remove(grafy[z]);
								}
								z++;
								
							}

							break;
					}

				}
			}

			return minDrzewoRoz;
		}

		int Sprawdź(Krawędzi k)
		{
			//funkcja zwraca ilość dodanych węzłów;
			int liczba = 0;
			if (!this.węzły.Contains(k.początek))
				liczba++;
			if (!this.węzły.Contains(k.koniec))
				liczba++;
			return liczba;
		}

		public void WygenerujGraf()
		{
			komunikat = "";
			foreach(var k in this.krawędzie)
			{
				komunikat += "Krawędź: " + k.początek + " i " + k.koniec + " o wadzę " + k.waga + "\n";
			}
		}
	}
}

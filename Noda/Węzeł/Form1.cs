namespace Węzeł
{
	public partial class Form1 : Form
	{
		string napis = "";
		List<Węzeł2> odwiedzone = new();

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var w1 = new Węzeł(5);

			var w2 = new Węzeł(3);
			var w3 = new Węzeł(1);
			var w4 = new Węzeł(2);
			var w5 = new Węzeł(6);
			var w6 = new Węzeł(4);

			w1.dzieci.Add(w2);
			w1.dzieci.Add(w3);
			w1.dzieci.Add(w4);
			w2.dzieci.Add(w5);
			w2.dzieci.Add(w6);

			napis = "";
			A(w1);
			MessageBox.Show(napis);
		}

		void A(Węzeł w)//DFS drzewa
		{
			for (int i = 0; i < w.dzieci.Count; i++)
			{
				A(w.dzieci[i]);
			}
			napis += " " + w.wartość.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var w1 = new Węzeł2(1);
			var w2 = new Węzeł2(2);
			var w3 = new Węzeł2(3);
			var w4 = new Węzeł2(4);
			var w5 = new Węzeł2(5);
			var w6 = new Węzeł2(6);
			var w7 = new Węzeł2(7);


			w1.Add(w2);
			w1.Add(w4);
			w1.Add(w5);
			w2.Add(w3);
			w3.Add(w4);
			w5.Add(w6);
			w5.Add(w7);
			w6.Add(w7);

			napis = "";
			odwiedzone.Clear();
			B(w1);
			MessageBox.Show(napis);
		}

		void B(Węzeł2 w)//DFS grafy z cyklem
		{
			odwiedzone.Add(w);
			napis += w.wartość.ToString() + " ";
			foreach (var sąsiad in w.sąsiedzi)
			{
				if (!odwiedzone.Contains(sąsiad))
					B(sąsiad);
			}
		}



		private void button3_Click(object sender, EventArgs e)
		{
			var w1 = new Węzeł2(1);
			var w2 = new Węzeł2(2);
			var w3 = new Węzeł2(3);
			var w4 = new Węzeł2(4);
			var w5 = new Węzeł2(5);
			var w6 = new Węzeł2(6);
			var w7 = new Węzeł2(7);


			w1.Add(w2);
			w1.Add(w4);
			w1.Add(w5);
			w2.Add(w3);
			w3.Add(w4);
			w5.Add(w6);
			w5.Add(w7);
			w6.Add(w7);

			napis = "";
			odwiedzone.Clear();
			BFS(w1);
			MessageBox.Show(napis);
		}

		void BFS(Węzeł2 w)
		{
			if (w != null && !odwiedzone.Contains(w))
			{
				napis += w.wartość.ToString() + " ";
				odwiedzone.Add(w);
				foreach (var sąsiad in w.sąsiedzi)
				{
					BFS(sąsiad);
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			var w1 = new Węzeł3(5);

			var db = new drzewoBinarne(w1);
			db.Add(4);
			db.Add(4);
			db.Add(3);
			db.Add(4);
			db.Add(3);
			db.Add(8);
			db.Add(7);

			db.Wyswietl();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			var w = new Węzeł3(5);
			var d = new drzewoBinarne(w);

			d.Add(4);
			d.Add(3);
			d.Add(8);
			d.Add(7);
			d.Add(9);
			d.Add(2);
			d.Add(2);

			/*var w2 = d.ZnajdźNajmniejszy(d.korzeń);
			while(w != null)
			{
				w2 = d.Następnik(w2);
			}*/
			d.Wyswietl();
			var w1 = d.ZnajdźR(5);			
			d.Usuń(w1);			
			d.Wyswietl();
		}
	}

	class Węzeł
	{
		public int wartość;
		public List<Węzeł> dzieci = new List<Węzeł>();

		public Węzeł(int liczba)
		{
			this.wartość = liczba;
		}
	}

	class Węzeł2
	{
		public int wartość;
		public List<Węzeł2> sąsiedzi = new List<Węzeł2>();

		public Węzeł2(int liczba)
		{
			this.wartość = liczba;
		}

		public bool Add(Węzeł2 s)
		{
			if (this == s)
			{
				return false;
			}

			bool wynik = false;

			if (!this.sąsiedzi.Contains(s))
			{
				this.sąsiedzi.Add(s);
				wynik = true;
			}

			if (!s.sąsiedzi.Contains(this))
			{
				s.sąsiedzi.Add(this);
				wynik = true;
			}

			return wynik;
		}
	}

	class Węzeł3
	{
		public int wartość;
		public Węzeł3 rodzic;
		public Węzeł3 leweDziecko;
		public Węzeł3 praweDziecko;

		public Węzeł3(int wartość)
		{
			this.wartość = wartość;
		}

		public override string ToString()
		{
			return $"Wartość: {this.wartość}, Rodzic: {rodzic?.wartość ?? -1}, Lewe dziecko: {(this.leweDziecko != null ? this.leweDziecko.wartość.ToString() : "brak")}, Prawe dziecko: {(this.praweDziecko != null ? this.praweDziecko.wartość.ToString() : "brak")}\n"; ;
		}
		//można spróbować TreeView w form1;

		internal void Add(int liczba)
		{
			var dziecko = new Węzeł3(liczba);
			dziecko.rodzic = this;
			if (liczba < this.wartość)
			{
				this.leweDziecko = dziecko;
			}
			else
			{
				this.praweDziecko = dziecko;
			}
		}

		public int ileDzieci()
		{
			int wynik = 0;
			if(this.leweDziecko != null)
			{
				wynik++;
			}
			if(this.praweDziecko != null)
			{
				wynik++;
			}
			return wynik;
		}

	}

	class drzewoBinarne
	{
		public Węzeł3 korzeń;
		public int liczbaWęzłów = 0;
		private String napis;

		public drzewoBinarne(Węzeł3 korzeń)
		{
			this.korzeń = korzeń;
		}

		public override string ToString()
		{
			return this.korzeń.ToString();
		}

		public void Add(int liczba)
		{
			var rodzic = this.ZnajdźRodzica(liczba);
			rodzic.Add(liczba);
			liczbaWęzłów++;
		}

		private Węzeł3 ZnajdźRodzica(int liczba)
		{
			var w = this.korzeń;
			while (true)
			{
				if (liczba < w.wartość)
				{
					if (w.leweDziecko != null)
					{
						w = w.leweDziecko;
					}
					else
					{
						return w;
					}

				}
				else
				{
					if (w.praweDziecko != null)
					{
						w = w.praweDziecko;
					}
					else
					{
						return w;
					}
				}
			}

		}

		private Węzeł3 Znajdź(int liczba)
		{
			var w = this.korzeń;
			while (true)
			{
				if (liczba == w.wartość)
				{
					return w;
				}

				if (liczba < w.wartość)
				{
					if (w.leweDziecko != null)
					{
						w = w.leweDziecko;
					}
					else
					{
						return null;
					}

				}
				else
				{
					if (w.praweDziecko != null)
					{
						w = w.praweDziecko;
					}
					else
					{
						return null;
					}
				}
			}

		}

		public Węzeł3 ZnajdźR(int liczba)
		{
			return ZnajdźRekurencyjnie(korzeń, liczba);
		}

		private Węzeł3 ZnajdźRekurencyjnie(Węzeł3 w, int liczba)
		{
			if (w == null || w.wartość == liczba)
			{
				return w;
			}

			if (liczba < w.wartość)
			{
				return ZnajdźRekurencyjnie(w.leweDziecko, liczba);
			}
			else
			{
				return ZnajdźRekurencyjnie(w.praweDziecko, liczba);
			}
		}

		public Węzeł3 ZnajdźNajmniejszy(Węzeł3 w)
		{
			while (w.leweDziecko != null)
			{
				w = w.leweDziecko;
			}

			return w;
		}

		public Węzeł3 ZnajdźNajwiększy(Węzeł3 w)
		{
			while (w.praweDziecko != null)
			{
				w = w.praweDziecko;
			}

			return w;
		}

		public Węzeł3 Następnik(Węzeł3 w)
		{
			if (w.praweDziecko != null)
			{
				return ZnajdźNajmniejszy(w.praweDziecko);
			}

			Węzeł3 rodzic = w.rodzic;
			/*if(rodzic == null)
			{
				return null;
			}
			if(rodzic.leweDziecko == w)
			{
				return rodzic;
			}
			w = rodzic;*/

			/*while(rodzic != null)
			{
				if(rodzic.leweDziecko == w)
				{
					return rodzic;
				}
				w = rodzic;
			}*/

			while (rodzic != null && w == rodzic.praweDziecko)
			{
				w = rodzic;
				rodzic = rodzic.rodzic;
			}

			return rodzic;
		}

		/*public Węzeł3 Usuń(Węzeł3 w)
		{
			var rodzic = w.rodzic;
			*//*
			 * 1.Gdy nie ma dzieci to odwiązujemy węzeł
			 * 2.Gdy jest jedno dziecko, to wchodzi na miejsce rodzica
			 * 3.Gdy jest dwoje dzieci, to sprawdzam następnik rekurencyjnie aż będę miał krok 1 lub 2 
			 *//*

			// Przypadek 1: Brak dzieci
			//if (w.leweDziecko == null && w.praweDziecko == null)
			if (w.ileDzieci() == 0)
			{
				if (rodzic != null)
				{
					if (rodzic.leweDziecko == w)
					{
						rodzic.leweDziecko = null;
					}
					else
					{
						rodzic.praweDziecko = null;
					}
				}
				else
				{
					korzeń = null;
				}
			}
			// Przypadek 2: Jedno dziecko
			*//*//else if (w.leweDziecko == null)
			{
				var dziecko = w.praweDziecko;
				PodmieńWęzeł(w, dziecko);
			}
			else if (w.praweDziecko == null)
			{
				var dziecko = w.leweDziecko;
				PodmieńWęzeł(w, dziecko);
			}*//*


			// Przypadek 3: Dwoje dzieci
			else
			{
				var następnik = Następnik(w);
				Usuń(następnik);
			}

			liczbaWęzłów--;

			return w;
		}*/

		public Węzeł3 Usuń(Węzeł3 w)
		{
			var rodzic = w.rodzic;
			int liczbaDzieci = w.ileDzieci();
			switch (liczbaDzieci)
			{
				// Przypadek 1: Brak dzieci
				case 0:
					return this.UsuńGdy0Dzieci(w);									


				// Przypadek 2: Jedno dziecko
				case 1:
					return this.UsuńGdy1Dziecko(w);		
					

				// Przypadek 3: Dwoje dzieci
				case 2:
					return this.UsuńGdy2Dzieci(w);

			}	

			liczbaWęzłów--;

			return w;
		}

		private Węzeł3 UsuńGdy0Dzieci(Węzeł3 w)
		{
			var rodzic = w.rodzic;
			if (rodzic != null)
			{
				if (rodzic.leweDziecko == w)
				{
					rodzic.leweDziecko = null;
				}
				else
				{
					rodzic.praweDziecko = null;
				}
			}
			else
			{
				korzeń = null;
			}
			w.rodzic = null;

			return w;
		}

		private Węzeł3 UsuńGdy1Dziecko(Węzeł3 w)
		{
			Węzeł3 dziecko = null;
			/*if (w.praweDziecko != null)
			{
				dziecko = w.praweDziecko;
			}
			else
			{
				dziecko = w.leweDziecko;				
			}
			PodmieńWęzeł(w, dziecko);*/
			if(w.leweDziecko != null)
			{
				dziecko = w.leweDziecko;
				w.leweDziecko = null;
			}
			else
			{
				dziecko = w.praweDziecko;
				w.praweDziecko = null;
			}
			
			dziecko.rodzic = w.rodzic;
			
			if(w.rodzic.leweDziecko != null)
			{
				w.rodzic.leweDziecko = dziecko;
			}
			else
			{
				w.rodzic.praweDziecko = dziecko;
			}
			w.rodzic = null;
			return w;
		}

		private Węzeł3 UsuńGdy2Dzieci(Węzeł3 w)
		{
			var zamiennik = Następnik(w);
			zamiennik = Usuń(zamiennik);
			if(w.rodzic != null)
			{
				if(w.rodzic.leweDziecko == w)
				{
					w.rodzic.leweDziecko = zamiennik;
				}
				else
				{
					w.rodzic.praweDziecko = zamiennik;
				}
			}
			zamiennik.rodzic = w.rodzic;
			w.rodzic = null;

			zamiennik.leweDziecko = w.leweDziecko;
			zamiennik.leweDziecko.rodzic = zamiennik;
			w.leweDziecko = null;

			zamiennik.praweDziecko = w.praweDziecko;
			zamiennik.praweDziecko.rodzic = zamiennik;
			w.praweDziecko = null;
			return w;
		}

		private void PodmieńWęzeł(Węzeł3 staryWęzeł, Węzeł3 nowyWęzeł)
		{
			var rodzic = staryWęzeł.rodzic;

			if (rodzic != null)
			{
				if (rodzic.leweDziecko == staryWęzeł)
				{
					rodzic.leweDziecko = nowyWęzeł;
				}
				else
				{
					rodzic.praweDziecko = nowyWęzeł;					
				}
				nowyWęzeł.rodzic = rodzic;
				staryWęzeł = null;
			}
			else
			{
				korzeń = nowyWęzeł;
			}
		}


		public void Wyswietl()
		{
			napis = "";
			przejścieSzczegółowo(korzeń, null);
			MessageBox.Show(napis);
		}

		private void przejścieSzczegółowo(Węzeł3 w, Węzeł3 rodzic)
		{
			if (w != null)
			{
				przejścieSzczegółowo(w.leweDziecko, w);
				napis += $"Wartość: {w.wartość}, Rodzic: {rodzic?.wartość ?? -1}, Lewe dziecko: {(w.leweDziecko != null ? w.leweDziecko.wartość.ToString() : "brak")}, Prawe dziecko: {(w.praweDziecko != null ? w.praweDziecko.wartość.ToString() : "brak")}\n";
				przejścieSzczegółowo(w.praweDziecko, w);
			}
		}

	}
}
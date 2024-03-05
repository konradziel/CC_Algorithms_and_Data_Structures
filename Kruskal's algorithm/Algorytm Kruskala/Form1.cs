namespace Algorytm_Kruskala
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Graf graf = new Graf();
			graf.Dodaj(5, 0, 1);
			graf.Dodaj(9, 0, 3);
			graf.Dodaj(3, 0, 6);
			graf.Dodaj(9, 1, 2);
			graf.Dodaj(7, 1, 7);
			graf.Dodaj(6, 1, 5);
			graf.Dodaj(8, 1, 4);
			graf.Dodaj(1, 4, 6);
			graf.Dodaj(2, 4, 5);
			graf.Dodaj(3, 2, 7);
			graf.Dodaj(4, 2, 4);
			graf.Dodaj(5, 2, 6);
			graf.Dodaj(6, 5, 5);
			graf.Dodaj(8, 3, 6);
			graf.Dodaj(9, 2, 3);
			graf.Dodaj(9, 6, 7);

			Graf wynik = graf.AlgorytmKruskala();
			wynik.WygenerujGraf();
			MessageBox.Show(wynik.DostañKomunikat());
		}
	}
}
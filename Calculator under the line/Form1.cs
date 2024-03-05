using System;
using System.Windows.Forms; // Dodaj to, aby uzyskać dostęp do klasy Form

namespace Kalkulator_pod_kreską
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btsStart_Click(object sender, EventArgs e)
		{
			long wartosc1 = (long)numericUpDown1.Value;
			long wartosc2 = (long)numericUpDown2.Value;

			if (sumaBox.Checked)
			{
				long sumaWynik = DodawaniePisemne(wartosc1, wartosc2);
				MessageBox.Show("Suma równa jest " + sumaWynik);
			}

			if (roznicaBox.Checked)
			{
				if (wartosc1 >= wartosc2)
				{
					long roznicaWynik = OdejmowaniePisemne(wartosc1, wartosc2);
					MessageBox.Show("Różnica równa jest " + roznicaWynik);
				}
				else
				{
					long roznicaWynik = OdejmowaniePisemne(wartosc2, wartosc1);
					MessageBox.Show("Różnica równa jest -" + roznicaWynik);
				}
			}

			if (iloczynBox.Checked)
			{
				long iloczynWynik = IloczynPisemny(wartosc1, wartosc2);
				MessageBox.Show("Iloczyn równy jest " + iloczynWynik);
			}

			if (ilorazBox.Checked)
			{
				long ilorazWynik = IlorazPisemny(wartosc1, wartosc2);
				if (ilorazWynik == -1)
				{
					MessageBox.Show("Nie można dzielić przez zero.");
				}
				else
				{
					MessageBox.Show("Iloraz równy jest " + ilorazWynik);
				}
			}
		}

		long DodawaniePisemne(long n, long m)
		{
			long wynik = 0;
			long przeniesienie = 0;
			long pozycja = 1;

			while (n > 0 || m > 0 || przeniesienie > 0)
			{
				long cyfra1 = n % 10;
				long cyfra2 = m % 10;

				long suma = cyfra1 + cyfra2 + przeniesienie;
				long nowaCyfra = suma % 10;
				przeniesienie = suma / 10;

				wynik += nowaCyfra * pozycja;
				n /= 10;
				m /= 10;
				pozycja *= 10;
			}

			return wynik;
		}

		long OdejmowaniePisemne(long n, long m)
		{
			long wynik = 0;
			long pozycja = 1;
			long przeniesienie = 0;

			while (n > 0 || przeniesienie != 0)
			{
				long cyfra1 = n % 10;
				long cyfra2 = (m % 10) + przeniesienie;

				if (cyfra1 < cyfra2)
				{
					cyfra1 += 10;
					przeniesienie = 1;
				}
				else
				{
					przeniesienie = 0;
				}

				long roznicaCyfr = cyfra1 - cyfra2;
				wynik += roznicaCyfr * pozycja;
				n /= 10;
				m /= 10;
				pozycja *= 10;
			}

			return wynik;
		}

		long IloczynPisemny(long n, long m)
		{
			long iloczyn = 0;
			long pozycja = 1;

			while (m > 0)
			{
				long cyfra2 = m % 10;
				long wynikCzesciowy = n * cyfra2;

				iloczyn = DodawaniePisemne(iloczyn, wynikCzesciowy * pozycja);
				pozycja *= 10;
				m /= 10;
			}

			return iloczyn;
		}

		long IlorazPisemny(long n, long m)
		{
			if (m == 0)
			{
				return -1;
			}

			long iloraz = 0;
			long pozycja = 1;

			while (n >= m)
			{
				long iloscPelnych = 0;
				long wynikCzesciowy = 0;

				while (n >= (wynikCzesciowy + m))
				{
					iloscPelnych++;
					wynikCzesciowy += m;
				}

				iloraz += iloscPelnych * pozycja;
				n = OdejmowaniePisemne(n, wynikCzesciowy);
				pozycja *= 10;
			}

			return iloraz;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}

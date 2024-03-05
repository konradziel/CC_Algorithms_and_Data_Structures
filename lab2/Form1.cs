using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _18._10
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btsStart_Click(object sender, EventArgs e)
		{
			String liczby = tbInput.Text;
			int[] temp = stringToArray(liczby);
			int[] tab = bubbleSort(temp);
			lblWynik.Text = ("Bubble Sort: " + wypisz(tab));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String liczby = tbInput.Text;
			int[] temp = stringToArray(liczby);
			int[] tab = selectSort(temp);
			lblWynik.Text = ("Select Sort: " + wypisz(tab));
		}

		string wypisz(int[] tab)
		{
			string wynik = "";
			for (int i = 0; i < tab.Length; i++)
			{
				wynik += tab[i].ToString() + ", ";
			}
			return wynik;
		}

		public int[] bubbleSort(int[] NumArray)
		{
			bool czyZamiana = false;
			var n = NumArray.Length;
			do
			{
				czyZamiana = false;
				for (int j = 0; j < n - 1; j++)
				{
					if (NumArray[j] > NumArray[j + 1])
					{
						czyZamiana = true;
						var tempVar = NumArray[j + 1];
						NumArray[j + 1] = NumArray[j];
						NumArray[j] = tempVar;
					}
				}
			} while (czyZamiana);

			return NumArray;
		}

		public int[] selectSort(int[] NumArray)
		{
			int n = NumArray.Length;


			for (int i = 0; i < n - 1; i++)
			{
				int min_idx = i;
				for (int j = i + 1; j < n; j++)
					if (NumArray[j] < NumArray[min_idx])
						min_idx = j;

				int temp = NumArray[min_idx];
				NumArray[min_idx] = NumArray[i];
				NumArray[i] = temp;
			}

			return NumArray;
		}

		public static int[] stringToArray(string str)
		{
			var liczbyS = str.Trim().Split(' ');
			int[] numbers = new int[liczbyS.Length];
			for (int i = 0; i < liczbyS.Length; i++)
			{
				numbers[i] = int.Parse(liczbyS[i]);
			}
			return numbers;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}

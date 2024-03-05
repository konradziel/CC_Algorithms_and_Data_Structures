namespace selectSort
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btsStart_Click(object sender, EventArgs e)
		{
			string sizeInput = Microsoft.VisualBasic.Interaction.InputBox("Podaj rozmiar tablicy:", "WprowadŸ rozmiar", "0");

			if (int.TryParse(sizeInput, out int arraySize) && arraySize > 0)
			{

				int[] myArray = new int[arraySize];


				for (int i = 0; i < arraySize; i++)
				{
					string input = Microsoft.VisualBasic.Interaction.InputBox("Podaj element tablicy o indeksie " + i.ToString() + ":", "Wczytaj element", "0");
					if (int.TryParse(input, out int element))
					{
						myArray[i] = element;
					}
					else
					{
						MessageBox.Show("To nie jest liczba ca³kowita. WprowadŸ poprawn¹ liczbê.");
						i--;
					}
				}


				string arrayString = string.Join(", ", myArray);
				string arrayStringSorted = string.Join(", ", selectSort(myArray));
				MessageBox.Show("Wczytana tablica: " + arrayString +"\n" + "Wczytana tablica posortowana: " + arrayStringSorted);

			}
			else
			{
				MessageBox.Show("Podaj poprawny rozmiar tablicy (liczbê ca³kowit¹).");
			}



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

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}

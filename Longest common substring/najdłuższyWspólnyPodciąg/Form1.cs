namespace najdłuższyWspólnyPodciąg
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			char[] tabM = { 'A', 'B', 'A', 'A', 'B', 'B', 'A', 'A', 'A' };
			char[] tabN = { 'B', 'A', 'B', 'A', 'B' };

			int[,] tab = new int[tabN.GetLength(0) + 1, tabM.GetLength(0) + 1];

			for (int i = 1; i < tab.GetLength(0); i++)
			{
				for (int j = 1; j < tab.GetLength(1); j++)
				{
					if (tabN[i - 1] == tabM[j - 1])
					{
						tab[i, j] = tab[i - 1, j - 1] + 1;
					}
					else
					{
						tab[i, j] = Max(tab[i, j - 1], tab[i - 1, j]);
					}
				}
			}
		}

		int Max(int a, int b)
		{
			if (a >= b)
			{
				return a;
			}
			return b;
		}
	}
}
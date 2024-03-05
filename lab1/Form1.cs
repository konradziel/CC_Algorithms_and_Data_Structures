using System.Security.Policy;

namespace _04._10
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btsStart_Click(object sender, EventArgs e)
		{
			long intTemp = (long)nudNumberN.Value;
			MessageBox.Show(intTemp + " number of Fibonacci sequence is: " + fib2(intTemp));
		}

		int fib(int n)
		{
			if (n == 0)
				return 0;
			else if (n == 1)
				return 1;
			else
				return fib(n - 1) + fib(n - 2);
		}

		long fib2(long n)
		{
			if (n <= 0)
				return 0;

			if (n == 1)
				return 1;

			long[] tab = new long[n + 1];
			tab[1] = 1;

			for (int i = 2; i <= n; i++)
			{
				tab[i] = tab[i - 1] + tab[i - 2];
			}
			return tab[n];
		}

		private void Form1_Load(object sender, EventArgs e)
			{

			}
		}
	}

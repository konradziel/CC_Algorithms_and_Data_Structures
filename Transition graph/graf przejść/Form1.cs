using System.Text;

namespace graf_przejść
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Graf graf = new Graf();
			graf.Dodaj(3, 0, 1);
			graf.Dodaj(6, 0, 5);
			graf.Dodaj(3, 0, 4);
			graf.Dodaj(2, 4, 5);
			graf.Dodaj(1, 1, 2);
			graf.Dodaj(1, 2, 5);
			graf.Dodaj(4, 1, 3);
			graf.Dodaj(3, 2, 3);
			graf.Dodaj(1, 5, 3);

			graf.Dijkstra(0);
			MessageBox.Show(graf.DostańKomunikat());

			GrafZ grafZ = new GrafZ();
			grafZ.Dodaj(3, 0, 1);
			grafZ.Dodaj(6, 0, 5);
			grafZ.Dodaj(3, 0, 4);
			grafZ.Dodaj(2, 4, 5);
			grafZ.Dodaj(1, 1, 2);
			grafZ.Dodaj(1, 2, 5);
			grafZ.Dodaj(4, 1, 3);
			grafZ.Dodaj(3, 2, 3);
			grafZ.Dodaj(1, 5, 3);

			grafZ.Dijkstra(grafZ.DostańWęzeł(0));
			MessageBox.Show(grafZ.DostańKomunikat());
		}
	}	
}
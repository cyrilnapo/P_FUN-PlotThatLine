using ScottPlot;
using System.Globalization;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PlotThatLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] dataETH = File.ReadAllLines(@"C:\Users\pt63blc\Documents\GitHub\P_FUN-PlotThatLine\Data-eth\ethereum.csv");

            var dates = dataETH.Skip(1).Select(x => DateTime.Parse(x.Split(',')[0])).ToArray();
            var closes = dataETH.Skip(1).Select(x => double.Parse(x.Split(',')[4], CultureInfo.InvariantCulture)).ToArray();

            // importation des données dans le plotforms
            var scatter = viewData.Plot.AddScatter(dates.Select(x => x.ToOADate()).ToArray(), closes);
            

            viewData.Plot.XAxis.DateTimeFormat(true); //format des données de l'axe X

            //Personnalisation
            scatter.MarkerSize = 0; // taille des points
            scatter.Color = Color.Orange; //couleur du tracé
            scatter.Label = "Ethereum";
            viewData.Plot.Style(Style.Gray2);

            // titres
            viewData.Plot.Title("Prix de l'Ethereum");
            viewData.Plot.XLabel("Date");
            viewData.Plot.YLabel("Prix (USD)");
            viewData.Plot.Legend();


            viewData.Refresh();


        }

        private void viewData_Load(object sender, EventArgs e)
        {

        }
    }
}

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

            var datesETH = dataETH.Skip(1).Select(x => DateTime.Parse(x.Split(',')[0])).ToArray();
            var closesETH = dataETH.Skip(1).Select(x => double.Parse(x.Split(',')[4], CultureInfo.InvariantCulture)).ToArray();

            // importation des données dans le plotforms
            var ETHcurve = viewData.Plot.AddScatter(datesETH.Select(x => x.ToOADate()).ToArray(), closesETH);
            

            viewData.Plot.XAxis.DateTimeFormat(true); //format des données de l'axe X

            //Personnalisation
            ETHcurve.MarkerSize = 0; // taille des points
            ETHcurve.Color = Color.Orange; //couleur du tracé
            ETHcurve.Label = "Ethereum";
            viewData.Plot.Style(Style.Gray2); // style generale

            // titres
            viewData.Plot.Title("Prix de l'Ethereum");
            viewData.Plot.XLabel("Date");
            viewData.Plot.YLabel("Prix (USD)");
            viewData.Plot.Legend();


            viewData.Refresh();


        }

    }
}

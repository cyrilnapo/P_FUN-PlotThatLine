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
        private PlotManager statsManager;

        public Form1()
        {
            InitializeComponent();

            //init cadre de données
            statsManager = new PlotManager(viewData.Plot);

            // recupere données ethereum et bictoin
            var dataETH = CryptoData.LoadData(@"C:\Users\pt63blc\Documents\GitHub\P_FUN-PlotThatLine\Datas\ethereum.csv");
            var dataBTC = CryptoData.LoadData(@"C:\Users\pt63blc\Documents\GitHub\P_FUN-PlotThatLine\Datas\bitcoin.csv");

            // ajout des courbes au graphique
            statsManager.PlotData(dataETH, "Ethereum", System.Drawing.Color.Orange);
            statsManager.PlotData(dataBTC, "Bitcoin", System.Drawing.Color.DarkGreen);

            
            viewData.Refresh();


        }

        private void ethCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

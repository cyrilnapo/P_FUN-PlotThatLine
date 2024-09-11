using ScottPlot;
using System.Globalization;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ScottPlot.Plottable;

namespace PlotThatLine
{
    public partial class Form1 : Form
    {
        private PlotManager statsManager;
        private ScatterPlot ethCurve;
        private ScatterPlot btcCurve;
        private ScatterPlot avaxCurve;
        private ScatterPlot bnbCurve;
        private ScatterPlot xrpCurve;
        private ScatterPlot solCurve;


        public Form1()
        {
            InitializeComponent();

            statsManager = new PlotManager(viewData.Plot);

            // importe les donn�es
            var dataETH = CryptoData.LoadData(@"Datas\ethereum.csv");
            var dataBTC = CryptoData.LoadData(@"Datas\bitcoin.csv");
            var dataAVAX = CryptoData.LoadData(@"Datas\avalanche.csv");
            var dataBNB = CryptoData.LoadData(@"Datas\BNB.csv");
            var dataXRP = CryptoData.LoadData(@"Datas\XRP.csv");
            var dataSOL = CryptoData.LoadData(@"Datas\solana.csv");

            // ajoute les courbes
            ethCurve = statsManager.PlotData(dataETH, "Ethereum", Color.Orange);
            btcCurve = statsManager.PlotData(dataBTC, "Bitcoin", Color.IndianRed);
            avaxCurve = statsManager.PlotData(dataAVAX, "Avalanche", Color.BlueViolet);
            bnbCurve = statsManager.PlotData(dataBNB, "BNB", Color.GreenYellow);
            xrpCurve = statsManager.PlotData(dataXRP, "XRP", Color.MistyRose);
            solCurve = statsManager.PlotData(dataSOL, "Solana", Color.Red);

            viewData.Refresh();
        }

        private void ToggleCurveVisibility(CheckBox checkBox, ScatterPlot curve)
        {
            curve.IsVisible = checkBox.Checked;  // Modifie la visibilit� en fonction de l'�tat de la checkbox
            viewData.Refresh();  // Rafra�chir le graphique
        }


    }
}

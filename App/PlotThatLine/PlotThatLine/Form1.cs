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

            // importe les données
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
            xrpCurve = statsManager.PlotData(dataXRP, "XRP", Color.Green);
            solCurve = statsManager.PlotData(dataSOL, "Solana", Color.Blue);

            // lie toutes les checkboxs à la methode de visibilité
            ethCheck.CheckedChanged += (s, e) => ToggleCurveVisibility(ethCheck, ethCurve);
            btcCheck.CheckedChanged += (s, e) => ToggleCurveVisibility(btcCheck, btcCurve);
            avaxCheck.CheckedChanged += (s, e) => ToggleCurveVisibility(avaxCheck, avaxCurve);
            bnbCheck.CheckedChanged += (s, e) => ToggleCurveVisibility(bnbCheck, bnbCurve);
            xrpCheck.CheckedChanged += (s, e) => ToggleCurveVisibility(xrpCheck, xrpCurve);
            solCheck.CheckedChanged += (s, e) => ToggleCurveVisibility(solCheck, solCurve);

            viewData.Refresh();
        }

        private void ToggleCurveVisibility(CheckBox checkBox, ScatterPlot curve)
        {
            curve.IsVisible = checkBox.Checked;  // Modifie la visibilité en fonction de l'état de la checkbox
            viewData.Refresh();  // Rafraîchir le graphique
        }


    }
}

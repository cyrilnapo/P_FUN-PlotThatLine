﻿using ScottPlot;
using ScottPlot.Plottable;
using System;
using System.Drawing;

namespace PlotThatLine
{
    public class PlotManager
    {
        private readonly Plot plot;

        public PlotManager(Plot plot)
        {
            this.plot = plot;
            plot.XAxis.DateTimeFormat(true); // format des données de l'axe X
            plot.Style(Style.Gray2); // style général de cadre
            plot.Title("Prix des Cryptomonnaies");
            plot.XLabel("Date");
            plot.YLabel("Prix (USD)");
            plot.YAxis.SetBoundary(-.1);
            plot.YAxis.TickLabelFormat(a => $"{a}$");
        }
        /// <summary>
        /// Ajoute la courbe au graphique avec sa couleur son label et ses données
        /// </summary>
        /// <param name="data"></param>
        /// <param name="label"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public ScatterPlot PlotData(CryptoData data, string label, Color color)
        {
            var scatter = plot.AddScatter(data.Dates.Select(x => x.ToOADate()).ToArray(), data.Prices);
            scatter.MarkerSize = 0;
            scatter.Color = color;
            scatter.Label = label;
            plot.Legend().Location = Alignment.UpperLeft;
            return scatter;
        }
    }
}

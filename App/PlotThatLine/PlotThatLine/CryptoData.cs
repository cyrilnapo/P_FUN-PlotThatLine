using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotThatLine
{
    public class CryptoData
    {
        public DateTime[] Dates { get; private set; }
        public double[] Prices { get; private set; }

        public CryptoData(DateTime[] dates, double[] prices)
        {
            Dates = dates;
            Prices = prices;
        }
        /// <summary>
        /// Lit le fichier csv et sélectionne les données dont nous avons besoin
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static CryptoData LoadData(string filePath)
        {
            string[] data = File.ReadAllLines(filePath);

            var dates = data.Skip(1).Select(x => DateTime.Parse(x.Split(',')[0])).ToArray();
            var prices = data.Skip(1).Select(x => double.Parse(x.Split(',')[4])).ToArray();

            return new CryptoData(dates, prices);
        }
    }
}
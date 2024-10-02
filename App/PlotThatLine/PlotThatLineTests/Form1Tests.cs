using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlotThatLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotThatLine.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod]
        public void ClearBtn_ClickTest()
        {
            // Arrange
            var form = new Form1();
            form.ethCheck.Checked = true;
            form.btcCheck.Checked = true;

            // Act
            form.clearBtn_Click(null, null);

            // Assert
            Assert.IsFalse(form.ethCheck.Checked);
            Assert.IsFalse(form.btcCheck.Checked);
        }
    }
}
  using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace ConvertTemp
{
    [TestClass]
    public class ConvertTemp
    {
        [TestCategory("Temperature Conversion")]
        [TestMethod]
        
        public void C_To_F()
        {
            int num1 = 60;
            double conversion = num1 * 1.8 + 32;
            Assert.AreEqual(conversion, 140.0);
        }
        [TestMethod]
        public void F_To_C()
        {
            int num1 = 140;
            double conversion = num1 * 1.8 - 32;
            Assert.AreEqual(conversion,60.0,$"{conversion}");
        }
    }
}

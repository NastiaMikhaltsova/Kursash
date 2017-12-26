using Microsoft.VisualStudio.TestTools.UnitTesting;
using IceWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceWorld.Tests
{
    [TestClass()]
    public class KievFactoryTests
    {
        [TestMethod()]
        public void CreateIceTest()
        {
            KievFactory leo = new KievFactory();
            IIce max = leo.CreateIce();
            Assert.IsTrue(max is KievIce);
            Assert.IsTrue(max.Weight > 50 && max.Weight <= 500);
        }

        [TestMethod()]
        public void CreateCakeTest()
        {
            KievFactory leo = new KievFactory();
            ICake max = leo.CreateCake();
            Assert.IsTrue(leo is KievFactory);
            Assert.IsTrue(max.Weight > 800);
            Assert.IsTrue(max is KievCake);
            Assert.IsTrue(max.Diameter == 32);
            Assert.AreNotSame(leo, max);
        }
    }
}
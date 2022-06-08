using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer.Tests
{
    [TestClass]
    public class ShipTests
    {
        private Ship _ship;

        [TestInitialize]
        public void Setup()
        {
            _ship = new Ship();
            // arrange
            // act
            // assert
        }

        [TestMethod]
        public void Does_Ship_Have_Maximum_Amount_Of_Containers()
        {
            // arrange
            int a = _ship.Max_containers();
            // act
            // assert
            Assert.IsNotNull(_ship);
            Assert.AreEqual(a, 75);
        }
        [TestMethod]
        public void Does_Ship_Have_Correct_Maximum_Weight()
        {
            // arrange
            int h = _ship.Height;
            int wi = _ship.Width;
            int a = _ship.Max_weight(h, wi);
            // act
            // assert
            Assert.IsNotNull(_ship);
            Assert.AreEqual(a, 450000);
        }
    }
}

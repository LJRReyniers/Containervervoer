using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer.Tests
{
    [TestClass]
    public class PlaceTests
    {
        private Sort _sort;

        [TestInitialize]
        public void Setup()
        {
            _sort = new Sort();
            // arrange
            // act
            // assert
        }

        [TestMethod]
        public void Is_There_A_List_Of_Containers()
        {
            // arrange
            List<Container> list = new List<Container>();
            // act
            list = _sort.Layout();
            // assert
            Assert.IsNotNull(list);
        }
    }
}

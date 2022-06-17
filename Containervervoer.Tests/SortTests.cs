using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer.Tests
{
    [TestClass]
    public class SortTests
    {
        private Sort _sort;
        private Factory _factory;

        [TestInitialize]
        public void Setup()
        {
            _sort = new Sort();
            _factory = new Factory();
            // arrange
            // act
            // assert
        }

        [TestMethod]
        public void Does_List_In_Sort_Get_Filled_With_Containers()
        {
            // arrange
            _sort.Get_containers();
            List<Container> list = new List<Container>();
            // act
            list = _sort.Layout();
            // assert
            Assert.IsNotNull(list);
        }
        [TestMethod]
        public void Do_The_Containers_Get_Sorted()
        {
            // arrange
            List<Container> list = new List<Container>();
            // act
            list = _sort.Sort_containers();
            // assert
            Assert.IsNotNull(list);
        }
        [TestMethod]
        public void Do_The_Containers_Fit()
        {
            // arrange
            List<Container> list = new List<Container>();
            list = _sort.Get_containers();
            bool a = _sort.Get_fit();
            // act
            // assert
            Assert.AreEqual(a, true);
        }
    }
}

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
        private Container _container;
        private Ship _ship;

        [TestInitialize]
        public void Setup()
        {
            _sort = new Sort();
            _container = new Container();
            _ship = new Ship();
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
        [TestMethod]
        public void Is_First_Container_Type_1()
        {
            // arrange
            _container = new Container();
            _container.Type = 1;
            List<Container> list = new List<Container>();
            list = _sort.Containers(1);
            bool a = _sort.Cool(0);
            // act
            list.Clear();
            // assert
            Assert.IsNotNull(list);
            Assert.AreEqual(a, true);
        }
        [TestMethod]
        public void Is_First_Container_Type_2()
        {
            // arrange
            _container = new Container();
            _container.Type = 2;
            List<Container> list = new List<Container>();
            list = _sort.Containers(2);
            bool a = _sort.Normal(0);
            // act
            list.Clear();
            // assert
            Assert.IsNotNull(list);
            Assert.AreEqual(a, true);
        }
        [TestMethod]
        public void Is_First_Container_Type_3()
        {
            // arrange
            _container = new Container();
            _container.Type = 3;
            List<Container> list = new List<Container>();
            list = _sort.Containers(3);
            bool a = _sort.Valuable(0);
            // act
            list.Clear();
            // assert
            Assert.IsNotNull(list);
            Assert.AreEqual(a, true);
        }
        [TestMethod]
        public void Is_First_Container_Type_4()
        {
            // arrange
            _container = new Container();
            _container.Type = 4;
            List<Container> list = new List<Container>();
            list = _sort.Containers(4);
            bool a = _sort.Empty(0);
            // act
            list.Clear();
            // assert
            Assert.IsNotNull(list);
            Assert.AreEqual(a, true);
        }
        [TestMethod]
        public void Do_Rows_Still_Fit_On_Ship()
        {
            // arrange
            _ship.Length = 5;
            List<Row> rows = new List<Row>();
            bool a = _sort.Length();
            // act
            // assert
            Assert.AreEqual(a, true);
        }
        [TestMethod]
        public void Are_Rows_Set()
        {
            //arrange
            List<Container> containers = new List<Container>();
            _sort.Set_row();
            // act
            // assert
            Assert.IsNotNull(containers);
        }
        [TestMethod]
        public void Is_Visualise_Ship_True()
        {
            //arrange
            List<Container> containers = new List<Container>();
            var z = _sort.Containers(3);
            _container = new Container();
            _container.Type = 3;
            containers.Add(_container);
            _sort.Check();
            bool a = _sort.Visualise_ship;
            // act
            // assert
            Assert.IsNotNull(containers);
            Assert.AreEqual(a, true);

            // test fails omdat Check() en Set_row() elkaar in een loop aanroepen, zonder bij visualise_ship te komen
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Containervervoer.Tests
{
    [TestClass]
    public class ContainerTests
    {
        private Container _container;
        private Factory _factory;

        [TestInitialize]
        public void Setup()
        {
            _container = new Container();
            _factory = new Factory();
            // arrange
            // act
            // assert
        }

        [TestMethod]
        public void Does_Container_Have_Correct_Weight()
        {
            // arrange
            _container = _factory.Get_random_container();
            int a = _container.Get_weight();
            // act

            // assert
            Assert.IsNotNull(_container);
            Assert.AreEqual(4000, a);
        }
        [TestMethod]
        public void Does_Container_Have_A_Type()
        {
            // arrange
            _container = _factory.Get_random_container();
            int a = _container.Get_type();
            // act

            // assert
            Assert.IsNotNull(_container);
            Assert.AreEqual(a, _container.Type);
        }
    }
}

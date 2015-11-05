using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mappings;

namespace MappingsTests
{
    [TestClass]
    public class RepositoryTests
    {

        Repository _repo;

        [TestInitialize]
        public void startup()
        {
            _repo = new Repository(3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativePositionThrows()
        {
            _repo.add_item(-1, 10, true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PositionGreaterThanSizeThrows()
        {
            _repo.add_item(1000, 10, true);
        }

        [TestMethod]
        public void AddingValidItemReturnsTrue()
        {
            _repo.add_item(2, 10, false);
        }
        [TestMethod]
        public void AddingToOccupiedSpaceWithoutOverwriteReturnsFalse()
        {
            _repo.add_item(2, 10, false);
            _repo.add_item(2, 12, false);
        }

        [TestMethod]
        public void AddingToOccupiedSpaceWithOverwriteReturnsTrue()
        {
            _repo.add_item(2, 10, false);
            _repo.add_item(2, 12, true);
        }

    }
}

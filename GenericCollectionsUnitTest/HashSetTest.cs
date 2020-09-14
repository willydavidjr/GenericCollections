using System;
using System.Collections.Generic;
using GenericCollections;
using GenericCollections.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericCollections.Test
{
    [TestClass]
    public class HashSetTest
    {
        [TestMethod]
        public void UniqueSets()
        {
            //Arrange
            HashSet<int> hashSetOfInts = new HashSet<int>();
            hashSetOfInts.Add(1);
            hashSetOfInts.Add(2);

            //Act
            hashSetOfInts.Add(2);

            //Assert
            Assert.AreEqual(hashSetOfInts.Count, 2);
        }

        [TestMethod]
        public void ReferenceSets()
        {
            //Arrange
            HashSet<Person> hashSetPersons = new HashSet<Person>(new PersonComparer());
            hashSetPersons.Add(new Person()
            {
                Id = 1,
                Firstname = "John",
                Lastname = "Smith"
            });

            //Act
            hashSetPersons.Add(new Person()
            {
                Id = 1,
                Firstname = "John",
                Lastname = "Smith"
            });

            //Assert
            Assert.AreEqual(hashSetPersons.Count, 1);
        }
    }
}

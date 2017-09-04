#region Usings

using System;
using NUnit.Framework;
using TreeData.Capabilities;

#endregion

namespace TreeDataTests.Capabilities
{
    [TestFixture]
    public class CapabilitiesTests
    {
        [Test]
        public void TestAddCapability()
        {
            var collection = new CapabilitiesCollection();
            const string shapeId = "shape";
            var conceptBuilder = collection.AddConcept(shapeId);
            Assert.IsTrue(collection.HasConcept(shapeId));
            var sameConceptBuilder = collection.GetConcept(shapeId);
            Assert.IsTrue(conceptBuilder.Node == sameConceptBuilder.Node);
        }

        [Test]
        public void TestConceptBuilder()
        {
            var collection = new CapabilitiesCollection();
            const string shapeId = "shape";
            const string circleId = "circle";
            var shapeConcept = collection.AddConcept(shapeId);
            shapeConcept.SetCapability("Color", "Red");
            var circleConcept = collection.AddConcept(circleId);
            collection.AddRelation(circleId, shapeId);

            Assert.IsTrue(circleConcept.HasCapability("Color"));
            Assert.IsTrue(circleConcept.IsRelatedWith(shapeId));
            Assert.IsTrue(circleConcept.GetRelatedConcept(shapeId).Node == shapeConcept.Node);

            circleConcept.AddBlacklistedCapability("Color");
            Assert.IsFalse(circleConcept.HasCapability("Color"));
            Assert.IsTrue(circleConcept.GetCapability("Color") == String.Empty);

            circleConcept.RemoveBlackistedCapability("Color");
            Assert.IsTrue(circleConcept.HasCapability("Color"));
            Assert.IsTrue(circleConcept.GetCapability("Color") != String.Empty);
        }

        [Test]
        public void TestRelateCapability()
        {
            var collection = new CapabilitiesCollection();
            const string shapeId = "shape";
            const string tranId = "transform";
            var shapeConcept = collection.AddConcept(shapeId);
            shapeConcept.SetCapability("Color", "Red");
            var tranConcept = collection.AddConcept(tranId);
            collection.AddRelation(tranId, shapeId);
            var colorValue = tranConcept.GetCapability("Color");
            Assert.IsTrue(tranConcept.HasCapability("Color"));
            Assert.AreEqual(colorValue, "Red");
            Assert.IsTrue(tranConcept.IsRelatedWith(shapeId));
        }
    }
}
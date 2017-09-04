#region Usings

using System.IO;
using NUnit.Framework;
using PartModellingLogic;
using TreeData.Capabilities;

#endregion

namespace TreeDataTests.Capabilities
{
    [TestFixture]
    public class CapabilitiesDslTests
    {
        #region Setup/Teardown

        [SetUp]
        public void Setup()
        {
            DefaultInterpreters.Setup();
        }

        #endregion

        [Test]
        public void CapabilityExportEmptyConcept()
        {
            var collection = new CapabilitiesCollection();
            collection.AddConcept("Empty concept");

            const string documentName = "emtpy.xmlcaps";
            const string capsFileName = "out.caps";

            collection.SaveAsDocument(documentName);
            CapabilitiesDocumentImporter.LoadFileCapabilities(documentName, capsFileName);
            var exists = File.Exists(capsFileName);
            Assert.IsTrue(exists);
        }

        [Test]
        public void CapabilityExportRelatedConcept()
        {
            var collection = new CapabilitiesCollection();
            const string conceptName = "concept";
            const string relatedConcept = "related";
            const string relatedConcept2 = "related2";
            const string relatedConcept3 = "related3";
            var concept = collection.AddConcept(conceptName);
            var related = collection.AddConcept(relatedConcept);
            concept.AddRelatedConcept(related);
            collection.AddRelation(conceptName, relatedConcept2);
            collection.AddRelation(conceptName, relatedConcept3);

            concept.SetCapability("Color", "Red");
            related.SetCapability("Icon", "image.png");

            concept.AddBlacklistedCapability("Icon");

            const string documentName = "related.xmlcaps";
            const string capsFileName = "related.caps";

            collection.SaveAsDocument(documentName);
            CapabilitiesDocumentImporter.LoadFileCapabilities(documentName, capsFileName);
            var exists = File.Exists(capsFileName);
            Assert.IsTrue(exists);
            collection = CapabilitiesLoader.LoadFileCapabilities(capsFileName);

            Assert.IsTrue(collection.HasConcept("concept"));
        }
    }
}
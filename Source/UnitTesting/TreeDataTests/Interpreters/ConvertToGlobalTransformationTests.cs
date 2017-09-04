#region Usings

using System;
using NaroCppCore.Occ.gp;
using NUnit.Framework;

using TreeData.AttributeInterpreter;
using NaroCppCore.Occ.Precision;

#endregion

namespace TreeDataTests.Interpreters
{
    [TestFixture]
    internal class ConvertToGlobalTransformationTests
    {
        private readonly double _angularPrecision = Precision.Angular;
        private readonly double _distancePrecision = Precision.Confusion;

        [Test]
        public void TestRotate()
        {
            var customAxisSystem = new gpTrsf();
            customAxisSystem.SetValues(0, -1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, _angularPrecision, _distancePrecision);
            var aShapesTransformation = new gpTrsf();
            aShapesTransformation.SetValues(1, 0, 0, 10, 0, 1, 0, 0, 0, 0, 1, 0, _angularPrecision, _distancePrecision);
            var globalSystemtransformation = TransformationInterpreter.ConvertToGlobalTransformation(customAxisSystem,
                                                                                                 aShapesTransformation);

            Assert.IsTrue(Math.Abs(1 - globalSystemtransformation.Value(1, 1)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(1, 2)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(1, 3)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(1, 4)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(2, 1)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(1 - globalSystemtransformation.Value(2, 2)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(2, 3)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(10 - globalSystemtransformation.Value(2, 4)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(3, 1)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(3, 2)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(1 - globalSystemtransformation.Value(3, 3)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(3, 4)) < 0.1, "incorrect transformation");
        }

        [Test]
        public void TestRotateAndTranslate()
        {
            var customAxisSystem = new gpTrsf();
            customAxisSystem.SetValues(0, -1, 0, 10, 1, 0, 0, 10, 0, 0, 1, 10, _angularPrecision, _distancePrecision);
            var aShapesTransformation = new gpTrsf();
            aShapesTransformation.SetValues(1, 0, 0, 3, 0, 1, 0, 3, 0, 0, 1, 0, _angularPrecision, _distancePrecision);
            var globalSystemtransformation =TransformationInterpreter.ConvertToGlobalTransformation(customAxisSystem,
                                                                                                 aShapesTransformation);

            Assert.IsTrue(Math.Abs(1 - globalSystemtransformation.Value(1, 1)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(1, 2)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(1, 3)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(7 - globalSystemtransformation.Value(1, 4)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(2, 1)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(1 - globalSystemtransformation.Value(2, 2)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(2, 3)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(13 - globalSystemtransformation.Value(2, 4)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(3, 1)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(3, 2)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(1 - globalSystemtransformation.Value(3, 3)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(10 - globalSystemtransformation.Value(3, 4)) < 0.1, "incorrect transformation");
        }

        [Test]
        public void TestTranslate()
        {
            var customAxisSystem = new gpTrsf();
            customAxisSystem.SetValues(1, 0, 0, 10, 0, 1, 0, 10, 0, 0, 1, 10, _angularPrecision, _distancePrecision);
            var aShapesTransformation = new gpTrsf();
            aShapesTransformation.SetValues(1, 0, 0, 10, 0, 1, 0, 10, 0, 0, 1, 10, _angularPrecision, _distancePrecision);
            var globalSystemtransformation = TransformationInterpreter.ConvertToGlobalTransformation(customAxisSystem,
                                                                                                 aShapesTransformation);

            Assert.IsTrue(Math.Abs(1 - globalSystemtransformation.Value(1, 1)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(1, 2)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(1, 3)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(20 - globalSystemtransformation.Value(1, 4)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(2, 1)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(1 - globalSystemtransformation.Value(2, 2)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(2, 3)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(20 - globalSystemtransformation.Value(2, 4)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(3, 1)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(0 - globalSystemtransformation.Value(3, 2)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(1 - globalSystemtransformation.Value(3, 3)) < 0.1, "incorrect transformation");
            Assert.IsTrue(Math.Abs(20 - globalSystemtransformation.Value(3, 4)) < 0.1, "incorrect transformation");
        }
    }
}
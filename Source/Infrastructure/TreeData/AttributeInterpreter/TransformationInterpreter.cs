#region Usings

using System;
using System.Collections.Generic;
using System.Windows.Media.Media3D;
using NaroCppCore.Occ.gce;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.GeomAPI;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Precision;

using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace TreeData.AttributeInterpreter
{
    public class TransformationInterpreter : AttributeInterpreterBase
    {
        #region Data

        private const string Matr = "Matrix";
        private const string PivotString = "Pivot";
        private static readonly Vector3D AxisX = new Vector3D(1, 0, 0);
        private static readonly Vector3D AxisY = new Vector3D(0, 1, 0);
        private static readonly Vector3D AxisZ = new Vector3D(0, 0, 1);
        private gpTrsf _currTransform;
        private Point3D _pivot;

        #endregion

        #region Constructors

        public TransformationInterpreter()
        {
            _currTransform = new gpTrsf();
        }

        #endregion


        #region Properties

        private static readonly double _angularPrecision = Precision.Angular;
        private static readonly double _distancePrecision = Precision.Confusion;

        public static List<TransformationInfo> Transformations = new List<TransformationInfo>(); 

        public gpTrsf CurrTransform
        {
            get { return _currTransform; }
            set { _currTransform = value; }
        }

        public Point3D ShapeOrigin
        {
            get
            {
                var origin = new gpPnt();
                origin.Transform(_currTransform);
                return new Point3D(origin);
            }
        }

        public gpPnt Pivot
        {
            get { return _pivot.GpPnt; }
            set
            {
                _pivot = new Point3D(value);
                OnModified();
            }
        }

        public gpPnt Translate
        {
            get { return ShapeOrigin.GpPnt; }
            set
            {
                var translateValue = new Point3D(value);
                TranslateWith(translateValue.SubstractCoordinate(ShapeOrigin));
                OnModified();
            }
        }

        public gpPnt Rotate
        {
            set
            {
                GeneralRotation(AxisX, value.X);
                GeneralRotation(AxisY, value.Y);
                GeneralRotation(AxisZ, value.Z);

                OnModified();
            }
        }

        public double Scale
        {
            get { return 1; }
            set
            {
                GeneralScale(new Vector3D(value, value, value));

                OnModified();
            }
        }

        public void ResetPivot()
        {
            _pivot = ShapeOrigin;
        }

        public void TranslateWith(Point3D translateValue)
        {
            _currTransform.SetValues(
                _currTransform.Value(1, 1), _currTransform.Value(1, 2), _currTransform.Value(1, 3),
                _currTransform.Value(1, 4) + translateValue.X,
                _currTransform.Value(2, 1), _currTransform.Value(2, 2), _currTransform.Value(2, 3),
                _currTransform.Value(2, 4) + translateValue.Y,
                _currTransform.Value(3, 1), _currTransform.Value(3, 2), _currTransform.Value(3, 3),
                _currTransform.Value(3, 4) + translateValue.Z,
                _angularPrecision, _distancePrecision
                );
            _pivot = _pivot.AddCoordinate(translateValue);
        }

        private void ApplyMatrix(gpTrsf matrix)
        {
            _currTransform.Multiply(matrix);
        }

        private Matrix3D ExchangeRotationValues(Matrix3D matrix3D)
        {
            var result = matrix3D;
            result.M11 = _currTransform.Value(1, 1);
            result.M12 = _currTransform.Value(2, 1);
            result.M13 = _currTransform.Value(3, 1);
            result.M21 = _currTransform.Value(1, 2);
            result.M22 = _currTransform.Value(2, 2);
            result.M23 = _currTransform.Value(3, 2);
            result.M31 = _currTransform.Value(1, 3);
            result.M32 = _currTransform.Value(2, 3);
            result.M33 = _currTransform.Value(3, 3);
            return result;
        }

        private Matrix3D ExchangeTranslationValues(Matrix3D matrix3D)
        {
            var result = matrix3D;
            result.OffsetX = _currTransform.Value(1, 4);
            result.OffsetY = _currTransform.Value(2, 4);
            result.OffsetZ = _currTransform.Value(3, 4);
            return result;
        }

        private Matrix3D ConvertRotationFromgpTrsfToMatrix3D()
        {
            var matrix3D = Matrix3D.Identity;
            matrix3D = ExchangeRotationValues(matrix3D);
            return matrix3D;
        }

        private Matrix3D ConvertgpTrsfToMatrix3DTransform()
        {
            var matrix3D = Matrix3D.Identity;
            matrix3D = ExchangeRotationValues(matrix3D);
            matrix3D = ExchangeTranslationValues(matrix3D);
            return matrix3D;
        }

        private Vector3D ConvertTranslateFromgpTrsfToVector3D()
        {
            var vector3D = new Vector3D
                               {
                                   X = _currTransform.Value(0 + 1, 3 + 1),
                                   Y = _currTransform.Value(1 + 1, 3 + 1),
                                   Z = _currTransform.Value(2 + 1, 3 + 1)
                               };
            return vector3D;
        }

        private Vector3D ConvertPivotFromPoint3DToVector3D()
        {
            var vector3D = new Vector3D {X = _pivot.X, Y = _pivot.Y, Z = _pivot.Z};
            return vector3D;
        }

        public void RotateAroundAxis(gpAx1 axis, double angle)
        {
            GeneralRotationWithoutPivot(axis, angle);
            OnModified();
        }

        private void SetRotationValuesWithoutPivot(Matrix3D transformation, Point3D finalTranslationPoint,
                                                   Point3D finalPivotPoint)
        {
            _currTransform.SetValues(
                transformation.M11, transformation.M21, transformation.M31, finalTranslationPoint.X,
                transformation.M12, transformation.M22, transformation.M32, finalTranslationPoint.Y,
                transformation.M13, transformation.M23, transformation.M33, finalTranslationPoint.Z,
                _angularPrecision, _distancePrecision
                );
            _pivot.X = finalPivotPoint.X;
            _pivot.Y = finalPivotPoint.Y;
            _pivot.Z = finalPivotPoint.Z;
        }

        public static Point3D? ProjectPointOnLine(Point3D firstLinePoint, gpDir lineDirection, Point3D pointToProject)
        {
            // Make a parallel line with this line starting from the initial point
            var projectionLine = new gceMakeLin(firstLinePoint.GpPnt, lineDirection).Value;
            var geomLine = new GeomLine(projectionLine);
            var projectionPoint = new GeomAPIProjectPointOnCurve(pointToProject.GpPnt, geomLine);
            if (projectionPoint.NbPoints > 0)
            {
                return new Point3D(projectionPoint.NearestPoint);
            }

            return null;
        }

        private Point3D RotateAroundAxis(gpAx1 axis, Point3D basePoint, Quaternion quaternion)
        {
            var projectionPoint = ProjectPointOnLine(new Point3D(axis.Location), axis.Direction, basePoint);
            var translationTransformation = ConvertRotationFromgpTrsfToMatrix3D();
            var translationVector = new Vector3D(basePoint.X - projectionPoint.Value.X,
                                                 basePoint.Y - projectionPoint.Value.Y,
                                                 basePoint.Z - projectionPoint.Value.Z);
            translationTransformation.Translate(translationVector);
            translationTransformation.Rotate(quaternion);
            return new Point3D(translationTransformation.OffsetX + projectionPoint.Value.X,
                               translationTransformation.OffsetY + projectionPoint.Value.Y,
                               translationTransformation.OffsetZ + projectionPoint.Value.Z);
        }

        private void GeneralRotationWithoutPivot(gpAx1 axis, double angle)
        {
            var transformation = ConvertgpTrsfToMatrix3DTransform();
            var quaternion = new Quaternion(ShapeUtils.AxisToVector(axis), angle);
            transformation.Rotate(quaternion);

            var baseTranslationPoint = new Point3D(_currTransform.Value(1, 4), _currTransform.Value(2, 4),
                                                   _currTransform.Value(3, 4));
            var finalTranslationPoint = RotateAroundAxis(axis, baseTranslationPoint, quaternion);

            var basePivotPoint = new Point3D(_pivot.X, _pivot.Y, _pivot.Z);
            var finalPivotPoint = RotateAroundAxis(axis, basePivotPoint, quaternion);

            SetRotationValuesWithoutPivot(transformation, finalTranslationPoint, finalPivotPoint);
        }

        private void GeneralRotation(Vector3D axis, double angle)
        {
            var translationTransformation = ConvertRotationFromgpTrsfToMatrix3D();
            var difference = Vector3D.Subtract(ConvertPivotFromPoint3DToVector3D(),
                                               ConvertTranslateFromgpTrsfToVector3D());
            translationTransformation.Translate(difference);

            var quaternion = new Quaternion(axis, angle);
            var rotationTransformation = ConvertRotationFromgpTrsfToMatrix3D();
            rotationTransformation.Rotate(quaternion);
            translationTransformation.Rotate(quaternion);

            SetRotationValues(rotationTransformation, translationTransformation);
        }

        public void ApplyTranslateWith(Point3D translateValue)
        {
            TranslateWith(translateValue);
            OnModified();
        }

        public void ApplyGeneralCircularPattern(gpAx1 axis, double angle, double heigth)
        {
            GeneralRotationWithoutPivot(axis, angle);
            var transformation = ConvertgpTrsfToMatrix3DTransform();
            var heightToAdd = new gpVec(axis.Direction);
            heightToAdd.Normalize();
            heightToAdd.Multiply(heigth);
            SetTranslationValuesAndPivot(ref transformation,
                                         new Vector3D(heightToAdd.X, heightToAdd.Y, heightToAdd.Z));
            OnModified();
        }

        public void ApplyGeneralArrayPattern(gpAx1 rowAxis, gpAx1 colomnAxis, double rowLength,
                                             double colomnLength)
        {
            var transformation = ConvertgpTrsfToMatrix3DTransform();
            var rowLengthToAdd = new gpVec(rowAxis.Direction);
            rowLengthToAdd.Normalize();
            rowLengthToAdd.Multiply(rowLength);
            SetTranslationValuesAndPivot(ref transformation,
                                         new Vector3D(rowLengthToAdd.X, rowLengthToAdd.Y, rowLengthToAdd.Z));
            var colomnLengthToAdd = new gpVec(colomnAxis.Direction);
            colomnLengthToAdd.Normalize();
            colomnLengthToAdd.Multiply(colomnLength);
            SetTranslationValuesAndPivot(ref transformation,
                                         new Vector3D(colomnLengthToAdd.X, colomnLengthToAdd.Y,
                                                      colomnLengthToAdd.Z));
            OnModified();
        }

        private void SetTranslationValuesAndPivot(ref Matrix3D currentTransformation, Vector3D translationVector)
        {
            currentTransformation.Translate(translationVector);
            SetTranslationValues(currentTransformation);
            AddVectorToPivot(translationVector);
        }

        private void SetTranslationValues(Matrix3D rotationMatrix)
        {
            _currTransform.SetValues(
                _currTransform.Value(1, 1), _currTransform.Value(1, 2), _currTransform.Value(1, 3),
                rotationMatrix.OffsetX,
                _currTransform.Value(2, 1), _currTransform.Value(2, 2), _currTransform.Value(2, 3),
                rotationMatrix.OffsetY,
                _currTransform.Value(3, 1), _currTransform.Value(3, 2), _currTransform.Value(3, 3),
                rotationMatrix.OffsetZ,
                _angularPrecision, _distancePrecision
                );
        }

        private void SetRotationValues(Matrix3D rotationMatrix, Matrix3D translationvector)
        {
            _currTransform.SetValues(
                rotationMatrix.M11, rotationMatrix.M21, rotationMatrix.M31,
                _currTransform.Value(1, 4) + (_pivot.X - _currTransform.Value(0 + 1, 3 + 1) - translationvector.OffsetX),
                rotationMatrix.M12, rotationMatrix.M22, rotationMatrix.M32,
                _currTransform.Value(2, 4) + (_pivot.Y - _currTransform.Value(1 + 1, 3 + 1) - translationvector.OffsetY),
                rotationMatrix.M13, rotationMatrix.M23, rotationMatrix.M33,
                _currTransform.Value(3, 4) + (_pivot.Z - _currTransform.Value(2 + 1, 3 + 1) - translationvector.OffsetZ),
                _angularPrecision, _distancePrecision
                );
        }

        private void AddVectorToPivot(Vector3D vector)
        {
            _pivot.X += vector.X;
            _pivot.Y += vector.Y;
            _pivot.Z += vector.Z;
        }

        private void GeneralScale(Vector3D value)
        {
            var rotationTransformation = ConvertRotationFromgpTrsfToMatrix3D();
            var difference = Vector3D.Subtract(ConvertPivotFromPoint3DToVector3D(),
                                               ConvertTranslateFromgpTrsfToVector3D());
            rotationTransformation.Scale(value);
            difference = MultiplyVector3D(difference, value);
            SetScaleValues(rotationTransformation, difference);
        }

        private void SetScaleValues(Matrix3D rotationMatrix, Vector3D pivot)
        {
            _currTransform.SetValues(
                rotationMatrix.M11, rotationMatrix.M21, rotationMatrix.M31, _currTransform.Value(1, 4),
                rotationMatrix.M12, rotationMatrix.M22, rotationMatrix.M32, _currTransform.Value(2, 4),
                rotationMatrix.M13, rotationMatrix.M23, rotationMatrix.M33, _currTransform.Value(3, 4),
                _angularPrecision, _distancePrecision
                );
            _pivot.X = _currTransform.Value(1, 4) + pivot.X;
            _pivot.Y = _currTransform.Value(2, 4) + pivot.Y;
            _pivot.Z = _currTransform.Value(3, 4) + pivot.Z;
        }

        public static Vector3D MultiplyVector3D(Vector3D firstVector, Vector3D secondVector)
        {
            var result = new Vector3D
                             {
                                 X = firstVector.X*secondVector.X,
                                 Y = firstVector.Y*secondVector.Y,
                                 Z = firstVector.Z*secondVector.Z
                             };
            return result;
        }

        public static gpTrsf ConvertCoordinatesToGlobalTransformation(gpTrsf currentAxisSystem, double X, double Y,
                                                                         double Z)
        {
            var currentTransformation = new gpTrsf();
            currentTransformation.SetValues(1, 0, 0, X, 0, 1, 0, Y, 0, 0, 1, Z, _angularPrecision, _distancePrecision);
            return ConvertToGlobalTransformation(currentAxisSystem, currentTransformation);
        }

        public static gpTrsf ConvertToGlobalTransformation(gpTrsf currentAxisSystem,
                                                              gpTrsf currentTransformation)
        {
            var transformedCoordinates = new gpTrsf();
            transformedCoordinates = currentAxisSystem;
            transformedCoordinates.Multiply(currentTransformation);
            transformedCoordinates.SetValues(
                1, 0, 0, transformedCoordinates.Value(1, 4),
                0, 1, 0, transformedCoordinates.Value(2, 4),
                0, 0, 1, transformedCoordinates.Value(3, 4),
                _angularPrecision, _distancePrecision
                );
            return transformedCoordinates;
        }

        #endregion

        #region Methods

        public string Description
        {
            get { return AttributeData.DoubleArrayToString(MatrixToList(_currTransform)); }
        }

        public void Reset()
        {
            _currTransform = new gpTrsf();
            _pivot = new Point3D();
            OnModified();
        }

        private static gpTrsf GetScaleTrsf(double scaleFactor)
        {
            var scaleTrsf = new gpTrsf {ScaleFactor = scaleFactor};
            return scaleTrsf;
        }

        private static double[] MatrixToList(gpTrsf aTrans)
        {
            var tranformData = new double[16];

            for (var i = 1; i <= 3; i++)
                for (var j = 1; j <= 4; j++)
                    tranformData[(i - 1)*4 + (j - 1)] = aTrans.Value(i, j);
            return tranformData;
        }

        private static void ApplyMatrixString(gpTrsf aTrans, IList<double> values)
        {
            aTrans.SetValues(
                values[0], values[1], values[2], values[3],
                values[4], values[5], values[6], values[7],
                values[8], values[9], values[10], values[11],
                Precision.Angular, Precision.Confusion);
        }

        private static double DegreesToRadians(double angleInDegrees)
        {
            return angleInDegrees/180.0*Math.PI;
        }

        public static gpTrsf GetRotateTrsf(Point3D rotateAngle)
        {
            var angle = DegreesToRadians(rotateAngle.X);
            var rotateXTrsf = GetRotateXTrsf(angle);
            angle = DegreesToRadians(rotateAngle.Y);
            var rotateYTrsf = GetRotateYTrsf(angle);
            angle = DegreesToRadians(rotateAngle.Z);
            var rotateZTrsf = GetRotateZTrsf(angle);

            var rotateTrsf = new gpTrsf();
            rotateTrsf.Multiply(rotateZTrsf);
            rotateTrsf.Multiply(rotateYTrsf);
            rotateTrsf.Multiply(rotateXTrsf);
            return rotateTrsf;
        }

        private static gpTrsf GetRotateZTrsf(double angle)
        {
            var rotateZTrsf = new gpTrsf();
            rotateZTrsf.SetRotation(gp.OZ, angle);
            return rotateZTrsf;
        }

        private static gpTrsf GetRotateYTrsf(double angle)
        {
            var rotateYTrsf = new gpTrsf();
            rotateYTrsf.SetRotation(gp.OY, angle);
            return rotateYTrsf;
        }

        private static gpTrsf GetRotateXTrsf(double angle)
        {
            var rotateXTrsf = new gpTrsf();
            rotateXTrsf.SetRotation(gp.OX, angle);
            return rotateXTrsf;
        }

        public override void Serialize(AttributeData data)
        {
            data.WriteAttribute(PivotString, Pivot);
            data.WriteAttribute(Matr, MatrixToList(_currTransform));
        }

        public override void Deserialize(AttributeData data)
        {
            Pivot = data.ReadAttributePoint3D(PivotString).GpPnt;

            var values = data.ReadAttributeListDouble(Matr);

            ApplyMatrixString(_currTransform, values);
            OnModified();
        }

        private static gpTrsf GetTranslateTrsf(Point3D transformedPosition)
        {
            var translateTrsf = new gpTrsf();
            translateTrsf.SetTranslation(new gpVec(transformedPosition.X, transformedPosition.Y,
                                                      transformedPosition.Z));
            return translateTrsf;
        }

        #endregion
    }

    public class TransformationInfo
    {
        public int TrsfIndex;
        public int SketchIndex;
        public gpTrsf Transformation;
        public int RefSketchIndex;

        public static int maxTrsfIndex;
    }
}
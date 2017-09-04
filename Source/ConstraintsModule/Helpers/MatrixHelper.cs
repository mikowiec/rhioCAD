#region Usings

using System;
using System.Collections.Generic;
using ConstraintsModule.Primitives;

//using Naro.Infrastructure.Interface.GeomHelpers;
//using NaroCAD.SolverModule.Interface.Geometry;
//using OccCode;
//using OCNaroWrappers;
//using TreeData.AttributeInterpreter;

#endregion

namespace ConstraintsModule.Helpers
{
    public class Matrix
    {
        private double[][] matrix;
        private int rowCount;
        private int colCount;

        public int RowCount
        {
            get { return rowCount; }
        }

        public int ColCount
        {
            get { return colCount; }
        }

        public Matrix(int rowsCount, int columnsCount)
        {
            rowCount = rowsCount;
            colCount = columnsCount;
            matrix = new double[rowsCount][];
            for (int i = 0; i < rowsCount; i++)
            {
                matrix[i] = new double[columnsCount];
            }
        }

        public Matrix(Matrix B)
            : this(B.rowCount, B.colCount)
        {
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    matrix[i][j] = B.matrix[i][j];
                }
            }
        }

        public Matrix(int rowsCount, int columnsCount, int value)
            : this(rowsCount, columnsCount)
        {
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    matrix[i][j] = value;
                }
            }
        }

        public double this[int row, int col]
        {
            get { return matrix[row][col]; }
            set { matrix[row][col] = value; }
        }


        public void Set(int row, int column, double value)
        {
            matrix[row][column] = value;
        }

        public double Norm()
        {
            var sum = 0.0;
            for(int i=0;i<rowCount;i++)
            {
                for(int j=0;j<colCount;j++)
                {
                    sum += matrix[i][j]*matrix[i][j];
                }
            }
            return Math.Sqrt(sum);
        }

        public Matrix Transpose()
        {
            var transposedMatrix = new Matrix(colCount, rowCount);
            for (int i = 0; i < colCount; i++)
            {
                for (int j = 0; j < rowCount; j++)
                {
                    transposedMatrix.matrix[i][j] = matrix[j][i];
                }
            }
            return transposedMatrix;
        }

        public static Matrix operator +(Matrix l, Matrix r)
        {
            if(l.rowCount != r.rowCount || l.colCount!= r.colCount)
                throw new Exception("Can't add matrices if they don't have the same dimension!");
            var result = new Matrix(l.rowCount, l.colCount);
            for (int i = 0; i < l.rowCount;i++ )
            {
                for (int j = 0; j < l.colCount; j++)
                    result[i, j] = l.matrix[i][j] + r.matrix[i][j];
            }
                return result;
        }

        public static Matrix operator -(Matrix l, Matrix r)
        {
            if (l.rowCount != r.rowCount || l.colCount != r.colCount)
                throw new Exception("Can't substract matrices if they don't have the same dimension!");
            var result = new Matrix(l.rowCount, l.colCount);
            for (int i = 0; i < l.rowCount; i++)
            {
                for (int j = 0; j < l.colCount; j++)
                    result[i,j]= l.matrix[i][j] - r.matrix[i][j];
            }
            return result;
        }

        public static Matrix operator *(Matrix l, Matrix r)
        {
            if (l.colCount != r.rowCount)
                throw new Exception("Can't multiply matrices if they don't have the correct dimensions!");
        
			Matrix C = new Matrix(l.rowCount, r.colCount);

            for (int i = 0; i < l.rowCount; i++)
            {
                for (int j = 0; j < r.colCount; j++)
                {
                    C.matrix[i][j] = 0;
                    for (int k = 0; k < l.colCount; k++)
                    {
                        C.matrix[i][j] += l.matrix[i][k]*r.matrix[k][j];
                    }
                }
            }
            return C;
        }

        
        public static Matrix Identity(int rowCount, int colCount)
        {
            var A = new Matrix(rowCount, colCount);
            
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    A.matrix[i][j] = (i == j ? 1.0 : 0.0);
                }
            }
            return A;
        }		

        public static Matrix operator *(Matrix l, double val)
        {
           
            Matrix C = new Matrix(l.rowCount, l.colCount);

            for (int i = 0; i < l.colCount; i++)
            {
                for (int j = 0; j < l.rowCount; j++)
                {
                    C.matrix[i][j] = l.matrix[i][j] * val;
                }
            }
            return C;
        }

        public Matrix(double[] vals, int m)
		{
			this.rowCount = m;
			colCount = (m != 0?vals.Length / m:0);
            var n = colCount;
			if (m * n != vals.Length)
			{
				throw new System.ArgumentException("Array length must be a multiple of m.");
			}
			matrix = new double[m][];
			for (int i = 0; i < m; i++)
			{
				matrix[i] = new double[n];
			}
			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < n; j++)
				{
					matrix[i][j] = vals[i + j * m];
				}
			}
		}
    }

    public class Vector : List<double>
    {
        public int Length
        {
            get { return base.Count; }
        }

        public void Set(int pos, double value)
        {
            base[pos] = value;
        }
     
        public Vector(int capacity)
        {
            for (int i = 0; i < capacity; i++)
            {
                base.Add(0.0);
            }
        }

        public Vector(List<double> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                base.Add(list[i]);
            }
        }

        public Vector(List<DoubleRefObject> list)
        {
            for(int i=0;i<list.Count;i++)
            {
                base.Add(list[i].Value);
            }
        }

        public double Norm()
        {
            double norm = 0;
            for (int i = 0; i < base.Count;i++ )
            {
                var element = base[i];

                norm += element * element;
            }
            return Math.Sqrt(norm);
        }

        public double SquaredNorm()
        {
            double norm = 0;
            for (int i = 0; i < base.Count; i++)
            {
                var element = base[i];
                norm += element * element;
            }
            return norm;
        }

        public static Vector operator +(Vector l, Vector r)
        {
            var max = Math.Max(l.Length, r.Length);
            var result = new Vector(max);
            if(l.Length <= r.Length)
            {
                for(int i=0;i < l.Length;i++)
                {
                    result[i] = l[i] + r[i];
                }
                for(int i=l.Length;i<r.Length;i++)
                {
                    result[i] = r[i];
                }
            }
            else
            {
                for (int i = 0; i < r.Length; i++)
                {
                    result[i] = l[i] + r[i];
                }
                for (int i = r.Length; i < l.Length; i++)
                {
                    result[i] = l[i];
                }
            }
            return result;
        }

        public static Vector operator *(Vector l, double val)
        {

            var result = new Vector(l.Length);

            for (int i = 0; i < l.Length; i++)
            {
                result[i] = l[i] * val;
            }
            return result;
        }

        public static double operator *(Vector l, Vector r)
        {
            if(l.Length != r.Length)    
                throw new IndexOutOfRangeException("The two vectors should have the same length");
            var result = 0.0;

            for (int i = 0; i < l.Length; i++)
            {
                result += l[i] * r[i];
            }
            return result;
        }

        public static Vector operator *(double val, Vector l)
        {

            var result = new Vector(l.Length);

            for (int i = 0; i < l.Length; i++)
            {
                result[i] = l[i] * val;
            }
            return result;
        }

        public static Vector operator -(Vector l, Vector r)
        {
            var max = Math.Max(l.Length, r.Length);
            var result = new Vector(max);
            if (l.Length <= r.Length)
            {
                for (int i = 0; i < l.Length; i++)
                {
                    result[i] = l[i] - r[i];
                }
                for (int i = l.Length; i < r.Length; i++)
                {
                    result[i] = -r[i];
                }
            }
            else
            {
                for (int i = 0; i < r.Length; i++)
                {
                    result[i] = l[i] - r[i];
                }
                for (int i = r.Length; i < l.Length; i++)
                {
                    result[i] = l[i];
                }
            }
            return result;
        }

        public static Vector operator -(Vector l)
        {
            var result = new Vector(l.Length);
            for (int i = 0; i < l.Length; i++)
            {
                result[i] = -l[i];
            }
            return result;
        }

        public static bool operator ==(Vector l, Vector r)
        {
            if (l.Length != r.Length)
                return false;
            for (int i = 0; i < l.Length; i++)
                if (l[i] - r[i] > 1e-12)
                    return false;
            return true;
        }

        public static Vector operator *(Matrix l, Vector r)
        {
            if (l.ColCount != r.Length)
                throw new Exception("Can't multiply matrix and vector if they don't have the correct dimensions!");

            var C = new Vector(l.RowCount);

            for (int i = 0; i < l.RowCount; i++)
            {
                C[i] = 0;
                for (int k = 0; k < r.Length; k++)
                {
                    C[i] += l[i,k] * r[k];
                }
            }
            return C;
        }

        public static bool operator !=(Vector l, Vector r)
        {
            if (l.Length != r.Length)
                return true;
            for (int i = 0; i < l.Length; i++)
                if (l[i] - r[i] > 1e-12)
                    return true;
            return false;
        }

        public static double InnerProduct(Vector l, Vector r)
        {
            var result = 0.0;
            if(l.Length != r.Length)
                throw new Exception("The vectors should have the same length!");
            for(int i=0; i<l.Length;i++)
            {
                result += l[i]*r[i];
            }
            return result;
        }

        public static Matrix OuterProduct(Vector l, Vector r)
        {
            if (l.Length != r.Length)
                throw new Exception("The vectors should have the same length!");
            var result = new Matrix(l.Length, r.Length);
            for (int i = 0; i < l.Length; i++)
            {
               for(int j=0; j<l.Length;j++)
               {
                   result[i,j]= l[i] * r[j];
               }
            }
            return result;
        }

        private bool Equals(Vector other)
        {
            return !ReferenceEquals(null, other);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (Vector)) return false;
            return Equals((Vector) obj);
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
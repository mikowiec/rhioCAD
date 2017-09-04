#region Usings

using System;

#endregion

namespace TreeData.Utils
{
    public static class Ensure
    {
        #region Public Methods

        /// <summary>
        ///   Checks an argument to ensure it isn't null.
        /// </summary>
        /// <param name = "argumentValue">The argument value to check.</param>
        /// <param name = "argumentName">The name of the argument.</param>
        public static void ArgumentNotNull(object argumentValue, string argumentName)
        {
            if (argumentValue == null)
                throw new ArgumentNullException(argumentName);
        }

        public static void IsTrue(bool expression, string message)
        {
            if (!expression) throw new NaroException(message);
        }

        public static void IsTrue(bool expression)
        {
            IsTrue(expression, "Expression should be true");
        }

        public static void AreEqual<T>(T val1, T val2, string message)
        {
            if (!Equals(val1, val2)) throw new NaroException(message);
        }

        public static void AreEqual<T>(T val1, T val2)
        {
            AreEqual(val1, val2, "Values should be equal");
        }

        public static void IsNotNull(object data)
        {
            IsNotNull(data, "Value should be different from null");
        }

        public static void IsNotNull(object data, string message)
        {
            IsTrue(data != null, message);
        }

        public static void IsNotZero(int size)
        {
            IsNotZero(size, "Size should not be zero");
        }

        public static void IsNotZero(int size, string message)
        {
            IsTrue(size != 0, message);
        }

        public static void IsZero(int count, string message)
        {
            IsTrue(count == 0, message);
        }

        public static void IsZero(int count)
        {
            IsZero(count, "Value shoud be equal with zero");
        }

        public static void IsNotTrue(bool expression)
        {
            IsTrue(!expression);
        }

        #endregion
    }
}
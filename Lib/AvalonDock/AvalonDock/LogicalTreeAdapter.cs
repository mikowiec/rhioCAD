#region Usings

using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

#endregion

namespace AvalonDock
{
    /// <summary>
    ///   Defines an adapter that must be implemented in order to use the LinqToTree
    ///   extension methods
    /// </summary>
    /// <typeparam name = "T"></typeparam>
    internal interface ILinqToTree<T>
    {
        /// <summary>
        ///   The parent of the Item.
        /// </summary>
        ILinqToTree<T> Parent { get; }

        /// <summary>
        ///   The item being adapted.
        /// </summary>
        T Item { get; }

        /// <summary>
        ///   Obtains all the children of the Item.
        /// </summary>
        /// <returns></returns>
        IEnumerable<ILinqToTree<T>> Children();
    }

    internal static class ILinqToTreeExts
    {
        /// <summary>
        ///   Returns a collection of descendant elements.
        /// </summary>
        public static IEnumerable<ILinqToTree<T>>
            Descendants<T>(this ILinqToTree<T> adapter)
        {
            foreach (var child in adapter.Children())
            {
                yield return child;

                foreach (var grandChild in child.Descendants())
                {
                    yield return grandChild;
                }
            }
        }

        /// <summary>
        ///   Returns a collection of ancestor elements.
        /// </summary>
        public static IEnumerable<ILinqToTree<T>>
            Ancestors<T>(this ILinqToTree<T> adapter)
        {
            var parent = adapter.Parent;
            while (parent != null)
            {
                yield return parent;
                parent = parent.Parent;
            }
        }

        /// <summary>
        ///   Returns a collection of child elements.
        /// </summary>
        public static IEnumerable<ILinqToTree<T>>
            Elements<T>(this ILinqToTree<T> adapter)
        {
            foreach (var child in adapter.Children())
            {
                yield return child;
            }
        }
    }

    /// <summary>
    ///   An adapter for DependencyObject which implements ILinqToTree in
    ///   order to allow Linq queries on the visual tree
    /// </summary>
    internal class VisualTreeAdapter : ILinqToTree<DependencyObject>
    {
        private readonly DependencyObject _item;

        public VisualTreeAdapter(DependencyObject item)
        {
            _item = item;
        }

        #region ILinqToTree<DependencyObject> Members

        public IEnumerable<ILinqToTree<DependencyObject>> Children()
        {
            var childrenCount = VisualTreeHelper.GetChildrenCount(_item);
            for (var i = 0; i < childrenCount; i++)
            {
                yield return new VisualTreeAdapter(VisualTreeHelper.GetChild(_item, i));
            }
        }

        public ILinqToTree<DependencyObject> Parent
        {
            get { return new VisualTreeAdapter(VisualTreeHelper.GetParent(_item)); }
        }

        public DependencyObject Item
        {
            get { return _item; }
        }

        #endregion
    }

    /// <summary>
    ///   An adapter for DependencyObject which implements ILinqToTree in
    ///   order to allow Linq queries on the logical tree
    /// </summary>
    internal class LogicalTreeAdapter : ILinqToTree<DependencyObject>
    {
        private readonly DependencyObject _item;

        public LogicalTreeAdapter(DependencyObject item)
        {
            _item = item;
        }

        #region ILinqToTree<DependencyObject> Members

        public IEnumerable<ILinqToTree<DependencyObject>> Children()
        {
            var children = LogicalTreeHelper.GetChildren(_item).OfType<DependencyObject>();
            foreach (var child in children)
            {
                yield return new LogicalTreeAdapter(child);
            }
        }

        public ILinqToTree<DependencyObject> Parent
        {
            get { return new VisualTreeAdapter(LogicalTreeHelper.GetParent(_item)); }
        }

        public DependencyObject Item
        {
            get { return _item; }
        }

        #endregion
    }
}
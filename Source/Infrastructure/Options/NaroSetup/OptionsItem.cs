#region Usings

using System.Windows.Controls;

#endregion

namespace NaroSetup
{
    /// <summary>
    ///   Description of OptionsPage.
    /// </summary>
    public abstract class OptionsItem
    {
        protected OptionsItem(string name, string title, string description)
        {
            Name = name;
            Title = title;
            Description = description;
        }

        public string Name { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }

        public Section Data { get; set; }

        public Control View { get; private set; }

        public virtual void OnUpdateData()
        {
        }

        public void BuidView()
        {
            View = PopulateChild();
        }

        public virtual void DefaultValues()
        {
        }

        protected abstract Control PopulateChild();
    }
}
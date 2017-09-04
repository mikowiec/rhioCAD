#region Usings

using AvalonDock;
using Naro.Infrastructure.Interface.Views;
using PartModellingUi.Views;

#endregion

namespace PartModellingUi.Layout
{
    /// <summary>
    ///   Interaction logic for PartModelingView.xaml
    /// </summary>
    public partial class PartModelingView
    {
        private readonly DocumentPane _documentsHost;

        public PartModelingView(DocumentPane documentsHost, string title)
        {
            _documentsHost = documentsHost;
            InitializeComponent();
            AttachToParent(title);
        }

        private void AttachToParent(string title)
        {
            var content = new DocumentContent {Title = title};
            content.IsCloseable = false;
            content.IsFloatingAllowed = false;
            _documentsHost.Items.Add(content);
            var airspaceOverlay = new AirspaceOverlay();
            content.Content = airspaceOverlay;
            airspaceOverlay.Child = this;
        }

        public MultiViewPresenter GetPresenter()
        {
            return multiView.Presenter;
        }

        public IOccContainerMultiView GetMultiView()
        {
            return multiView;
        }
    }
}
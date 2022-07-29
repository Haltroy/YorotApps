using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace YorotAppDesigner
{
    public partial class EditorWindow : Window
    {
        public MainWindow MainWindow;

        public EditorWindow()
        {
            InitializeComponent();
            this.Closed += new System.EventHandler((sender, e) => { MainWindow.editorWindow = null; });
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace YorotAppDesigner
{
    public partial class MainWindow : Window
    {
        public EditorWindow editorWindow;
        public bool editorClosed;

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            editorWindow = new EditorWindow() { MainWindow = this };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void alwaysontop_click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            Topmost = !Topmost;
            if (sender != null && sender is MenuItem item && item.Icon is CheckBox checkBox)
            {
                checkBox.IsChecked = Topmost;
            }
        }

        public void editoralwaysontop_click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            editorWindow.Topmost = !editorWindow.Topmost;
            if (sender != null && sender is MenuItem item && item.Icon is CheckBox checkBox)
            {
                checkBox.IsChecked = editorWindow.Topmost;
            }
        }

        public void editor_click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (editorWindow is null)
            {
                editorWindow = new EditorWindow() { MainWindow = this };
            }
            if (editorWindow.IsVisible)
            {
                editorWindow.Close();
            }
            else
            {
                editorWindow.Show();
            }
        }

        private void quit_click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            //if(notedited)
            //{
            editorWindow?.Close();
            Close();
            //}
        }
    }
}
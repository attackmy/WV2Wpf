/// <summary>
/// WPF sample.
/// </summary>
namespace WV2Wpf
{
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeAsync();
        }

        async void InitializeAsync()
        {
            var webView = new Microsoft.Web.WebView2.Wpf.WebView2();
            var env = await Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateAsync("C:\\temp\\Microsoft.WebView2.FixedVersionRuntime.88.0.705.56.x64", "c:\\temp\\");
            await webView.EnsureCoreWebView2Async(env);
            webView.Source = new System.Uri("https://www.microsoft.com");

            var panel = new System.Windows.Controls.DockPanel();
            panel.Children.Add(webView);
            Content = panel;
        }
    }
}

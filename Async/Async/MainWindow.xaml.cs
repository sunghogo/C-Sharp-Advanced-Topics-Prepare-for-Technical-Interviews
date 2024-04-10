using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Async
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // async/await can only be used in async functions, so nesting occurs
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //DownloadHtml("https://msdn.microsoft.com");
            //DownloadHtmlAsync("https://msdn.microsoft.com");

            var getHtmlTask = GetHtmlAsync("https://msdn.microsoft.com");
            MessageBox.Show("Waiting for task to complete");

            var html = await getHtmlTask;
            MessageBox.Show(html.Substring(0, 10));
        }

        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"c:\temp\resutls.html"))
            {
                streamWriter.Write(html);
            }
        }

        // async/await used for blocking oeprations in WPF applications or applications for Windows Runtime
        // asynchronous functions declared using async keyword + Task<type>
        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            // await keyword to await Async methods
            // this means control of execution is returned back to caller of the method/thread instead of blocking the thread, and then resumes execution once await operation is done
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"c:\temp\resutls.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        public string GetHtml(string url)
        {
            var webClient = new WebClient();

            return webClient.DownloadString(url);
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();

            return await webClient.DownloadStringTaskAsync(url);
        }
    }
}

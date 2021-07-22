using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
#if !Framework3_5
        Task<bool> loadAsync = null;
        CancellationTokenSource cancellationTokenSource = null;
#endif

        public MainWindow()
        {
            InitializeComponent();
        }

#if Framework3_5 || Framework4_0
        private void LoadDoc1_Click(object sender, RoutedEventArgs e)
#else
        private async void LoadDoc1_Click(object sender, RoutedEventArgs e)
#endif
        {
#if Framework3_5
            richTextBoxAdv.Load("../../Data/Sample.docx");
#else
            if (loadAsync != null && !loadAsync.IsCompleted && !loadAsync.IsFaulted && cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
                try
                {
                    if (!loadAsync.IsCanceled)
#if SyncfusionFramework4_0
                                loadAsync.Wait();
#else
                        await loadAsync;
#endif
                }
                catch
                { }
            }
            try
            {
                cancellationTokenSource = new CancellationTokenSource();
#if SyncfusionFramework4_0
                loadAsync = richTextBoxAdv.LoadAsync("../../Data/Windows8.docx", cancellationTokenSource.Token);
#else
                loadAsync = richTextBoxAdv.LoadAsync("../../Data/Windows8.docx", cancellationTokenSource.Token);
                await loadAsync;
#endif
                if (cancellationTokenSource != null)
                    cancellationTokenSource.Dispose();
                cancellationTokenSource = null;
                loadAsync = null;
            }
            catch
            { }
#endif
        }

#if Framework3_5 || Framework4_0
        private void LoadDoc2_Click(object sender, RoutedEventArgs e)
#else
        private async void LoadDoc2_Click(object sender, RoutedEventArgs e)
#endif
        {
#if Framework3_5
            richTextBoxAdv.Load("../../Data/Windows8.docx");
#else
            if (loadAsync != null && !loadAsync.IsCompleted && !loadAsync.IsFaulted && cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
                try
                {
                    if (!loadAsync.IsCanceled)
#if SyncfusionFramework4_0
                                loadAsync.Wait();
#else
                        await loadAsync;
#endif
                }
                catch
                { }
            }
            try
            {
                cancellationTokenSource = new CancellationTokenSource();
#if SyncfusionFramework4_0
                loadAsync = richTextBoxAdv.LoadAsync("../../Data/Windows8.docx", cancellationTokenSource.Token);
#else
                loadAsync = richTextBoxAdv.LoadAsync("../../Data/Windows8.docx", cancellationTokenSource.Token);
                await loadAsync;
#endif
                if (cancellationTokenSource != null)
                    cancellationTokenSource.Dispose();
                cancellationTokenSource = null;
                loadAsync = null;
            }
            catch
            { }
#endif
        }
    }
}

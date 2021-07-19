using Syncfusion.Windows.Controls.RichTextBoxAdv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Shapes;

namespace Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
            this.Unloaded += MainWindow_Unloaded;

            Assembly assembly = typeof(MainWindow).Assembly;
            Stream stream = assembly.GetManifestResourceStream("Sample.Assets.GettingStarted.docx");
            richTextBoxAdv.Load(stream, FormatType.Docx);
            richTextBoxAdv.DocumentTitle = "Getting Started";
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            richTextBoxAdv.Focus();
        }

        private void MainWindow_Unloaded(object sender, RoutedEventArgs e)
        {
            richTextBoxAdv.Dispose();
        }
    }
}

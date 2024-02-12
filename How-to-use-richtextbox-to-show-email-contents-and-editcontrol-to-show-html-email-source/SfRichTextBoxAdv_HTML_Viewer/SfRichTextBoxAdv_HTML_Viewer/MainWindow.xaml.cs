using Syncfusion.Windows.Controls.RichTextBoxAdv;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
using System.Windows.Shapes;

namespace SfRichTextBoxAdv_HTML_Viewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Sample.MainWindow">MainWindow</see> class. 
        /// </summary>
        /// <remarks></remarks>
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            this.Unloaded += MainWindow_Unloaded;
            richTextBoxAdv.ContentChanged += RichTextBoxAdv_ContentChanged;
            richTextBoxAdv.DocumentChanged += RichTextBoxAdv_DocumentChanged;
            editControl.TextChanged += EditControl_TextChanged;
        }
        #endregion

        #region HTML Viewer Implementation
        /// <summary>
        /// When content changes in EditControl, the content will be updated in SfRichTextBoxAdv.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private void EditControl_TextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null && e.NewValue.ToString() != richTextBoxAdv.HtmlText)
            {
                //Loads the HTML string
                Stream stream = new MemoryStream();
                byte[] bytes = Encoding.UTF8.GetBytes(e.NewValue.ToString());
                stream.Write(bytes, 0, bytes.Length);
                stream.Position = 0;
                richTextBoxAdv.Load(stream, FormatType.Html);
            }
        }
        /// <summary>
        /// When content changes in SfRichTextBoxAdv, the HTML content will be updated in EditControl.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        private void RichTextBoxAdv_ContentChanged(object obj, ContentChangedEventArgs args)
        {
            editControl.Text = richTextBoxAdv.HtmlText;
        }
        /// <summary>
        /// When Document changes in SfRichTextBoxAdv, the HTML content will be updated in EditControl.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void RichTextBoxAdv_DocumentChanged(object obj, DocumentChangedEventArgs args)
        {
            editControl.Text = richTextBoxAdv.HtmlText;
        }
        #endregion

        #region Events
        /// <summary>
        /// Called when window loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            richTextBoxAdv.Focus();
        }
        /// <summary>
        /// Called when main window loaded.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void MainWindow_Unloaded(object sender, RoutedEventArgs e)
        {
            if (richTextBoxAdv != null)
            {
                richTextBoxAdv.Dispose();
            }
        }
        /// <summary>
        /// Handles the RequestNavigate event of the richTextBoxAdv control.
        /// </summary>
        /// <param name="obj">The source of the event.</param>
        /// <param name="args">The <see cref="Syncfusion.Windows.Tools.RichTextBoxAdv.RequestNavigateEventArgs"/> instance containing the event data.</param>
        void RichTextBoxAdv_RequestNavigate(object obj, Syncfusion.Windows.Controls.RichTextBoxAdv.RequestNavigateEventArgs args)
        {
            if (args.Hyperlink.LinkType == Syncfusion.Windows.Controls.RichTextBoxAdv.HyperlinkType.Webpage || args.Hyperlink.LinkType == Syncfusion.Windows.Controls.RichTextBoxAdv.HyperlinkType.Email)
            {
                Uri uri = new Uri(args.Hyperlink.NavigationLink);
                LaunchUri(uri);
            }
        }
        /// <summary>
        /// Launches the URI.
        /// </summary>
        /// <param name="uri">The URI.</param>
        void LaunchUri(Uri uri)
        {
            Process.Start(new ProcessStartInfo(uri.AbsoluteUri));
        }
        #endregion
    }
}

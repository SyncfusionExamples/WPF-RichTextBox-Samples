using Microsoft.Win32;
using Syncfusion.DocIO.DLS;
using Syncfusion.Windows.Controls.RichTextBoxAdv;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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
        #region Properties
        /// <summary>
        /// Gets or Sets the font family source.
        /// </summary>
        public List<string> FontFamilySource
        {
            get
            {
                return (List<string>)GetValue(FontFamilySourceProperty);
            }
            set
            {
                SetValue(FontFamilySourceProperty, value);
            }
        }
        /// <summary>
        /// Gets or Sets the font size source.
        /// </summary>
        public double[] FontSizeSource
        {
            get
            {
                return (double[])GetValue(FontSizeSourceProperty);
            }
            set
            {
                SetValue(FontSizeSourceProperty, value);
            }
        }
        /// <summary>
        /// Gets or Sets the list view model.
        /// </summary>
        public ListViewModel ListViewModel
        {
            get
            {
                return (ListViewModel)GetValue(ListViewModelProperty);
            }
            set
            {
                SetValue(ListViewModelProperty, value);
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Sample.MainWindow">MainWindow</see> class. 
        /// </summary>
        /// <remarks></remarks>
        public MainWindow()
        {
            AddFontFamily();
            InitializeComponent();
            ListViewModel = new ListViewModel(this.richTextBoxAdv);
            this.Loaded += MainWindow_Loaded;
            this.Unloaded += MainWindow_Unloaded;
        }
        #endregion

        #region Static Dependency Properties
        // Using a DependencyProperty as the backing store for FontFamilySource.
        public static readonly DependencyProperty FontFamilySourceProperty = DependencyProperty.Register("FontFamilySource", typeof(List<string>), typeof(MainWindow), new PropertyMetadata(null));
        // Using a DependencyProperty as the backing store for FontSizeSource.
        public static readonly DependencyProperty FontSizeSourceProperty = DependencyProperty.Register("FontSizeSource", typeof(double[]), typeof(MainWindow), new PropertyMetadata(new double[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 24, 26, 28, 36, 48, 72 }));
        // Using a DependencyProperty as the backing store for ListViewModelSource.
        public static readonly DependencyProperty ListViewModelProperty = DependencyProperty.Register("ListViewModel", typeof(ListViewModel), typeof(MainWindow), new PropertyMetadata(null));
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
            ClearValue(FontFamilySourceProperty);
            ClearValue(FontSizeSourceProperty);
            ClearValue(ListViewModelProperty);
            if (richTextBoxAdv != null)
            {
                richTextBoxAdv.Dispose();
            }
        }
        #endregion

        #region Implementation
        /// <summary>
        /// Adds the font family.
        /// </summary>
        private void AddFontFamily()
        {
            FontFamilySource = new List<string>();
            foreach (FontFamily fontfamily in Fonts.SystemFontFamilies)
            {
                FontFamilySource.Add(fontfamily.Source);
            }
        }
        /// <summary>
        /// Called on bulleted list split button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void BulletedListSplitButton_Click(object sender, RoutedEventArgs e)
        {
            ListViewModel viewModel = (sender as FrameworkElement).DataContext as ListViewModel;
            if (string.IsNullOrEmpty(viewModel.ListName) || viewModel.ListName == "NoList" || viewModel.ListName == "Null" || !viewModel.ListName.StartsWith("_Bullet"))
                viewModel.ListName = "_Bullet_Dot";
            else
                viewModel.ListName = "NoList";
        }
        /// <summary>
        /// Called on numbered list split button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void NumberedListSplitButton_Click(object sender, RoutedEventArgs e)
        {
            ListViewModel viewModel = (sender as FrameworkElement).DataContext as ListViewModel;
            if (string.IsNullOrEmpty(viewModel.ListName) || viewModel.ListName == "NoList" || viewModel.ListName == "Null" || !viewModel.ListName.StartsWith("_Numbering"))
                viewModel.ListName = "_Numbering_Number_Dot";
            else
                viewModel.ListName = "NoList";
        }
        /// <summary>
        /// Occurs when drop down item click
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        private void DropDownItem_Click(object sender, RoutedEventArgs e)
        {
            object obj = (sender as FrameworkElement).Parent;
            while (!(obj is DropDownButtonAdv || obj is SplitButtonAdv))
            {
                obj = (obj as FrameworkElement).Parent;
            }
            DropDownButtonAdv dropdown = obj as DropDownButtonAdv;
            dropdown.IsDropDownOpen = false;
        }
        #endregion

        #region Events
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

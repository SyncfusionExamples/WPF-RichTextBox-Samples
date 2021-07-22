using Microsoft.Win32;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using Syncfusion.Windows.Controls.RichTextBoxAdv;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
#if !Framework3_5
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
#endif

namespace DocumentEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        #region Feilds
#if !Framework3_5
        Task<bool> loadAsync = null;
        CancellationTokenSource cancellationTokenSource = null;
#endif
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
#if !Framework3_5
            //Enables touch manipulation.
            richTextBoxAdv.IsManipulationEnabled = true;
#endif
            DataContext = richTextBoxAdv;

            Assembly assembly = typeof(MainWindow).Assembly;
            Stream stream = assembly.GetManifestResourceStream("DocumentEditor.Assets.GettingStarted.docx");
            richTextBoxAdv.Load(stream, FormatType.Docx);
            richTextBoxAdv.DocumentTitle = "Getting Started";
            richTextBoxAdv.RequestNavigate += RichTextBoxAdv_RequestNavigate;
            richTextBoxAdv.SelectionChanged += RichTextBoxAdv_SelectionChanged;
            this.Loaded += OnLoaded;
            this.Unloaded += OnUnloaded;
        }
        #endregion

        #region Events
        /// <summary>
        /// Called when [loaded].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            if (ribbon != null)
                ribbon.Loaded += Ribbon_Loaded;
        }
        /// <summary>
        /// Handles the RequestNavigate event of the richTextBoxAdv control.
        /// </summary>
        /// <param name="obj">The source of the event.</param>
        /// <param name="args">The <see cref="Syncfusion.Windows.Controls.RichTextBoxAdv.RequestNavigateEventArgs"/> instance containing the event data.</param>
        void RichTextBoxAdv_RequestNavigate(object obj, Syncfusion.Windows.Controls.RichTextBoxAdv.RequestNavigateEventArgs args)
        {
            if (args.Hyperlink.LinkType == Syncfusion.Windows.Controls.RichTextBoxAdv.HyperlinkType.Webpage || args.Hyperlink.LinkType == Syncfusion.Windows.Controls.RichTextBoxAdv.HyperlinkType.Email)
                LaunchUri(new Uri(args.Hyperlink.NavigationLink));
            else if (args.Hyperlink.LinkType == HyperlinkType.File && File.Exists(args.Hyperlink.NavigationLink))
                Process.Start(args.Hyperlink.NavigationLink);
        }
        /// <summary>
        /// Called on RichTextBoxAdv selection changes.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args">An <see cref="T:Syncfusion.Windows.Controls.RichTextBoxAdv.SelectionChangedEventArgs">SelectionChangedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        private void RichTextBoxAdv_SelectionChanged(object obj, Syncfusion.Windows.Controls.RichTextBoxAdv.SelectionChangedEventArgs args)
        {
            pagecountRun.RunText = richTextBoxAdv.PageCount.ToString();
            currentPageNumberRun.RunText = richTextBoxAdv.CurrentPageNumber.ToString();
        }
        /// <summary>
        /// Calle when [unloaded].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        private void OnUnloaded(object sender, RoutedEventArgs e)
        {
            this.Unloaded -= OnUnloaded;
            this.Loaded -= OnLoaded;
            DisposeRibbon();
            if (richTextBoxAdv != null)
            {
                richTextBoxAdv.SelectionChanged -= RichTextBoxAdv_SelectionChanged;
                richTextBoxAdv.RequestNavigate -= RichTextBoxAdv_RequestNavigate;
                richTextBoxAdv.Dispose();
                richTextBoxAdv = null;
            }
        }
        #endregion

        #region Initiate Bindings
        /// <summary>
        /// Called on ribbon loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ribbon_Loaded(object sender, RoutedEventArgs e)
        {
            CommandBindings.Add(new CommandBinding(SfRichTextBoxAdv.SaveDocumentCommand, OnSaveExecuted));
            CommandBindings.Add(new CommandBinding(SfRichTextBoxAdv.SaveAsDocumentCommand, OnSaveAsExecuted));
            CommandBindings.Add(new CommandBinding(SfRichTextBoxAdv.PrintDocumentCommand, OnPrintExecuted));
            CommandBindings.Add(new CommandBinding(SfRichTextBoxAdv.OpenDocumentCommand, OnOpenExecuted));
            CommandBindings.Add(new CommandBinding(SfRichTextBoxAdv.NewDocumentCommand, OnNewExecuted));
            CommandBindings.Add(new CommandBinding(SfRichTextBoxAdv.ShowEncryptDocumentDialogCommand, OnShowEncryptDocumentExecuted));
            WireUpEvents();
            if (fontFamilyComboBox != null)
                fontFamilyComboBox.ItemsSource = GetFontFamilySource();
            if (fontSizeComboBox != null)
                fontSizeComboBox.ItemsSource = new double[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 24, 26, 28, 36, 48, 72, 96 };
            if (richTextBoxAdv != null)
                richTextBoxAdv.Focus();
        }
        /// <summary>
        /// On save executed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="ExecutedRoutedEventArgs"/> instance containing the event data.</param>
        private void OnSaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            WordExport(string.Empty);
            richTextBoxAdv.Focus();
        }
        /// <summary>
        /// On save as executed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="ExecutedRoutedEventArgs"/> instance containing the event data.</param>
        private void OnSaveAsExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            string extension = string.Empty;
            if (e.Parameter == null)
                extension = ".docx";
            else
                extension = e.Parameter.ToString();
            WordExport(extension);
        }
        /// <summary>
        /// On print executed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="ExecutedRoutedEventArgs"/> instance containing the event data.</param>
        private void OnPrintExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            richTextBoxAdv.PrintDocument();
            richTextBoxAdv.Focus();
        }
        /// <summary>
        /// On new executed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="ExecutedRoutedEventArgs"/> instance containing the event data.</param>
        private void OnNewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            richTextBoxAdv.Document = new DocumentAdv();
            richTextBoxAdv.Focus();
        }
        /// <summary>
        /// On open executed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="ExecutedRoutedEventArgs"/> instance containing the event data.</param>
        private void OnOpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            WordImport();
            richTextBoxAdv.Focus();
        }
        /// <summary>
        /// On show encrypt document executed.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.Input.ExecutedRoutedEventArgs">ExecutedRoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        private void OnShowEncryptDocumentExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SfRichTextBoxAdv.ShowEncryptDocumentDialogCommand.Execute(null, richTextBoxAdv);
        }
        /// <summary>
        /// Wires up the events.
        /// </summary>
        /// <remarks></remarks>
        private void WireUpEvents()
        {
            backstageOpenButton.Click += BackstageButton_Click;
            backstageSaveButton.Click += BackstageButton_Click;
            backstageSaveAsButton.Click += BackstageButton_Click;
            backstagePrintButton.Click += BackstageButton_Click;
            backstageRestrictEditingButton.Click += BackstageRestrictEditingButton_Click;
            backstageEncryptDocumentButton.Click += BackstageEncryptDocumentButton_Click;
            rteButton.Click += BackstageButton_Click;
            backstageNewDocumentButton.Click += NewDocumentButton_Click;
            createDocumentButton.Click += NewDocumentButton_Click;
            onlineHelpButton.Click += OnlineHelpButton_Click;
            gettingStartedButton.Click += GettingStartedButton_Click;
            increaseFontSizeButton.Click += IncreaseFontSizeButton_Click;
            decreaseFontSizeButton.Click += DecreaseFontSizeButton_Click;
            fontColorSplitButton.Click += FontColorSplitButton_Click;
            fontColorPicker.SetBinding(ColorPickerPalette.ColorProperty, new Binding() { Path = new PropertyPath("Selection.CharacterFormat.FontColor"), Mode = BindingMode.TwoWay, Converter = new FontColorConverter() });
            fontColorPicker.ColorChanged += FontColorPicker_ColorChanged;
            highlightColorSplitButton.Click += HighlightColorSplitButton_Click;
            noHighlightButton.Click += DropDownItem_Click;
            yellowHighlightButton.Click += DropDownItem_Click;
            brightGreenHighlightButton.Click += DropDownItem_Click;
            turquoiseHighlightButton.Click += DropDownItem_Click;
            pinkHighlightButton.Click += DropDownItem_Click;
            blueHighlightButton.Click += DropDownItem_Click;
            redHighlightButton.Click += DropDownItem_Click;
            darkBlueHighlightButton.Click += DropDownItem_Click;
            tealHighlightButton.Click += DropDownItem_Click;
            greenHighlightButton.Click += DropDownItem_Click;
            violetHighlightButton.Click += DropDownItem_Click;
            darkRedHighlightButton.Click += DropDownItem_Click;
            darkYellowHighlightButton.Click += DropDownItem_Click;
            darkGrayHighlightButton.Click += DropDownItem_Click;
            lightGrayHighlightButton.Click += DropDownItem_Click;
            blackHighlightButton.Click += DropDownItem_Click;
            foreach (MenuItem lineSpacingItem in lineSpacingMenuGroup.Items)
                lineSpacingItem.Click += LineSpacingItem_Click;
            restrictEditingButton.IsSelectedChanged += RestrictEditingButton_IsSelectedChanged;
            tablePicker.Click += TablePicker_Click;
            insertTableButton.Click += DropDownItem_Click;
            zoomInButton.Click += ZoomInButton_Click;
            zoomOutButton.Click += ZoomOutButton_Click;
            InitListOptions();
        }
        /// <summary>
        /// Called on increase font size button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void IncreaseFontSizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (richTextBoxAdv != null)
            {
                double[] fontSizeSource = new double[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 24, 26, 28, 36, 48, 72, 96 };
                if (richTextBoxAdv.Selection.CharacterFormat.FontSize >= fontSizeSource[fontSizeSource.Length - 1])
                    richTextBoxAdv.Selection.CharacterFormat.FontSize += 10;
                else if (fontSizeComboBox.SelectedIndex < 0)
                {
                    if (richTextBoxAdv.Selection.CharacterFormat.FontSize < 1)
                        richTextBoxAdv.Selection.CharacterFormat.FontSize = 8;
                    else if (richTextBoxAdv.Selection.CharacterFormat.FontSize < 8)
                        richTextBoxAdv.Selection.CharacterFormat.FontSize += 1;
                    else
                        richTextBoxAdv.Selection.CharacterFormat.FontSize = fontSizeSource.OrderBy(d => Math.Abs(d - richTextBoxAdv.Selection.CharacterFormat.FontSize)).ElementAt(1);
                }
                else
                    fontSizeComboBox.SelectedIndex += 1;
            }
        }
        /// <summary>
        /// Called on decrease font size button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void DecreaseFontSizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (richTextBoxAdv != null)
            {
                if (richTextBoxAdv.Selection.CharacterFormat.FontSize - 1 <= 0)
                    return;
                double[] fontSizeSource = new double[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 24, 26, 28, 36, 48, 72, 96 };
                if (fontSizeComboBox.SelectedIndex > 0)
                    fontSizeComboBox.SelectedIndex -= 1;
                else if (richTextBoxAdv.Selection.CharacterFormat.FontSize <= 8)
                    richTextBoxAdv.Selection.CharacterFormat.FontSize -= 1;
                else if (richTextBoxAdv.Selection.CharacterFormat.FontSize - 10 > fontSizeSource[fontSizeSource.Length - 1])
                    richTextBoxAdv.Selection.CharacterFormat.FontSize -= 10;
                else
                    richTextBoxAdv.Selection.CharacterFormat.FontSize = fontSizeSource.OrderBy(d => Math.Abs(d - richTextBoxAdv.Selection.CharacterFormat.FontSize)).ElementAt(0);
            }
        }
        /// <summary>
        /// Called on font color picker color changed.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e">An <see cref="T:System.Windows.DependencyPropertyChangedEventArgs">DependencyPropertyChangedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void FontColorPicker_ColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SplitButton splitbutton = (SplitButton)fontColorPicker.Parent;
            if (splitbutton != null)
                splitbutton.IsDropDownOpen = false;
        }
        /// <summary>
        /// Called on font color split button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void FontColorSplitButton_Click(object sender, RoutedEventArgs e)
        {
            if (fontColorPicker != null && richTextBoxAdv != null && fontColorPicker.RecentlyUsedCollection.Count > 0 && fontColorPicker.RecentlyUsedCollection[0].Color is SolidColorBrush)
                richTextBoxAdv.Selection.CharacterFormat.FontColor = (fontColorPicker.RecentlyUsedCollection[0].Color as SolidColorBrush).Color;
            else
                richTextBoxAdv.Selection.CharacterFormat.FontColor = Color.FromArgb(0xff, 0xff, 0x00, 0x00);
        }
        /// <summary>
        /// Called on highlight color split button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void HighlightColorSplitButton_Click(object sender, RoutedEventArgs e)
        {
            if (richTextBoxAdv != null && richTextBoxAdv.Selection.CharacterFormat.HighlightColor != HighlightColor.NoColor)
                richTextBoxAdv.Selection.CharacterFormat.HighlightColor = HighlightColor.NoColor;
            else
                richTextBoxAdv.Selection.CharacterFormat.HighlightColor = HighlightColor.Yellow;
        }
        /// <summary>
        /// Called on backstage button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void BackstageButton_Click(object sender, RoutedEventArgs e)
        {
            CloseBackstage();
        }
        /// <summary>
        /// Called on new document button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void NewDocumentButton_Click(object sender, RoutedEventArgs e)
        {
            CloseBackstage();
            if (richTextBoxAdv != null)
                richTextBoxAdv.DocumentTitle = "Untitled";
        }
        /// <summary>
        /// Called on online help button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void OnlineHelpButton_Click(object sender, RoutedEventArgs e)
        {
            LaunchUri(new Uri("http://help.syncfusion.com"));
            CloseBackstage();
        }
        /// <summary>
        /// On getting started button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void GettingStartedButton_Click(object sender, RoutedEventArgs e)
        {
            LaunchUri(new Uri("http://help.syncfusion.com/ug/wpf/Documents/overview60.htm"));
            CloseBackstage();
        }
        /// <summary>
        /// Closed the backstage.
        /// </summary>
        /// <remarks></remarks>
        void CloseBackstage()
        {
            if (ribbon != null && ribbon.BackStageButton != null)
                ribbon.BackStageButton.IsOpen = false;
            if (richTextBoxAdv != null)
                richTextBoxAdv.Focus();
        }
        /// <summary>
        /// Called on backstage restrict editing button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void BackstageRestrictEditingButton_Click(object sender, RoutedEventArgs e)
        {
            if (richTextBoxAdv != null && !richTextBoxAdv.IsReadOnly)
            {
                richTextBoxAdv.IsReadOnly = true;
                OnRestrictEditing();
            }
            CloseBackstage();
        }
        /// <summary>
        /// Called on backstage encrypt document button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void BackstageEncryptDocumentButton_Click(object sender, RoutedEventArgs e)
        {
            CloseBackstage();
        }
        /// <summary>
        /// Called on restrict editing button selection changed.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e">An <see cref="T:System.Windows.DependencyPropertyChangedEventArgs">DependencyPropertyChangedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void RestrictEditingButton_IsSelectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            OnRestrictEditing();
        }
        /// <summary>
        /// On restrict editing.
        /// </summary>
        /// <remarks></remarks>
        private void OnRestrictEditing()
        {
            if (richTextBoxAdv != null)
            {
                IEnumerable tabs = ribbon.Items;
                string visual = SkinStorage.GetVisualStyle(this);
                foreach (var tab in tabs)
                {
                    RibbonTab ribbontab = tab as RibbonTab;
                    if (ribbontab != null)
                    {
                        foreach (var bar in ribbontab.Items)
                        {
                            RibbonBar ribbonBar = bar as RibbonBar;
                            if (ribbonBar != null)
                            {
                                // Options that should work on read only mode should not be disabled.
                                // Currently, Copy, Find and ShowComments options.
                                if (ribbonBar.Header == "ClipBoard")
                                {
                                    foreach (var item in ribbonBar.Items)
                                    {
                                        RibbonButton button = item as RibbonButton;
                                        if (button != null && button.Label != "Copy")
                                        {
                                            if (richTextBoxAdv.IsReadOnly)
                                                button.IsEnabled = false;
                                            else
                                                button.IsEnabled = true;
                                        }
                                    }
                                }
                                else if (ribbonBar.Header == "Editing")
                                {
                                    foreach (var item in ribbonBar.Items)
                                    {
                                        RibbonButton button = item as RibbonButton;
                                        if (button != null && button.Label == "Replace")
                                        {
                                            if (richTextBoxAdv.IsReadOnly)
                                                button.IsEnabled = false;
                                            else
                                                button.IsEnabled = true;
                                        }
                                    }
                                }
                                else if (ribbonBar.Header == "Comments")
                                {
                                    foreach (var item in ribbonBar.Items)
                                    {
                                        RibbonButton button = item as RibbonButton;
                                        if (button != null && button.Label != "Show Comments")
                                        {
                                            if (richTextBoxAdv.IsReadOnly)
                                                button.IsEnabled = false;
                                            else
                                                button.IsEnabled = true;
                                        }
                                    }
                                }
                                else if (ribbonBar.Header != "Page SetUp" && ribbonBar.Header != "Zoom" && ribbonBar.Header != "Color Scheme")
                                {
                                    if (richTextBoxAdv.IsReadOnly)
                                    {
                                        ribbonBar.IsEnabled = false;
                                        if (visual == "Office2010Blue" || visual == "Office2010Black" || visual == "Office2010Silver")
                                            ribbonBar.Effect = new DisableEffect();
                                    }
                                    else
                                    {
                                        ribbonBar.Effect = null;
                                        ribbonBar.IsEnabled = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// On table picker clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void TablePicker_Click(object sender, RoutedEventArgs e)
        {
            if (richTextBoxAdv != null && sender is TablePickerUI)
            {
                TablePickerUI tablePicker = sender as TablePickerUI;
                int[] tableSize = new int[] { tablePicker.SelectedCell.Row + 1, tablePicker.SelectedCell.Column + 1 };
                tablePicker.CommandParameter = tableSize;
                CloseDropDown(tablePicker.Parent);
            }
        }
        /// <summary>
        /// Occurs when drop down item click
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        private void DropDownItem_Click(object sender, RoutedEventArgs e)
        {
            CloseDropDown((sender as FrameworkElement).Parent);
        }
        /// <summary>
        /// Closes the drop down.
        /// </summary>
        /// <param name="obj"></param>
        /// <remarks></remarks>
        void CloseDropDown(object obj)
        {
            while (!(obj is DropDownButton || obj is SplitButton))
            {
                obj = (obj as FrameworkElement).Parent;
            }
            // SplitButton is derived from DropDown only. Hence no need to handle it specifically.
            if (obj is DropDownButton)
                (obj as DropDownButton).IsDropDownOpen = false;
        }
        /// <summary>
        /// Initiates the List options
        /// </summary>
        /// <remarks></remarks>
        private void InitListOptions()
        {
            ListViewModel viewModel = new ListViewModel(richTextBoxAdv);
            noBulletButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Path = new PropertyPath("ListName"), Converter = new ListToggleConverter(), ConverterParameter = "NoList" });
            noBulletButton.Click += DropDownItem_Click;
            arrowBulletButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Path = new PropertyPath("ListName"), Converter = new ListToggleConverter(), ConverterParameter = "_Bullet_Arrow" });
            arrowBulletButton.Click += DropDownItem_Click;
            dotBulletButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Path = new PropertyPath("ListName"), Converter = new ListToggleConverter(), ConverterParameter = "_Bullet_Dot" });
            dotBulletButton.Click += DropDownItem_Click;
            flowerBulletButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Path = new PropertyPath("ListName"), Converter = new ListToggleConverter(), ConverterParameter = "_Bullet_Flower" });
            flowerBulletButton.Click += DropDownItem_Click;
            circleBulletButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Path = new PropertyPath("ListName"), Converter = new ListToggleConverter(), ConverterParameter = "_Bullet_Circle" });
            circleBulletButton.Click += DropDownItem_Click;
            squareBulletButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Path = new PropertyPath("ListName"), Converter = new ListToggleConverter(), ConverterParameter = "_Bullet_Square" });
            squareBulletButton.Click += DropDownItem_Click;
            tickBulletButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Path = new PropertyPath("ListName"), Converter = new ListToggleConverter(), ConverterParameter = "_Bullet_Tick" });
            tickBulletButton.Click += DropDownItem_Click;
            noNumberingButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Path = new PropertyPath("ListName"), Converter = new ListToggleConverter(), ConverterParameter = "NoList" });
            noNumberingButton.Click += DropDownItem_Click;
            numberDotNumberingButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Path = new PropertyPath("ListName"), Converter = new ListToggleConverter(), ConverterParameter = "_Numbering_Number_Dot" });
            numberDotNumberingButton.Click += DropDownItem_Click;
            numberBraceNumberingButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Path = new PropertyPath("ListName"), Converter = new ListToggleConverter(), ConverterParameter = "_Numbering_Number_Brace" });
            numberBraceNumberingButton.Click += DropDownItem_Click;
            lowLetterDotNumberingButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Path = new PropertyPath("ListName"), Converter = new ListToggleConverter(), ConverterParameter = "_Numbering_LowLetter_Dot" });
            lowLetterDotNumberingButton.Click += DropDownItem_Click;
            lowLetterBraceNumberingButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Path = new PropertyPath("ListName"), Converter = new ListToggleConverter(), ConverterParameter = "_Numbering_LowLetter_Brace" });
            lowLetterBraceNumberingButton.Click += DropDownItem_Click;
            upLetterNumberingButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Path = new PropertyPath("ListName"), Converter = new ListToggleConverter(), ConverterParameter = "_Numbering_UpLetter" });
            upLetterNumberingButton.Click += DropDownItem_Click;
            upRomanNumberingButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Path = new PropertyPath("ListName"), Converter = new ListToggleConverter(), ConverterParameter = "_Numbering_UpRoman" });
            upRomanNumberingButton.Click += DropDownItem_Click;
            lowRomanNumberingButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Path = new PropertyPath("ListName"), Converter = new ListToggleConverter(), ConverterParameter = "_Numbering_LowRoman" });
            lowRomanNumberingButton.Click += DropDownItem_Click;
            noListButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Source = viewModel, Path = new PropertyPath("ListName"), Converter = new ListToggleConverter(), ConverterParameter = "NoList" });
            noListButton.Click += DropDownItem_Click;
            bulletedListButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Source = viewModel, Path = new PropertyPath("ListName"), Converter = new ListToggleConverter(), ConverterParameter = "_List_Bullet" });
            bulletedListButton.Click += DropDownItem_Click;
            normalListButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Source = viewModel, Path = new PropertyPath("ListName"), Converter = new ListToggleConverter(), ConverterParameter = "_List_Normal" });
            normalListButton.Click += DropDownItem_Click;
            multilevelListButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Source = viewModel, Path = new PropertyPath("ListName"), Converter = new ListToggleConverter(), ConverterParameter = "_List_Multilevel" });
            multilevelListButton.Click += DropDownItem_Click;
            bulletedListSplitButton.DataContext = viewModel;
            bulletedListSplitButton.Click += BulletedListSplitButton_Click;
            numberedListSplitButton.DataContext = viewModel;
            numberedListSplitButton.Click += NumberedListSplitButton_Click;
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
        /// Called on line spacing item clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void LineSpacingItem_Click(object sender, RoutedEventArgs e)
        {
            CloseDropDown(sender);
        }
        /// <summary>
        /// Called on zoom in button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void ZoomInButton_Click(object sender, RoutedEventArgs e)
        {
            if (richTextBoxAdv != null)
            {
                if (richTextBoxAdv.ZoomFactor + 10 > 500)
                    richTextBoxAdv.ZoomFactor = 500;
                else
                    richTextBoxAdv.ZoomFactor += 10;
            }
        }
        /// <summary>
        /// Called on zoom out button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="T:System.Windows.RoutedEventArgs">RoutedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void ZoomOutButton_Click(object sender, RoutedEventArgs e)
        {
            if (richTextBoxAdv != null)
            {
                if (richTextBoxAdv.ZoomFactor - 10 < 10)
                    richTextBoxAdv.ZoomFactor = 10;
                else
                    richTextBoxAdv.ZoomFactor -= 10;
            }
        }
        #endregion

        #region Dispose Bindings
        /// <summary>
        /// Unwires the events.
        /// </summary>
        /// <remarks></remarks>
        private void UnWireEvents()
        {
            backstageOpenButton.Click -= BackstageButton_Click;
            backstageSaveButton.Click -= BackstageButton_Click;
            backstageSaveAsButton.Click -= BackstageButton_Click;
            backstagePrintButton.Click -= BackstageButton_Click;
            backstageRestrictEditingButton.Click -= BackstageRestrictEditingButton_Click;
            backstageEncryptDocumentButton.Click -= BackstageEncryptDocumentButton_Click;
            rteButton.Click -= BackstageButton_Click;
            backstageNewDocumentButton.Click -= NewDocumentButton_Click;
            createDocumentButton.Click -= NewDocumentButton_Click;
            onlineHelpButton.Click -= OnlineHelpButton_Click;
            gettingStartedButton.Click -= GettingStartedButton_Click;
            increaseFontSizeButton.Click -= IncreaseFontSizeButton_Click;
            decreaseFontSizeButton.Click -= DecreaseFontSizeButton_Click;
            fontColorSplitButton.Click -= FontColorSplitButton_Click;
            fontColorPicker.ColorChanged -= FontColorPicker_ColorChanged;
            highlightColorSplitButton.Click -= HighlightColorSplitButton_Click;
            noHighlightButton.Click -= DropDownItem_Click;
            yellowHighlightButton.Click -= DropDownItem_Click;
            brightGreenHighlightButton.Click -= DropDownItem_Click;
            turquoiseHighlightButton.Click -= DropDownItem_Click;
            pinkHighlightButton.Click -= DropDownItem_Click;
            blueHighlightButton.Click -= DropDownItem_Click;
            redHighlightButton.Click -= DropDownItem_Click;
            darkBlueHighlightButton.Click -= DropDownItem_Click;
            tealHighlightButton.Click -= DropDownItem_Click;
            greenHighlightButton.Click -= DropDownItem_Click;
            violetHighlightButton.Click -= DropDownItem_Click;
            darkRedHighlightButton.Click -= DropDownItem_Click;
            darkYellowHighlightButton.Click -= DropDownItem_Click;
            darkGrayHighlightButton.Click -= DropDownItem_Click;
            lightGrayHighlightButton.Click -= DropDownItem_Click;
            blackHighlightButton.Click -= DropDownItem_Click;
            foreach (MenuItem lineSpacingItem in lineSpacingMenuGroup.Items)
                lineSpacingItem.Click -= LineSpacingItem_Click;
            restrictEditingButton.IsSelectedChanged -= RestrictEditingButton_IsSelectedChanged;
            tablePicker.Click -= TablePicker_Click;
            insertTableButton.Click -= DropDownItem_Click;
            zoomInButton.Click -= ZoomInButton_Click;
            zoomOutButton.Click -= ZoomOutButton_Click;
        }
        /// <summary>
        /// Disposes the list options.
        /// </summary>
        /// <remarks></remarks>
        private void DisposeListOptions()
        {
            BindingOperations.ClearAllBindings(noBulletButton);
            noBulletButton.Click -= DropDownItem_Click;
            BindingOperations.ClearAllBindings(arrowBulletButton);
            arrowBulletButton.Click -= DropDownItem_Click;
            BindingOperations.ClearAllBindings(dotBulletButton);
            dotBulletButton.Click -= DropDownItem_Click;
            BindingOperations.ClearAllBindings(flowerBulletButton);
            flowerBulletButton.Click -= DropDownItem_Click;
            BindingOperations.ClearAllBindings(circleBulletButton);
            circleBulletButton.Click -= DropDownItem_Click;
            BindingOperations.ClearAllBindings(squareBulletButton);
            squareBulletButton.Click -= DropDownItem_Click;
            BindingOperations.ClearAllBindings(tickBulletButton);
            tickBulletButton.Click -= DropDownItem_Click;
            BindingOperations.ClearAllBindings(noNumberingButton);
            noNumberingButton.Click -= DropDownItem_Click;
            BindingOperations.ClearAllBindings(numberDotNumberingButton);
            numberDotNumberingButton.Click -= DropDownItem_Click;
            BindingOperations.ClearAllBindings(numberBraceNumberingButton);
            numberBraceNumberingButton.Click -= DropDownItem_Click;
            BindingOperations.ClearAllBindings(lowLetterDotNumberingButton);
            lowLetterDotNumberingButton.Click -= DropDownItem_Click;
            BindingOperations.ClearAllBindings(lowLetterBraceNumberingButton);
            lowLetterBraceNumberingButton.Click -= DropDownItem_Click;
            BindingOperations.ClearAllBindings(upLetterNumberingButton);
            upLetterNumberingButton.Click -= DropDownItem_Click;
            BindingOperations.ClearAllBindings(upRomanNumberingButton);
            upRomanNumberingButton.Click -= DropDownItem_Click;
            BindingOperations.ClearAllBindings(lowRomanNumberingButton);
            lowRomanNumberingButton.Click -= DropDownItem_Click;
            BindingOperations.ClearAllBindings(noListButton);
            noListButton.Click -= DropDownItem_Click;
            BindingOperations.ClearAllBindings(bulletedListButton);
            bulletedListButton.Click -= DropDownItem_Click;
            BindingOperations.ClearAllBindings(normalListButton);
            normalListButton.Click -= DropDownItem_Click;
            if (multilevelListButton.DataContext is ListViewModel)
                (multilevelListButton.DataContext as ListViewModel).Dispose();
            BindingOperations.ClearAllBindings(multilevelListButton);
            multilevelListButton.Click -= DropDownItem_Click;
            if (bulletedListSplitButton.DataContext is ListViewModel)
                (bulletedListSplitButton.DataContext as ListViewModel).Dispose();
            bulletedListSplitButton.DataContext = null;
            bulletedListSplitButton.Click -= BulletedListSplitButton_Click;
            if (numberedListSplitButton.DataContext is ListViewModel)
                (numberedListSplitButton.DataContext as ListViewModel).Dispose();
            numberedListSplitButton.DataContext = null;
            numberedListSplitButton.Click -= NumberedListSplitButton_Click;
        }
        #endregion

        #region Implementation
        /// <summary>
        /// Words the import.
        /// </summary>
#if Framework3_5 || Framework4_0
        private void WordImport()
#else
        private async void WordImport()
#endif
        {
            OpenFileDialog openDialog = new OpenFileDialog()
            {
                Filter = "All supported files (*.docx,*.doc,*.htm,*.html,*.rtf,*.txt,*.xaml)|*.docx;*.doc;*.htm;*.html;*.rtf,*.txt;*.xaml|Word Document (*.docx)|*.docx|Word 97 - 2003 Document (*.doc)|*.doc|Web Page (*.htm,*.html)|*.htm;*.html|Rich Text File (*.rtf)|*.rtf|Text File (*.txt)|*.txt|Xaml File (*.xaml)|*.xaml",
                FilterIndex = 1,
                Multiselect = false
            };
            if ((bool)openDialog.ShowDialog() && richTextBoxAdv != null)
            {
                Stream fileStream = openDialog.OpenFile();
                FileInfo file = new FileInfo(openDialog.FileName);
                string fileName = file.Name;
                string fileExtension = file.Extension;
                if (!string.IsNullOrEmpty(fileExtension) && fileStream != null)
                {
                    FormatType formatType = GetFormatType(fileExtension);
#if Framework3_5
                    RichTextBoxAdv.Load(fileStream, formatType);
#else
                    if (loadAsync != null && !loadAsync.IsCompleted && !loadAsync.IsFaulted && cancellationTokenSource != null)
                    {
                        cancellationTokenSource.Cancel();
                        try
                        {
                            if (!loadAsync.IsCanceled)
#if Framework4_0
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
#if Framework4_0
                        loadAsync = RichTextBoxAdv.LoadAsync(fileStream, formatType, cancellationTokenSource.Token);
#else
                        loadAsync = richTextBoxAdv.LoadAsync(fileStream, formatType, cancellationTokenSource.Token);
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
                    richTextBoxAdv.DocumentTitle = fileName.Remove(fileName.LastIndexOf("."));
                }
            }
        }
        /// <summary>
        /// Words the export.
        /// </summary>
        /// <param name="extension">The extension.</param>
#if Framework3_5 || Framework4_0
        private void WordExport(string extension)
#else
        private async void WordExport(string extension)
#endif
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            {
                saveDialog.Filter = "Word Document (*.docx)|*.docx|Word 97 - 2003 Document (*.doc)|*.doc|Web Page (*.htm,*.html)|*.htm;*.html|Rich Text File (*.rtf)|*.rtf|Text File (*.txt)|*.txt|Xaml File (*.xaml)|*.xaml";
            };
            if ((bool)saveDialog.ShowDialog())
            {
                Stream fileStream = saveDialog.OpenFile();
                FileInfo file = new FileInfo(saveDialog.FileName);
                string fileExtension = file.Extension;
                if (!string.IsNullOrEmpty(fileExtension))
                {
                    FormatType formatType = GetFormatType(fileExtension);
#if Framework3_5
                    RichTextBoxAdv.Save(fileStream, formatType);
#elif Framework4_0
                    RichTextBoxAdv.SaveAsync(fileStream, formatType);
#else
                    await richTextBoxAdv.SaveAsync(fileStream, formatType);
#endif
                }
                fileStream.Close();
            }
        }
        /// <summary>
        /// Gets the format type.
        /// </summary>
        /// <param name="extension"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        private FormatType GetFormatType(string extension)
        {
            switch (extension.ToLower())
            {
                case ".doc":
                    return FormatType.Doc;
                case ".rtf":
                    return FormatType.Rtf;
                case ".txt":
                    return FormatType.Txt;
                case ".htm":
                case ".html":
                    return FormatType.Html;
                case ".xaml":
                    return FormatType.Xaml;
                default:
                    return FormatType.Docx;
            }
        }
        /// <summary>
        /// Adds the font family source.
        /// </summary>
        private List<string> GetFontFamilySource()
        {
            List<string> fontFamilySource = new List<string>();
            foreach (FontFamily fontfamily in Fonts.SystemFontFamilies)
            {
                fontFamilySource.Add(fontfamily.Source);
            }
            return fontFamilySource;
        }
        /// <summary>
        /// Launches the URI.
        /// </summary>
        /// <param name="uri">The URI.</param>
        private void LaunchUri(Uri uri)
        {
            Process.Start(new ProcessStartInfo(uri.AbsoluteUri));
        }
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or
        /// resetting unmanaged resources.
        /// </summary>
        public void DisposeRibbon()
        {
            DataContext = null;
            UnWireEvents();
            fontFamilyComboBox = null;
            fontSizeComboBox = null;
            fontColorPicker = null;
            restrictEditingButton = null;
#if !Framework3_5 
#if !Framework4_0
            //Handled to cancel the asynchronous load operation.
            if (loadAsync != null && !loadAsync.IsCompleted && !loadAsync.IsFaulted && cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
                try
                {
                    //await loadAsync;
                }
                catch
                { }
            }
#endif
            loadAsync = null;
            cancellationTokenSource = null;
#endif
            if (ribbon != null)
            {
                ribbon.Loaded -= Ribbon_Loaded;
                ribbon.Dispose();
                ribbon = null;
            }
        }
        #endregion
    }
}

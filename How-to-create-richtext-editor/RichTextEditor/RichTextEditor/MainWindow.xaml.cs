using Syncfusion.Windows.Controls.RichTextBoxAdv;
using Syncfusion.Windows.Tools.Controls;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace RichTextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ToolBarAdv dhhd = new ToolBarAdv();

            SfRichTextBoxAdv richTextBoxAdv = new SfRichTextBoxAdv();
            richTextBoxAdv.LayoutType = LayoutType.Continuous;
        }
    }
}

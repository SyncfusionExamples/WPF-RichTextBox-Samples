using Syncfusion.Windows.Controls.RichTextBoxAdv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RichTextEditor
{
    public class ViewModel 
    {
        #region Fields
        private List<string> fontFamilySource;
        private double[] fontSizeSource;
        #endregion

        #region Properties

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or Sets the font family source.
        /// </summary>
        public List<string> FontFamilySource
        {
            get
            {
                return fontFamilySource;
            }
        }

        /// <summary>
        /// Gets or Sets the font size source.
        /// </summary>
        public double[] FontSizeSource
        {
            get
            {
                return fontSizeSource;
            }
        }

        #endregion

        #region Constructor
        public ViewModel()
        {
            AddFontFamily();
            AddFontSize();
        }
        #endregion

        #region Implementation
        /// <summary>
        /// Adds the font family.
        /// </summary>
        private void AddFontFamily()
        {
            fontFamilySource = new List<string>();
            foreach (FontFamily fontfamily in Fonts.SystemFontFamilies)
            {
                FontFamilySource.Add(fontfamily.Source);
            }
        }

        /// <summary>
        /// Adds the font size.
        /// </summary>
        private void AddFontSize()
        {
            fontSizeSource = new double[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 24, 26, 28, 36, 48, 72 };
        }
        #endregion
    }
}

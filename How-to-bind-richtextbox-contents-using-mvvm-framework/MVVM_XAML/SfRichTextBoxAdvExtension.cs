using Syncfusion.Windows.Controls.RichTextBoxAdv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Sample
{
    /// <summary>
    /// Represents the extension class for SfRichTextBoxAdv.
    /// </summary>
    public class SfRichTextBoxAdvExtension : SfRichTextBoxAdv
    {
        #region Fields
        bool skipUpdating = false;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or Sets the Xaml Text.
        /// </summary>
        public string XamlText
        {
            get
            {
                return (string)GetValue(XamlTextProperty);
            }
            set
            {
                SetValue(XamlTextProperty, value);
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes the instance of SfRichTextBoxAdvExtension class.
        /// </summary>
        public SfRichTextBoxAdvExtension()
        {
            // Wires the ContentChanged event.
            this.ContentChanged += RicTextBoxAdv_ContentChanged;
        }
        #endregion

        #region Static Dependency Properties
        /// <summary>
        /// Using as a backing store for XamlText dependency property to enable styling, animation etc.
        /// </summary>
        public static readonly DependencyProperty XamlTextProperty = DependencyProperty.Register("XamlText", typeof(string), typeof(SfRichTextBoxAdvExtension), new PropertyMetadata(string.Empty, new PropertyChangedCallback(OnXamlTextChanged)));
        #endregion

        #region Static Events
        /// <summary>
        /// Called when Xaml Text changed.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        private static void OnXamlTextChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            SfRichTextBoxAdvExtension richTextBox = (SfRichTextBoxAdvExtension)obj;
            //Update the document with the Xaml Text.
            richTextBox.UpdateDocument((string)e.NewValue);
        }
        #endregion

        #region Events
        /// <summary>
        /// Called when content changes in SfRichTextBoxAdv.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        void RicTextBoxAdv_ContentChanged(object obj, ContentChangedEventArgs args)
        {
            if (this.Document != null)
            {
                // To skip internal updation of document on setting XamlText property.
                skipUpdating = true;
                Stream stream = new MemoryStream();
                // Serialize the document as Xaml Format into stream.
                this.Save(stream, FormatType.Xaml);
                stream.Position = 0;
                // Reads the Xaml text from the stream.
                using (StreamReader reader = new StreamReader(stream))
                {
                    this.XamlText = reader.ReadToEnd();
                }
                skipUpdating = false;
            }
        }
        #endregion

        #region Implementation
        /// <summary>
        /// Updates the document.
        /// </summary>
        /// <param name="xamlText"></param>
        private void UpdateDocument(string xamlText)
        {
            // If XamlText property is set internally means, skip updating the document.
            if (!skipUpdating && !string.IsNullOrEmpty(xamlText))
            {
                Stream stream = new MemoryStream();
                // Convert the xaml text to byte array.
                byte[] bytes = Encoding.UTF8.GetBytes(xamlText);
                // Writes the byte array to stream.
                stream.Write(bytes, 0, bytes.Length);
                stream.Position = 0;
                //Load the stream.
                Load(stream, FormatType.Xaml);
            }
        }
        /// <summary>
        /// Disposes the instance.
        /// </summary>
        public new void Dispose()
        {
            this.ContentChanged -= RicTextBoxAdv_ContentChanged;
            ClearValue(XamlTextProperty);
            base.Dispose();
        }
        #endregion
    }

}

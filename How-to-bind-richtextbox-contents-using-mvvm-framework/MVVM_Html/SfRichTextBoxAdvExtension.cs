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
        /// Gets or Sets the Html Text.
        /// </summary>
        public string HtmlText
        {
            get
            {
                return (string)GetValue(HtmlTextProperty);
            }
            set
            {
                SetValue(HtmlTextProperty, value);
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
        /// Using as a backing store for HtmlText dependency property to enable styling, animation etc.
        /// </summary>
        public static readonly DependencyProperty HtmlTextProperty = DependencyProperty.Register("HtmlText", typeof(string), typeof(SfRichTextBoxAdvExtension), new PropertyMetadata(string.Empty, new PropertyChangedCallback(OnHtmlTextChanged)));
        #endregion

        #region Static Events
        /// <summary>
        /// Called when Html Text changed.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        private static void OnHtmlTextChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            SfRichTextBoxAdvExtension richTextBox = (SfRichTextBoxAdvExtension)obj;
            //Update the document with the Html Text.
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
                // To skip internal updation of document on setting HtmlText property.
                skipUpdating = true;
                Stream stream = new MemoryStream();
                // Serialize the document as Html Format into stream.
                this.Save(stream, FormatType.Html);
                stream.Position = 0;
                // Reads the Html text from the stream.
                using (StreamReader reader = new StreamReader(stream))
                {
                    this.HtmlText = reader.ReadToEnd();
                }
                skipUpdating = false;
            }
        }
        #endregion

        #region Implementation
        /// <summary>
        /// Updates the document.
        /// </summary>
        /// <param name="htmlText"></param>
        private void UpdateDocument(string htmlText)
        {
            // If HtmlText property is set internally means, skip updating the document.
            if (!skipUpdating && !string.IsNullOrEmpty(htmlText))
            {
                Stream stream = new MemoryStream();
                // Convert the html text to byte array.
                byte[] bytes = Encoding.UTF8.GetBytes(htmlText);
                // Writes the byte array to stream.
                stream.Write(bytes, 0, bytes.Length);
                stream.Position = 0;
                //Load the stream.
                Load(stream, FormatType.Html);
            }
        }
        /// <summary>
        /// Disposes the instance.
        /// </summary>
        public new void Dispose()
        {
            this.ContentChanged -= RicTextBoxAdv_ContentChanged;
            ClearValue(HtmlTextProperty);
            base.Dispose();
        }
        #endregion
    }
}

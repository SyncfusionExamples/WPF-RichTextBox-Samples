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
        /// Gets or Sets the Rtf Text.
        /// </summary>
        public string RtfText
        {
            get
            {
                return (string)GetValue(RtfTextProperty);
            }
            set
            {
                SetValue(RtfTextProperty, value);
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
        /// Using as a backing store for RtfText dependency property to enable styling, animation etc.
        /// </summary>
        public static readonly DependencyProperty RtfTextProperty = DependencyProperty.Register("RtfText", typeof(string), typeof(SfRichTextBoxAdvExtension), new PropertyMetadata(string.Empty, new PropertyChangedCallback(OnRtfTextChanged)));
        #endregion

        #region Static Events
        /// <summary>
        /// Called when Rtf Text changed.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        private static void OnRtfTextChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            SfRichTextBoxAdvExtension richTextBox = (SfRichTextBoxAdvExtension)obj;
            //Update the document with the Rtf Text.
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
                // Serialize the document as Rtf Format into stream.
                this.Save(stream, FormatType.Rtf);
                stream.Position = 0;
                // Reads the Rtf text from the stream.
                using (StreamReader reader = new StreamReader(stream))
                {
                    this.RtfText = reader.ReadToEnd();
                }
                skipUpdating = false;
            }
        }
        #endregion

        #region Implementation
        /// <summary>
        /// Updates the document.
        /// </summary>
        /// <param name="rtfText"></param>
        private void UpdateDocument(string rtfText)
        {
            // If RtfText property is set internally means, skip updating the document.
            if (!skipUpdating && !string.IsNullOrEmpty(rtfText))
            {
                Stream stream = new MemoryStream();
                // Convert the rtf text to byte array.
                byte[] bytes = Encoding.UTF8.GetBytes(rtfText);
                // Writes the byte array to stream.
                stream.Write(bytes, 0, bytes.Length);
                stream.Position = 0;
                //Load the stream.
                Load(stream, FormatType.Rtf);
            }
        }
        /// <summary>
        /// Disposes the instance.
        /// </summary>
        public new void Dispose()
        {
            this.ContentChanged -= RicTextBoxAdv_ContentChanged;
            ClearValue(RtfTextProperty);
            base.Dispose();
        }
        #endregion
    }
}

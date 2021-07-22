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
        /// Gets or Sets the text.
        /// </summary>
        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }
            set
            {
                SetValue(TextProperty, value);
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
        /// Using as a backing store for Text dependency property to enable styling, animation etc.
        /// </summary>
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(SfRichTextBoxAdvExtension), new PropertyMetadata(string.Empty, new PropertyChangedCallback(OnTextChanged)));
        #endregion

        #region Static Events
        /// <summary>
        /// Called when text changed.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        private static void OnTextChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            SfRichTextBoxAdvExtension richTextBox = (SfRichTextBoxAdvExtension)obj;
            //Update the document with the Text.
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
                // To skip internal updation of document on setting Text property.
                skipUpdating = true;
                Stream stream = new MemoryStream();
                // Saves the document's text into a Stream.
                this.Save(stream, FormatType.Txt);
                stream.Position = 0;
                // Reads the text from the stream.
                using (StreamReader reader = new StreamReader(stream))
                {
                    this.Text = reader.ReadToEnd();
                }
                skipUpdating = false;
            }
        }
        #endregion

        #region Implementation
        /// <summary>
        /// Updates the document.
        /// </summary>
        /// <param name="text"></param>
        private void UpdateDocument(string text)
        {
            // If text property is set internally means, skip updating the document.
            if (!skipUpdating && !string.IsNullOrEmpty(text))
            {
                Stream stream = new MemoryStream();
                // Convert the text to byte array.
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                // Writes the byte array to stream.
                stream.Write(bytes, 0, bytes.Length);
                stream.Position = 0;
                //Load the stream.
                Load(stream, FormatType.Txt);
            }
        }
        /// <summary>
        /// Disposes the instance.
        /// </summary>
        public new void Dispose()
        {
            this.ContentChanged -= RicTextBoxAdv_ContentChanged;
            ClearValue(TextProperty);
            base.Dispose();
        }
        #endregion
    }

}

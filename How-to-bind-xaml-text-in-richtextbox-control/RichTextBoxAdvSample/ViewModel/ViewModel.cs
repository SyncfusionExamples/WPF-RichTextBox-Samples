using Syncfusion.Windows.Controls.RichTextBoxAdv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace NotesEditor
{
    /// <summary>
    /// Sample View Model class
    /// </summary>
    public class ViewModel : INotifyPropertyChanged
    {
        #region Field
        private string documentTitle;
        private string xamlText;
        Dictionary<string, string> documents = null;
        bool skipUpdating = false;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the document title.
        /// </summary>
        /// <value>
        /// The document title.
        /// </value>
        public string DocumentTitle
        {
            get
            {
                return documentTitle;
            }
            set
            {
                documentTitle = value;
                NotifyPropertyChanged("DocumentTitle");
            }
        }
        /// <summary>
        /// Gets the documents.
        /// </summary>
        /// <value>
        /// The documents.
        /// </value>
        public ICollection<string> Documents
        {
            get
            {
                return documents.Keys;
            }
        }
        /// <summary>
        /// Gets or sets the document.
        /// </summary>
        /// <value>
        /// The document.
        /// </value>
        public string  XamlText
        {
            get
            {
                return xamlText;
            }
            set
            {
                xamlText = value;
                NotifyPropertyChanged("XamlText");
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel()
        {
            InitializeDocuments();
        }
        #endregion

        #region Event
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Implementation
        /// <summary>
        /// Notifies the property changed.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            // Updates the Html text when document title changes (reflects the view).
            if (propertyName == "DocumentTitle")
            {
                skipUpdating = true;
                XamlText = documents[documentTitle];
                skipUpdating = false;
            }
            // Updates the document content, when changes done in view.
            if (propertyName == "XamlText" && !skipUpdating)
                documents[DocumentTitle] = XamlText;
        }
        /// <summary>
        /// Initializes the documents.
        /// </summary>
        private void InitializeDocuments()
        {
            documents = new Dictionary<string, string>();
#if Framework3_5 || Framework4_0
            Assembly assembly = typeof(MainWindow).Assembly;
#else
            Assembly assembly = typeof(MainWindow).GetTypeInfo().Assembly;
#endif
            Stream stream = assembly.GetManifestResourceStream("NotesEditor.Assets.AdventureCycles.xaml");
            using (StreamReader reader = new StreamReader(stream))
            {
                documents.Add("Adventure Cycles", reader.ReadToEnd());
            }
            stream = assembly.GetManifestResourceStream("NotesEditor.Assets.GiantPanda.xaml");
            using (StreamReader reader = new StreamReader(stream))
            {
                documents.Add("Giant Panda", reader.ReadToEnd());
            }
            stream = assembly.GetManifestResourceStream("NotesEditor.Assets.MeetingMinutes.xaml");
            using (StreamReader reader = new StreamReader(stream))
            {
                documents.Add("Meeting Minutes", reader.ReadToEnd());
            }
            DocumentTitle = "Adventure Cycles";
        }
        #endregion
    }
}

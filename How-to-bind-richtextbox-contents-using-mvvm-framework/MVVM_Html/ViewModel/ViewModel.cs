using Syncfusion.Windows.Controls.RichTextBoxAdv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Sample
{
    /// <summary>
    /// Represents the view model class.
    /// </summary>
    public class ViewModel : INotifyPropertyChanged
    {
        #region Field
        private string animal;
        private string description;
        Dictionary<string, string> animals = null;
        bool skipUpdating = false;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the animal.
        /// </summary>
        /// <value>
        /// The document title.
        /// </value>
        public string Animal
        {
            get
            {
                return animal;
            }
            set
            {
                animal = value;
                NotifyPropertyChanged("Animal");
            }
        }
        /// <summary>
        /// Gets the animals.
        /// </summary>
        /// <value>
        /// The animals.
        /// </value>
        public ICollection<string> Animals
        {
            get
            {
                return animals.Keys;
            }
        }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The document.
        /// </value>
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                NotifyPropertyChanged("Description");
            }
        }
        #endregion

        #region Event
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel()
        {
            Initialize();
        }
        #endregion

        #region Implementation
        /// <summary>
        /// Handles initialization.
        /// </summary>
        private void Initialize()
        {
            animals = new Dictionary<string, string>();

            Assembly assembly = typeof(MainWindow).Assembly;

            Stream stream = assembly.GetManifestResourceStream("Sample.Assets.Tiger.html");
            using (StreamReader reader = new StreamReader(stream))
            {
                animals.Add("Tiger", reader.ReadToEnd());
            }

            stream = assembly.GetManifestResourceStream("Sample.Assets.Lion.html");
            using (StreamReader reader = new StreamReader(stream))
            {
                animals.Add("Lion", reader.ReadToEnd());
            }

            stream = assembly.GetManifestResourceStream("Sample.Assets.Panda.html");
            using (StreamReader reader = new StreamReader(stream))
            {
                animals.Add("Panda", reader.ReadToEnd());
            }

            stream = assembly.GetManifestResourceStream("Sample.Assets.Bear.html");
            using (StreamReader reader = new StreamReader(stream))
            {
                animals.Add("Bear", reader.ReadToEnd());
            }

            stream = assembly.GetManifestResourceStream("Sample.Assets.Deer.html");
            using (StreamReader reader = new StreamReader(stream))
            {
                animals.Add("Deer", reader.ReadToEnd());
            }

            Animal = "Lion";
        }
        /// <summary>
        /// Notifies the property changed.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

            // Updates the description when the animal changes. (This will be reflected in View)
            if (propertyName == "Animal")
            {
                skipUpdating = true;
                Description = animals[animal];
                skipUpdating = false;
            }

            // Updates the document content, when changes done in view. (This will be reflected in Data source)
            if (propertyName == "Description" && !skipUpdating)
                animals[Animal] = Description;
        }
        #endregion
    }

}

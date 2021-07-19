using Syncfusion.Windows.Controls.RichTextBoxAdv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
        /// Gets or sets the Description.
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

            animals.Add("Tiger", "The tiger is the largest cat species, reaching a total body length of up to 3.38 m over curves and exceptionally weighing up to 388.7 kg in the wild.");
            animals.Add("Lion", "The lion (Panthera leo) is one of the five big cats in the genus Panthera and a member of the family Felidae.");
            animals.Add("Panda", "The giant panda, also known as panda bear or simply panda, is a bear native to south central China. It is easily recognized by the large, distinctive black patches around its eyes, over the ears, and across its round body.");
            animals.Add("Beer", "Bears are mammals of the family Ursidae. Bears are classified as caniforms, or doglike carnivorans, with the pinnipeds being their closest living relatives.");
            animals.Add("Deer", "Deer are the ruminant mammals forming the family Cervidae. Species in the family include the white-tailed deer, mule deer, elk, moose, red deer, reindeer, fallow deer, roe deer, pudú and chital.");

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
            // Updates the text when the animal changes (This will be reflected in the view).
            if (propertyName == "Animal")
            {
                skipUpdating = true;
                Description = animals[animal];
                skipUpdating = false;
            }
            // Updates the document content, when changes done in view (This will be reflected in the data source).
            if (propertyName == "Description" && !skipUpdating)
                animals[Animal] = Description;
        }
        #endregion
    }
}

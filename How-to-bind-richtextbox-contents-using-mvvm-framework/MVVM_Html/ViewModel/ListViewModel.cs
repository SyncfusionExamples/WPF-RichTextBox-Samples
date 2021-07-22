using Syncfusion.Windows.Controls.RichTextBoxAdv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace Sample
{
    /// <summary>
    /// The List viewmodel class.
    /// </summary>
    /// <remarks></remarks>
    public class ListViewModel : INotifyPropertyChanged
    {
        #region Fields
        private string listName;
        private SfRichTextBoxAdv richTextBoxAdv = null;
        Dictionary<string, ListAdv> lists = new Dictionary<string, ListAdv>();
        private bool isRetrieving = false;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the ListName.
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public string ListName
        {
            get
            {
                return listName;
            }
            set
            {
                if (value == listName)
                    return;
                listName = value;
                NotifyPropertyChanged("ListName");
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DocumentEditor_WPF.ListViewModel">ListViewModel</see> class. 
        /// </summary>
        /// <param name="richTextBoxAdv"></param>
        /// <remarks></remarks>
        public ListViewModel(SfRichTextBoxAdv richTextBoxAdv)
        {
            this.richTextBoxAdv = richTextBoxAdv;
            List<string> listNames = new List<string>() 
            {
                "_Bullet_Dot", "_Bullet_Square", "_Bullet_Circle", "_Bullet_Flower", "_Bullet_Tick", "_Bullet_Arrow" ,
                "_Numbering_LowLetter_Brace","_Numbering_LowLetter_Dot","_Numbering_Number_Brace","_Numbering_Number_Dot","_Numbering_UpLetter","_Numbering_UpRoman","_Numbering_LowRoman",
                "_List_Normal","_List_Multilevel","_List_Bullet"
            };
            foreach (string listName in listNames)
            {
                lists.Add(listName, CreateList(listName));
            }
            richTextBoxAdv.SelectionChanged += richTextBoxAdv_SelectionChanged;
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Occurs when the richTextBoxAdv selection changes
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args">An <see cref="T:Syncfusion.Windows.Tools.RichTextBoxAdv.SelectionChangedEventArgs">SelectionChangedEventArgs</see> that contains the event data.</param>
        /// <remarks></remarks>
        void richTextBoxAdv_SelectionChanged(object obj, SelectionChangedEventArgs args)
        {
            isRetrieving = true;
            ListAdv list = richTextBoxAdv.Selection.ParagraphFormat.GetList();
            if (list == null)
            {
                if (richTextBoxAdv.Selection.ParagraphFormat.ListLevelNumber == 0)
                    ListName = "NoList";
                else
                    ListName = "Null";
            }
            else
            {
                list = richTextBoxAdv.Selection.Start.Paragraph.ParagraphFormat.ListFormat.List;
                bool hasList = false;
                foreach (string name in lists.Keys)
                {
                    if (lists[name] == list)
                    {
                        ListName = name;
                        hasList = true;
                        break;
                    }
                }
                if (!hasList)
                    ListName = "List";
            }
            isRetrieving = false;
        }
        #endregion

        #region Implementation
        /// <summary>
        /// Notifies when the property changes
        /// </summary>
        /// <param name="propertyName"></param>
        /// <remarks></remarks>
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            if (!isRetrieving)
            {
                if (listName == "NoList")
                    richTextBoxAdv.Selection.ParagraphFormat.SetList(null);
                if (lists.ContainsKey(ListName))
                    richTextBoxAdv.Selection.ParagraphFormat.SetList(lists[ListName]);
            }
        }
        /// <summary>
        /// Creates the list
        /// </summary>
        /// <param name="listName"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        internal ListAdv CreateList(string listName)
        {
            AbstractListAdv abstractListAdv = new AbstractListAdv(null);
            ListAdv list = new ListAdv(null);
            list.AbstractList = abstractListAdv;
            if (listName.StartsWith("_List"))
            {
                AddListLevels(abstractListAdv, listName);
            }
            else
            {
                ListLevelAdv listLevel = new ListLevelAdv(abstractListAdv);
                abstractListAdv.Levels.Add(listLevel);
                if (listName.StartsWith("_Bullet"))
                {
                    listLevel.ListLevelPattern = ListLevelPattern.Bullet;
                    switch (listName.Substring(8))
                    {
                        case "Dot":
                            listLevel.NumberFormat = "\uf0b7";
                            listLevel.CharacterFormat.FontFamily = new FontFamily("Symbol");
                            break;
                        case "Square":
                            listLevel.NumberFormat = "\uf0a7";
                            listLevel.CharacterFormat.FontFamily = new FontFamily("Wingdings");
                            break;
                        case "Circle":
                            listLevel.NumberFormat = "\uf06f" + "\u0020";
                            listLevel.CharacterFormat.FontFamily = new FontFamily("Symbol");
                            break;
                        case "Flower":
                            listLevel.NumberFormat = "\uf076";
                            listLevel.CharacterFormat.FontFamily = new FontFamily("Wingdings");
                            break;
                        case "Arrow":
                            listLevel.NumberFormat = "\uf0d8";
                            listLevel.CharacterFormat.FontFamily = new FontFamily("Wingdings");
                            break;
                        case "Tick":
                            listLevel.NumberFormat = "\uf0fc";
                            listLevel.CharacterFormat.FontFamily = new FontFamily("Wingdings");
                            break;
                    }
                }
                else
                {
                    if (listName.Contains("UpRoman"))
                        listLevel.ListLevelPattern = ListLevelPattern.UpRoman;
                    else if (listName.Contains("LowRoman"))
                        listLevel.ListLevelPattern = ListLevelPattern.LowRoman;
                    else if (listName.Contains("UpLetter"))
                        listLevel.ListLevelPattern = ListLevelPattern.UpLetter;
                    else if (listName.Contains("LowLetter"))
                        listLevel.ListLevelPattern = ListLevelPattern.LowLetter;
                    else if (listName.Contains("Number"))
                        listLevel.ListLevelPattern = ListLevelPattern.Number;
                    if (listName.EndsWith("Brace"))
                        listLevel.NumberFormat = "%1)";
                    else
                        listLevel.NumberFormat = "%1.";
                    listLevel.StartAt = 1;
                }
                listLevel.CharacterFormat.FontColor = Colors.Black;
                listLevel.CharacterFormat.FontSize = 13.33;
                listLevel.ParagraphFormat.LeftIndent = 48;
                listLevel.ParagraphFormat.FirstLineIndent = -24;
            }
            return list;
        }
        /// <summary>
        /// Adds the list levels
        /// </summary>
        /// <param name="abstractList"></param>
        /// <param name="listName"></param>
        /// <remarks></remarks>
        internal void AddListLevels(AbstractListAdv abstractList, string listName)
        {
            List<string> bulletCharacters = new List<string>() { "\uf076", "\uf0d8", "\uf0a7", "\uf0b7", "\uf0a8" };
            for (int i = abstractList.Levels.Count; i < 9; i++)
            {
                ListLevelAdv listLevel = new ListLevelAdv(abstractList);
                if (listName.Contains("Bullet"))
                {
                    listLevel.ListLevelPattern = ListLevelPattern.Bullet;
                    listLevel.NumberFormat = bulletCharacters[i < 5 ? i % 5 : i % 5 + 1];
                    listLevel.CharacterFormat.FontFamily = i < 3 || i == 5 ? new FontFamily("Wingdings") : new FontFamily("Symbol");
                }
                else
                {
                    if (listName.Contains("Multilevel"))
                    {
                        for (int j = 0; j < i + 1; j++)
                            listLevel.NumberFormat += "%" + (j + 1).ToString() + ".";
                    }
                    else
                        listLevel.NumberFormat = "%" + (i + 1).ToString() + ".";
                    listLevel.StartAt = 1;
                    listLevel.RestartLevel = i;
                    listLevel.ListLevelPattern = i % 3 == 0 ? ListLevelPattern.Number
                        : i % 3 == 1 ? ListLevelPattern.LowLetter : ListLevelPattern.LowRoman;
                }
                listLevel.CharacterFormat.FontColor = Colors.Black;
                listLevel.CharacterFormat.FontSize = 13.33;
                listLevel.ParagraphFormat.LeftIndent = i == 0 ? 24 : 48 * i;
                listLevel.ParagraphFormat.FirstLineIndent = -24;
                abstractList.Levels.Add(listLevel);
            }
        }
        /// <summary>
        /// Releases all resources used by the.
        /// <see cref="T:DocumentEditor_WPF.ListViewModel">ListViewModel</see>.
        /// </summary>
        /// <remarks></remarks>
        internal void Dispose()
        {
            richTextBoxAdv.SelectionChanged -= richTextBoxAdv_SelectionChanged;
            listName = null;
            lists.Clear();
            lists = null;
            richTextBoxAdv = null;
        }
        #endregion
    }
}

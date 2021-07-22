using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentEditor
{
    public class DocumentEditorResourceWrapper
    {
        public static string Home
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Home");
            }
        }
        public static string Undo
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Undo");
            }
        }
        public static string UndoToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "UndoToolTip");
            }
        }
        public static string Redo
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Redo");
            }
        }
        public static string RedoToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "RedoToolTip");
            }
        }
        public static string Save
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Save");
            }
        }
        public static string SaveToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "SaveToolTip");
            }
        }
        public static string New
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "New");
            }
        }
        public static string Open
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Open");
            }
        }
        public static string SaveAs
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "SaveAs");
            }
        }
        public static string WordDocx
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "WordDocx");
            }
        }
        public static string WordDoc
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "WordDoc");
            }
        }
        public static string HtmlDocument
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "HtmlDocument");
            }
        }
        public static string XamlDocument
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "XamlDocument");
            }
        }
        public static string TextDocument
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "TextDocument");
            }
        }
        public static string Print
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Print");
            }
        }
        public static string Information
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Information");
            }
        }
        public static string ProtectDocument
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "ProtectDocument");
            }
        }
        public static string Editing
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Editing");
            }
        }
        public static string RestrictEditing
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "RestrictEditing");
            }
        }
        public static string RestrictEditingToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "RestrictEditingToolTip");
            }
        }
        public static string EncryptWithPassword
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "EncryptWithPassword");
            }
        }
        public static string EncryptWithPasswordToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "EncryptWithPasswordToolTip");
            }
        }
        public static string ProtectDocumentToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "ProtectDocumentToolTip");
            }
        }
        public static string AvailableTemplates
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "AvailableTemplates");
            }
        }
        public static string BlankDocument
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "BlankDocument");
            }
        }
        public static string BlankDocumentToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "BlankDocumentToolTip");
            }
        }
        public static string Create
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Create");
            }
        }
        public static string UserInterfaceHelp
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "UserInterfaceHelp");
            }
        }
        public static string OnlineHelp
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "OnlineHelp");
            }
        }
        public static string OnlineHelpToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "OnlineHelpToolTip");
            }
        }
        public static string GettingStarted
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "GettingStarted");
            }
        }
        public static string GettingStartedToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "GettingStartedToolTip");
            }
        }
        public static string CutToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "CutToolTip");
            }
        }
        public static string Paste
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Paste");
            }
        }
        public static string PasteToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "PasteToolTip");
            }
        }
        public static string Copy
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Copy");
            }
        }
        public static string CopyToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "CopyToolTip");
            }
        }
        public static string PasteToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "PasteToolTipHeader");
            }
        }
        public static string CutToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "CutToolTipHeader");
            }
        }
        public static string CopyToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "CopyToolTipHeader");
            }
        }
        public static string FontToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "FontToolTipHeader");
            }
        }
        public static string FontToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "FontToolTip");
            }
        }
        public static string FontSizeToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "FontSizeToolTipHeader");
            }
        }
        public static string FontSizeToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "FontSizeToolTip");
            }
        }
        public static string IncreaseFontSizeToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "IncreaseFontSizeToolTipHeader");
            }
        }
        public static string IncreaseFontSizeToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "IncreaseFontSizeToolTip");
            }
        }
        public static string DecreaseFontSizeToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "DecreaseFontSizeToolTipHeader");
            }
        }
        public static string DecreaseFontSizeToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "DecreaseFontSizeToolTip");
            }
        }
        public static string GrowFont
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "GrowFont");
            }
        }
        public static string DecreaseFont
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "DecreaseFont");
            }
        }
        public static string Bold
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Bold");
            }
        }
        public static string BoldToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "BoldToolTipHeader");
            }
        }
        public static string BoldToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "BoldToolTip");
            }
        }
        public static string Italic
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Italic");
            }
        }
        public static string ItalicToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "ItalicToolTipHeader");
            }
        }
        public static string ItalicToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "ItalicToolTip");
            }
        }
        public static string Underline
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Underline");
            }
        }
        public static string UnderlineToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "UnderlineToolTipHeader");
            }
        }
        public static string UnderlineToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "UnderlineToolTip");
            }
        }
        public static string SingleStrike
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "SingleStrike");
            }
        }
        public static string StrikethroughToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "StrikethroughToolTipHeader");
            }
        }
        public static string StrikethroughToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "StrikethroughToolTip");
            }
        }
        public static string SubScript
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "SubScript");
            }
        }
        public static string SubScriptToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "SubScriptToolTipHeader");
            }
        }
        public static string SubScriptToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "SubScriptToolTip");
            }
        }
        public static string SuperScript
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "SuperScript");
            }
        }
        public static string SuperScriptToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "SuperScriptToolTipHeader");
            }
        }
        public static string SuperScriptToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "SuperScriptToolTip");
            }
        }
        public static string TextHighlightColor
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "TextHighlightColor");
            }
        }
        public static string TextHighlightColorToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "TextHighlightColorToolTip");
            }
        }
        public static string YellowHighlightToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "YellowHighlightToolTip");
            }
        }
        public static string BrightGreenHighlightToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "BrightGreenHighlightToolTip");
            }
        }
        public static string TurquoiseHighlightToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "TurquoiseHighlightToolTip");
            }
        }
        public static string PinkHighlightToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "PinkHighlightToolTip");
            }
        }
        public static string BlueHighlightToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "BlueHighlightToolTip");
            }
        }
        public static string RedHighlightToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "RedHighlightToolTip");
            }
        }
        public static string DarkBlueHighlightToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "DarkBlueHighlightToolTip");
            }
        }
        public static string TealHighlightToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "TealHighlightToolTip");
            }
        }
        public static string GreenHighlightToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "GreenHighlightToolTip");
            }
        }
        public static string VioletHighlightToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "VioletHighlightToolTip");
            }
        }
        public static string DarkRedHighlightToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "DarkRedHighlightToolTip");
            }
        }
        public static string DarkYellowHighlightToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "DarkYellowHighlightToolTip");
            }
        }
        public static string Gray50HighlightToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Gray50HighlightToolTip");
            }
        }
        public static string Gray25HighlightToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Gray25HighlightToolTip");
            }
        }
        public static string BlackHighlightToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "BlackHighlightToolTip");
            }
        }
        public static string NoColor
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "NoColor");
            }
        }
        public static string FontColor
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "FontColor");
            }
        }
        public static string FontColorToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "FontColorToolTip");
            }
        }
        public static string Paragraph
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Paragraph");
            }
        }
        public static string BulletsToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "BulletsToolTipHeader");
            }
        }
        public static string BulletsToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "BulletsToolTip");
            }
        }
        public static string BulletsToolTipMore
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "BulletsToolTipMore");
            }
        }
        public static string BulletLibrary
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "BulletLibrary");
            }
        }
        public static string None
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "None");
            }
        }
        public static string DefineList
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "DefineList");
            }
        }
        public static string NumberingToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "NumberingToolTipHeader");
            }
        }
        public static string NumberingToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "NumberingToolTip");
            }
        }
        public static string NumberingToolTipMore
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "NumberingToolTipMore");
            }
        }
        public static string NumberingLibrary
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "NumberingLibrary");
            }
        }
        public static string NumberLeftAlignment
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "NumberLeftAlignment");
            }
        }
        public static string NumberRightAlignment
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "NumberRightAlignment");
            }
        }
        public static string MultilevelListToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "MultilevelListToolTipHeader");
            }
        }
        public static string MultilevelListToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "MultilevelListToolTip");
            }
        }
        public static string ListLibrary
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "ListLibrary");
            }
        }
        public static string DecreaseIndentToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "DecreaseIndentToolTipHeader");
            }
        }
        public static string DecreaseIndentToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "DecreaseIndentToolTip");
            }
        }
        public static string IncreaseIndentToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "IncreaseIndentToolTipHeader");
            }
        }
        public static string IncreaseIndentToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "IncreaseIndentToolTip");
            }
        }
        public static string AlignLeft
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "AlignLeft");
            }
        }
        public static string AlignLeftToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "AlignLeftToolTipHeader");
            }
        }
        public static string AlignLeftToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "AlignLeftToolTip");
            }
        }

        public static string AlignCenter
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "AlignCenter");
            }
        }
        public static string AlignCenterToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "AlignCenterToolTipHeader");
            }
        }
        public static string AlignCenterToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "AlignCenterToolTip");
            }
        }
        public static string AlignRight
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "AlignRight");
            }
        }
        public static string AlignRightToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "AlignRightToolTipHeader");
            }
        }
        public static string AlignRightToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "AlignRightToolTip");
            }
        }
        public static string AlignJustify
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "AlignJustify");
            }
        }
        public static string AlignJustifyToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "AlignJustifyToolTipHeader");
            }
        }
        public static string AlignJustifyToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "AlignJustifyToolTip");
            }
        }
        public static string LineSpacingToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "LineSpacingToolTipHeader");
            }
        }
        public static string LineSpacingToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "LineSpacingToolTip");
            }
        }
        public static string ReadOnly
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "ReadOnly");
            }
        }
        public static string ReadOnlyToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "ReadOnlyToolTip");
            }
        }
        public static string Find
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Find");
            }
        }
        public static string FindToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "FindToolTipHeader");
            }
        }
        public static string FindToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "FindToolTip");
            }
        }
        public static string Replace
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Replace");
            }
        }
        public static string ReplaceToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "ReplaceToolTipHeader");
            }
        }
        public static string ReplaceToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "ReplaceToolTip");
            }
        }
        public static string Insert
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Insert");
            }
        }
        public static string Tables
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Tables");
            }
        }
        public static string Table
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Table");
            }
        }
        public static string AddTableToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "AddTableToolTipHeader");
            }
        }
        public static string AddTableToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "AddTableToolTip");
            }
        }
        public static string InsertTable
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "InsertTable");
            }
        }
        public static string Illustrations
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Illustrations");
            }
        }
        public static string PictureToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "PictureToolTipHeader");
            }
        }
        public static string PictureToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "PictureToolTip");
            }
        }
        public static string Picture
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Picture");
            }
        }
        public static string Links
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Links");
            }
        }
        public static string Hyperlink
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Hyperlink");
            }
        }
        public static string HyperlinkToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "HyperlinkToolTipHeader");
            }
        }
        public static string HyperlinkToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "HyperlinkToolTip");
            }
        }
        public static string Review
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Review");
            }
        }
        public static string Proofing
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Proofing");
            }
        }
        public static string Spelling
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Spelling");
            }
        }
        public static string SpellingToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "SpellingToolTipHeader");
            }
        }
        public static string SpellingToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "SpellingToolTip");
            }
        }
        public static string Comments
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Comments");
            }
        }
        public static string NewComment
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "NewComment");
            }
        }
        public static string InsertCommentToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "InsertCommentToolTipHeader");
            }
        }
        public static string InsertCommentToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "InsertCommentToolTip");
            }
        }
        public static string DeleteComment
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "DeleteComment");
            }
        }
        public static string DeleteCommentToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "DeleteCommentToolTipHeader");
            }
        }
        public static string DeleteCommentToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "DeleteCommentToolTip");
            }
        }
        public static string PreviousComment
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "PreviousComment");
            }
        }
        public static string PreviousCommentToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "PreviousCommentToolTipHeader");
            }
        }
        public static string PreviousCommentToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "PreviousCommentToolTip");
            }
        }
        public static string NextComment
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "NextComment");
            }
        }
        public static string NextCommentToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "NextCommentToolTip");
            }
        }
        public static string NextCommentToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "NextCommentToolTipHeader");
            }
        }
        public static string ShowCommentsToolTipHeader
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "ShowCommentsToolTipHeader");
            }
        }
        public static string ShowCommentsToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "ShowCommentsToolTip");
            }
        }
        public static string View
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "View");
            }
        }
        public static string Views
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Views");
            }
        }
        public static string PrintLayout
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "PrintLayout");
            }
        }
        public static string PrintLayoutToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "PrintLayoutToolTip");
            }
        }
        public static string WebLayout
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "WebLayout");
            }
        }
        public static string WebLayoutToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "WebLayoutToolTip");
            }
        }
        public static string Zoom
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Zoom");
            }
        }
        public static string ZoomIn
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "ZoomIn");
            }
        }
        public static string ZoomInToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "ZoomInToolTip");
            }
        }
        public static string ZoomOut
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "ZoomOut");
            }
        }
        public static string ZoomOutToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "ZoomOutToolTip");
            }
        }
        public static string Zoom100
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Zoom100");
            }
        }
        public static string Zoom100ToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Zoom100ToolTip");
            }
        }
        public static string OnePageView
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "OnePageView");
            }
        }
        public static string OnePageViewToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "OnePageViewToolTip");
            }
        }
        public static string MultiplePagesView
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "MultiplePagesView");
            }
        }
        public static string MultiplePagesViewToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "MultiplePagesViewToolTip");
            }
        }
        public static string PageWidth
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "PageWidth");
            }
        }
        public static string PageWidthToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "PageWidthToolTip");
            }
        }
        public static string Info
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Info");
            }
        }
        public static string Help
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Help");
            }
        }
        public static string Clipboard
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Clipboard");
            }
        }
        public static string Font
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Font");
            }
        }
        public static string Cut
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "Cut");
            }
        }
        public static string WordDocxToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "WordDocxToolTip");
            }
        }
        public static string XamlDocumentToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "XamlDocumentToolTip");
            }
        }
        public static string WordDocToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "WordDocToolTip");
            }
        }
        public static string HtmlDocumentToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "HtmlDocumentToolTip");
            }
        }
        public static string TextDocumentToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "TextDocumentToolTip");
            }
        }
        public static string RibbonStatusBarPage
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "RibbonStatusBarPage");
            }
        }
        public static string RibbonStatusBarPageOf
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "RibbonStatusBarPageOf");
            }
        }
        public static string RibbonStatusBarPageToolTip
        {
            get
            {
                return SR.GetString(CultureInfo.CurrentUICulture, "RibbonStatusBarPageToolTip");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLibrary
{
    public class NoteModel
    {
        public enum NoteType
        {
            ShoppingList,
            Meeting,
            TodoList,
            Miscellaneous,
        }
        public CreatorModel Creator { get; set; }
        public string NoteContent { get; set; }
        public string NoteTitle { get; set; }
        public NoteType _noteType { get; set; }
        public List<String>? EditorList { get; set; }
        public DateTime createdTime { get; set; }
        public DateTime updatedTime { get; set; }

        public NoteModel(CreatorModel Creator, string NoteTitle, string NoteContent,NoteType _noteType)
        {
            this.Creator= Creator;
            this.NoteTitle = NoteTitle;
            this.NoteContent= NoteContent;
            this._noteType= _noteType;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLibrary
{
    public class CreatorModel
    {
        public enum PermissionType
        {
            Admin,
            Creator,
            CoEditor,
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public Dictionary<PermissionType, NoteModel> NotePermitDict = new Dictionary<PermissionType, NoteModel>();

        public CreatorModel(string Name,string Email) 
        { 
            this.Name = Name;
            this.Email = Email;
        }
        public void CreateNote(NoteModel note)
        {
            NotePermitDict.Add(PermissionType.Creator, note);
        }

    }
}

using LibraryDisplay.Models.Enums;

namespace LibraryDisplay.Utils.Models
{
    public class EditStatus
    {
        public bool HasChanges { get; set; }
        public DbTable Table { get; set; }
        public EditStatus(bool hasChanges, DbTable table)
        {
            HasChanges = hasChanges;
            Table = table;
        }
    }
}

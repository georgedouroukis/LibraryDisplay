using LibraryDisplay.Models;
using LibraryDisplay.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDisplay.Utils.Models
{
    public class NavigationItem
    {
        public PanelState panelState { get; set; }
        public bool? bookCheckBox { get; set; }
        public bool? authorCheckBox { get; set; }
        public bool? publisherCheckBox { get; set; }
        public string? searchString { get; set; }
        public int? id { get; set; }
        public Book? referencedBook { get; set; }
        public Author? referencedAuthor { get; set; }
        public Publisher? referencedPublisher { get; set; }
        public Genre? referencedGenre { get; set; }

    }
}

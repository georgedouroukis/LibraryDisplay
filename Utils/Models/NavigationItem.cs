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
        public string? referencedId { get; set; }
        public Book? book { get; set; }
        public Author? author { get; set; }
        public Publisher? publisher { get; set; }
        public Genre? genre { get; set; }

        public NavigationItem(PanelState panelState)
        {
            this.panelState = panelState;
        }

    }
}

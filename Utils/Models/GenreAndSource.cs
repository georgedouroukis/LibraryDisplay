using LibraryDisplay.Models;
using LibraryDisplay.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDisplay.Utils.Models
{
    public class GenreAndSource
    {
        public Genre genre;
        public CallFrom source;

        public GenreAndSource(Genre genre, CallFrom source) 
        {
            this.genre = genre;
            this.source = source;
        }
    }
}

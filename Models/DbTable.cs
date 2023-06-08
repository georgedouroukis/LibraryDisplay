namespace LibraryDisplay.Models
{
    public enum DbTable { Book = 1, Author = 2, Publisher = 3, Genre = 4 }

    public enum CallFrom { EditBook = 1, CreateBook = 2, EditGenreParent = 3, CreateGenreParent = 4, EditGenreSub = 5, CreateGenreSub = 6, None = 7}
}

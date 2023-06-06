namespace LibraryDisplay.Models
{
    public enum DbTable { Book = 1, Author = 2, Publisher = 3, Genre = 4 }

    public enum CallFrom { EditBook = 1, CreateBook = 2, EditGenre = 3, CreateGenre = 4, None = 5}
}

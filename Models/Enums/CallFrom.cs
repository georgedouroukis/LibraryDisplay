namespace LibraryDisplay.Models.Enums
{
    /// <summary>
    ///  Used to identify from which combobox and from where the create new has been pressed so to go after save 
    ///  None means called from home control or return to homecontrol after save
    /// </summary>
    public enum CallFrom
    {
        EditBook = 1,
        CreateBook = 2,
        EditGenreParent = 3,
        CreateGenreParent = 4,
        EditGenreSub = 5,
        CreateGenreSub = 6,
        None = 7
    }
}

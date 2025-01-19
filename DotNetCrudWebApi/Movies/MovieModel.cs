namespace DotNetCrudWebApi.Movies
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public DateTime ReleaseDate { get; set; } = DateTime.Now; // Default to the current date and time   
        public string? Language { get; set; } = "hindi";
    }
}

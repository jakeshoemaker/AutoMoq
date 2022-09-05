namespace MoqApi.Models;

public class Recipe
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public List<string> Ingredients { get; set; } = new List<string> {}; 
    public int Temperature { get; set; }
    public int Time { get; set; }
    public int ServingSize { get; set; }
}
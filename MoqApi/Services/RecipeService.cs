using MoqApi.Models;

namespace MoqApi.Services;

public interface IRecipeService
{
    IEnumerable<Recipe> GetAllRecipes();
    Recipe GetRecipeById(Guid id);
    Recipe CreateRecipe(Recipe recipe);
}

public class RecipeService : IRecipeService
{
    private readonly ILogger<RecipeService> _logger;
    public List<Recipe> _recipes;
    public RecipeService(ILogger<RecipeService> logger)
    {
        _logger = logger;
        _recipes = new List<Recipe>();
        _recipes.Add(
            new Recipe() {
                Id = new Guid(),
                Title = "Pepperoni Pizza",
                Ingredients = new List<string>() { "Dough", "Cheese", "Sauce", "Pepperoni" },
                Temperature = 600,
                Time = 15,
                ServingSize = 4
            }
        );
    }

    public Recipe CreateRecipe(Recipe recipe)
    {
        var id = new Guid();
        recipe.Id = id;
        _recipes.Add(recipe);
        return recipe;
    }

    public IEnumerable<Recipe> GetAllRecipes()
    {
        return _recipes;
    }

    public Recipe GetRecipeById(Guid id)
    {
        var recp =  _recipes.FirstOrDefault(l => l.Id == id);
        if (recp is null)
            throw new Exception("recipe not found");
        return recp;
    }
}

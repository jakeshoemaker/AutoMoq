using Microsoft.AspNetCore.Mvc;
using MoqApi.Models;
using MoqApi.Services;

namespace MoqApi.Controllers;

[ApiController]
[Route("api/recipes")]
public class RecipeController : ControllerBase
{
    private readonly IRecipeService _recipeService;
    public RecipeController(IRecipeService recipeService)
    {
        _recipeService = recipeService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var recipes = _recipeService.GetAllRecipes();
        if (recipes.Any())
            return Ok(recipes);
        
        return NoContent();
    }
}

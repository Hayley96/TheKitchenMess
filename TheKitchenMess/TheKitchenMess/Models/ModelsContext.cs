using Microsoft.EntityFrameworkCore;

namespace TheKitchenMess.Models
{
    public class ModelsContext : DbContext
    {
        public ModelsContext(DbContextOptions<ModelsContext> options) : base(options)
        {
        }

        public DbSet<Root>? RecipeRoot { get; set; }
        public DbSet<Result>? Recipes { get; set; }
        public DbSet<AnalyzedInstructions>? analyzedInstructions { get; set; }
        public DbSet<Equipment>? equipments { get; set; }
        public DbSet<Ingredient>? ingredients { get; set; }
        public DbSet<Step>? steps { get; set; }
    }
}
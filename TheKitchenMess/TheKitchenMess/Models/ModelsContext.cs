using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TheKitchenMess.Models
{
    public class ModelsContext : DbContext
    {
        public ModelsContext(DbContextOptions<ModelsContext> options) : base(options)
        {
        }

        public DbSet<Root>? RecipeRoot { get; set; }
        public DbSet<Result>? Recipes { get; set; }
        public DbSet<Nutrient>? Nutrients { get; set; }
        public DbSet<Nutrition>? Nutrition { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var splitStringConverter = new ValueConverter<IEnumerable<string>, string>(v => string.Join(",", v), v => v.Split(new[] { ',' }));
            builder.Entity<Result>().Property(nameof(Result.Cuisines)).HasConversion(splitStringConverter);
            builder.Entity<Result>().Property(nameof(Result.DishTypes)).HasConversion(splitStringConverter);
            builder.Entity<Result>().Property(nameof(Result.Diets)).HasConversion(splitStringConverter);

        }
   

    
    }
}
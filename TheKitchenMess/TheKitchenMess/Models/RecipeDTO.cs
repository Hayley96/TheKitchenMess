namespace TheKitchenMess.Models
{
    public class RecipeDTO
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public double Calories { get; set; }
        public int ReadyInMinutes { get; set; }
        public int Servings { get; set; }
        public string? SpoonacularSourceUrl { get; set; }
    }
}
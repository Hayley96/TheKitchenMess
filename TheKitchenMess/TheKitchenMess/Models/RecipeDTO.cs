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

        //public RecipeDTO(long id, string title, double calories, int readyInMin, int servings, string url)
        //{
        //    Id = id;
        //    Title = title;
        //    Calories = calories;
        //    ReadyInMinutes = readyInMin;
        //    Servings = servings;
        //    SpoonacularSourceUrl = url;
        //}
    }
}
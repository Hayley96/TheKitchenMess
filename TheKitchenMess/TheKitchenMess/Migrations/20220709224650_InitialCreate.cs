using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TheKitchenMess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nutrition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecipeRoot",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Offset = table.Column<int>(type: "integer", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    TotalResults = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeRoot", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nutrients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    NutritionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nutrients_Nutrition_NutritionId",
                        column: x => x.NutritionId,
                        principalTable: "Nutrition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Vegetarian = table.Column<bool>(type: "boolean", nullable: false),
                    Vegan = table.Column<bool>(type: "boolean", nullable: false),
                    GlutenFree = table.Column<bool>(type: "boolean", nullable: false),
                    DairyFree = table.Column<bool>(type: "boolean", nullable: false),
                    LowFodmap = table.Column<bool>(type: "boolean", nullable: false),
                    WeightWatcherSmartPoints = table.Column<int>(type: "integer", nullable: false),
                    PreparationMinutes = table.Column<int>(type: "integer", nullable: false),
                    CookingMinutes = table.Column<int>(type: "integer", nullable: false),
                    License = table.Column<string>(type: "text", nullable: true),
                    SourceName = table.Column<string>(type: "text", nullable: true),
                    Recipeid = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    ReadyInMinutes = table.Column<int>(type: "integer", nullable: false),
                    Servings = table.Column<int>(type: "integer", nullable: false),
                    SourceUrl = table.Column<string>(type: "text", nullable: true),
                    OpenLicense = table.Column<int>(type: "integer", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: true),
                    ImageType = table.Column<string>(type: "text", nullable: true),
                    Cuisines = table.Column<string>(type: "text", nullable: true),
                    DishTypes = table.Column<string>(type: "text", nullable: true),
                    Diets = table.Column<string>(type: "text", nullable: true),
                    SpoonacularSourceUrl = table.Column<string>(type: "text", nullable: true),
                    NutritionId = table.Column<int>(type: "integer", nullable: true),
                    RootId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_Nutrition_NutritionId",
                        column: x => x.NutritionId,
                        principalTable: "Nutrition",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Recipes_RecipeRoot_RootId",
                        column: x => x.RootId,
                        principalTable: "RecipeRoot",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nutrients_NutritionId",
                table: "Nutrients",
                column: "NutritionId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_NutritionId",
                table: "Recipes",
                column: "NutritionId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_RootId",
                table: "Recipes",
                column: "RootId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nutrients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Nutrition");

            migrationBuilder.DropTable(
                name: "RecipeRoot");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Moq;
using TheKitchenMess.Controllers;
using TheKitchenMess.Models;
using TheKitchenMess.Services;
using FluentAssertions;

namespace TheKitchenMessTests
{
    public class Tests
    {
        private RecipeManagementController? _controller;
        private Mock<IRecipeManagementService>? _mockRecipeManagementService;

        [SetUp]
        public void Setup()
        {
            //Arrange
            _mockRecipeManagementService = new Mock<IRecipeManagementService>();
            _controller = new RecipeManagementController(_mockRecipeManagementService.Object);
        }

        [Test]
        public void GetRecipes_Returns_AllResults()
        {
            //Arange
            _mockRecipeManagementService!.Setup(b => b.GetRecipes()).Returns(GetTestRoot());

            //Act
            var result = _controller!.GetRecipes(1000);

            //Assert
            result.Should().BeOfType(typeof(ActionResult<IEnumerable<RecipeDTO>>));
        }

        [Test]
        public void GetRecipesByIngredients_Returns_AllResults()
        {
            //Arange
            _mockRecipeManagementService!.Setup(b => b.GetRecipes()).Returns(GetTestRoot());

            //Act
            var result = _controller!.GetRecipesByIngredients("cheese", 1000);

            //Assert
            result.Should().BeOfType(typeof(ActionResult<IEnumerable<RecipeDTO>>));
        }

        [Test]
        public void GetRecipesByIngredientsAndExIngredietns_Returns_AllResults()
        {
            //Arange
            _mockRecipeManagementService!.Setup(b => b.GetRecipes()).Returns(GetTestRoot());

            //Act
            var result = _controller!.GetRecipesByIngredientsAndExIngredietns("tomato","cheese", 1000);

            //Assert
            result.Should().BeOfType(typeof(ActionResult<IEnumerable<RecipeDTO>>));
        }


        private static List<RecipeDTO> GetTestRoot()
        {
            return new List<RecipeDTO>
            {
                new RecipeDTO() { },
                new RecipeDTO() { },
                new RecipeDTO() { },
            };
        }
    }
}
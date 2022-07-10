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
        /*

        [Test]
        public void GetRoot_Returns_AllResults()
        {
            //Arange
            _mockRecipeManagementService!.Setup(b => b.SearchRecipes()).Returns(GetTestRoot());

            //Act
            var result = _controller!.SearchRecipes();

            //Assert
            result.Should().BeOfType(typeof(ActionResult<IEnumerable<RecipeDTO>>));
            result.Value!.Should().BeEquivalentTo(GetTestRoot());
            result.Value!.Count().Should().Be(3);
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
        */
    }
}
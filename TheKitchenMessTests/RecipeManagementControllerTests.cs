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
        public void GetRoot_Returns_AllResults()
        {
            //Arange
            _mockRecipeManagementService!.Setup(b => b.GetRecipes()).Returns(GetTestRoot());

            //Act
            var result = _controller!.GetRecipes();

            //Assert
            result.Should().BeOfType(typeof(ActionResult<IEnumerable<Root>>));
            result.Value!.Should().BeEquivalentTo(GetTestRoot());
            result.Value!.Count().Should().Be(3);
        }


        private static List<Root> GetTestRoot()
        {
            return new List<Root>
            {
                new Root() { },
                new Root() { },
                new Root() { },
            };
        }
    }
}
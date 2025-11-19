using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using WebApplication1; // 👈 Required for Program

namespace WebApplication1.Tests.Integration
{
    public class HomeControllerIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public HomeControllerIntegrationTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Get_Home_Index_ReturnsSuccess()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/Home/Index");

            // Assert
            response.EnsureSuccessStatusCode();
            var html = await response.Content.ReadAsStringAsync();

            // Optional: check if basic HTML or view content is returned
            Assert.Contains("<!DOCTYPE", html, System.StringComparison.OrdinalIgnoreCase);
        }

        [Fact]
        public async Task Get_Home_Privacy_ReturnsSuccess()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/Home/Privacy");

            // Assert
            response.EnsureSuccessStatusCode();
            var html = await response.Content.ReadAsStringAsync();

            Assert.Contains("<!DOCTYPE", html, System.StringComparison.OrdinalIgnoreCase);
        }

    }
}




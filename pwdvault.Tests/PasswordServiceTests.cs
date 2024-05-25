using pwdvault.Services;

namespace pwdvault.Tests
{
    public class PasswordServiceTests
    {
        [Fact]
        public void GeneratePassword_ShouldReturnNotNullOrNotEmpty()
        {
            // Act
            string result = PasswordService.GeneratePassword();

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void GeneratePassword_ShouldReturnExpectedSize()
        {
            // Act
            string result = PasswordService.GeneratePassword();

            // Assert
            Assert.Equal(20, result.Length);
        }

        [Fact]
        public void GeneratePassword_ShouldReturnDifferentPassword()
        {
            // Act
            string result1 = PasswordService.GeneratePassword();
            string result2 = PasswordService.GeneratePassword();

            // Assert
            Assert.NotEqual(result1, result2);
        }

        [Fact]
        public void IsPasswordStrong_ShouldReturnFalseForEmptyPassword()
        {
            // Arrange
            string password = "";

            // Act
            bool result = PasswordService.IsPasswordStrong(password);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPasswordStrong_ShouldReturnFalseForShortPassword()
        {
            // Arrange
            string password = "P123@!";

            // Act
            bool result = PasswordService.IsPasswordStrong(password);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPasswordStrong_ShouldReturnFalseForPasswordWithoutUppercase()
        {
            // Arrange
            string password = "password123@!password";

            // Act
            bool result = PasswordService.IsPasswordStrong(password);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPasswordStrong_ShouldReturnFalseForPasswordWithoutLowercase()
        {
            // Arrange
            string password = "PASSWORD123@!PASSWORD";

            // Act
            bool result = PasswordService.IsPasswordStrong(password);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPasswordStrong_ShouldReturnFalseForPasswordWithoutNumber()
        {
            // Arrange
            string password = "Password@!Password";

            // Act
            bool result = PasswordService.IsPasswordStrong(password);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPasswordStrong_ShouldReturnFalseForPasswordWithoutSpecialCharacter()
        {
            // Arrange
            string password = "Password123Password";

            // Act
            bool result = PasswordService.IsPasswordStrong(password);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPasswordStrong_ShouldReturnFalseForValidPassword()
        {
            // Arrange
            string password = "Password123@!Password";

            // Act
            bool result = PasswordService.IsPasswordStrong(password);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void GetIconName_ShouldReturnNotNullOrNotEmpty()
        {
            // Arrange
            string appname = "appname";

            // Act
            string result = PasswordService.GetIconName(appname);

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void GetIconName_ShouldReturnSameIconNameForSameAppName()
        {
            // Arrange
            string appname = "appname";

            // Act
            string result1 = PasswordService.GetIconName(appname);
            string result2 = PasswordService.GetIconName(appname);

            // Assert
            Assert.Equal(result1, result2);
        }

        [Fact]
        public void GetIconName_ShouldReturnDifferentIconNamesForDifferentAppName()
        {
            // Arrange
            string appname1 = "github";
            string appname2 = "gmail";

            // Act
            string result1 = PasswordService.GetIconName(appname1);
            string result2 = PasswordService.GetIconName(appname2);

            // Assert
            Assert.NotEqual(result1, result2);
        }

        [Fact]
        public void GetIconName_ShouldReturnCorrectIconNameForExistantAppName()
        {
            // Arrange
            string appname = "github";

            // Act
            string result = PasswordService.GetIconName(appname);

            // Assert
            Assert.Equal("icons8_github_48", result);
        }

        [Fact]
        public void GetIconName_ShouldReturnGenericIconNameForNonExistantAppName()
        {
            // Arrange
            string appname = "appname";

            // Act
            string result = PasswordService.GetIconName(appname);

            // Assert
            Assert.Equal("icons8_image_48", result);
        }
    }
}

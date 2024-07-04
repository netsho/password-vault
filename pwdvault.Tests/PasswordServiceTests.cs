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
        public void IsPasswordStrong_ShouldReturnTrueForValidPassword()
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
            string appName = "appname";

            // Act
            string result = PasswordService.GetIconName(appName);

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void GetIconName_ShouldReturnSameIconNameForSameAppName()
        {
            // Arrange
            string appName = "appname";

            // Act
            string result1 = PasswordService.GetIconName(appName);
            string result2 = PasswordService.GetIconName(appName);

            // Assert
            Assert.Equal(result1, result2);
        }

        [Fact]
        public void GetIconName_ShouldReturnDifferentIconNamesForDifferentAppName()
        {
            // Arrange
            string appName1 = "github";
            string appName2 = "gmail";

            // Act
            string result1 = PasswordService.GetIconName(appName1);
            string result2 = PasswordService.GetIconName(appName2);

            // Assert
            Assert.NotEqual(result1, result2);
        }

        [Fact]
        public void GetIconName_ShouldReturnCorrectIconNameForExistentAppName()
        {
            // Arrange
            string appName = "github";

            // Act
            string result = PasswordService.GetIconName(appName);

            // Assert
            Assert.Equal("github", result);
        }

        [Fact]
        public void GetIconName_ShouldReturnGenericIconNameForNonExistentAppName()
        {
            // Arrange
            string appName = "appname";

            // Act
            string result = PasswordService.GetIconName(appName);

            // Assert
            Assert.Equal("icons8_application", result);
        }

        //[Fact]
        //public void ExportPasswords_ShouldCreateNonEmptyCsvForExistentPasswords()
        //{
        //    // Arrange
        //    string csvFile = $"{Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PasswordVault")}\\pwdvault_export.csv";
        //    File.Delete(csvFile);
        //    List<AppPassword> passwords = new() { new AppPassword("test1", "test2", "test3", [0, 1, 5, 6], "test4", [0, 1, 5, 6]),
        //    new AppPassword("test5", "test6", "test7", [0, 1, 5, 6], "test8", [0, 1, 5, 6])};
        //    // Act
        //    PasswordService.ExportPasswords(passwords);

        //    // Assert
        //    Assert.True(File.Exists(csvFile));
        //    Assert.NotEmpty(File.ReadAllBytes(csvFile));
        //}

        //[Fact]
        //public void ExportPasswords_ShouldCreateOnlyHeaderInCsvForNonExistentPasswords()
        //{
        //    // Arrange
        //    string csvFile = $"{Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PasswordVault")}\\pwdvault_export.csv";
        //    File.Delete(csvFile);
        //    List<AppPassword> passwords = [];
        //    // Act
        //    PasswordService.ExportPasswords(passwords);

        //    // Assert
        //    Assert.True(File.Exists(csvFile));
        //    Assert.Equal("Id,AppCategory,AppName,UserName,Password,IconName,Bytes,CreationTime,UpdateTime\r\n", File.ReadAllText(csvFile));
        //}
    }
}

using pwdvault.Services;

namespace pwdvault.Tests
{
    public class EncryptionServiceTests
    {
        [Fact]
        public void EncryptPassword_ShouldReturnNotNullAndNotEmptyAndValidSize()
        {
            // Arrange
            string password = "password";
            byte[] key = EncryptionService.GenerateKey(password);

            // Act
            byte[] encryptedPassword = EncryptionService.EncryptPassword(password, key, out _);

            // Assert
            Assert.NotNull(encryptedPassword);
            Assert.NotEmpty(encryptedPassword);
            Assert.Equal(16, encryptedPassword.Length);
        }

        [Fact]
        public void EncryptPassword_ShouldReturnDifferentResultsForSamePasswordAndKey()
        {
            // Arrange
            string password = "password";
            byte[] key = EncryptionService.GenerateKey(password);

            // Act
            byte[] encryptedPassword1 = EncryptionService.EncryptPassword(password, key, out _);
            byte[] encryptedPassword2 = EncryptionService.EncryptPassword(password, key, out _);

            // Assert
            Assert.NotEqual(encryptedPassword1 , encryptedPassword2);
        }

        [Fact]
        public void EncryptPassword_ShouldReturnDifferentResultsForDifferentPasswordsAndKeys()
        {
            // Arrange
            string password1 = "password1";
            string password2 = "password2";
            byte[] key1 = EncryptionService.GenerateKey(password1);
            byte[] key2 = EncryptionService.GenerateKey(password2);

            // Act
            byte[] encryptedPassword1 = EncryptionService.EncryptPassword(password1, key1, out _);
            byte[] encryptedPassword2 = EncryptionService.EncryptPassword(password2, key2, out _);

            // Assert
            Assert.NotEqual(encryptedPassword1, encryptedPassword2);
        }

        [Fact]
        public void EncryptPassword_ShouldReturnDifferentResultsForSamePasswordAndDifferentKeys()
        {
            // Arrange
            string password = "password";
            string passwordSecondKey = "passwordkey";
            byte[] key1 = EncryptionService.GenerateKey(password);
            byte[] key2 = EncryptionService.GenerateKey(passwordSecondKey);

            // Act
            byte[] encryptedPassword1 = EncryptionService.EncryptPassword(password, key1, out _);
            byte[] encryptedPassword2 = EncryptionService.EncryptPassword(password, key2, out _);

            // Assert
            Assert.NotEqual(encryptedPassword1, encryptedPassword2);
        }

        [Fact]
        public void EncryptPassword_ShouldReturnDifferentResultsForDifferentPasswordsAndSameKeys()
        {
            // Arrange
            string password1 = "password1";
            string password2 = "password2";
            byte[] key1 = EncryptionService.GenerateKey(password1);
            byte[] key2 = EncryptionService.GenerateKey(password1);

            // Act
            byte[] encryptedPassword1 = EncryptionService.EncryptPassword(password1, key1, out _);
            byte[] encryptedPassword2 = EncryptionService.EncryptPassword(password2, key2, out _);

            // Assert
            Assert.NotEqual(encryptedPassword1, encryptedPassword2);
        }

        [Fact]
        public void EncryptPassword_ShouldReturnDifferentIVsForSamePasswordAndKey()
        {
            // Arrange
            string password = "password";
            byte[] key = EncryptionService.GenerateKey(password);

            // Act
            _ = EncryptionService.EncryptPassword(password, key, out byte[] iv1);
            _ = EncryptionService.EncryptPassword(password, key, out byte[] iv2);

            // Assert
            Assert.NotEqual(iv1, iv2);
        }

        [Fact]
        public void EncryptPassword_ShouldReturnDifferentIVsForDifferentPasswordsAndKeys()
        {
            // Arrange
            string password1 = "password1";
            string password2 = "password2";
            byte[] key1 = EncryptionService.GenerateKey(password1);
            byte[] key2 = EncryptionService.GenerateKey(password2);

            // Act
            _ = EncryptionService.EncryptPassword(password1, key1, out byte[] iv1);
            _ = EncryptionService.EncryptPassword(password2, key2, out byte[] iv2);

            // Assert
            Assert.NotEqual(iv1, iv2);
        }

        [Fact]
        public void EncryptPassword_ShouldReturnIvOfValidSize()
        {
            // Arrange
            string password = "password";
            byte[] key = EncryptionService.GenerateKey(password);

            // Act
            _ = EncryptionService.EncryptPassword(password, key, out byte[] iv);

            // Assert
            Assert.Equal(16, iv.Length);
        }

        [Fact]
        public void EncryptPassword_ShouldThrowExceptionWhenPasswordIsNullOrEmpty()
        {
            // Arrange
            string passwordForKey = "password";
            string password1 = "";
            string? password2 = null;
            byte[] key = EncryptionService.GenerateKey(passwordForKey);
            Type exceptionType = typeof(ArgumentException);

            // Assert & act
            Assert.Throws(exceptionType, () => _ = EncryptionService.EncryptPassword(password1, key, out _));
            Assert.Throws(exceptionType, () => _ = EncryptionService.EncryptPassword(password2, key, out _));
        }

        [Fact]
        public void EncryptPassword_ShouldThrowExceptionWhenEncryptionKeyIsNullOrNotValidSize()
        {
            // Arrange
            string password = "password";
            byte[]? key1 = null;
            byte[] key2 = [];
            Type exceptionType = typeof(ArgumentException);

            // Assert & act
            Assert.Throws(exceptionType, () => _ = EncryptionService.EncryptPassword(password, key1, out _));
            Assert.Throws(exceptionType, () => _ = EncryptionService.EncryptPassword(password, key2, out _));
        }

        [Fact]
        public void DecryptPassword_ShouldReturnNotNullAndNotEmpty()
        {
            // Arrange
            string password = "password";
            byte[] key = EncryptionService.GenerateKey(password);
            byte[] encryptedPassword = EncryptionService.EncryptPassword(password, key, out byte[] iv);

            // Act
            string decryptedPassword = EncryptionService.DecryptPassword(encryptedPassword, key, iv);

            // Assert
            Assert.NotNull(decryptedPassword);
            Assert.NotEmpty(decryptedPassword);
        }

        [Fact]
        public void DecryptPassword_ShouldReturnCorrectPasswordWhenDecrypting()
        {
            // Arrange
            string password = "password";
            byte[] key = EncryptionService.GenerateKey(password);
            byte[] encryptedPassword = EncryptionService.EncryptPassword(password, key, out byte[] iv);

            // Act
            string decryptedPassword = EncryptionService.DecryptPassword(encryptedPassword, key, iv);

            // Assert
            Assert.Equal("password", decryptedPassword);
        }

        [Fact]
        public void DecryptPassword_ShouldReturnSameResultForSameParameters()
        {
            // Arrange
            string password = "password";
            byte[] key = EncryptionService.GenerateKey(password);
            byte[] encryptedPassword = EncryptionService.EncryptPassword(password, key, out byte[] iv);

            // Act
            string decryptedPassword1 = EncryptionService.DecryptPassword(encryptedPassword, key, iv);
            string decryptedPassword2 = EncryptionService.DecryptPassword(encryptedPassword, key, iv);

            // Assert
            Assert.Equal(decryptedPassword1, decryptedPassword2);
        }

        [Fact]
        public void DecryptPassword_ShouldReturnDifferentResultsForDifferentDifferentParameters()
        {
            // Arrange
            string password1 = "password1";
            string password2 = "password2";
            byte[] key1 = EncryptionService.GenerateKey(password1);
            byte[] key2 = EncryptionService.GenerateKey(password2);
            byte[] encryptedPassword1 = EncryptionService.EncryptPassword(password1, key1, out byte[] iv1);
            byte[] encryptedPassword2 = EncryptionService.EncryptPassword(password2, key2, out byte[] iv2);

            // Act
            string decryptedPassword1 = EncryptionService.DecryptPassword(encryptedPassword1, key1, iv1);
            string decryptedPassword2 = EncryptionService.DecryptPassword(encryptedPassword2, key2 , iv2);

            // Assert
            Assert.NotEqual(decryptedPassword1, decryptedPassword2);
        }

        [Fact]
        public void DecryptPassword_ShouldThrowExceptionWhenEncryptedPasswordIsNullOrEmpty()
        {
            // Arrange
            string password = "password";
            byte[] encryptedPassword1 = [];
            byte[]? encryptedPassword2 = null;
            byte[] key = EncryptionService.GenerateKey(password);
            _ = EncryptionService.EncryptPassword(password, key, out byte[] iv);
            Type exceptionType = typeof(ArgumentException);

            // Assert & act
            Assert.Throws(exceptionType, () => _ = EncryptionService.DecryptPassword(encryptedPassword1, key, iv));
            Assert.Throws(exceptionType, () => _ = EncryptionService.DecryptPassword(encryptedPassword2, key, iv));
        }

        [Fact]
        public void DecryptPassword_ShouldThrowExceptionWhenDecryptionKeyIsNullOrNotValidSize()
        {
            // Arrange
            string password = "password";
            byte[] key = EncryptionService.GenerateKey(password);
            byte[] encryptedPassword = EncryptionService.EncryptPassword(password, key, out byte[] iv);
            byte[]? key1 = null;
            byte[] key2 = new byte[1];
            Type exceptionType = typeof(ArgumentException);

            // Assert & act
            Assert.Throws(exceptionType, () => _ = EncryptionService.DecryptPassword(encryptedPassword, key1, iv));
            Assert.Throws(exceptionType, () => _ = EncryptionService.DecryptPassword(encryptedPassword, key2, iv));
        }

        [Fact]
        public void DecryptPassword_ShouldThrowExceptionWhenIVIsNullOrNotValidSize()
        {
            // Arrange
            string password = "password";
            byte[] key = EncryptionService.GenerateKey(password);
            byte[] encryptedPassword = EncryptionService.EncryptPassword(password, key, out _);
            byte[]? iv1 = null;
            byte[] iv2 = new byte[1];
            Type exceptionType = typeof(ArgumentException);

            // Assert & act
            Assert.Throws(exceptionType, () => _ = EncryptionService.DecryptPassword(encryptedPassword, key, iv1));
            Assert.Throws(exceptionType, () => _ = EncryptionService.DecryptPassword(encryptedPassword, key, iv2));
        }

        [Fact]
        public void GenerateKey_ShouldReturnNonNullAndNotEmptyAndValidSize()
        {
            // Arrange
            string password = "password";

            // Act
            byte[] result = EncryptionService.GenerateKey(password);

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal(16, result.Length);
        }

        [Fact]
        public void GenerateKey_ShouldReturnDifferentKeysForDifferentPasswords()
        {
            // Arrange
            string password1 = "firstPassword";
            string password2 = "secondPassword";

            // Act
            byte[] result1 = EncryptionService.GenerateKey(password1);
            byte[] result2 = EncryptionService.GenerateKey(password2);

            // Assert
            Assert.NotEqual(result1, result2);
        }

        [Fact]
        public void GenerateKey_ShouldReturnDifferentKeysForSamePassword()
        {
            // Arrange
            string password = "password";

            // Act
            byte[] result1 = EncryptionService.GenerateKey(password);
            byte[] result2 = EncryptionService.GenerateKey(password);

            // Assert
            Assert.NotEqual(result1, result2);
        }

        [Fact]
        public void GenerateKey_ShouldThrowExceptionWhenPasswordIsNullOrEmpty()
        {
            // Arrange
            string password1 = "";
            string? password2 = null;
            Type exceptionType = typeof(ArgumentException);

            // Assert & act
            Assert.Throws(exceptionType, () => _ = EncryptionService.GenerateKey(password1));
            Assert.Throws(exceptionType, () => _ = EncryptionService.GenerateKey(password2));
        }
    }
}

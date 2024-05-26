using pwdvault.Services;

namespace pwdvault.Tests
{
    public class EncryptionServiceTests
    {
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
        public void EncryptPassword_ShouldThrowExceptionWhenKeyIsNullOrEmpty()
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
        public void DecryptPassword_ShouldReturnSamePasswordForSameEncryptedPasswordAndKeyAndIv()
        {
            
        }



        [Fact]
        public void GenerateKey_ShouldReturnNonNullOrNotEmpty()
        {
            // Arrange
            string password = "password";

            // Act
            byte[] result = EncryptionService.GenerateKey(password);

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
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

using pwdvault.Services;

namespace pwdvault.Tests
{
    public class UserPasswordSecurityTests
    {
        [Fact]
        public void GenerateSalt_ShouldReturnNonNullOrNotEmpty()
        {
            // Act
            byte[] result = UserPasswordService.GenerateSalt();

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void GenerateSalt_ShouldReturnExpectedSize()
        {
            // Act
            byte[] result = UserPasswordService.GenerateSalt();

            // Assert
            Assert.Equal(32, result.Length);
        }

        [Fact]
        public void GenerateSalt_ShouldReturnDifferentSalt()
        {
            // Act
            byte[] result1 = UserPasswordService.GenerateSalt();
            byte[] result2 = UserPasswordService.GenerateSalt();

            // Assert
            Assert.NotEqual(result1, result2);
        }

        [Fact]
        public void GenerateHash_ShouldReturnNonNullOrNotEmpty()
        {
            // Arrange
            string password = "password";
            byte[] salt = UserPasswordService.GenerateSalt();

            // Act
            byte[] result = UserPasswordService.GenerateHash(password, salt);

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void GenerateHash_ShouldReturnDifferentHashForDifferentSalts()
        {
            // Arrange
            string password = "password";
            byte[] salt1 = UserPasswordService.GenerateSalt();
            byte[] salt2 = UserPasswordService.GenerateSalt();

            // Act
            byte[] result1 = UserPasswordService.GenerateHash(password, salt1);
            byte[] result2 = UserPasswordService.GenerateHash(password, salt2);

            // Assert
            Assert.NotEqual(result1, result2);
        }

        [Fact]
        public void GenerateHash_ShouldReturnDifferentHashForDifferentPasswords()
        {
            // Arrange
            string password1 = "firstPassword";
            string password2 = "secondPassword";
            byte[] salt = UserPasswordService.GenerateSalt();

            // Act
            byte[] result1 = UserPasswordService.GenerateHash(password1, salt);
            byte[] result2 = UserPasswordService.GenerateHash(password2, salt);

            // Assert
            Assert.NotEqual(result1, result2);
        }

        [Fact]
        public void GenerateHash_ShouldReturnSameHashForSamePasswordAndSalt()
        {
            // Arrange
            string password = "password";
            byte[] salt = UserPasswordService.GenerateSalt();

            // Act
            byte[] result1 = UserPasswordService.GenerateHash(password, salt);
            byte[] result2 = UserPasswordService.GenerateHash(password, salt);

            // Assert
            Assert.Equal(result1, result2);
        }

        [Fact]
        public void VerifyPassword_ShouldReturnTrueForMatchingPasswordsAndSalts()
        {
            // Arrange
            string samepassword = "password";
            byte[] salt = UserPasswordService.GenerateSalt();
            byte[] hash = UserPasswordService.GenerateHash(samepassword, salt);

            // Act
            bool result = UserPasswordService.VerifyPassword(samepassword, salt, hash);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void VerifyPassword_ShouldReturnFalseForDifferentPasswordsAndSameSalts()
        {
            // Arrange
            string password1 = "firstPassword";
            string password2 = "secondPassword";
            byte[] salt = UserPasswordService.GenerateSalt();
            byte[] hash = UserPasswordService.GenerateHash(password1, salt);

            // Act
            bool result = UserPasswordService.VerifyPassword(password2, salt, hash);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void VerifyPassword_ShouldReturnTrueForNullSalt()
        {
            // Arrange
            string samepassword = "password";
            byte[]? salt = null;
            byte[] hash = UserPasswordService.GenerateHash(samepassword, salt);

            // Act
            bool result = UserPasswordService.VerifyPassword(samepassword, salt, hash);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void VerifyPassword_ShouldThrowExceptionForNullHash()
        {
            // Arrange
            string samepassword = "password";
            byte[] salt = UserPasswordService.GenerateSalt();
            byte[]? hash = null;
            var exception = typeof(NullReferenceException);

            // Assert & act
            Assert.Throws(exception, () => UserPasswordService.VerifyPassword(samepassword, salt, hash));
        }
    }
}

using pwdvault.Services;

namespace pwdvault.Tests
{
    public class UserPasswordSecurityTests
    {
        [Fact]
        public void GenerateSalt_ShouldReturnNonNullOrNotEmpty()
        {
            // Act
            byte[] result = UserPasswordSecurity.GenerateSalt();

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void GenerateSalt_ShouldReturnExpectedSize()
        {
            // Act
            byte[] result = UserPasswordSecurity.GenerateSalt();

            // Assert
            Assert.Equal(32, result.Length);
        }

        [Fact]
        public void GenerateSalt_ShouldReturnDifferentSalt()
        {
            // Act
            byte[] result1 = UserPasswordSecurity.GenerateSalt();
            byte[] result2 = UserPasswordSecurity.GenerateSalt();

            // Assert
            Assert.NotEqual(result1, result2);
        }

        [Fact]
        public void GenerateHash_ShouldReturnNonNullOrNotEmpty()
        {
            // Arrange
            string password = "password";
            byte[] salt = UserPasswordSecurity.GenerateSalt();

            // Act
            byte[] result = UserPasswordSecurity.GenerateHash(password, salt);

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void GenerateHash_ShouldReturnDifferentHashForDifferentSalts()
        {
            // Arrange
            string password = "password";
            byte[] salt1 = UserPasswordSecurity.GenerateSalt();
            byte[] salt2 = UserPasswordSecurity.GenerateSalt();

            // Act
            byte[] result1 = UserPasswordSecurity.GenerateHash(password, salt1);
            byte[] result2 = UserPasswordSecurity.GenerateHash(password, salt2);

            // Assert
            Assert.NotEqual(result1, result2);
        }

        [Fact]
        public void GenerateHash_ShouldReturnDifferentHashForDifferentPasswords()
        {
            // Arrange
            string password1 = "firstPassword";
            string password2 = "secondPassword";
            byte[] salt = UserPasswordSecurity.GenerateSalt();

            // Act
            byte[] result1 = UserPasswordSecurity.GenerateHash(password1, salt);
            byte[] result2 = UserPasswordSecurity.GenerateHash(password2, salt);

            // Assert
            Assert.NotEqual(result1, result2);
        }

        [Fact]
        public void GenerateHash_ShouldReturnSameHashForSamePasswordAndSalt()
        {
            // Arrange
            string password = "password";
            byte[] salt = UserPasswordSecurity.GenerateSalt();

            // Act
            byte[] result1 = UserPasswordSecurity.GenerateHash(password, salt);
            byte[] result2 = UserPasswordSecurity.GenerateHash(password, salt);

            // Assert
            Assert.Equal(result1, result2);
        }

        [Fact]
        public void VerifyPassword_ShouldReturnTrueForMatchingPasswordsAndSalts()
        {
            // Arrange
            string samepassword = "password";
            byte[] salt = UserPasswordSecurity.GenerateSalt();
            byte[] hash = UserPasswordSecurity.GenerateHash(samepassword, salt);

            // Act
            bool result = UserPasswordSecurity.VerifyPassword(samepassword, salt, hash);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void VerifyPassword_ShouldReturnFalseForDifferentPasswordsAndSameSalts()
        {
            // Arrange
            string password1 = "firstPassword";
            string password2 = "secondPassword";
            byte[] salt = UserPasswordSecurity.GenerateSalt();
            byte[] hash = UserPasswordSecurity.GenerateHash(password1, salt);

            // Act
            bool result = UserPasswordSecurity.VerifyPassword(password2, salt, hash);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void VerifyPassword_ShouldReturnTrueForNullSalt()
        {
            // Arrange
            string samepassword = "password";
            byte[]? salt = null;
            byte[] hash = UserPasswordSecurity.GenerateHash(samepassword, salt);

            // Act
            bool result = UserPasswordSecurity.VerifyPassword(samepassword, salt, hash);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void VerifyPassword_ShouldThrowExceptionForNullHash()
        {
            // Arrange
            string samepassword = "password";
            byte[] salt = UserPasswordSecurity.GenerateSalt();
            byte[]? hash = null;
            var exception = typeof(NullReferenceException);

            // Assert & act
            Assert.Throws(exception, () => UserPasswordSecurity.VerifyPassword(samepassword, salt, hash));
        }
    }
}

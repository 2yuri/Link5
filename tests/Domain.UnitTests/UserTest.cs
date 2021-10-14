using System;
using Link5.Domain.Entities;
using Xunit;

namespace Domain.UnitTests
{
    public class UserTest
    {
        private const string SOME_NAME = "name test";
        private const string SOME_MAIL = "email@mail.com";
        private const string DEFAULT_PASS = "123456";
        private const string HASHED_PASS = "ba3253876aed6bc22d4a6ff53d8406c6ad864195ed144ab5c87621b6c233b548baeae6956df346ec8c17f5ea10f35ee3cbc514797ed7ddd3145464e2a0bab413";

        [Fact]
        public void HashPassword_ValidPassword_ReturnsValidPass()
        {
            var user = new User(SOME_NAME, SOME_MAIL, DEFAULT_PASS, true);
            Assert.Equal(DEFAULT_PASS, user.Password);

            user.HashPassword();

            Assert.Equal(HASHED_PASS, user.Password);
        }

        [Fact]
        public void VerifyPassword_WrongPass_ReturnsTrue()
        {
            var user = new User(SOME_NAME, SOME_MAIL, DEFAULT_PASS, true);
            user.HashPassword();

            string WrongPass = "wrong";
            Assert.False(user.VerifyPassword(WrongPass));
        }

        [Fact]
        public void VerifyPassword_CorrectPass_ReturnsTrue()
        {
            var user = new User(SOME_NAME, SOME_MAIL, DEFAULT_PASS, true);
            user.HashPassword();

            Assert.True(user.VerifyPassword(DEFAULT_PASS));
        }
    }
}

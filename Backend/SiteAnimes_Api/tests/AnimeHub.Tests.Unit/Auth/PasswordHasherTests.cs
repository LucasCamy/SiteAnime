using AnimeHub.Infrastructure.Auth;
using FluentAssertions;

namespace AnimeHub.Tests.Unit.Auth
{
    public class PasswordHasherTests
    {
        [Fact]
        public void HashPassword_DeveGerarHash_DiferenteDaSenhaOriginal()
        {
            var senha = "TestOnly!2026Secure";

            var hash = PasswordHasher.Hash(senha);

            hash.Should().NotBeNullOrWhiteSpace();
            hash.Should().NotBe(senha);
        }

        [Fact]
        public void VerifyPassword_DeveRetornarTrue_QuandoSenhaCorreta()
        {
            var senha = "TestOnly!2026Secure";
            var hash = PasswordHasher.Hash(senha);

            var ok = PasswordHasher.Verify(senha, hash);

            ok.Should().BeTrue();
        }

        [Fact]
        public void VerifyPassword_DeveRetornarFalse_QuandoSenhaIncorreta()
        {
            var hash = PasswordHasher.Hash("TestOnly!2026Secure");

            var ok = PasswordHasher.Verify("SenhaErrada", hash);

            ok.Should().BeFalse();
        }
    }
}

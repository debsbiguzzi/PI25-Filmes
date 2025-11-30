using Xunit;
using Filminhos.NET;

namespace Filminhos.NET.Tests
{
    public class ClassesTests
    {
        [Fact]
        public void Usuario_Init_SetsProperties()
        {
            // Arrange & Act
            var usuario = new Usuario { Id = 42, Nome = "tester", IsAdmin = true };

            // Assert
            Assert.Equal(42, usuario.Id);
            Assert.Equal("tester", usuario.Nome);
            Assert.True(usuario.IsAdmin);
        }

        [Fact]
        public void Sessao_SetAndClear_Works()
        {
            // Arrange
            var usuario = new Usuario { Id = 1, Nome = "user1", IsAdmin = false };

            // Act
            Sessao.UsuarioAtual = usuario;

            // Assert assigned instance is same
            Assert.Same(usuario, Sessao.UsuarioAtual);

            // Act clear
            Sessao.UsuarioAtual = null;

            // Assert cleared
            Assert.Null(Sessao.UsuarioAtual);
        }

        // NOTE:
        // - The remaining methods in `Classes.Sistema` (e.g., `Consultar`, `AutenticarUsuario`, `CadastrarUsuario`)
        //   depend on MySQL and .env values. To test those you should add integration tests that:
        //     1) Provide a test MySQL instance (local container or test DB).
        //     2) Populate a test `usuarios` table with known data.
        //     3) Load .env via DotNetEnv.Env.Load(...) or call Env.Load() in Program.Main.
        //   Or refactor production code to allow injecting a database abstraction (e.g., an interface for data access)
        //   so you can unit-test authentication logic with mocks (recommended).
    }
}
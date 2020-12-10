using System;
using System.Threading.Tasks;
using Xunit;
using Moq;
using MediatR.Commands.Results;
using MediatR.Commands.Extensions;
using MediatR.Commands.Tests.TestDoubles;
using MediatR.Commands.BodyTypes;

namespace MediatR.Commands.Tests
{
    public class ResultSucceeded
    {
        // cen�rios: 
        // em um comando que executa com sucesso, resultado.Succeeded deve ser true
        // comando bem sucedido deve ter resultado Ok, Created, Updated, Deleted
        // em um comando que N�O executa com sucesso, resultado.Succeeded deve ser false
        // comando mal sucedido deve ter resultado Error, Invalid, Exception, Unauthorized, NotFound

        [Fact]
        public async Task ShouldBeTrueWhenCommandIsSuccessfull()
        {
            // arrange
            var resposta = "comando funcionou";
            var resultado = new OkResult<string>(resposta);
            var comando = new ComandoQualquer();
            var token = new System.Threading.CancellationToken();
            var mock = new Mock<IMediator>();
            mock
                .Setup(m => m.Send(comando, token))
                .Returns(Task.FromResult(resultado.AsResult()));

            var mediator = mock.Object;

            // act
            var result = await mediator.Send(comando, token);

            // assert
            Assert.True(result.Succeeded);
            Assert.IsType<OkResult<string>>(result);
            var body = result.Body as ObjectBody<string>;
            Assert.Equal(resposta, body.Response);
        }

        [Fact]
        public async Task ShouldBeFalseWhenCommandNotSuccessfull()
        {
            // arrange
            var resposta = new Exception("Deu zebra");
            var resultado = new ExceptionResult(resposta);
            var comando = new ComandoQualquer();
            var token = new System.Threading.CancellationToken();
            var mock = new Mock<IMediator>();
            mock
                .Setup(m => m.Send(comando, token))
                .Returns(Task.FromResult(resultado.AsResult()));

            var mediator = mock.Object;

            // act
            var result = await mediator.Send(comando, token);

            // assert
            Assert.False(result.Succeeded);
            Assert.IsType<ExceptionResult>(result);
        }
    }
}

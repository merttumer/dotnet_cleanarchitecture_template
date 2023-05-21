using Hello.Application.Templates;
using MediatR;

namespace Hello.Application.Greet
{
    public record GreetRequest(GreetRequestDto dto) : IRequest<Result<GreetResponseDto>>;
}
using Hello.Application.Repository;
using Hello.Application.Templates;
using MediatR;

namespace Hello.Application.Greet
{
    public class GreetHandler : IRequestHandler<GreetRequest, Result<GreetResponseDto>>
    {
        private readonly IHelloRepository helloRepository;
        public GreetHandler(IHelloRepository helloRepository)
        {
            this.helloRepository = helloRepository;
        }

        public async Task<Result<GreetResponseDto>> Handle(GreetRequest request, CancellationToken cancellationToken)
        {
            var user = await helloRepository.GetUser(request.dto.userId);
            if (user == null)
            {
                // Not Found is still a valid result
                return Result<GreetResponseDto>.Ok(null);
            }

            return Result<GreetResponseDto>.Ok(new GreetResponseDto($"Hello {user.Name}"));
        }
    }
}
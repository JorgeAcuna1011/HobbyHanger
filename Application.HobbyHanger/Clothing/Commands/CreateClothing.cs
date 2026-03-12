using Domain.HobbyHanger;
using MediatR;
using Persistence.HobbyHanger;

namespace Application.HobbyHanger.Clothing.Commands;

public class CreateClothing
{
    public class Command : IRequest<string>
    {
        public required Clothes Clothes { get; set; }
    }

    public class Handler(HobbyHangerDbContext context) : IRequestHandler<Command, string>
    {
        public async Task<string> Handle(Command request, CancellationToken cancellationToken)
        {
            context.Products.Add(request.Clothes);
            
            await context.SaveChangesAsync(cancellationToken);
            
            return request.Clothes.ProductId;
        }
    }
}
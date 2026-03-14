using AutoMapper;
using Domain.HobbyHanger;
using MediatR;
using Persistence.HobbyHanger;

namespace Application.HobbyHanger.Clothing.Commands;

public class EditClothing
{
    public class Command : IRequest
    {
        public required Clothes Clothes { get; set; }
    }
    
    public class Handler(HobbyHangerDbContext context, IMapper mapper) : IRequestHandler<Command>
    {
        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            var clothes = await context.Clothes
                .FindAsync([request.Clothes.ProductId], cancellationToken)
                          ?? throw new Exception("No clothes found");

            mapper.Map(request.Clothes, clothes);
            
            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
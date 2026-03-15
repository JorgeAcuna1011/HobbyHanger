using Domain.HobbyHanger;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.HobbyHanger;

namespace Application.HobbyHanger.Clothing.Commands;

public class DeleteClothing
{
    public class Command : IRequest
    {
        public required string ProductId { get; set; }
    }

    public class Handler(HobbyHangerDbContext context) : IRequestHandler<Command>
    {
        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            var clothes = await context.Clothes
                              .Include(c => c.Measurements)
                              .FirstOrDefaultAsync(x => x.ProductId == request.ProductId, cancellationToken)
                                ?? throw new Exception("No clothes found");

            if (clothes.Measurements != null)
            {
                context.Measurements.Remove(clothes.Measurements);
            }
            
            context.Remove(clothes);

            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
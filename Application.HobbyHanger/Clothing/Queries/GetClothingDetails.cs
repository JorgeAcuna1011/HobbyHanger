using Domain.HobbyHanger;
using MediatR;
using Persistence.HobbyHanger;

namespace Application.HobbyHanger.Clothing.Queries;

public class GetClothingDetails
{
    public class Query : IRequest<Clothes>
    {
        public required string Id { get; set; }
    }

    public class Handler(HobbyHangerDbContext context) : IRequestHandler<Query, Clothes>
    {
        public async Task<Clothes> Handle(Query request, CancellationToken cancellationToken)
        {
            var clothes = await context.Clothes.FindAsync([request.Id], cancellationToken);
            
            if (clothes == null) throw new Exception("Clothes not found");

            return clothes;
        }
    }
}
using System.Net.Mime;
using Domain.HobbyHanger;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.HobbyHanger;


namespace Application.HobbyHanger.Clothing.Queries;

public class GetClothingList
{
    public class Query : IRequest<List<Clothes>> {}

    public class Handler(HobbyHangerDbContext context) : IRequestHandler<Query, List<Clothes>>
    {
        public async Task<List<Clothes>> Handle(Query request, CancellationToken cancellationToken)
        {
            return await context.Clothes.ToListAsync(cancellationToken);
        }
    }
}
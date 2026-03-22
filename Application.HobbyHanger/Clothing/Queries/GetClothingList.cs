using System.Net.Mime;
using Domain.HobbyHanger;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence.HobbyHanger;


namespace Application.HobbyHanger.Clothing.Queries;

public class GetClothingList
{
    public class Query : IRequest<List<Clothes>> {}

    public class Handler(HobbyHangerDbContext context, ILogger<GetClothingList> logger) : IRequestHandler<Query, List<Clothes>>
    {
        public async Task<List<Clothes>> Handle(Query request, CancellationToken cancellationToken)
        {
            //  This is a block of code to simulate loading time
            //  It's not being used right now it's just
            //  more of a snippet that we can use when needed
            //
            // try
            // {
            //     for (int i = 0; i < 10; i++)
            //     {
            //         cancellationToken.ThrowIfCancellationRequested();
            //         await Task.Delay(1000, cancellationToken);
            //         logger.LogInformation($"Task {i} has completed");
            //     }    
            // }
            // catch (System.Exception)
            // {
            //     logger.LogInformation("Task was cancelled");
            // }
            
            return await context.Clothes.ToListAsync(cancellationToken);
        }
    }
}
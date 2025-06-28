using GraphQLAPI.HotChocolate.Mutations;
using GraphQLAPI.HotChocolate.Queries;

namespace GraphQLAPI.HotChocolate.WebApplicationBuilder
{
    public static class GraphQLExtensions
    {
        public static IServiceCollection AddGraphQLServices(this IServiceCollection services)
        {
            services
                .AddGraphQLServer()
                .AddAuthorization()
                .AddQueryType(d => d.Name("Query"))
                .AddTypeExtension<TaskQuery>()
                .AddTypeExtension<UserQuery>()
                .AddTypeExtension<CommonQuery>()
                .AddMutationType(d => d.Name("Mutation"))
                .AddTypeExtension<AuthMutation>()
                .AddTypeExtension<TaskMutation>()
                .AddFiltering()
                .AddSorting();

            return services;
        }
    }
}

namespace GraphQLAPI.HotChocolate.Inputs
{
    public record CreateTaskInput(string Title, string? Description, int StatusId, Guid? CreatedById);
}

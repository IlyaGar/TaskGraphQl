namespace GraphQLAPI.HotChocolate.Inputs
{
    public record UpdateTaskInput(int Id, string Title, string? Description, int StatusId, Guid? CreatedById);
}
namespace OpenApiRecursiveModel.Models;

public record Person(string FirstName, string LastName)
{
    public List<Person> Children { get; set; } = [];
}

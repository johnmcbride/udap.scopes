public class Profile
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public IEnumerable<Scope> ProfileScopes { get; set; }
}
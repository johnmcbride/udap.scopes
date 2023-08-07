using Microsoft.OpenApi.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

var builder = WebApplication.CreateBuilder(args);
//add swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if ( app.Environment.IsDevelopment() )
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/scopes",() => {

})
.WithDescription("Returns a list of all scopes we have in our directory that can be used by a participant");

app.MapGet("/scopes/profiles", () => {
    List<Profile> profiles = new List<Profile> {
        new Profile { Name="patient.read",Description = "A scope profile that provides access to reading patient information"},
        new Profile {Name="patient.write",Description="A scope profile that provides write access for a patient."},
        new Profile {Name="billing.read",Description="A scope profile that profile read access to billing"}
    };
    return Results.Json(profiles);
}).WithName("GetScopeProfiles")
.WithOpenApi();

app.MapGet("/scopes/{profilename}", (string profilename) => {

}).WithOpenApi();

app.MapGet("/scopes/{profileid}", (int profileid) => {

}).WithOpenApi();

app.MapGet("/scopes/client/{id}",(int id) => {

}).WithOpenApi();

app.MapPut("/scopes/client/{id}",(int id) => {}).WithOpenApi();
app.Run();

public class Profile
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
public class Scope
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public string ScopeSpec { get; set; }
}

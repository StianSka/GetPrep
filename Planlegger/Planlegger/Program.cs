using Planlegger.model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var inMemoryDb = new List<TaskItem> 
{
    new TaskItem("lunsj","11.30-12.15"),
    new TaskItem("jobbe med prosjekt","12.15-14.30"),
};

app.MapGet("/index", () =>
{
    return inMemoryDb;
});
app.MapPost("/index",(TaskItem taskItme) =>{
    inMemoryDb.Add(taskItme);
});
app.UseStaticFiles();
app.Run();

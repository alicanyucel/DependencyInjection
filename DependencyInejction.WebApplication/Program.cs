
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddTransient<Cekic>();
builder.Services.AddTransient<Civi>();
builder.Services.AddTransient<Builder>();
// services collection // container
//  ihtiyaç duyulduðunda hangi classýn nereden ve nasýl instance turetileceðini bilgi olarak saklayan
//  bir registration yapýsý container

var app = builder.Build();
app.MapGet("/test", () =>
{
    var cekic=app.Services.GetRequiredService<Cekic>(); //getrequiredservice null döndürmez
    var civi=app.Services.GetRequiredService<Civi>(); //getservice null döndürebilir
    var b=new Builder(cekic,civi);
    b.BuildHouse();
    return Results.Ok();
});
//service provider
//2. parça bu da containerin execute esnasýnda o class istenirse instance üretmesini saðlar.

app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();

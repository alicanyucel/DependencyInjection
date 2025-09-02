
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddTransient<Cekic>();
builder.Services.AddTransient<Civi>();
builder.Services.AddTransient<Builder>();
// services collection // container
//  ihtiya� duyuldu�unda hangi class�n nereden ve nas�l instance turetilece�ini bilgi olarak saklayan
//  bir registration yap�s� container

var app = builder.Build();
app.MapGet("/test", () =>
{
    var cekic=app.Services.GetRequiredService<Cekic>(); //getrequiredservice null d�nd�rmez
    var civi=app.Services.GetRequiredService<Civi>(); //getservice null d�nd�rebilir
    var b=new Builder(cekic,civi);
    b.BuildHouse();
    return Results.Ok();
});
//service provider
//2. par�a bu da containerin execute esnas�nda o class istenirse instance �retmesini sa�lar.

app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();

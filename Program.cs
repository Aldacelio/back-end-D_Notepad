using D_Notepad_back.Views;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "MyPolicy",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
        });
});
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IPensamentoRepository, PensamentoRepository>();


var app = builder.Build();


if(app.Environment.IsDevelopment()){
    app.UseSwagger();
    app.UseSwaggerUI();
    
}


app.UseCors("MyPolicy");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
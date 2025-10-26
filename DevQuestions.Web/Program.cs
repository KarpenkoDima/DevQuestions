
using DevQuestions.Web;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddProgramDependencies();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{    
    app.UseSwagger();
    app.UseSwaggerUI();/* options =>
    {        
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "DevQuestions");
    });*/
}

app.MapControllers();
app.Run();

using UsersApi.Models;
using UsersApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Регистрируем контроллеры
builder.Services.AddControllers();

// добавялем Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Регистрируем UserService как Singleton
// Singleton — потому что мы храним пользователей "в памяти", один сервис на всё приложение.
// TO-DO: Почитать про Singleton 
builder.Services.AddSingleton<IUserService, UserService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
// app.UseAuthentication();
app.MapControllers();
SeedAdminUser(app.Services);

app.Run();

void SeedAdminUser(IServiceProvider services)
{
    var userService = services.GetRequiredService<IUserService>();

    // Проверяем, есть ли Admin
    if (!userService.GetAll().Any(u => u.Login == "admin"))
    {
        userService.Create(new UserModel
        {
            Guid = 1,
            Login = "admin",
            Password =  "admin",
            Name = "Nick",
            Gender = 1,
            Birthday = DateTime.Today,
            Admin =  true,
            CreatedOn =  DateTime.Now,
            CreatedBy = "admin",
            ModifiedOn =  DateTime.Now,
            ModifiedBy = "admin", 
            RevokedOn = DateTime.Now,
            RevokedBy =  "admin"
        });
    }
}
using DLVD.App;
using DVLD.Infrastructure;
using DVLD.API.MiddleWares;
using DVLD.API;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using DVLD.API.Config;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);




// Cnfig Options 
builder.Services.Configure<OptionsConfigOptions>(builder.Configuration.GetSection("OptionsConfig"));
// Add services to the container.


// Global Filter 
builder.Services.AddControllers(opt =>
{
    //opt.Filters.Add<LogActivityActionFilter>();
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
        .AddControllers()
        .AddJsonOptions(opt =>
        {
            opt.JsonSerializerOptions.PropertyNamingPolicy = null;
            opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        });
           

builder.Services.AddAppServices();
builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader());
            });

// REGISTER Dependancies
builder.Services.AddInfrastructureServices(builder.Configuration);

var jwtOptions = builder.Configuration.GetSection("JwtConfig").Get<JwtConfig>();

builder.Services.AddSingleton(jwtOptions!);

var tokenValidationParameters = new TokenValidationParameters()
{

    ValidateIssuerSigningKey = true,
    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtOptions!.Secret)),
    ValidIssuer = jwtOptions.Issuer,
    ValidateIssuer = false,
    ValidAudience = jwtOptions.Auidiance,
    ValidateAudience = false,
    RequireExpirationTime = true,
    ValidateLifetime = true,
    ClockSkew = TimeSpan.Zero,
};


builder.Services.AddSingleton(tokenValidationParameters);

builder.Services.AddAuthentication(o =>
{
    o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    o.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
   .AddJwtBearer(JwtCfg =>
   {
       JwtCfg.SaveToken = true;
       JwtCfg.TokenValidationParameters = tokenValidationParameters;
   });



   //.AddScheme<AuthenticationSchemeOptions, BasicAuths>("Basic", null)
   //.AddCookie(CookieAuthenticationDefaults.AuthenticationScheme)
   //.AddCookie("cookie", o =>
   //{
   //    o.Cookie.Name = "demo";
   //    o.Cookie.Expiration = TimeSpan.FromHours(8);
   //    o.LoginPath = "/log-in";

   //});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<ProfillingMiddleWare>();
//app.UseMiddleware<ExceptionHandlerMiddleware>();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.UseCors(builder => builder
     .AllowAnyOrigin()
     .AllowAnyMethod()
     .AllowAnyHeader());

app.Run();

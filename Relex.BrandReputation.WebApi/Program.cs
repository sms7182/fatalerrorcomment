

namespace Relex.BrandReputation.WebApi
{
    [ExcludeFromCodeCoverage]
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


           
            AddAppSetting(builder.Services, builder);


            // Add services to the container.
            ConfigureServices(builder.Services);



            var app = builder.Build();
            // Configure the HTTP request pipeline.
            ConfigureApp(app);

            app.Run();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
               



            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();


            services.AddFluentValidation(fv => {
                fv.RegisterValidatorsFromAssemblyContaining<ReviewValidator>();
            });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IContentTruncateResolver, ContentTruncateResolver>();
            services.AddScoped<IContentTruncateLengthResolver, ContentTruncateLengthResolver>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IReviewBusinessService, ReviewBusinessService>();

            services.AddDbContext<BrandReputationDbContext>(options =>
            {
                options.UseSqlServer(GlobalAppSettings.Instance.ConnectionStrings.DefaultConnection);
            });

        }

        private static void ConfigureApp(WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
            app.ConfigureFluentValidationExceptionHandler();
        }

        private static void AddAppSetting(IServiceCollection services, WebApplicationBuilder builder)
        {
            var appSettings = new GlobalAppSettings();
            builder.Configuration.Bind(appSettings);
            services.AddSingleton(appSettings);
        }
    }
}
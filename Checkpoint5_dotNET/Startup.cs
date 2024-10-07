public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        // Configuração do MongoDbSettings a partir do appsettings.json
        services.Configure<MongoDbSettings>(
            Configuration.GetSection(nameof(MongoDbSettings)));

        // Registro do repositório como singleton
        services.AddSingleton<IProductRepository, ProductRepository>();

        // Adicionando suporte aos controladores (WebAPI)
        services.AddControllers();

        // Configuração para a documentação Swagger (opcional, mas útil)
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Checkpoint5_dotNET v1"));
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}

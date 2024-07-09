public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddCors(options =>
    {
        options.AddPolicy("PurchaseTrackerClient",
            builder => builder
                .WithOrigins("http://localhost:4200")
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());
    });

        services.AddControllers();
        services.AddSwaggerGen();
        services.AddSingleton<IPurchaseRepository, PurchaseRepository>();
        services.AddScoped<PurchaseService>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseCors("PurchaseTrackerClient");
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Purchase Tracker API V1");
        });
    }
}

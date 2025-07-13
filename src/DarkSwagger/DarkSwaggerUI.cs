using Microsoft.AspNetCore.Builder;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace DarkSwagger;

public static class DarkSwaggerUI
{
    public static void UseDarkSwaggerUI(this IApplicationBuilder app, Action<SwaggerUIOptions>? setup = null)
    {
        app.UseStaticFiles();

        app.Map("/swagger/ui/dark-swagger-ui.css", builder =>
        {
            builder.Run(async context =>
            {
                var assembly = typeof(DarkSwaggerUI).Assembly;
                var resourceName = "DarkSwagger.wwwroot.swagger.ui.dark-swagger-ui.css";

                context.Response.ContentType = "text/css";
                using var stream = assembly.GetManifestResourceStream(resourceName);
                if (stream == null)
                {
                    context.Response.StatusCode = 404;
                    return;
                }
                await stream.CopyToAsync(context.Response.Body);
            });
        });

        app.UseSwaggerUI(options =>
        {
            options.InjectStylesheet("/swagger/ui/dark-swagger-ui.css");
            setup?.Invoke(options);
        });
    }
}
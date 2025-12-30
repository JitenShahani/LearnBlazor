var builder = WebApplication.CreateBuilder (args);

// Add services to the container.
builder.Services.AddRazorComponents ()
    .AddInteractiveServerComponents ();

// Register Blazor Bootstrap
builder.Services.AddBlazorBootstrap ();

// NuGet Package Microsoft.AspNetCore.Components.CustomElements required to register a component as Custom Element.
builder.Services.AddServerSideBlazor (options =>
{
    options.RootComponents.RegisterCustomElement<Counter> ("my-counter");
});

builder.Services.AddScoped<SidebarState> ();
builder.Services.AddScoped<WeatherForecastService> ();
builder.Services.AddScoped<CounterService> ();
builder.Services.AddScoped<ISampleData, SampleData> ();
builder.Services.AddScoped<ContactService> ();

// Enable Localization
builder.Services.AddLocalization();

var app = builder.Build ();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment ())
{
    app.UseExceptionHandler ("/Error", createScopeForErrors: true);

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts ();
}
app.UseStatusCodePagesWithReExecute ("/not-found", createScopeForStatusCodePages: true);

app.UseHttpsRedirection ();

app.UseAntiforgery ();

// In .NET 9, MapStaticAssets() is a new middleware for serving static files in Blazor projects,
// but by default, it is optimized for assets (CSS, JS, images, fonts, etc.) and does not automatically serve .html files
// unless explicitly configured.
//app.MapStaticAssets ();

// Make sure the folder mentioned in UseStaticFiles exists and contains the static files to be served.
if (!Directory.Exists (@"C:\Temp\Storage\"))
    Directory.CreateDirectory (@"C:\Temp\Storage\");

// Allow users to upload images and save them on server @ C:\Temp\Storage\...
app.UseStaticFiles (new StaticFileOptions ()
{
    FileProvider = new PhysicalFileProvider (@"C:\Temp\Storage"),
});

// Serve static files including .html files.
app.UseStaticFiles ();

// Enable Localization
string[] supportedCultures = ["en-US", "es-MX", "hi", "mr", "gu"];
app.UseRequestLocalization (new RequestLocalizationOptions ()
    .AddSupportedCultures (supportedCultures)
    .AddSupportedUICultures (supportedCultures)
    .SetDefaultCulture (supportedCultures[0]));

app.MapRazorComponents<App> ()
    .AddInteractiveServerRenderMode ();

app.MapGet ("Culture", ([FromQuery] string culture, [FromQuery] string redirectUri, HttpContext context) =>
{
    if (culture is not null)
    {
        var requestCulture = new RequestCulture (culture, culture);
        var cookieName = CookieRequestCultureProvider.DefaultCookieName;
        var cookieValue = CookieRequestCultureProvider.MakeCookieValue (requestCulture);

        context.Response.Cookies.Append (cookieName, cookieValue);

        context.Response.Redirect (redirectUri);
    }
});

app.Run ();
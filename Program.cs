var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages().Services.AddServerSideBlazor();

var app = builder.Build();

if (!app.Environment.IsDevelopment())  
    app.UseHsts();

app.UseHttpsRedirection().UseStaticFiles().UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();
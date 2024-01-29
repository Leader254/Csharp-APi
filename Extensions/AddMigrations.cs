using csharp_crud_api.Data;
using Microsoft.EntityFrameworkCore;

namespace csharp_crud_api.Extensions
{
    public static class AddMigrations
    {
        public static IApplicationBuilder UseMigration(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var _db = scope.ServiceProvider.GetRequiredService<UserContext>();
                if (_db.Database.GetPendingMigrations().Any())
                {
                    _db.Database.Migrate();
                }
            }

            return app;
        }
    }
}

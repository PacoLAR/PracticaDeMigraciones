using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace Dragons.Models {
    public static class SeedData {
        public static void EnsurePopulated(IApplicationBuilder app) {
            DragonDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<DragonDbContext>();
            if (context.Database.GetPendingMigrations().Any()) {
                context.Database.Migrate();
            }
            if (!context.Dragons.Any()) {
                context.Dragons.AddRange(
                    new Dragon {
                        Nombre = "Dragon profundidades", Tipo = "Tiniebla"
                    },
                    new Dragon {
                        Nombre = "Dragon plata", Tipo = "Hielo"
                    },
                    new Dragon {
                        Nombre = "Dragon rojo", Tipo = "Fuego"
                    },
                    new Dragon {
                        Nombre = "Dragon dorado", Tipo = "Fuego"
                    },
                    new Dragon {
                        Nombre = "Dragon azul", Tipo = "Hielo"
                    },
                    new Dragon {
                        Nombre = "Dragon fugaz", Tipo = "Electrico"
                    },
                    new Dragon {
                        Nombre = "Dragon negro", Tipo = "Tierra"
                    },
                    new Dragon {
                        Nombre = "Dragon demonio", Tipo = "Tiniebla"
                    },
                    new Dragon {
                        Nombre = "Dragon viento", Tipo = "Hielo"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
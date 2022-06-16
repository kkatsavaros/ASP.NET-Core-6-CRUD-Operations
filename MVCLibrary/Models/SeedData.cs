using Microsoft.EntityFrameworkCore;
using MVCLibrary.Data;

namespace MVCLibrary.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LibraryContext>>()))
            {
                if (context.Book.Any()) // Αν υπάρχουν βιβλία επέστρεψε.
                {
                    return;
                }
                context.Book.AddRange(
                    new Book { Title = "Tine C# Projects", CallNumber = "AXD 2029" },
                    new Book { Title = "Tine Android Projects", CallNumber = "bgn 5453" }
                    );

                context.SaveChanges();

            }
        }

    }
}

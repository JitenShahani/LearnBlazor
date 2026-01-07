namespace LearnBlazor.Services;

public sealed class SeedCategory
{
	private readonly ILogger<SeedCategory> _logger;

	public SeedCategory (ILogger<SeedCategory> logger)
		=> _logger = logger;

	private static List<Category> GetSampleData ()
	{
		return
			[
				new () { Name = "Appetizer" },
				new () { Name = "Entree" },
				new () { Name = "Dessert" }
			];
	}

	public void Seed (AppDbContext context)
	{
		if (context is not AppDbContext db)
		{
			_logger.LogWarning ("Context is not `AppDbContext`");
			return;
		}

		var exists = db.Categories.Any ();

		if (!exists)
		{
			var categories = GetSampleData ();

			db.Categories.AddRange (categories);
			db.SaveChanges ();

            _logger.LogInformation ("Seeded {count} records", categories.Count);
        }
		else
            _logger.LogInformation ("Data already seeded...");
    }

    public async Task SeedAsync (AppDbContext context, CancellationToken cancellationToken)
    {
        if (context is not AppDbContext db)
        {
            _logger.LogWarning ("Context is not `AppDbContext`");
            return;
        }

        var exists = await db.Categories.AnyAsync (cancellationToken);

        if (!exists)
        {
            var categories = GetSampleData ();

            await db.Categories.AddRangeAsync (categories, cancellationToken);
            await db.SaveChangesAsync (cancellationToken);

            _logger.LogInformation ("Seeded {count} records", categories.Count);
        }
        else
            _logger.LogInformation ("Data already seeded...");
    }
}
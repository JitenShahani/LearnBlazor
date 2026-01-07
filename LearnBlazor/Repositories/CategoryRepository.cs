namespace LearnBlazor.Repository;

public class CategoryRepository : ICategoryRepository
{
	private readonly AppDbContext _db;

	public CategoryRepository (AppDbContext db)
		=> _db = db;

	public async Task<IEnumerable<Category>> GetAllCategoriesAsync ()
		=> await _db.Categories.ToListAsync ();

	public async Task<Category> GetCategoryByIdAsync (int id)
		=> await _db.Categories.FirstOrDefaultAsync (c => c.Id == id) ?? new Category();

    public async Task<Category> CreateCategoryAsync (Category category)
	{
		_db.Categories.Add (category);
		await _db.SaveChangesAsync ();

		return category;
	}

	public async Task<Category> UpdateCategoryAsync (Category category)
	{
		var existingCategory = await _db.Categories.FirstOrDefaultAsync (c => c.Id == category.Id);
        if (existingCategory is null)
			return category;

		existingCategory.Name = category.Name;

		_db.Update (existingCategory);
        await _db.SaveChangesAsync ();

		return existingCategory;
	}

	public async Task<bool> DeleteCategoryAsync (int id)
	{
		var category = await _db.Categories.FirstOrDefaultAsync (c => c.Id == id);
        if (category is null)
			return false;

		_db.Categories.Remove (category);
		return await _db.SaveChangesAsync () > 0;
	}
}
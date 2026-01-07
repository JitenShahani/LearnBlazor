namespace LearnBlazor.Repository;

public interface ICategoryRepository
{
    public Task<IEnumerable<Category>> GetAllCategoriesAsync ();

    public Task<Category> GetCategoryByIdAsync (int id);

    public Task<Category> CreateCategoryAsync (Category category);

    public Task<Category> UpdateCategoryAsync (Category category);

    public Task<bool> DeleteCategoryAsync (int id);
}
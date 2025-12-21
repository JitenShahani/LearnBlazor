namespace LearnBlazor.Models;

public class ToDoItem
{
    [Required]
    public string Title { get; set; } = string.Empty;
    public DateOnly? DueDate { get; set; }
    public bool IsDone { get; set; }
}
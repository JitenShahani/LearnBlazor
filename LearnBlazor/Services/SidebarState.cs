namespace LearnBlazor.Services;

public class SidebarState
{
	public bool IsExpanded { get; private set; } = true;

	public int Width => IsExpanded ? 350 : 0;

	public event Action? Changed;

	public void Toggle ()
	{
		IsExpanded = !IsExpanded;
		Changed?.Invoke ();
	}
}
namespace LearnBlazor.Components.Base;

public class PageBase : ComponentBase
{
	public string ApplicationName { get; set; } = "Learn Blazor";

	public string PageRenderMode { get; set; } = string.Empty;

	protected override void OnInitialized ()
	{
		PageRenderMode = AssignedRenderMode switch
		{
			InteractiveServerRenderMode => "Interactive Server",
			InteractiveWebAssemblyRenderMode => "Interactive WebAssembly",
			InteractiveAutoRenderMode => "Interactive Auto",
			null => "Static Server-Side Rendering (SSR)",
			_ => "Unknown"
		};

		base.OnInitialized ();
	}
}
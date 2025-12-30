namespace LearnBlazor.Components.Base;

public class PageBase : ComponentBase
{
	public string ApplicationName { get; set; } = "Learn Blazor";

	public string PageRenderMode { get; set; } = string.Empty;

	public static (string Key, string Description)[] SupportedCultures { get; set; } =
	[
		( "en-US", "English - US" ),
		( "es-MX", "Spanish - MX" ),
		( "hi", "Hindi - IN" ),
		( "mr", "Marathi - IN" ),
		( "gu", "Gujarati - IN" )
	];

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
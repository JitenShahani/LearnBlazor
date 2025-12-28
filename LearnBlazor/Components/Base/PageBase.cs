namespace LearnBlazor.Components.Base;

public class PageBase : ComponentBase
{
	public string ApplicationName { get; set; } = "Learn Blazor";

    public string PageRenderMode { get; set; } = "Static";

    protected override void OnInitialized ()
    {
        PageRenderMode = AssignedRenderMode switch
        {
            InteractiveServerRenderMode => "Interactive Server",
            InteractiveWebAssemblyRenderMode => "Interactive WebAssembly",
            InteractiveAutoRenderMode => "Interactive Auto",
            null => "Static",
            _ => "Unknown"
        };

        base.OnInitialized ();
    }
}
namespace LearnBlazor.Helper;

public static class JSRuntimeExtensions
{
	extension(IJSRuntime JSRuntime)
	{
		public async Task ToastrInfo (string title, string message)
			=> await JSRuntime.InvokeVoidAsync ("showToastr", "info", title, message);

		public async Task ToastrSuccess (string title, string message)
			=> await JSRuntime.InvokeVoidAsync ("showToastr", "success", title, message);

		public async Task ToastrWarning (string title, string message)
			=> await JSRuntime.InvokeVoidAsync ("showToastr", "warning", title, message);

		public async Task ToastrError (string title, string message)
			=> await JSRuntime.InvokeVoidAsync ("showToastr", "error", title, message);

		public async Task SweetAlertInfo (string title, string message)
			=> await JSRuntime.InvokeVoidAsync ("showSweetAlert", "info", title, message);

		public async Task SweetAlertSuccess (string title, string message)
			=> await JSRuntime.InvokeVoidAsync ("showSweetAlert", "success", title, message);

		public async Task<bool> SweetAlertQuestion (string title, string message, string cancelButtonText, string confirmButtonText)
			=> await JSRuntime.InvokeAsync<bool> ("showSweetAlert", "question", title, message, cancelButtonText, confirmButtonText);

        public async Task SweetAlertWarning (string title, string message)
			=> await JSRuntime.InvokeVoidAsync ("showSweetAlert", "warning", title, message);

		public async Task SweetAlertError (string title, string message)
			=> await JSRuntime.InvokeVoidAsync ("showSweetAlert", "error", title, message);
    }
}
using Microsoft.JSInterop;

namespace BlazorCodemy.Client.Helpers
{
    public static class JSRuntimeExtensions
    {
        public static ValueTask<bool> Confirm(this IJSRuntime jsRuntime, string message)
        {
            return jsRuntime.InvokeAsync<bool>("confirm", message);
        }

        public static ValueTask Alert(this IJSRuntime jsRuntime, string message)
        {
            return jsRuntime.InvokeVoidAsync("confirm", message);
        }
    }
}

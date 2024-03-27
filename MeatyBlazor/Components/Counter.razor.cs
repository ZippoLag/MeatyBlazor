namespace MeatyBlazor.Components;

using Microsoft.AspNetCore.Components;


public partial class Counter
{
    [Parameter]
    public int Count { get; set; }

    [Parameter]
    public EventCallback<int> CountChanged { get; set; }

    private void onButtonClickHandler()
    {
        Count++;
        CountChanged.InvokeAsync(Count);
    }
}

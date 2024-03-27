using MeatyBlazor.Services;
using Microsoft.AspNetCore.Components;

namespace MeatyBlazor.Pages;

public partial class Index : IDisposable
{
	[Inject]
	SharedStateService SharedState { get; set; } = null!;
	private IDisposable totalSubscription = null!;
	private int total;

	protected override void OnInitialized()
	{
		totalSubscription = SharedState.TotalObservable.Subscribe(newTotal =>
		{
			total = newTotal;
			StateHasChanged();
		});
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		totalSubscription?.Dispose();
	}

	~Index()
	{
		Dispose(false);
	}
}

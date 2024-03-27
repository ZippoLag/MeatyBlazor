namespace MeatyBlazor.Services;

using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;

public class SharedStateService
{
	public SharedStateService()
	{
		TotalObservable = totalSubject.AsObservable();
	}

	#region Total
	private readonly Subject<int> totalSubject = new();
	public IObservable<int> TotalObservable { get; }
	public void TotalUpdate(int newTotal)
	{
		totalSubject.OnNext(newTotal);
	}
	#endregion Total
}

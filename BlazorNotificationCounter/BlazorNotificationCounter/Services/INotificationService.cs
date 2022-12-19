namespace BlazorNotificationCounter.Services
{
    public interface INotificationService
    {
        int Count { get; set; }

        event Action OnChange;

        void DecrementCounter();
        void IncrementCounter(int currentNumber);
        void ResetCount();
    }
}
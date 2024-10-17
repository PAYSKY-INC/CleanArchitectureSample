namespace CleanArchitecture.Application.Common.Abstracts.Integration
{
    public interface IEventDispatcher
    {
        Task Publish<T>(T eventMessage, CancellationToken cancellationToken = default) where T : class;
    }
}

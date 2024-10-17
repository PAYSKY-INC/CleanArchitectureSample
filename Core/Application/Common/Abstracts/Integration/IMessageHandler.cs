namespace CleanArchitecture.Application.Common.Abstracts.Integration
{
    public interface IMessageHandler<in T>
    {
        Task HandleAsync(T message);
    }
}

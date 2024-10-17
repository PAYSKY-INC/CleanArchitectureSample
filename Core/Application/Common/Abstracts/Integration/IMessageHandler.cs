namespace SearchService.Application.Common.Abstracts.Ports
{
    public interface IMessageHandler<in T>
    {
        Task HandleAsync(T message);
    }
}

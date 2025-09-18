using MediatR;
using System.Text.Json;

namespace WebAppSandbox01.Behaviors
{
    public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest: IRequest<TResponse>
    {
        private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger;

        public LoggingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
        {
            _logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {

            var requestObj = JsonSerializer.Serialize<TRequest>(request);
            _logger.LogInformation(
                $"Handling {typeof(TRequest).Name}.\n" +
                $"Request Data: {JsonSerializer.Serialize<TRequest>(request)}"
            );

            var response = await next();

            _logger.LogInformation(
                $"Response for {typeof(TRequest).Name}: {typeof(TResponse).Name}.\n" 
                $"Response Type: {typeof(TResponse).Name}.\n" +
                $"Response Data: {JsonSerializer.Serialize<TResponse>(response)}"
            );
            return response;
        }
    }
}

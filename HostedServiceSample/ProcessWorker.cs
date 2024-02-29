public class ProcessWorker : BackgroundService
{
    private ILogger<ProcessWorker> _logger;
    public ProcessWorker(ILogger<ProcessWorker> logger)
    {
        _logger = logger;
    }
    protected async override  Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while(!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Background Service is Runing at : {time}", DateTimeOffset.Now);
            await Task.Delay(1000,stoppingToken);
        }
    }
}
namespace TestService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/106.0.0.0 Safari/537.36");
                var response = await httpClient.GetAsync(@"https://www.list.am/item/17668677", stoppingToken);
                if (response != null && response.IsSuccessStatusCode)
                {
                    var html = await response.Content.ReadAsStringAsync();
                    if (html.Contains("$16,200"))
                    {
                        _logger.LogInformation("My car value = $16,200");
                    }
                }
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
        public override async Task StartAsync(CancellationToken stoppingToken)
        {
            Run(stoppingToken);
        }



        public async Task Run(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/106.0.0.0 Safari/537.36");
                var response = await httpClient.GetAsync(@"https://www.list.am/item/17668677", stoppingToken);
                if (response != null && response.IsSuccessStatusCode)
                {
                    var html = await response.Content.ReadAsStringAsync();
                    if (html.Contains("$16,200"))
                    {
                        _logger.LogInformation("My car value = $16,200");
                    }
                    else
                    {
                        stoppingToken.ThrowIfCancellationRequested();
                    }
                }
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
        public override Task StopAsync(CancellationToken cancellationToken)
        {
            return base.StopAsync(cancellationToken);
        }
    }
}
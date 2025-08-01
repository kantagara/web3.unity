namespace ChainSafe.Gaming.Web3.Environment
{
    /// <summary>
    /// The environment Web3 is being executed in.
    /// </summary>
    public class Web3Environment
    {
        public Web3Environment(IHttpClient httpClient, ILogWriter logWriter, IOperatingSystemMediator operatingSystem)
        {
            OperatingSystem = operatingSystem;
            HttpClient = httpClient;
            LogWriter = logWriter;
        }

        public IHttpClient HttpClient { get; }

        public ILogWriter LogWriter { get; }

        public IOperatingSystemMediator OperatingSystem { get; }
    }
}
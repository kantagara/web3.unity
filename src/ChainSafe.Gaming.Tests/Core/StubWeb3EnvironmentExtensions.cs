using ChainSafe.Gaming.Web3.Build;
using ChainSafe.Gaming.Web3.Environment;
using Microsoft.Extensions.DependencyInjection;

namespace ChainSafe.Gaming.Tests.Core
{
    public static class StubWeb3EnvironmentExtensions
    {
        public static IWeb3ServiceCollection UseStubEnvironment(
            this IWeb3ServiceCollection collection,
            IHttpClient httpClient = null,
            ILogWriter logWriter = null,
            IOperatingSystemMediator osMediator = null)
        {
            collection.AddSingleton(httpClient ?? new StubHttpClient());
            collection.AddSingleton(logWriter ?? new TestLogWriter());
            collection.AddSingleton(osMediator ?? new StubOperatingSystemMediator());
            collection.AddSingleton<Web3Environment>();

            return collection;
        }
    }
}
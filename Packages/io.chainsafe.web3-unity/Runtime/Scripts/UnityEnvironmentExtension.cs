using ChainSafe.Gaming.Unity;
using ChainSafe.Gaming.Web3.Build;
using ChainSafe.Gaming.Web3.Core.Unity;
using ChainSafe.Gaming.Web3.Environment;
using Microsoft.Extensions.DependencyInjection;

namespace ChainSafe.Gaming.Web3.Unity
{
    public static class UnityEnvironmentExtensions
    {
        /// <summary>
        /// Binds Unity-specific environment components to the Web3 builder.
        /// This includes platform specific http clients, loggers, etc.
        /// </summary>
        /// <param name="collection">Service collection to bind to.</param>
        /// <returns>Service collection.</returns>
        public static IWeb3ServiceCollection UseUnityEnvironment(this IWeb3ServiceCollection collection)
        {
            collection.AssertServiceNotBound<Web3Environment>();

            return (IWeb3ServiceCollection)collection.AddSingleton<IHttpClient, UnityHttpClient>()
                .AddSingleton<ILogWriter, UnityLogWriter>()
                .AddSingleton<IOperatingSystemMediator, UnityOperatingSystemMediator>()
                .AddSingleton<Web3Environment>();
        }
    }
}
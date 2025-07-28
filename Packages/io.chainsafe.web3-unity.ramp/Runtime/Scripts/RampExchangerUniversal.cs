using System.Threading.Tasks;
using ChainSafe.Gaming.Evm.Signers;
using RampSDK;

namespace ChainSafe.Gaming.Unity.Ramp
{
    public class RampExchangerUniversal
    {
        private readonly RampConfig config;
        private readonly ISigner signer;

        public RampExchangerUniversal(IRampExchangerConfig config, ISigner signer)
        {
            this.config = config.Config();
            this.signer = signer;
        }
    }
}
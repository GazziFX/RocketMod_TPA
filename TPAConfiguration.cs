using Rocket.API;

namespace RocketMod_TPA
{
    public class TPAConfiguration : IRocketPluginConfiguration
    {
        public int TPACoolDownSeconds, TPADelaySeconds, NinjaEffectID;
        public bool TPADelay, CancelOnBleeding, CancelOnHurt, TPACoolDown, NinjaTP;

        public void LoadDefaults()
        {
            TPACoolDown = false;
            TPACoolDownSeconds = 20;
            TPADelay = false;
            TPADelaySeconds = 10;
            CancelOnBleeding = false;
            CancelOnHurt = false;
            NinjaTP = false;
            NinjaEffectID = 45;
        }
    }
}

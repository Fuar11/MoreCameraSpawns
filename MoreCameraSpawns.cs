using ComplexLogger;

namespace MoreCameraSpawns
{
    public class Main : MelonMod
    {
        internal static ComplexLogger<Main> Logger = new();

        public override void OnInitializeMelon()
        {
            Logger.Log("More Camera Spawns is online.", FlaggedLoggingLevel.Always);
        }
    }
}

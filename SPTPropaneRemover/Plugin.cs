using BepInEx;
using SPTPropaneRemover.Patches;

namespace SPTPropaneRemover
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        internal void Awake()
        {
            new HandlerExplosionStartPatch().Enable();
        }
    }
}

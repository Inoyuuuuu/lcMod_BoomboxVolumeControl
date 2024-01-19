using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using lcBoomboxVolumeControl.Patches;
using lcBoomboxVolumeControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lcBoomboxVolumeControl
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class BoomboxVolControlMod : BaseUnityPlugin
    {
        private const string modGUID = "inoyu.lcBoomboxVolumeControl";
        private const string modName = "BoomboxVolumeControl";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static BoomboxVolControlMod instance;

        internal ManualLogSource mls;

        public static BoomboxVolChangeOnButtonPress InputActionInstance = new BoomboxVolChangeOnButtonPress();

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("mod awake");

            harmony.PatchAll(typeof(BoomboxVolControlMod));
            harmony.PatchAll(typeof(BoomboxVolChangePatch));

        }
    }
}

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
    public class BoomboxVolumeControlMod : BaseUnityPlugin
    {
        private const string modGUID = "inoyu.lcBoomboxVolumeControl";
        private const string modName = "BoomboxVolumeControl";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static BoomboxVolumeControlMod instance;

        internal ManualLogSource mls;

        public static BoomboxVolumeDownOnButtonPress InputActionInstance = new BoomboxVolumeDownOnButtonPress();

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("mod awake");

            harmony.PatchAll(typeof(BoomboxVolumeControlMod));
          
        }
    }
}

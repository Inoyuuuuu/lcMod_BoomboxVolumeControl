using HarmonyLib;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lcBoomboxVolumeControl.Patches
{
    [HarmonyPatch(typeof(BoomboxItem))]
    internal class BoomboxVolDownPatch
    {
        [HarmonyPatch(nameof(BoomboxItem.Update))]
        [HarmonyPostfix]
        static void volumeDown(ref AudioSource ___boomboxAudio)
        {
            if (BoomboxVolumeControlMod.InputActionInstance.BoomboxVolDownKey.triggered && ___boomboxAudio.volume > 0)
            {
                ___boomboxAudio.volume = ___boomboxAudio.volume - 10;
            }
        }
    }
}

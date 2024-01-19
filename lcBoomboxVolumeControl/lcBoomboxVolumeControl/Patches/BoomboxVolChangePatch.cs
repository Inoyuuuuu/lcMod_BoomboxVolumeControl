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
    internal class BoomboxVolChangePatch
    {
        private const float volumeChangeAmount = 5f;

        [HarmonyPatch(nameof(BoomboxItem.Update))]
        [HarmonyPostfix]
        static void volumeDown(ref AudioSource ___boomboxAudio)
        {
            if (BoomboxVolControlMod.InputActionInstance.BoomboxVolDownKey.triggered && ___boomboxAudio.volume > 0f)
            {
                ___boomboxAudio.volume -= volumeChangeAmount;
            } 
            else if(BoomboxVolControlMod.InputActionInstance.BoomboxVolUpKey.triggered && ___boomboxAudio.volume < 100f)
            {
                ___boomboxAudio.volume += volumeChangeAmount;
            }
        }
    }
}

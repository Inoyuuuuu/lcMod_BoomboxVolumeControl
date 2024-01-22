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
        private const float VOLUME_CHANGE_AMOUNT = 0.2f;
        private const float VOLUME_MAX = 1.0f;
        private const float VOLUME_MIN = 0.0f;

        [HarmonyPatch(nameof(BoomboxItem.Update))]
        [HarmonyPostfix]
        static void volumeDown(ref AudioSource ___boomboxAudio)
        {
            if (BoomboxVolControlMod.InputActionInstance.BoomboxVolDownKey.triggered)
            {
                if (___boomboxAudio.volume > VOLUME_MIN)
                {
                    ___boomboxAudio.volume -= VOLUME_CHANGE_AMOUNT;
                }
            } 
            else if(BoomboxVolControlMod.InputActionInstance.BoomboxVolUpKey.triggered && ___boomboxAudio.volume < VOLUME_MAX)
            {
                ___boomboxAudio.volume += VOLUME_CHANGE_AMOUNT;
            }
        }
    }
}

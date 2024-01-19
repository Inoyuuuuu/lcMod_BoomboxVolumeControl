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
        private const float volumeChangeAmount = 1;

        [HarmonyPatch(nameof(BoomboxItem.Update))]
        [HarmonyPrefix]
        static void volumeDown(ref AudioSource ___boomboxAudio)
        {
            if (BoomboxVolControlMod.InputActionInstance.BoomboxVolDownKey.triggered)
            {
                if (___boomboxAudio.volume > 0f)
                {
                    ___boomboxAudio.volume = 0f;
                } else
                {
                    ___boomboxAudio.volume = 100f;
                }
            } 
            //else if(BoomboxVolControlMod.InputActionInstance.BoomboxVolUpKey.triggered && ___boomboxAudio.volume < 100)
            //{
            //    ___boomboxAudio.volume = 100f;
            //}
        }
    }
}

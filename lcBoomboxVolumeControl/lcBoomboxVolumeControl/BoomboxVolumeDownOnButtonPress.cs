using LethalCompanyInputUtils.Api;
using UnityEngine.InputSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lcBoomboxVolumeControl.Patches
{
    public class BoomboxVolumeDownOnButtonPress : LcInputActions
    {
        [InputAction("<Keyboard>/o", Name = "BoomboxVolDown", GamepadPath = "<Gamepad>/Button North", ActionType = InputActionType.Button)]
        public InputAction BoomboxVolDownKey {  get; set; }
    }
}

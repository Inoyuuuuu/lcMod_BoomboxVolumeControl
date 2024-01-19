using LethalCompanyInputUtils.Api;
using UnityEngine.InputSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lcBoomboxVolumeControl.Patches
{
    public class BoomboxVolChangeOnButtonPress : LcInputActions
    {
        [InputAction("<Keyboard>/o", Name = "BoomboxVolDown", ActionType = InputActionType.Button)]
        public InputAction BoomboxVolDownKey {  get; set; }

        //[InputAction("<Keyboard>/p", Name = "BoomboxVolUp", ActionType = InputActionType.Button)]
        //public InputAction BoomboxVolUpKey { get; set; }
    }
}

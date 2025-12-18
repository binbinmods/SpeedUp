using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
// using Obeliskial_Content;
// using Obeliskial_Essentials;
using System.IO;
using static UnityEngine.Mathf;
using UnityEngine.TextCore.LowLevel;
using static SpeedUp.Plugin;
using System.Collections.ObjectModel;
using UnityEngine;

namespace SpeedUp
{
    public class SpeedUpFunctions
    {

        public static void HandleSpeedChange()
        {
            Time.timeScale = SpeedModifier.Value;
        }

        public static void HandleUltraFast()
        {
            if (EnableUltrafast.Value)
            {
                GameManager.Instance.configGameSpeed = Enums.ConfigSpeed.Ultrafast;
                return;
            }

            bool flag = SaveManager.PrefsHasKey("fastMode") ? SaveManager.LoadPrefsBool("fastMode") : (SettingsManager.Instance?.fastModeToggle.isOn ?? false);
            SettingsManager.Instance?.fastModeToggle?.isOn = flag;
            if (flag)
            {
                GameManager.Instance.configGameSpeed = Enums.ConfigSpeed.Fast;
            }
            else
            {
                GameManager.Instance.configGameSpeed = Enums.ConfigSpeed.Slow;
            }

        }


    }
}


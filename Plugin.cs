using System;
using BepInEx;
using Photon.Pun;
using UnityEngine;
using Utilla;

namespace GorillaCinema
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {

    }

    public class PluginInfo
    {
        internal const string
            GUID = "Rhosyn.GorillaCinema",      
            Name = "GorillaCinema",      
            Version = "1.0.0";      
    }
}

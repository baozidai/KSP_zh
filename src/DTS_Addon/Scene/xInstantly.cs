﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DTS_Addon.Scene
{
    [KSPAddon(KSPAddon.Startup.Instantly, false)]
    public class xInstantly : MonoBehaviour
    {
        void OnGUI()
        {
            //GUI.Label(new Rect(10, 10, 200, 20), "Instantly");
        }
    }
}

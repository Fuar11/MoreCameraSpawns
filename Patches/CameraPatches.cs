using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Il2Cpp;
using HarmonyLib;

namespace MoreCameraSpawns.Patches
{
    internal class CameraPatches : MonoBehaviour
    {

        [HarmonyPatch(typeof(GearItem), nameof(GearItem.ManualStart))]

        public class RemoveCameraSpawn
        {

            public static void Prefix(GearItem __instance)
            {

                if (__instance.m_HasBeenEquippedAndUsed || __instance.m_BeenInPlayerInventory || __instance.m_InPlayerInventory || __instance.m_ItemLooted || __instance.IsInsideContainer())
                {
                    return;
                }

                if (__instance.name.ToLowerInvariant().Contains("camera"))
                {

                    if (GameManager.GetInventoryComponent().GetBestGearItemWithName("GEAR_Camera") != null)
                    {
                        Destroy(__instance.gameObject);
                    }
                }

            }


        }


    }
}

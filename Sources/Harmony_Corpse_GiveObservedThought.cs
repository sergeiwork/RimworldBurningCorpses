using HarmonyLib;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace BurningCorpse
{
    [HarmonyPatch(typeof(Corpse))]
    [HarmonyPatch("GiveObservedThought")]
    class Harmony_Corpse_GiveObservedThought
    {
        [HarmonyPrefix]
        static bool GiveObservedThought_Prefix(Corpse __instance, ref Thought_Memory __result)
        {
            if (__instance.IsBurning())
            {
                __result = (Thought_MemoryObservation) ThoughtMaker.MakeThought(ThoughtDef.Named("ObservedBurningCorpse"));
                (__result as Thought_MemoryObservation).Target = __instance;
                Log.Message("Burning Corpse found");
                return false;
            }
            return true;
        }
    }
}

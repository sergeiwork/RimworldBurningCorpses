using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;
using HarmonyLib;
using System.Reflection;

namespace BurningCorpse
{
    public class BurningCorpse : Mod
    {
        public BurningCorpse(ModContentPack content) : base(content)
        {
            Harmony harmony = new Harmony("rimworld.undone.burningcorpse");
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            Log.Message("Burning Corpse loaded");
        }
    }
}

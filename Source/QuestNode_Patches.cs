using HarmonyLib;
using RimWorld;
using RimWorld.QuestGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace NoDisabledFactions {
    [HarmonyPatch]
    public static class QuestNode_Patches {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(QuestNode_CreateIncidents), "TestRunInt")]
        public static void CreateIncidents(ref bool __result, Slate slate, QuestNode_CreateIncidents __instance) {
            if (__result) {
                var n = __instance;
                var parms = new IncidentParms {
                    forced = true,
                    target = slate.Get<Map>("map"),
                    points = n.points.GetValue(slate),
                    faction = n.faction.GetValue(slate)
                };
                var def = n.incidentDef.GetValue(slate);
                __result = def.Worker.CanFireNow(parms);
            }
        }
    }
}

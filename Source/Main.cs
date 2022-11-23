using HarmonyLib;
using Verse;
using UnityEngine;
using RimWorld.QuestGen;
using RimWorld;

namespace NoDisabledFactions {
    [StaticConstructorOnStartup]
    public class Main {
        static Main() {
            var harmony = new Harmony(Strings.ID);
            harmony.PatchAll();
            QuestNode_RandomNode n;
            QuestNode_CreateIncidents n2;
            IncidentWorker_MechCluster n3;
        }
    }
}

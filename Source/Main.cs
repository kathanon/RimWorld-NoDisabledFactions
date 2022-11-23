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
            QuestNode_Infestation n2;
            SitePartWorker_MechCluster n3;
            SitePartWorker_SleepingMechanoids n6;
            QuestNode_GenerateSite n4;
            QuestNode_SubScript n5;
        }
    }
}

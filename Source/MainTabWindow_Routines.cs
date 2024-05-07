using System.Collections.Generic;
using System.Linq;
using RimWorld;
using UnityEngine;
using Verse;

namespace PawnRoutines
{
    public class MainTabWindow_Routines: MainTabWindow
    {
        private static List<Pawn> pawns;
        
     
        public override void DoWindowContents(Rect inRect)
        {
            
        }

        public override void PreOpen()
        {
            GetPawns();
            base.PreOpen();
            
        }

        private static void GetPawns()
        {
            pawns = Find.CurrentMap.mapPawns.FreeColonists.ToList();
            
        }
    }
}
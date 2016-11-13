﻿using RimWorld;
using Verse;
using Verse.AI;

namespace Combat_Realism
{
    class JobGiver_HunkerDown : ThinkNode_JobGiver
    {
        protected override Job TryGiveJob(Pawn pawn)
        {

            //if (pawn.TryGetComp<CompSuppressable>().isHunkering && pawn.GetPosture() != PawnPosture.Standing)
            //{
            //    return null;
            //}

            if (!pawn.Position.Standable() && !pawn.Position.ContainsStaticFire())
            {
                return null;
            }

            if (GenAI.EnemyIsNear(pawn, 4f))
            {
                return null;
            }

            return new Job(CR_JobDefOf.HunkerDown, pawn)
            {
                //                playerForced = true,
            };
        }
    }
}

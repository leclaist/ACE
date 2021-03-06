﻿using ACE.Network.Sequence;
using ACE.Network.Motion;
using ACE.Entity;

namespace ACE.Network.GameMessages.Messages
{
    public class GameMessageUpdateMotion : GameMessage
    {
       public GameMessageUpdateMotion(ObjectGuid animationTargetGuid, byte[] instance_timestamp, SequenceManager sequence, MotionState newState)
            : base(GameMessageOpcode.Motion, GameMessageGroup.Group0A)
        {
            Writer.WriteGuid(animationTargetGuid);
            // who is getting the message - the rest of the sequences are the target objects sequences -may be the same
            Writer.Write(instance_timestamp);
            Writer.Write(sequence.GetNextSequence(SequenceType.ObjectMovement));
            if (!newState.IsAutonomous)
                Writer.Write(sequence.GetNextSequence(SequenceType.ObjectServerControl));
            else
                Writer.Write(sequence.GetCurrentSequence(SequenceType.ObjectServerControl));

            ushort autonomous;
            if (newState.IsAutonomous)
                autonomous = 1;
            else
                autonomous = 0;
            Writer.Write(autonomous);
            var movementData = newState.GetPayload(animationTargetGuid, sequence);
            Writer.Write(movementData);
            Writer.Align();
        }
    }
}

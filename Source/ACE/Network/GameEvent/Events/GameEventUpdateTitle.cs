﻿namespace ACE.Network.GameEvent.Events
{
    public class GameEventUpdateTitle : GameEventMessage
    {
        public GameEventUpdateTitle(Session session, uint title)
            : base(GameEventType.UpdateTitle, GameMessageGroup.Group09, session)
        {
            Writer.Write(title);
            Writer.Write(1u);
        }
    }
}

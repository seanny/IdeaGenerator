//
// 	Copyright (C) 2019 Outlaw Games Studio. All Rights Reserved.
//
// 	This document is the property of Outlaw Games Studio.
// 	It is considered confidential and proprietary.
//
// 	This document may not be reproduced or transmitted in any form
// 	without the consent of Outlaw Games Studio.
//
using System;
namespace GameIdeaGenerator
{
    public class Multiplayer
    {
        public bool multiplayer;

        public void RandomMultiplayer()
        {
            Random random = new Random();
            SetMultiplayer(random.NextDouble() >= 0.5);
        }

        public void SetMultiplayer(bool isMp)
        {
            Console.WriteLine($"Multiplayer set to {isMp.ToString()}");
            multiplayer = isMp;
        }
    }
}

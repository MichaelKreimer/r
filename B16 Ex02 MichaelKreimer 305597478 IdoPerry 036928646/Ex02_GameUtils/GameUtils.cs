﻿using System;
using System.Collections.Generic;
using System.Text;

namespace B16_Ex02
{
    public class GameUtils
    {
        public const char k_Player1Symbol = 'x';
        public const char k_Player2Symbol = 'o';
        public const bool v_Human = true;
        public const bool v_Robot = false;
        public enum eGameMode : byte
        {
            PlayerVsPlayer,
            PlayerVsAi
        }

    }
}

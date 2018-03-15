using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Work.Tests
{
    enum EngineState : byte
    {
        IsBrake = 1 << 0,
        IsClutch = 1 << 1,
        IsRunning = 1 << 2,
        SpeedMask = (1 << 3 | 1 << 4 | 1 << 5),
        SpeedShift = 3
    }

    static class EngineStateHelper
    {
        public static bool CheckRunning(this EngineState s)
        {
            return (s & EngineState.IsRunning) != 0;
        }

        public static EngineState StopEngine(this EngineState s)
        {
            return s & ~EngineState.IsRunning;
        }

        public static EngineState StartEngine(EngineState s)
        {
            return s | EngineState.IsRunning;
        }

        public static int GetSpeed(EngineState s)
        {
            return (int)(s & EngineState.SpeedMask)
                            >> (int)EngineState.SpeedShift;
        }

        public static EngineState SetSpeed(EngineState s, int speed)
        {
            if (speed < 0 || speed > 7) throw new ArgumentException("Speed must be between 0 and 7.");
            speed <<= (int)EngineState.SpeedShift;
            s &= ~EngineState.SpeedMask;
            return (EngineState)((int)s | speed);
        }

    }
}

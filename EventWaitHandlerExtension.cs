﻿using System.Threading;

namespace Road_Lap1
{
    public static class EventWaitHandleExtension
    {
        public static bool WaitOneEx(this EventWaitHandle ewh, bool flag) => flag ? ewh.WaitOne() : false;
    }
}

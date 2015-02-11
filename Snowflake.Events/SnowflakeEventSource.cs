﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowflake.Events
{
    public partial class SnowflakeEventSource
    {
        public static SnowflakeEventSource EventSource;
        SnowflakeEventSource()
        {
        }
        public static void InitEventSource()
        {
            if (SnowflakeEventSource.EventSource == null)
            {
                SnowflakeEventSource.EventSource = new SnowflakeEventSource();
            }
        }
    }
}
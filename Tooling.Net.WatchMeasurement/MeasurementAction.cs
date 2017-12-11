using System;
using System.Diagnostics;

namespace Tooling.Net.WatchMeasurement
{
    public static class MeasurementAction
    {
        public static bool IsEnabled { get; set; }

        /// <summary>
        /// Start a new measure code bloc.
        /// </summary>
        /// <param name="onEnd">Action called on the object dispose</param>
        /// <param name="startNow">Indicate if the measurement will start now</param>
        /// <returns></returns>
        public static MeasureAction StartMeasure(Action<Stopwatch> onEnd, bool startNow)
        {
            return new MeasureAction(onEnd, startNow);
        }
    }
}

using System;
using System.Diagnostics;

namespace Tooling.Net.WatchMeasurement
{
    public class MeasureAction : IDisposable
    {
        #region Private fields

        private readonly Stopwatch stopWatch;
        private readonly Action<Stopwatch> onEnd;

        #endregion

        #region Constructor

        public MeasureAction(Action<Stopwatch> onEnd, bool startNow)
        {
            if (MeasurementAction.IsEnabled)
            {
                this.onEnd = onEnd;
                stopWatch = new Stopwatch();

                if (startNow)
                    Start();
            }
        }

        #endregion

        #region Public methods

        public void Stop()
        {
            if (MeasurementAction.IsEnabled)
                stopWatch.Stop();
        }

        public void Start()
        {
            if (MeasurementAction.IsEnabled)
                stopWatch.Start();
        }

        public void Restart()
        {
            if (MeasurementAction.IsEnabled)
                stopWatch.Restart();
        }

        #endregion

        #region Dispose

        public void Dispose()
        {
            if (MeasurementAction.IsEnabled)
            {
                stopWatch.Stop();
                onEnd(stopWatch);
            }
        }

        #endregion
    }
}

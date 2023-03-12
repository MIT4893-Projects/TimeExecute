using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeExecute.Components.Exceptions;

namespace TimeExecute.Components
{
    class Timer
    {
        private bool StartedTiming { get; set; } = false;
        private readonly Stopwatch ExecuteTimer = new();

        public Timer() { }
        
        /// <summary>
        /// Start timing.
        /// </summary>
        /// <exception cref="StartedTimerException">Occurs when Timer already started.</exception>
        public void StartTimer()
        {
            if (StartedTiming)
                throw new StartedTimerException();

            StartedTiming = true;
            ExecuteTimer.Start();
        }

        /// <summary>
        /// Stop the Timer and return the elapsed time.
        /// </summary>
        /// <returns>Elapsed time, as TimeSpan type</returns>
        /// <exception cref="UnstartedTimerException">Occurs when Timer haven't start yet.</exception>
        public TimeSpan StopTimer()
        {
            if (!StartedTiming)
                throw new UnstartedTimerException();

            StartedTiming = false;
            ExecuteTimer.Stop();
            TimeSpan timeTaken = ExecuteTimer.Elapsed;
            return timeTaken;
        }
    }
}

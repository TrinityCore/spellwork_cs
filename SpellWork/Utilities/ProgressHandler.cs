using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpellWork.Utilities
{
    internal class ProgressHandler
    {
        Action<int> Callback { get; set; }
        public int Progress
        {
            get
            {
                return _progress;
            }
        }
        volatile int _progress;

        int _stepsProgressStartValue;
        int _stepsProgressStepsCount;
        int _stepsProgressTarget;
        volatile int _stepsProgressCurrent;

        public ProgressHandler(Action<int> callback)
        {
            this.Callback = callback;
        }

        public void SetProgress(int value)
        {
            if (value < Progress)
                throw new ArgumentOutOfRangeException(nameof(value), value, "New progress is lower than previous progress");

            SetProgressNoValidation(value);
        }

        private void SetProgressNoValidation(int value)
        {
            _progress = value;
            Callback?.Invoke(Progress);
        }

        public void StartStepsProgress(int steps, int targetProgress)
        {
            _stepsProgressStartValue = Progress;
            _stepsProgressStepsCount = steps;
            _stepsProgressTarget = targetProgress;
            _stepsProgressCurrent = 0;
        }

        public void IncrementStepsProgress()
        {
            // The code below is not fully atomic, with the last line possible setting the progress to an old value
            var newStepsProgress = Interlocked.Increment(ref _stepsProgressCurrent);
            var newProgress = _stepsProgressStartValue + newStepsProgress * (_stepsProgressTarget - _stepsProgressStartValue) / _stepsProgressStepsCount;
            SetProgressNoValidation(newProgress);
        }

        public void ResetProgress()
        {
            SetProgressNoValidation(0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalWithNoiseWFORMS
{
    internal class ImpulseCharacteristic
    {
        const float PI = 3.14159265358f;

        private float _amplitude = 0;
        private float _quadraticDeviation = 0;

        public ImpulseCharacteristic(float amplitude, float quadraticDeviation)
        {
            _amplitude = amplitude;
            _quadraticDeviation = quadraticDeviation;
        }

        public float GetFunctionValue(int stepNumber, float samplingPeriod, int countsNumber)
        {
            if(stepNumber <= countsNumber / 2)
            {
                return _amplitude * (float)Math.Exp(-Math.Pow(stepNumber * samplingPeriod, 2) / (2 * _quadraticDeviation * _quadraticDeviation));
            }
            else
            {
                return _amplitude * (float)Math.Exp(-Math.Pow(stepNumber * samplingPeriod - countsNumber * samplingPeriod, 2) / (2 * _quadraticDeviation * _quadraticDeviation));
            }
        }
    }
}

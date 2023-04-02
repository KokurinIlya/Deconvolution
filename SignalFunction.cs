using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalWithNoiseWFORMS
{
	class SignalFunction
    {
		const float PI = 3.14159265358f;

		private float _amplitude = 0;
		private float _average = 0;
		private float _quadraticDeviation = 0;


		public SignalFunction(float amplitude, float average, float quadraticDeviation)
		{
			_amplitude = amplitude;
			_average = average;
			_quadraticDeviation = quadraticDeviation;
		}

		public float GetFunctionValue(int stepNumber, float samplingPeriod)
		{
			return _amplitude * (float)Math.Exp(-Math.Pow(stepNumber * samplingPeriod - _average, 2) / (2 * _quadraticDeviation * _quadraticDeviation));
		}
	}
}

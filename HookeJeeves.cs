using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalWithNoiseWFORMS
{
    internal class HookeJeeves
    {
        public delegate void IntermediateResult(List<float> values, List<PointF> impulseCharacteristicPoints, List<PointF> signalPoints, float samplingPeriod);
        private IntermediateResult _drawMethod;

        private List<PointF> _impulseCharacteristicPoints;
        private List<PointF> _signalPoints;
        private float _samplingPeriod;

        public HookeJeeves() { }
        public HookeJeeves(IntermediateResult drawMethod, List<PointF> impulseCharacteristicPoints, List<PointF> signalPoints, float samplingPeriod)
        {
            _drawMethod = drawMethod;
            _impulseCharacteristicPoints = impulseCharacteristicPoints;
            _signalPoints = signalPoints;
            _samplingPeriod = samplingPeriod;
        }

        void DrawIntermediateResult(List<float> values)
        {
            _drawMethod(values, _impulseCharacteristicPoints, _signalPoints, _samplingPeriod);
        }

        private float CalculateFunction(List<float> outputValues, List<float> impulseCharacteristicValues, List<float> values)
        {
            List<float> buffer = new List<float>();

            for (int i = 0; i < outputValues.Count; i++)
            {
                float summ = 0;
                for (int j = 0; j < outputValues.Count; j++)
                {
                    if (j - i >= 0)
                    {
                        summ += values[j] * impulseCharacteristicValues[(j - i) % outputValues.Count];
                    }
                    else
                    {
                        summ += values[j] * impulseCharacteristicValues[outputValues.Count - (i - j) % outputValues.Count];
                    }
                }
                buffer.Add(summ);
            }

            float result = 0;

            for (int i = 0; i < outputValues.Count; i++)
            {
                float summ = 0;
                for (int j = 0; j < outputValues.Count; j++)
                {
                    if (i - j >= 0)
                    {
                        summ += (float)Math.Exp(-1 - buffer[j]) * impulseCharacteristicValues[(i - j) % outputValues.Count];
                    }
                    else
                    {
                        summ += (float)Math.Exp(-1 - buffer[j]) * impulseCharacteristicValues[outputValues.Count - (j - i) % outputValues.Count];
                    }
                }
                result += (float)Math.Pow(outputValues[i] - summ, 2);
            }

            return result;
        }

        public List<float> GetResult(List<float> outputValues, List<float> impulseCharacteristicValues, float accuracy, List<float> startValues, List<float> steps, float stepReduction, float speed)
        {
            List<float> previousValues = new List<float>(startValues);
            List<float> nextValues = new List<float>(startValues);
            List<float> buffer = new List<float>(startValues);
            float previousFunctionValue = 0;
            float nextFunctionValue = 0;
            int count = 0;
            while (true)
            {
                
                for (int i = 0; i < startValues.Count; i++)
                {
                    previousFunctionValue = CalculateFunction(outputValues, impulseCharacteristicValues, nextValues);

                    nextValues[i] = previousValues[i] + steps[i];

                    nextFunctionValue = CalculateFunction(outputValues, impulseCharacteristicValues, nextValues);

                    if (nextFunctionValue > previousFunctionValue)
                    {
                        nextValues[i] = previousValues[i] - steps[i];
                        nextFunctionValue = CalculateFunction(outputValues, impulseCharacteristicValues, nextValues);

                        if (nextFunctionValue > previousFunctionValue)
                        {
                            nextValues[i] = previousValues[i];
                        }
                    }
                }

                previousFunctionValue = CalculateFunction(outputValues, impulseCharacteristicValues, buffer);
                nextFunctionValue = CalculateFunction(outputValues, impulseCharacteristicValues, nextValues);

                if (nextFunctionValue < previousFunctionValue)
                {
                    for (int i = 0; i < nextValues.Count; i++)
                    {              
                        previousValues[i] = nextValues[i] + speed*(nextValues[i] - buffer[i]);
                        buffer[i] = nextValues[i];
                        nextValues[i] = previousValues[i];
                    }
                }
                else
                {
                    if(CheckCompleteCondition(steps, accuracy, stepReduction))
                    {
                        nextValues =  new List<float>(buffer);
                        break;
                    }
                    for (int i = 0; i < nextValues.Count; i++)
                    {
                        previousValues[i] = buffer[i];
                        nextValues[i] = buffer[i];
                    }
                }

                count++;
                if (count % 100 == 0)
                {
                    DrawIntermediateResult(nextValues);
                }
            }
            DrawIntermediateResult(nextValues);
            return nextValues; 
        }

        private bool CheckCompleteCondition(List<float> steps, float accuracy, float stepReduction)
        {
            bool isComplete = true;
            for (int i = 0; i < steps.Count; i++)
            {
                if(steps[i] > accuracy)
                {
                    steps[i] /= stepReduction;
                    isComplete = false;
                }
            }
            return isComplete;
        }
    }
}

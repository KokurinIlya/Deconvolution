using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalWithNoiseWFORMS
{
    class CoordinateConverter
    {
		public List<PointF> ConvertRange(List<PointF> data, float outMaximumX, float outMinimumX, float outMaximumT, float outMinimumT, float inMaximumX, float inMinimumX, float inMaximumT, float inMinimumT)
		{
			List<PointF> output = new List<PointF>(data);
			float kForT = (outMaximumT - outMinimumT) / (inMaximumT - inMinimumT);
			float kForX = (outMaximumX - outMinimumX) / (inMaximumX - inMinimumX);
            if (float.IsInfinity(kForX))
            {
				kForX = 0;
			}
			//проходим по всем элементам вектора output записывая в него новые значения item(наши преобразованные координаты)
			for (int i = 0; i < output.Count; i++)
			{
				output[i] = new PointF((output[i].X - inMinimumT) * kForT + outMinimumT,(output[i].Y - inMinimumX) * kForX + outMinimumX);
			}

			return output;
		}
	}
}

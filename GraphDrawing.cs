using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalWithNoiseWFORMS
{
    class GraphDrawing
    {
        PictureBox graphPictureBox;
        Graphics graphicCanvas;
        Bitmap myBitmap;


        bool init;

		Pen gridPen;
		Pen _dataPen;
        SolidBrush fontPen;
		Font font;

		//Переменны для границ области рисования графика
		float actualTop;
        float actualBottom;
        float actualLeft;
        float actualRight;

        //необходимые отступы
        float padding = 40;
        float leftKeysPadding = 20;
        float bottomKeysPadding = 10;

        float actualWidth;
        float actualHeight;

		CoordinateConverter _coordinateConverter = new CoordinateConverter();

        public GraphDrawing(PictureBox picBox, Pen dataPen)
		{
            graphPictureBox = picBox;

            myBitmap = new Bitmap(picBox.Width, picBox.Height);

            graphicCanvas = Graphics.FromImage(myBitmap);
			graphicCanvas.Clear(Color.White);
       
            gridPen = new Pen(Color.FromArgb(100, 235, 235, 235), 0.5f);
            _dataPen = dataPen;
            fontPen = new SolidBrush(Color.Black);

            font = new Font("Montserrat", 8);

            init = true;
		}

        public void StartDrawing(List<PointF> data, float tMinimum, float xMinimum, float tMaximum, float xMaximum, string xAxisName, string yAxisName, Pen dataPen, bool drawGrid = true)
        {

            if (!init) return;

            if (!data.Any()) return;

            _dataPen = dataPen;

            //переписал для удобства высоту и длинну окна с учетом отступов
            actualWidth = graphPictureBox.Width - 2 * padding - leftKeysPadding;
            actualHeight = graphPictureBox.Height - 2 * padding - bottomKeysPadding;

            actualTop = padding;
            actualBottom = actualTop + actualHeight;
            actualLeft = padding + leftKeysPadding;
            actualRight = actualLeft + actualWidth;


            //вектора с преобразованными координатами
            data = _coordinateConverter.ConvertRange(data, actualTop, actualBottom, actualRight, actualLeft, xMaximum, xMinimum, tMaximum, tMinimum);
            if (drawGrid)
            {
                DrawGrid(tMinimum, xMinimum, tMaximum, xMaximum, xAxisName, yAxisName);
            }
            DrawGraph(data);
        }

        public void SwitchPenColor(Pen color)
        {
            _dataPen = color;
        }

        private void DrawGraph(List<PointF> data)
        {
            PointF[] points = new PointF[data.Count()];

            for (int i = 0; i < data.Count(); i++)
            {
                points[i] = data[i];
            }

            graphicCanvas.DrawLines(_dataPen, points);
            graphPictureBox.Image = myBitmap;
            graphPictureBox.Refresh();
        }

        //Нарисовать отдельно сетку графика
        private void DrawGrid(float tMinimum, float xMinimum, float tMaximum, float xMaximum, string xAxisName, string yAxisName)
        {
            // Рисуем сетку и подсетку.
            int gridSize = 10;

            for (int i = 0; i < gridSize + 1; i++)
            {
                graphicCanvas.DrawLine(gridPen, new PointF(actualLeft + i * actualWidth / gridSize, actualTop), new PointF(actualLeft + i * actualWidth / gridSize, actualBottom));
                graphicCanvas.DrawLine(gridPen, new PointF(actualLeft, actualTop + i * actualHeight / gridSize), new PointF(actualRight, actualTop + i * actualHeight / gridSize));

                graphicCanvas.DrawString((tMinimum + i * (tMaximum - tMinimum) / gridSize).ToString("0.0"), font, fontPen, new PointF(actualLeft + i * actualWidth / (gridSize) - bottomKeysPadding, actualBottom + bottomKeysPadding / 2));
                graphicCanvas.DrawString((xMinimum + i * (xMaximum - xMinimum) / gridSize).ToString("0.0"), font, fontPen, new PointF(actualLeft - 1.75f * leftKeysPadding, actualBottom - i * actualHeight / gridSize - bottomKeysPadding));
            }
            float kForX = (actualTop - actualBottom) / (xMaximum - xMinimum);
            if (float.IsInfinity(kForX))
            {
                kForX = 0;
            }
            graphicCanvas.DrawLine(new Pen(Color.Gray), new PointF(actualLeft, actualTop), new PointF(actualLeft, actualBottom));
            graphicCanvas.DrawLine(new Pen(Color.Gray), new PointF(actualLeft, (0 - xMinimum) * kForX + actualBottom), new PointF(actualRight, (0 - xMinimum) * kForX + actualBottom));

            graphicCanvas.DrawString(yAxisName, font, fontPen, new PointF(actualLeft, padding/2));
            graphicCanvas.DrawString(xAxisName, font, fontPen, new PointF(actualRight + padding / 3, ((0 - xMinimum) * kForX + actualBottom - 10)));
            graphPictureBox.Image = myBitmap;
            graphPictureBox.Refresh();
        }
    }
}

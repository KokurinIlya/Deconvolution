using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace SignalWithNoiseWFORMS
{
    public partial class MainForm : Form
    {
        #region Поля
        private List<HarmonicItem> harmonicItems;
        private Pen dataPen;
        private Random random;

        #endregion

        public MainForm()
        {

            InitializeComponent();

            harmonicItems = new List<HarmonicItem>() { new HarmonicItem(panel1, textBoxAmplitude1, textBoxAverage1, textBoxQuadraticDeviation1),
                                                       new HarmonicItem(panel2, textBoxAmplitude2, textBoxAverage2, textBoxQuadraticDeviation2),
                                                       new HarmonicItem(panel3, textBoxAmplitude3, textBoxAverage3, textBoxQuadraticDeviation3),};

            dataPen = new Pen(Color.FromArgb(255, 134, 190, 252), 1.75f);

            comboBoxHarmonics.SelectedItem = comboBoxHarmonics.Items[0];
            panel1.Enabled = true;
            comboBoxSignalWidth.SelectedItem = comboBoxSignalWidth.Items[0];

            panel2.Enabled = false;
			panel3.Enabled = false;

            random = new Random();
        }

        #region Отрисовка
        private void buttonModeling_Click(object sender, EventArgs e)
        {
            GraphDrawing graphPicture = new GraphDrawing(GRAPH, dataPen);
            GraphDrawing graphPictureConvolution = new GraphDrawing(convolutionGraph, dataPen);
            GraphDrawing graphPictureImpulseCharacteristic = new GraphDrawing(impulseCharacteristicGraph, dataPen);
            

            float samplingPeriod;
            if (float.Parse(textBoxPhaseDescret.Text) != 0) samplingPeriod = 1 / float.Parse(textBoxPhaseDescret.Text);
            else
            {
                MessageBox.Show("Введите ненулевое значение частоты дескритизации");
                return;
            }

            List<PointF> signalPoints = GetSignal(samplingPeriod);

            PointF min1 = ReturnMinPoint(signalPoints);
            PointF max1 = ReturnMaxPoint(signalPoints);

            DrawGraph(graphPicture, signalPoints, min1, max1, "t,c", "X", dataPen);

            List<PointF> impulseCharacteristicPoints = GetImpulseCharacteristic(samplingPeriod);

            min1 = ReturnMinPoint(impulseCharacteristicPoints);
            max1 = ReturnMaxPoint(impulseCharacteristicPoints);

            DrawGraph(graphPictureImpulseCharacteristic, impulseCharacteristicPoints, min1, max1, "t,c", "X", dataPen);

            List<PointF> convolution = GetConvolution(signalPoints, impulseCharacteristicPoints);

            min1 = ReturnMinPoint(convolution);
            max1 = ReturnMaxPoint(convolution);

            DrawGraph(graphPictureConvolution, convolution, min1, max1, "t,c", "X", dataPen);

            
            //HOOKEJEVEES
            HookeJeeves hookeJeeves = new HookeJeeves(DrawIntermediateResult, impulseCharacteristicPoints, signalPoints, samplingPeriod);

            List<float> convolutionValues = new List<float>();
            List<float> impulseCharacteristicValues = new List<float>();
            List<float> startsValues = new List<float>();
            List<float> stepValues = new List<float>();

            Random rand = new Random();
            for (int i = 0; i < convolution.Count; i++)
            {
                convolutionValues.Add(convolution[i].Y);
                impulseCharacteristicValues.Add(impulseCharacteristicPoints[i].Y);
                startsValues.Add((float)rand.Next(-1, 1));
                stepValues.Add(1);
            }

            List<float> buffer = new List<float>(hookeJeeves.GetResult(convolutionValues, impulseCharacteristicValues, float.Parse(textBoxAccuracy.Text), startsValues, stepValues, 4, 1));

            DrawIntermediateResult(buffer, impulseCharacteristicPoints, signalPoints, samplingPeriod);
        }
        #endregion


        public void DrawIntermediateResult(List<float> values, List<PointF> impulseCharacteristicPoints, List<PointF> signalPoints, float samplingPeriod)
        {
            GraphDrawing graphPicture = new GraphDrawing(GRAPH, dataPen);
           
            PointF min1 = ReturnMinPoint(signalPoints);
            PointF max1 = ReturnMaxPoint(signalPoints);

            List<PointF> buffer = GetRestoredSignal(values, impulseCharacteristicPoints, samplingPeriod);

            PointF min2 = ReturnMinPoint(buffer);
            PointF max2 = ReturnMaxPoint(buffer);

            if (min1.X > min2.X)
            {
                min1.X = min2.X;
            }
            if (min1.Y > min2.Y)
            {
                min1.Y = min2.Y;
            }

            if (max1.Y < max2.Y)
            {
                max1.Y = max2.Y;
            }
            if (max1.X < max2.X)
            {
                max1.X = max2.X;
            }

            DrawGraph(graphPicture, signalPoints, min1, max1, "t,c", "X", dataPen);
            DrawGraph(graphPicture, buffer, min1, max1, "t,c", "X", new Pen(Color.FromArgb(255, 247, 185, 40), 1.75f), false);
        }

        #region Методы инициализации сигналов/функций
        List<PointF> GetSignal(float samplingPeriod)
        {
            int harmonicsCount = Int32.Parse(comboBoxHarmonics.SelectedItem.ToString());

            List<float> amplitudes = new List<float>();
            List<float> averages = new List<float>();
            List<float> quadraticDeviations = new List<float>();

            List<SignalFunction> gaussFunctions = new List<SignalFunction>();

            for (int i = 0; i < harmonicsCount; i++)
            {
                if (harmonicItems[i].harmonicPanel.Enabled == true)
                {
                    amplitudes.Add(float.Parse(harmonicItems[i].amplitude.Texts));
                    averages.Add(float.Parse(harmonicItems[i].frequency.Texts));
                    quadraticDeviations.Add(float.Parse(harmonicItems[i].initialPhase.Texts));

                    gaussFunctions.Add(new SignalFunction(amplitudes[i], averages[i], quadraticDeviations[i]));
                }
            }

            List<PointF> signalPoints = new List<PointF>();

            for (int i = 0; i < int.Parse(comboBoxSignalWidth.SelectedItem.ToString()); i++)
            {
                float summ = 0;
                for (int j = 0; j < harmonicsCount; j++)
                {
                    summ += gaussFunctions[j].GetFunctionValue(i, samplingPeriod);
                }
                signalPoints.Add(new PointF((float)(i * samplingPeriod), (float)summ));
            }

            return signalPoints;
        }

        List<PointF> GetRestoredSignal(List<float> hookeJeveesResult, List<PointF> impulseCharacteristicPoints, float samplingPeriod)
        {
            List<PointF> restoredSignalPoints = new List<PointF>();

            for (int i = 0; i < hookeJeveesResult.Count; i++)
            {
                float summ = 0;
                for (int j = 0; j < hookeJeveesResult.Count; j++)
                {
                    if (j - i >= 0)
                    {
                        summ += hookeJeveesResult[j] * impulseCharacteristicPoints[(j - i) % hookeJeveesResult.Count].Y;
                    }
                    else
                    {
                        summ += hookeJeveesResult[j] * impulseCharacteristicPoints[hookeJeveesResult.Count - (i - j) % hookeJeveesResult.Count].Y;
                    }
                }
                restoredSignalPoints.Add(new PointF((float)(i * samplingPeriod), (float)Math.Exp(-1 - summ)));
            }

            return restoredSignalPoints;
        }

        List<PointF> GetImpulseCharacteristic(float samplingPeriod)
        {
            ImpulseCharacteristic impulseCharacteristic = new ImpulseCharacteristic(float.Parse(textBoxAmplitudeCharacteristic.Texts), float.Parse(textBoxQuadraticDeviationCharacteristic.Texts));

            List<PointF> impulseCharacteristicPoints = new List<PointF>();

            for (int i = 0; i < int.Parse(comboBoxSignalWidth.SelectedItem.ToString()); i++)
            {
                impulseCharacteristicPoints.Add(new PointF((float)(i * samplingPeriod), impulseCharacteristic.GetFunctionValue(i, samplingPeriod, int.Parse(comboBoxSignalWidth.SelectedItem.ToString()))));
            }

            return impulseCharacteristicPoints;
        }

        List<PointF> GetConvolution(List<PointF> signal1, List<PointF> signal2)
        {
            List<PointF> convolution = new List<PointF>();

            for (int i = 0; i < signal1.Count; i++)
            {
                float summ = 0;
                for (int j = 0; j < signal1.Count; j++)
                {
                    if(i-j >= 0)
                    {
                        summ += signal1[j].Y * signal2[(i - j) % signal1.Count].Y;
                    }
                    else
                    {
                        summ += signal1[j].Y * signal2[signal1.Count- (j-i) % signal1.Count].Y;
                    }
                }
                convolution.Add(new PointF(signal1[i].X, summ));
            }
            return convolution;
        }
        #endregion

        #region Отрисовка графиков
        private void DrawGraph(GraphDrawing graphPicture, List<PointF> points, PointF min, PointF max, string xAxisName, string yAxisName, Pen dataPen, bool drawGrid = true)
        {
            graphPicture.StartDrawing(points, min.X, min.Y, max.X, max.Y, xAxisName, yAxisName, dataPen, drawGrid);
        }

        #endregion

        #region Методы проверки максимального/минимального значения
        private PointF ReturnMinPoint(List<PointF> points)
        {
            PointF min = points[0];

            foreach (var item in points)
            {
                min.X = Math.Min(min.X, item.X);
                min.Y = Math.Min(min.Y, item.Y);
            }

            return min;
        }

        private PointF ReturnMaxPoint(List<PointF> points)
        {
            PointF max = points[0];

            foreach (var item in points)
            {
                max.X = Math.Max(max.X, item.X);
                max.Y = Math.Max(max.Y, item.Y);
            }

            return max;
        }
        #endregion

        #region Метод для фильтрации вводимых символов
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((!Char.IsDigit(number)) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Методы для визиуальных эффектов
        private void comboBoxHarmonics_SelectedIndexChanged(object sender, EventArgs e)
        {
            int harmonicsCount = int.Parse(comboBoxHarmonics.SelectedItem.ToString());
            Panel[] harmonicPanels = new Panel[] { panel1, panel2, panel3 };

            for (int i = 0; i < harmonicsCount; i++)
            {
                harmonicPanels[i].Enabled = true;
            }
            for (int i = harmonicPanels.Length - 1; i >= harmonicsCount; i--)
            {
                harmonicPanels[i].Enabled = false;
            }
        }

        private void buttonColorPick_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                dataPen.Color = MyDialog.Color;
            }

        }
        #endregion
    }
}

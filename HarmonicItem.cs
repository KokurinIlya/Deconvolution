using customDesignForWForms.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalWithNoiseWFORMS
{
    class HarmonicItem
    {
        public Panel harmonicPanel;
        public textBox_ByIlya amplitude;
        public textBox_ByIlya frequency;
        public textBox_ByIlya initialPhase;

        public HarmonicItem(Panel harmonicPanel, textBox_ByIlya amplitude, textBox_ByIlya frequency, textBox_ByIlya initialPhase)
        {
            this.harmonicPanel = harmonicPanel;
            this.amplitude = amplitude;
            this.frequency = frequency;
            this.initialPhase = initialPhase;
        }
    }
}

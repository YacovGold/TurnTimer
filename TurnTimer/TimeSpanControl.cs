using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurnTimer
{
    public partial class TimeSpanControl : UserControl
    {
        TimeSpan _timeSpan = TimeSpan.Zero;

        public TimeSpan TimeSpan
        {
            get => _timeSpan;
            set
            {
                _timeSpan = value;
                lbl.Text = _timeSpan.ToString("c");
            }
        }

        public TimeSpanControl()
        {
            InitializeComponent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurnTimer.Properties;

namespace TurnTimer
{
    public partial class Form1 : Form
    {
        TimeSpan _ots;
        TimeSpan _ts;
        SoundPlayer _soundPlayer = new SoundPlayer();


        public Form1()
        {
            _soundPlayer.Stream = Resources.Alarm;
            InitializeComponent();

            rb_10.Checked = true;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            var m = int.Parse(rb.Tag.ToString());

            n_h.Enabled = n_m.Enabled = n_s.Enabled = m == 0;

            if (m != 0)
            {
                n_h.Value = n_s.Value = 0;
                n_m.Value = m;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timeSpanControl1.TimeSpan = _ts = _ots = new TimeSpan((int)n_h.Value, (int)n_m.Value, (int)n_s.Value);
            progressBar1.Maximum = (int)_ts.TotalSeconds;
            progressBar1.Value = 0;
            timer1.Enabled = true;
            EnableDisable(true);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            _soundPlayer.Stop();
            EnableDisable(false);
        }

        private void cb_autoRestart_CheckedChanged(object sender, EventArgs e)
        {
            cb_ringForEver.Enabled = !cb_autoRestart.Checked;
        }
        private void cb_ringForEver_CheckedChanged(object sender, EventArgs e)
        {
            cb_autoRestart.Enabled = !cb_ringForEver.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeSpanControl1.TimeSpan = _ts = new TimeSpan(_ts.Hours, _ts.Minutes, _ts.Seconds - 1);
            progressBar1.Value = (int)(_ots.TotalSeconds - _ts.TotalSeconds);
            if (_ts == TimeSpan.Zero)
                OnTrigger();
        }

        void EnableDisable(bool isStart)
        {
            n_h.Enabled = n_m.Enabled = n_s.Enabled = !isStart;
            btn_start.Enabled = !isStart;
            btn_reset.Enabled = isStart;
            rb_c.Enabled = rb_5.Enabled = rb_3.Enabled = rb_15.Enabled = rb_10.Enabled = !isStart;

            cb_ringForEver.Enabled = !cb_autoRestart.Checked;
            cb_autoRestart.Enabled = !cb_ringForEver.Checked;
        }

        void OnTrigger()
        {
            if (cb_ringForEver.Checked)
            {
                _soundPlayer.PlayLooping();
                timer1.Enabled = false;
            }
            else if (cb_autoRestart.Checked)
            {
                _soundPlayer.Play();
                timeSpanControl1.TimeSpan = _ts = _ots;
            }
            else
            {
                _soundPlayer.Play();
                timer1.Enabled = false;
            }
        }
    }
}

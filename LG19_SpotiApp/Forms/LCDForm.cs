using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LG19_SpotiApp
{

    public partial class LCDForm : Form
    {

        public static LCDForm _activeForm;

        public string _appletname = "LG19 SpotiApp";

        private Timer _LCDUpdateTimer;

        private Timer _LCDButtonPressTimer;

        private int _device;

        public LCDForm()
        {
            InitializeComponent();
            if (File.Exists("DMcLgLCD.dll"))
            {
                _LCDUpdateTimer = new Timer();
                _LCDUpdateTimer.Interval = 34;
                _LCDUpdateTimer.Tick += _OnLCDUpdate;

                _LCDButtonPressTimer = new Timer();
                _LCDButtonPressTimer.Interval = 100;
                _LCDButtonPressTimer.Tick += _OnLCDButtonPressTimer;

                DMcLgLCD.LcdInit();
                var Connection = DMcLgLCD.LcdConnectEx(_appletname, 0, 0);
                if (Connection != DMcLgLCD.LGLCD_INVALID_CONNECTION)
                {
                    _device = DMcLgLCD.LcdOpenByType(Connection, DMcLgLCD.LGLCD_DEVICE_QVGA);
                    if (_device != DMcLgLCD.LGLCD_INVALID_DEVICE)
                    {
                        DMcLgLCD.LcdSetAsLCDForegroundApp(_device, DMcLgLCD.LGLCD_FORE_YES);
                        _LCDUpdateTimer.Start();
                        _LCDButtonPressTimer.Start();
                    }
                }
            }
        }

        private void _LCDUpdateTimer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _OnLCDUpdate(object sender, EventArgs e)
        {
            UpdateLCDPicture(_activeForm);
        }

        private void _OnLCDButtonPressTimer(object sender, EventArgs e)
        {
            uint button = DMcLgLCD.LcdReadSoftButtons(_device);

            if (button != 0)
            {
                OnLCDButtonPress(button);
            }
        }

        public virtual void OnLCDButtonPress(uint Button)
        {
            
        }

        private void UpdateLCDPicture(Form form)
        {
            try
            {
                int wid = form.Width;
                int hgt = form.Height;
                Bitmap bm = new Bitmap(wid, hgt);
                form.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, wid, hgt));
                DMcLgLCD.LcdUpdateBitmap(_device, bm.GetHbitmap(), DMcLgLCD.LGLCD_DEVICE_QVGA);
                bm.Dispose();
            } catch (Exception ex) {

            }
        }

        private void LCDForm_Load(object sender, EventArgs e)
        {

        }
    }
}

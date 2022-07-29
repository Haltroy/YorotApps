using System;
using System.Collections.Generic;
using System.Text;
using Yorot;
using Yorot.AppForms;

namespace YorotApps
{
    public class YCalc : YorotApp
    {
        public YCalc(AppManager manager) : base("com.yorot.calc", manager)
        {
            MainForm = new frmMain(this);
        }

        private class frmMain : Form
        {
            private Tabs tabs;
            private TabPage tpNormal;
            private TabPage tpScientific;
            private TabPage tpProgrammer;
            private TabPage tpDistance;
            private TabPage tpTime;
            private TabPage tpSize;
            private TabPage tpDate;
            private TabPage tpTemperature;
            private TabPage tpCurrency;
            private TabPage tpComplex;
            private TabPage tpEnergy;
            private TabPage tpPower;
            private TabPage tpArea;
            private TabPage tpData;
            private TabPage tpSpeed;
            private TabPage tpPressure;
            private TabPage tpAngle;

            public frmMain(YorotApp app) : base(app)
            {
            }

            public override void Initialize(string[] args)
            {
            }
        }
    }
}
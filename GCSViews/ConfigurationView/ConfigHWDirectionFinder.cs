using System;
using System.Windows.Forms;
using MissionPlanner.Controls;
using MissionPlanner.Utilities;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class ConfigHWDirectionFinder : UserControl, IActivate, IDeactivate
    {
        bool startup = true;

        public ConfigHWDirectionFinder()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
            {
                Enabled = false;
                return;
            }
            Enabled = true;
            startup = true;

            CMB_dirfndtype.setup(
                ParameterMetaDataRepository.GetParameterOptionsInt("DIRFND_TYPE",
                    MainV2.comPort.MAV.cs.firmware.ToString()), "DIRFND_TYPE", MainV2.comPort.MAV.param);

            timer1.Start();

            startup = false;
        }

        public void Deactivate()
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBL_dir.Text = MainV2.comPort.MAV.cs.directiondirection.ToString();
            LBL_mag.Text = MainV2.comPort.MAV.cs.directionmagnitude.ToString();
        }

        private void CMB_dirfndtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (startup)
                return;
        }
    }
}
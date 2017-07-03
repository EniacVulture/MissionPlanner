namespace MissionPlanner.GCSViews.ConfigurationView
{
    partial class ConfigHWDirectionFinder
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigHWDirectionFinder));
            this.CMB_dirfndtype = new MissionPlanner.Controls.MavlinkComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_mag = new System.Windows.Forms.Label();
            this.LBL_dir = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CMB_dirfndtype
            // 
            this.CMB_dirfndtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CMB_dirfndtype, "CMB_dirfndtype");
            this.CMB_dirfndtype.FormattingEnabled = true;
            this.CMB_dirfndtype.Items.AddRange(new object[] {
            resources.GetString("CMB_dirfndtype.Items"),
            resources.GetString("CMB_dirfndtype.Items1"),
            resources.GetString("CMB_dirfndtype.Items2"),
            resources.GetString("CMB_dirfndtype.Items3")});
            this.CMB_dirfndtype.Name = "CMB_dirfndtype";
            this.CMB_dirfndtype.ParamName = null;
            this.CMB_dirfndtype.SubControl = null;
            this.CMB_dirfndtype.SelectedIndexChanged += new System.EventHandler(this.CMB_dirfndtype_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // LBL_mag
            // 
            resources.ApplyResources(this.LBL_mag, "LBL_mag");
            this.LBL_mag.Name = "LBL_mag";
            // 
            // LBL_dir
            // 
            resources.ApplyResources(this.LBL_dir, "LBL_dir");
            this.LBL_dir.Name = "LBL_dir";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ConfigHWDirectionFinder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.LBL_mag);
            this.Controls.Add(this.LBL_dir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CMB_dirfndtype);
            this.Name = "ConfigHWDirectionFinder";
            resources.ApplyResources(this, "$this");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MavlinkComboBox CMB_dirfndtype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBL_mag;
        private System.Windows.Forms.Label LBL_dir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

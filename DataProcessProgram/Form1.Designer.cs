
namespace DataProcessProgram
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.frmTitle = new System.Windows.Forms.Panel();
            this.btnMinimal = new System.Windows.Forms.Button();
            this.btnMaxminal = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.strProgram = new System.Windows.Forms.Label();
            this.frmLogo = new System.Windows.Forms.PictureBox();
            this.frmStatus = new System.Windows.Forms.Panel();
            this.picStatus = new System.Windows.Forms.PictureBox();
            this.strStatus = new System.Windows.Forms.Label();
            this.tabPanel = new System.Windows.Forms.Panel();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnDevice = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeviceConnect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabDevice = new System.Windows.Forms.TabPage();
            this.tabData = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabDataPlot = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.btnAbout = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.frmTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmLogo)).BeginInit();
            this.frmStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).BeginInit();
            this.tabPanel.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.tabWelcome.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabData.SuspendLayout();
            this.tabDataPlot.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmTitle
            // 
            this.frmTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.frmTitle.Controls.Add(this.btnMinimal);
            this.frmTitle.Controls.Add(this.btnMaxminal);
            this.frmTitle.Controls.Add(this.btnClose);
            this.frmTitle.Controls.Add(this.strProgram);
            this.frmTitle.Controls.Add(this.frmLogo);
            this.frmTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.frmTitle.Location = new System.Drawing.Point(0, 0);
            this.frmTitle.MaximumSize = new System.Drawing.Size(0, 50);
            this.frmTitle.MinimumSize = new System.Drawing.Size(0, 50);
            this.frmTitle.Name = "frmTitle";
            this.frmTitle.Size = new System.Drawing.Size(1074, 50);
            this.frmTitle.TabIndex = 1;
            this.frmTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmTitle_MouseDown);
            // 
            // btnMinimal
            // 
            this.btnMinimal.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimal.FlatAppearance.BorderSize = 0;
            this.btnMinimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimal.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimal.Image")));
            this.btnMinimal.Location = new System.Drawing.Point(894, 0);
            this.btnMinimal.Name = "btnMinimal";
            this.btnMinimal.Size = new System.Drawing.Size(60, 50);
            this.btnMinimal.TabIndex = 4;
            this.btnMinimal.UseVisualStyleBackColor = false;
            this.btnMinimal.Click += new System.EventHandler(this.btnMinimal_Click);
            // 
            // btnMaxminal
            // 
            this.btnMaxminal.BackColor = System.Drawing.Color.Transparent;
            this.btnMaxminal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaxminal.FlatAppearance.BorderSize = 0;
            this.btnMaxminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxminal.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxminal.Image")));
            this.btnMaxminal.Location = new System.Drawing.Point(954, 0);
            this.btnMaxminal.Name = "btnMaxminal";
            this.btnMaxminal.Size = new System.Drawing.Size(60, 50);
            this.btnMaxminal.TabIndex = 3;
            this.btnMaxminal.UseVisualStyleBackColor = false;
            this.btnMaxminal.Click += new System.EventHandler(this.btnMaxminal_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1014, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 50);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // strProgram
            // 
            this.strProgram.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.strProgram.AutoSize = true;
            this.strProgram.BackColor = System.Drawing.Color.Transparent;
            this.strProgram.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.strProgram.ForeColor = System.Drawing.Color.AliceBlue;
            this.strProgram.Location = new System.Drawing.Point(56, 15);
            this.strProgram.Name = "strProgram";
            this.strProgram.Size = new System.Drawing.Size(195, 16);
            this.strProgram.TabIndex = 1;
            this.strProgram.Text = "纳米孔电流检测采集系统";
            // 
            // frmLogo
            // 
            this.frmLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.frmLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.frmLogo.Image = ((System.Drawing.Image)(resources.GetObject("frmLogo.Image")));
            this.frmLogo.Location = new System.Drawing.Point(0, 0);
            this.frmLogo.Name = "frmLogo";
            this.frmLogo.Size = new System.Drawing.Size(50, 50);
            this.frmLogo.TabIndex = 0;
            this.frmLogo.TabStop = false;
            // 
            // frmStatus
            // 
            this.frmStatus.BackColor = System.Drawing.Color.SteelBlue;
            this.frmStatus.Controls.Add(this.picStatus);
            this.frmStatus.Controls.Add(this.strStatus);
            this.frmStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.frmStatus.Location = new System.Drawing.Point(0, 632);
            this.frmStatus.MaximumSize = new System.Drawing.Size(0, 32);
            this.frmStatus.MinimumSize = new System.Drawing.Size(0, 32);
            this.frmStatus.Name = "frmStatus";
            this.frmStatus.Size = new System.Drawing.Size(1074, 32);
            this.frmStatus.TabIndex = 2;
            this.frmStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Status_MouseDown);
            // 
            // picStatus
            // 
            this.picStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.picStatus.Location = new System.Drawing.Point(0, 0);
            this.picStatus.Name = "picStatus";
            this.picStatus.Size = new System.Drawing.Size(32, 32);
            this.picStatus.TabIndex = 2;
            this.picStatus.TabStop = false;
            // 
            // strStatus
            // 
            this.strStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.strStatus.AutoSize = true;
            this.strStatus.BackColor = System.Drawing.Color.Transparent;
            this.strStatus.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.strStatus.ForeColor = System.Drawing.Color.AliceBlue;
            this.strStatus.Location = new System.Drawing.Point(38, 9);
            this.strStatus.Name = "strStatus";
            this.strStatus.Size = new System.Drawing.Size(112, 14);
            this.strStatus.TabIndex = 1;
            this.strStatus.Text = "检测设备未连接";
            // 
            // tabPanel
            // 
            this.tabPanel.BackColor = System.Drawing.Color.SlateGray;
            this.tabPanel.Controls.Add(this.btnAbout);
            this.tabPanel.Controls.Add(this.btnDisplay);
            this.tabPanel.Controls.Add(this.btnData);
            this.tabPanel.Controls.Add(this.btnDevice);
            this.tabPanel.Controls.Add(this.btnHome);
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabPanel.Location = new System.Drawing.Point(0, 50);
            this.tabPanel.MaximumSize = new System.Drawing.Size(200, 0);
            this.tabPanel.MinimumSize = new System.Drawing.Size(200, 0);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(200, 582);
            this.tabPanel.TabIndex = 3;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Transparent;
            this.btnDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisplay.Location = new System.Drawing.Point(0, 150);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(200, 50);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "数据显示";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.Transparent;
            this.btnData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnData.ForeColor = System.Drawing.Color.White;
            this.btnData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnData.Location = new System.Drawing.Point(0, 100);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(200, 50);
            this.btnData.TabIndex = 2;
            this.btnData.Text = "测序采集";
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnDevice
            // 
            this.btnDevice.BackColor = System.Drawing.Color.Transparent;
            this.btnDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevice.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDevice.ForeColor = System.Drawing.Color.White;
            this.btnDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevice.Location = new System.Drawing.Point(0, 50);
            this.btnDevice.Name = "btnDevice";
            this.btnDevice.Size = new System.Drawing.Size(200, 50);
            this.btnDevice.TabIndex = 1;
            this.btnDevice.Text = "仪器连接";
            this.btnDevice.UseVisualStyleBackColor = false;
            this.btnDevice.Click += new System.EventHandler(this.btnDevice_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 50);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "首页";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.tabWelcome);
            this.mainTab.Controls.Add(this.tabDevice);
            this.mainTab.Controls.Add(this.tabData);
            this.mainTab.Controls.Add(this.tabDataPlot);
            this.mainTab.Controls.Add(this.tabAbout);
            this.mainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTab.Location = new System.Drawing.Point(200, 50);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(874, 582);
            this.mainTab.TabIndex = 4;
            this.mainTab.TabStop = false;
            // 
            // tabWelcome
            // 
            this.tabWelcome.Controls.Add(this.flowLayoutPanel1);
            this.tabWelcome.Location = new System.Drawing.Point(4, 22);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tabWelcome.Size = new System.Drawing.Size(866, 556);
            this.tabWelcome.TabIndex = 0;
            this.tabWelcome.Text = "首页";
            this.tabWelcome.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDeviceConnect);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(860, 550);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnDeviceConnect
            // 
            this.btnDeviceConnect.BackColor = System.Drawing.Color.LightGreen;
            this.btnDeviceConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeviceConnect.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeviceConnect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeviceConnect.Location = new System.Drawing.Point(3, 3);
            this.btnDeviceConnect.Name = "btnDeviceConnect";
            this.btnDeviceConnect.Size = new System.Drawing.Size(141, 72);
            this.btnDeviceConnect.TabIndex = 0;
            this.btnDeviceConnect.Text = "仪器连接";
            this.btnDeviceConnect.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(150, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "开始测序";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.NavajoWhite;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(297, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 72);
            this.button2.TabIndex = 2;
            this.button2.Text = "数据显示";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tabDevice
            // 
            this.tabDevice.Location = new System.Drawing.Point(4, 22);
            this.tabDevice.Name = "tabDevice";
            this.tabDevice.Padding = new System.Windows.Forms.Padding(3);
            this.tabDevice.Size = new System.Drawing.Size(866, 556);
            this.tabDevice.TabIndex = 1;
            this.tabDevice.Text = "设备连接";
            this.tabDevice.UseVisualStyleBackColor = true;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.label3);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(866, 556);
            this.tabData.TabIndex = 2;
            this.tabData.Text = "数据采集";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "这是数据采集";
            // 
            // tabDataPlot
            // 
            this.tabDataPlot.Controls.Add(this.label4);
            this.tabDataPlot.Location = new System.Drawing.Point(4, 22);
            this.tabDataPlot.Name = "tabDataPlot";
            this.tabDataPlot.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataPlot.Size = new System.Drawing.Size(866, 556);
            this.tabDataPlot.TabIndex = 3;
            this.tabDataPlot.Text = "数据显示";
            this.tabDataPlot.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "这是数据显示";
            // 
            // tabAbout
            // 
            this.tabAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabAbout.Controls.Add(this.tableLayoutPanel);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(866, 556);
            this.tabAbout.TabIndex = 4;
            this.tabAbout.Text = "关于";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 200);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(200, 50);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "关于";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.838384F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.16161F));
            this.tableLayoutPanel.Controls.Add(this.lblProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(860, 550);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProductName.Location = new System.Drawing.Point(40, 0);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.lblProductName.MaximumSize = new System.Drawing.Size(0, 23);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(817, 23);
            this.lblProductName.TabIndex = 19;
            this.lblProductName.Text = "RotorAnalysisProgram分析软件-(RotorAnalysisProgram Analysis Program)";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVersion.Location = new System.Drawing.Point(40, 55);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 23);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(817, 23);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "版本:    {0:s}";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCopyright.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCopyright.Location = new System.Drawing.Point(40, 110);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 23);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(817, 23);
            this.labelCopyright.TabIndex = 21;
            this.labelCopyright.Text = "西安交通大学 版权所有";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxDescription.Location = new System.Drawing.Point(40, 224);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(7, 4, 3, 4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(817, 267);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = resources.GetString("textBoxDescription.Text");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1074, 664);
            this.Controls.Add(this.mainTab);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.frmStatus);
            this.Controls.Add(this.frmTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.frmTitle.ResumeLayout(false);
            this.frmTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmLogo)).EndInit();
            this.frmStatus.ResumeLayout(false);
            this.frmStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).EndInit();
            this.tabPanel.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.tabWelcome.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
            this.tabDataPlot.ResumeLayout(false);
            this.tabDataPlot.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel frmTitle;
        private System.Windows.Forms.PictureBox frmLogo;
        private System.Windows.Forms.Button btnMinimal;
        private System.Windows.Forms.Button btnMaxminal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label strProgram;
        private System.Windows.Forms.Panel frmStatus;
        private System.Windows.Forms.Label strStatus;
        private System.Windows.Forms.PictureBox picStatus;
        private System.Windows.Forms.Panel tabPanel;
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage tabWelcome;
        private System.Windows.Forms.TabPage tabDevice;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.TabPage tabDataPlot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnDevice;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDeviceConnect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.TextBox textBoxDescription;
    }
}


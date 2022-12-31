
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.frmTitle = new System.Windows.Forms.Panel();
            this.strProgram = new System.Windows.Forms.Label();
            this.frmStatus = new System.Windows.Forms.Panel();
            this.strStatus = new System.Windows.Forms.Label();
            this.tabPanel = new System.Windows.Forms.Panel();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeviceConnect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabDevice = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tabData = new System.Windows.Forms.TabPage();
            this.tableDataRecord = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.numVoletOffset = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.strDeviceName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabDataPlot = new System.Windows.Forms.TabPage();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.Help = new System.Windows.Forms.ToolTip(this.components);
            this.cbxComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPortBuad = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.strDataFile = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabView = new System.Windows.Forms.TabControl();
            this.tabGridView = new System.Windows.Forms.TabPage();
            this.tabPlotView = new System.Windows.Forms.TabPage();
            this.dgvDataView = new System.Windows.Forms.DataGridView();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnDevice = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.picStatus = new System.Windows.Forms.PictureBox();
            this.btnMinimal = new System.Windows.Forms.Button();
            this.btnMaxminal = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.frmLogo = new System.Windows.Forms.PictureBox();
            this.frmTitle.SuspendLayout();
            this.frmStatus.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.tabWelcome.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabDevice.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tabData.SuspendLayout();
            this.tableDataRecord.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVoletOffset)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabDataPlot.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tabView.SuspendLayout();
            this.tabGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmLogo)).BeginInit();
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
            this.frmTitle.Size = new System.Drawing.Size(831, 50);
            this.frmTitle.TabIndex = 1;
            this.frmTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmTitle_MouseDown);
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
            this.frmStatus.Size = new System.Drawing.Size(831, 32);
            this.frmStatus.TabIndex = 2;
            this.frmStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Status_MouseDown);
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
            this.mainTab.Size = new System.Drawing.Size(631, 582);
            this.mainTab.TabIndex = 4;
            this.mainTab.TabStop = false;
            // 
            // tabWelcome
            // 
            this.tabWelcome.Controls.Add(this.flowLayoutPanel1);
            this.tabWelcome.Location = new System.Drawing.Point(4, 22);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabWelcome.Size = new System.Drawing.Size(623, 556);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(617, 550);
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
            this.btnDeviceConnect.Click += new System.EventHandler(this.btnDeviceConnect_Click);
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
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabDevice
            // 
            this.tabDevice.Controls.Add(this.tableLayoutPanel1);
            this.tabDevice.Location = new System.Drawing.Point(4, 22);
            this.tabDevice.Name = "tabDevice";
            this.tabDevice.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabDevice.Size = new System.Drawing.Size(623, 556);
            this.tabDevice.TabIndex = 1;
            this.tabDevice.Text = "设备连接";
            this.tabDevice.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.50524F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.49476F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(617, 550);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnConnect, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.cbxComPort, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.cbxPortBuad, 3, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(611, 34);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "仪器串口号：";
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.tableDataRecord);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabData.Size = new System.Drawing.Size(623, 556);
            this.tabData.TabIndex = 2;
            this.tabData.Text = "数据采集";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // tableDataRecord
            // 
            this.tableDataRecord.ColumnCount = 1;
            this.tableDataRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDataRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableDataRecord.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableDataRecord.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableDataRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDataRecord.Location = new System.Drawing.Point(3, 3);
            this.tableDataRecord.Name = "tableDataRecord";
            this.tableDataRecord.RowCount = 4;
            this.tableDataRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableDataRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableDataRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.50524F));
            this.tableDataRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.49476F));
            this.tableDataRecord.Size = new System.Drawing.Size(617, 550);
            this.tableDataRecord.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 8;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.numVoletOffset, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnPreview, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnRecord, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnStop, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnSave, 6, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(611, 34);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "偏置电压（mV）";
            // 
            // numVoletOffset
            // 
            this.numVoletOffset.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numVoletOffset.Location = new System.Drawing.Point(145, 4);
            this.numVoletOffset.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numVoletOffset.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numVoletOffset.Name = "numVoletOffset";
            this.numVoletOffset.Size = new System.Drawing.Size(94, 26);
            this.numVoletOffset.TabIndex = 2;
            this.numVoletOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.strDeviceName, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(611, 34);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // strDeviceName
            // 
            this.strDeviceName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.strDeviceName.AutoSize = true;
            this.strDeviceName.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.strDeviceName.Location = new System.Drawing.Point(198, 9);
            this.strDeviceName.Name = "strDeviceName";
            this.strDeviceName.Size = new System.Drawing.Size(35, 16);
            this.strDeviceName.TabIndex = 3;
            this.strDeviceName.Text = "---";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "当前连接仪器：";
            // 
            // tabDataPlot
            // 
            this.tabDataPlot.Controls.Add(this.tableLayoutPanel2);
            this.tabDataPlot.Location = new System.Drawing.Point(4, 22);
            this.tabDataPlot.Name = "tabDataPlot";
            this.tabDataPlot.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabDataPlot.Size = new System.Drawing.Size(623, 556);
            this.tabDataPlot.TabIndex = 3;
            this.tabDataPlot.Text = "数据显示";
            this.tabDataPlot.UseVisualStyleBackColor = true;
            // 
            // tabAbout
            // 
            this.tabAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabAbout.Controls.Add(this.tableLayoutPanel);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabAbout.Size = new System.Drawing.Size(623, 556);
            this.tabAbout.TabIndex = 4;
            this.tabAbout.Text = "关于";
            this.tabAbout.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel.Size = new System.Drawing.Size(617, 550);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProductName.Location = new System.Drawing.Point(30, 0);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.lblProductName.MaximumSize = new System.Drawing.Size(0, 23);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(584, 23);
            this.lblProductName.TabIndex = 19;
            this.lblProductName.Text = "RotorAnalysisProgram分析软件-(RotorAnalysisProgram Analysis Program)";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVersion.Location = new System.Drawing.Point(30, 55);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 23);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(584, 23);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "版本:    {0:s}";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCopyright.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCopyright.Location = new System.Drawing.Point(30, 110);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 23);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(584, 23);
            this.labelCopyright.TabIndex = 21;
            this.labelCopyright.Text = "西安交通大学 版权所有";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxDescription.Location = new System.Drawing.Point(30, 224);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(7, 4, 3, 4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(584, 267);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = resources.GetString("textBoxDescription.Text");
            // 
            // cbxComPort
            // 
            this.cbxComPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxComPort.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxComPort.FormattingEnabled = true;
            this.cbxComPort.Location = new System.Drawing.Point(123, 5);
            this.cbxComPort.Name = "cbxComPort";
            this.cbxComPort.Size = new System.Drawing.Size(94, 24);
            this.cbxComPort.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "波特率：";
            // 
            // cbxPortBuad
            // 
            this.cbxPortBuad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxPortBuad.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxPortBuad.FormattingEnabled = true;
            this.cbxPortBuad.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.cbxPortBuad.Location = new System.Drawing.Point(313, 5);
            this.cbxPortBuad.Name = "cbxPortBuad";
            this.cbxPortBuad.Size = new System.Drawing.Size(94, 24);
            this.cbxPortBuad.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConnect.Location = new System.Drawing.Point(413, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(195, 28);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "仪器连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tabView, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(617, 550);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 398F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.btnOpen, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.strDataFile, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(611, 34);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // strDataFile
            // 
            this.strDataFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.strDataFile.AutoSize = true;
            this.strDataFile.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.strDataFile.Location = new System.Drawing.Point(261, 9);
            this.strDataFile.Name = "strDataFile";
            this.strDataFile.Size = new System.Drawing.Size(76, 16);
            this.strDataFile.TabIndex = 3;
            this.strDataFile.Text = "---";
            this.strDataFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "数据文件：";
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.tabPlotView);
            this.tabView.Controls.Add(this.tabGridView);
            this.tabView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabView.Location = new System.Drawing.Point(3, 43);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(611, 504);
            this.tabView.TabIndex = 4;
            // 
            // tabGridView
            // 
            this.tabGridView.Controls.Add(this.dgvDataView);
            this.tabGridView.Location = new System.Drawing.Point(4, 22);
            this.tabGridView.Name = "tabGridView";
            this.tabGridView.Padding = new System.Windows.Forms.Padding(3);
            this.tabGridView.Size = new System.Drawing.Size(603, 478);
            this.tabGridView.TabIndex = 0;
            this.tabGridView.Text = "表格显示";
            this.tabGridView.UseVisualStyleBackColor = true;
            // 
            // tabPlotView
            // 
            this.tabPlotView.Location = new System.Drawing.Point(4, 22);
            this.tabPlotView.Name = "tabPlotView";
            this.tabPlotView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlotView.Size = new System.Drawing.Size(603, 478);
            this.tabPlotView.TabIndex = 1;
            this.tabPlotView.Text = "图像显示";
            this.tabPlotView.UseVisualStyleBackColor = true;
            // 
            // dgvDataView
            // 
            this.dgvDataView.AllowUserToAddRows = false;
            this.dgvDataView.AllowUserToDeleteRows = false;
            this.dgvDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataView.Location = new System.Drawing.Point(3, 3);
            this.dgvDataView.Name = "dgvDataView";
            this.dgvDataView.ReadOnly = true;
            this.dgvDataView.RowTemplate.Height = 23;
            this.dgvDataView.Size = new System.Drawing.Size(597, 472);
            this.dgvDataView.TabIndex = 0;
            // 
            // btnPreview
            // 
            this.btnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPreview.FlatAppearance.BorderSize = 0;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Image = global::DataProcessProgram.Properties.Resources.preview;
            this.btnPreview.Location = new System.Drawing.Point(297, 4);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(44, 26);
            this.btnPreview.TabIndex = 3;
            this.Help.SetToolTip(this.btnPreview, "信号采集预览");
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnRecord
            // 
            this.btnRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Image = global::DataProcessProgram.Properties.Resources.record;
            this.btnRecord.Location = new System.Drawing.Point(348, 4);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(44, 26);
            this.btnRecord.TabIndex = 3;
            this.Help.SetToolTip(this.btnRecord, "信号采集记录");
            this.btnRecord.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = global::DataProcessProgram.Properties.Resources.stop;
            this.btnStop.Location = new System.Drawing.Point(399, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(44, 26);
            this.btnStop.TabIndex = 3;
            this.Help.SetToolTip(this.btnStop, "停止采集");
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::DataProcessProgram.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(450, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(44, 26);
            this.btnSave.TabIndex = 3;
            this.Help.SetToolTip(this.btnSave, "保存当前数据");
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Image = global::DataProcessProgram.Properties.Resources.file_open;
            this.btnOpen.Location = new System.Drawing.Point(501, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(107, 28);
            this.btnOpen.TabIndex = 4;
            this.Help.SetToolTip(this.btnOpen, "信号采集预览");
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = global::DataProcessProgram.Properties.Resources.关于;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 200);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(200, 50);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "关于";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Transparent;
            this.btnDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDisplay.FlatAppearance.BorderSize = 0;
            this.btnDisplay.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnDisplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.Image = global::DataProcessProgram.Properties.Resources.显示;
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
            this.btnData.FlatAppearance.BorderSize = 0;
            this.btnData.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnData.ForeColor = System.Drawing.Color.White;
            this.btnData.Image = global::DataProcessProgram.Properties.Resources.采集;
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
            this.btnDevice.FlatAppearance.BorderSize = 0;
            this.btnDevice.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnDevice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevice.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDevice.ForeColor = System.Drawing.Color.White;
            this.btnDevice.Image = global::DataProcessProgram.Properties.Resources.设备;
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
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::DataProcessProgram.Properties.Resources.主页;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 50);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "首页";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
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
            // btnMinimal
            // 
            this.btnMinimal.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimal.FlatAppearance.BorderSize = 0;
            this.btnMinimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnMinimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnMinimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimal.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimal.Image")));
            this.btnMinimal.Location = new System.Drawing.Point(651, 0);
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
            this.btnMaxminal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnMaxminal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnMaxminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxminal.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxminal.Image")));
            this.btnMaxminal.Location = new System.Drawing.Point(711, 0);
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
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(771, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 50);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(831, 664);
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
            this.frmStatus.ResumeLayout(false);
            this.frmStatus.PerformLayout();
            this.tabPanel.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.tabWelcome.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabDevice.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tabData.ResumeLayout(false);
            this.tableDataRecord.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVoletOffset)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabDataPlot.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tabView.ResumeLayout(false);
            this.tabGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmLogo)).EndInit();
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
        private System.Windows.Forms.ToolTip Help;
        private System.Windows.Forms.TableLayoutPanel tableDataRecord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numVoletOffset;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label strDeviceName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbxComPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPortBuad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label strDataFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabView;
        private System.Windows.Forms.TabPage tabPlotView;
        private System.Windows.Forms.TabPage tabGridView;
        private System.Windows.Forms.DataGridView dgvDataView;
    }
}


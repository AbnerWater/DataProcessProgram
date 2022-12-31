using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeviceControl;
using System.Threading;
using DisplayControl;
using Arction.WinForms.Charting;
using System.IO.Ports;

namespace DataProcessProgram
{
    public partial class FrmMain : Form
    {
        #region dllImport
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public const int WM_NCHITTEST = 0x0084;
        public const int HTLEFT = 10;      //左边界
        public const int HTRIGHT = 11;     //右边界
        public const int HTTOP = 12;       //上边界
        public const int HTTOPLEFT = 13;   //左上角
        public const int HTTOPRIGHT = 14;  //右上角
        public const int HTBOTTOM = 15;    //下边界
        public const int HTBOTTOMLEFT = 0x10;    //左下角
        public const int HTBOTTOMRIGHT = 17;     //右下角
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    Point vPoint = new Point((int)m.LParam & 0xFFFF,
                        (int)m.LParam >> 16 & 0xFFFF);
                    vPoint = PointToClient(vPoint);
                    if (vPoint.X <= 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPLEFT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMLEFT;
                        else m.Result = (IntPtr)HTLEFT;
                    else if (vPoint.X >= ClientSize.Width - 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPRIGHT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMRIGHT;
                        else m.Result = (IntPtr)HTRIGHT;
                    else if (vPoint.Y <= 5)
                        m.Result = (IntPtr)HTTOP;
                    else if (vPoint.Y >= ClientSize.Height - 5)
                        m.Result = (IntPtr)HTBOTTOM;
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        #endregion
        private LightningChartUltimate _voletPlot;
        private LightningChartUltimate _currentPlot;
        private System.Timers.Timer _sysTimer;
        private System.Timers.Timer _plotTimer;
        private RsDevice _rsDevice;
        private DataSet _data;
        private bool _simulateDev = false;
        public FrmMain()
        {
            InitializeComponent();
        }
        private void deviceConnect(string port,string buad)
        {
            if(_rsDevice.Connection)
            {
                if (MessageBox.Show("当前已连接至仪器，是否断开并重新连接", "提示", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    _rsDevice.Disconnect();
                    _rsDevice.Connect(port, int.Parse(buad));
                }
            }
            else
                _rsDevice.Connect(port, int.Parse(buad));
        }
        private void deviceDisconnect()
        {
            if (_rsDevice.Connection)
                _rsDevice.Disconnect();
        }
        private void openDataset(string file)
        {

        }
        private void loadData2dgv(DataSet data)
        {

        }
        private void loadData2Plot(DataSet data)
        {

        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            SplasherForm.Status = "界面初始化......";
            strProgram.Text = Application.ProductName;
            lblProductName.Text = Application.ProductName;
            labelVersion.Text = string.Format(labelVersion.Text, Application.ProductVersion);
            textBoxDescription.Text = string.Format(textBoxDescription.Text, Application.ProductName);
            _rsDevice = new RsDevice(500);
            #region iniTimer
            _sysTimer = new System.Timers.Timer(500);
            _sysTimer.AutoReset = true;
            _sysTimer.Elapsed += _sysTimer_Elapsed;
            _sysTimer.Start();
            _plotTimer = new System.Timers.Timer(100);
            _plotTimer.AutoReset = true;
            _plotTimer.Elapsed += _plotTimer_Elapsed;
            #endregion
            #region GUI
            mainTab.Appearance = TabAppearance.FlatButtons;
            mainTab.ItemSize = new Size(0, 1);
            mainTab.SizeMode = TabSizeMode.Fixed;
            _currentPlot = PlotMethod.CreateChart(null);
            PlotMethod.formatLcuXY(_currentPlot, "电流采集","电流(pA/V)", -5, 5);
            tableDataRecord.Controls.Add(_currentPlot, 0, 2);
            _voletPlot = PlotMethod.CreateChart(null);
            PlotMethod.formatLcuXY(_voletPlot, "电压采集","电压(mV)", -1, 1);
            tableDataRecord.Controls.Add(_voletPlot, 0, 3);
            foreach (var v in SerialPort.GetPortNames())
            {
                cbxComPort.Items.Add(v);
            }
            mainTab.SelectedIndexChanged += MainTab_SelectedIndexChanged;
            #endregion
            SplasherForm.Status = "初始化完毕";
            Thread.Sleep(300);
            SplasherForm.Close();
        }

        private void MainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tab = sender as TabControl;
            switch (tab.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    if(!_rsDevice.Connection&&!_simulateDev)
                    {
                        if(MessageBox.Show("检测到当前并未连接任何设备，是否进入模拟采集状态", "提示", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                            _simulateDev = true;
                    }
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }

        private void _plotTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            
        }

        private void _sysTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke(new Action(() => {
                if(_rsDevice.Connection)
                {
                    strDeviceName.Text = _rsDevice.PortName;
                    strStatus.Text = "仪器已连接";
                    strStatus.ForeColor = Color.LightGreen;
                    picStatus.Image = Properties.Resources.正常;
                    btnConnect.BackColor = Color.LightGreen;
                    btnConnect.Text = "断开连接";
                }
                else if(_simulateDev)
                {
                    strDeviceName.Text = "虚拟仪器";
                    strStatus.Text = "虚拟仪器连接";
                    strStatus.ForeColor = Color.LightGreen;
                    picStatus.Image = Properties.Resources.正常;
                    btnConnect.BackColor = Color.White;
                    btnConnect.Text = "仪器连接";
                }
                else
                {
                    strStatus.Text = "仪器未连接";
                    strStatus.ForeColor = Color.Red;
                    picStatus.Image = Properties.Resources.错误;
                    btnConnect.BackColor = Color.White;
                    btnConnect.Text = "仪器连接";
                }
            }));
        }

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void frmTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        private void Status_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        private void btnMinimal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxminal_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainTab.SelectedTab = tabWelcome;
        }

        private void btnDevice_Click(object sender, EventArgs e)
        {
            mainTab.SelectedTab = tabDevice;
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            mainTab.SelectedTab = tabData;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            mainTab.SelectedTab = tabDataPlot;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            mainTab.SelectedTab = tabAbout;
        }

        private void btnDeviceConnect_Click(object sender, EventArgs e)
        {
            mainTab.SelectedTab = tabDevice;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mainTab.SelectedTab = tabData;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainTab.SelectedTab = tabDataPlot;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if(btn.Text.Contains("仪器"))
            {
                deviceConnect(cbxComPort.SelectedItem.ToString(), cbxPortBuad.SelectedItem.ToString());
            }
            else
            {
                deviceDisconnect();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "(数据文件)|*.xml|*.txt|*.csv";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    DataSet data = new DataSet(ofd.FileName);
                    if (data != null)
                    {
                        strDataFile.Text = data.DataSetName;
                        loadData2dgv(data);
                        loadData2Plot(data);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("打开数据文件出错，请检查数据文件格式后重试！");
                }
            }
        }
    }
}

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
using DataSet = DataControl.DataSet;

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
        private LightningChartUltimate _currentDisplay;
        private LightningChartUltimate _voletDisplay;
        private System.Timers.Timer _sysTimer;
        private System.Timers.Timer _plotTimer;
        private System.Timers.Timer _recTimer;
        private RsDevice _rsDevice;
        private DataSet _data;
        private bool _preview = false;
        private bool _record = false;
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
        private void loadData2Plot(DataSet data)
        {
            if(data.TimeList.Count== data.Signal_I.Count)
                PlotMethod.AddLineXY(_currentDisplay, data.TimeList, data.Signal_I, "电流信号", Color.Blue);
            else
                PlotMethod.AddLineXY(_currentDisplay, data.Signal_I, "电流信号", Color.Blue);
            if(data.TimeList.Count == data.Signal_V.Count)
                PlotMethod.AddLineXY(_voletDisplay, data.TimeList, data.Signal_V, "电压信号", Color.Red);
            else
                PlotMethod.AddLineXY(_voletDisplay, data.Signal_V, "电压信号", Color.Red);
        }
        private void clearBtnColor()
        {
            btnHome.BackColor = Color.Transparent;
            btnDevice.BackColor = Color.Transparent;
            btnDisplay.BackColor = Color.Transparent;
            btnAbout.BackColor = Color.Transparent;
            btnData.BackColor = Color.Transparent;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            SplasherForm.Status = "界面初始化......";
            this.Text= Application.ProductName;
            strProgram.Text = Application.ProductName;
            lblProductName.Text = Application.ProductName;
            labelVersion.Text = string.Format(labelVersion.Text, Application.ProductVersion);
            textBoxDescription.Text = string.Format(textBoxDescription.Text, Application.ProductName);
            _rsDevice = new RsDevice(10);
            #region iniTimer
            _sysTimer = new System.Timers.Timer(500);
            _sysTimer.AutoReset = true;
            _sysTimer.Elapsed += _sysTimer_Elapsed;
            _sysTimer.Start();
            _plotTimer = new System.Timers.Timer(10);
            _plotTimer.AutoReset = true;
            _plotTimer.Elapsed += _plotTimer_Elapsed;
            _plotTimer.Start();
            _recTimer = new System.Timers.Timer(10);
            _recTimer.AutoReset = true;
            _recTimer.Elapsed += _recTimer_Elapsed;
            _recTimer.Start();
            #endregion
            #region GUI
            mainTab.Appearance = TabAppearance.FlatButtons;
            mainTab.ItemSize = new Size(0, 1);
            mainTab.SizeMode = TabSizeMode.Fixed;
            _currentPlot = PlotMethod.CreateChart(null);
            PlotMethod.formatLcuXY(_currentPlot, "电流采集","电流(pA)", 0, 1e6);
            PlotMethod.addDefaultLine(_currentPlot);
            tableDataRecord.Controls.Add(_currentPlot, 0, 2);
            _voletPlot = PlotMethod.CreateChart(null);
            PlotMethod.formatLcuXY(_voletPlot, "电压采集","电压(mV)", 0, 1000);
            PlotMethod.addDefaultLine(_voletPlot);
            tableDataRecord.Controls.Add(_voletPlot, 0, 3);
            _currentDisplay = PlotMethod.CreateChart(dataViewContainer.Panel1);
            PlotMethod.formatLcuXY(_currentDisplay, "电流数据", "电流(pA)", 0, 1e12);
            _voletDisplay = PlotMethod.CreateChart(dataViewContainer.Panel2);
            PlotMethod.formatLcuXY(_voletDisplay, "电压数据", "电压(mV)", 0, 1000);
            foreach (var v in SerialPort.GetPortNames())
            {
                cbxComPort.Items.Add(v);
            }
            mainTab.SelectedIndexChanged += MainTab_SelectedIndexChanged;
            btnStop.Enabled = false;
            btnSave.Enabled = false;
            #endregion
            _data = new DataSet();
            SplasherForm.Status = "初始化完毕";
            Thread.Sleep(2500);
            SplasherForm.Close();
            this.FormClosing += FrmMain_FormClosing;
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_sysTimer!=null)
            {
                _sysTimer.Stop();
                _sysTimer.Close();
                _sysTimer = null;
            }
            if (_recTimer != null)
            {
                _recTimer.Stop();
                _recTimer.Close();
                _recTimer = null;
            }
            if (_plotTimer != null)
            {
                _plotTimer.Stop();
                _plotTimer.Close();
                _plotTimer = null;
            }
        }
        private void _recTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!_record)
                return;
            _data.AddData(DateTime.Now, _rsDevice.Data[0], _rsDevice.Data[1]);
        }
        private void _plotTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!_preview)
                return;
            this.BeginInvoke(new Action(() =>
            {
                PlotMethod.trackPlot(_currentPlot, DateTime.Now, _rsDevice.Data[0], 0);
                PlotMethod.trackPlot(_voletPlot, DateTime.Now, _rsDevice.Data[1], 0);
            }));
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
                        if (MessageBox.Show("检测到当前并未连接任何设备，是否进入模拟采集状态", "提示", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                        {
                            _simulateDev = true;
                            _rsDevice.SetVirtual(true);
                        }
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
                if (_data.TimeList.Count > 0 && !_record)
                    btnSave.Enabled = true;
                else
                    btnSave.Enabled = false;
                btnStop.Enabled = _record || _preview;
                if (_record)
                    strRecordStatus.Text = "正在记录数据...";
                else
                    strRecordStatus.Text = "";
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
            clearBtnColor();
            (sender as Button).BackColor = Color.Teal;
        }
        private void btnDevice_Click(object sender, EventArgs e)
        {
            mainTab.SelectedTab = tabDevice;
            clearBtnColor();
            (sender as Button).BackColor = Color.Teal;
        }
        private void btnData_Click(object sender, EventArgs e)
        {
            mainTab.SelectedTab = tabData;
            clearBtnColor();
            (sender as Button).BackColor = Color.Teal;
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            mainTab.SelectedTab = tabDataPlot;
            clearBtnColor();
            (sender as Button).BackColor = Color.Teal;
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            mainTab.SelectedTab = tabAbout;
            clearBtnColor();
            (sender as Button).BackColor = Color.Teal;
        }
        private void btnDeviceConnect_Click(object sender, EventArgs e)
        {
            mainTab.SelectedTab = tabDevice;
            clearBtnColor();
            btnDevice.BackColor = Color.Teal;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            mainTab.SelectedTab = tabData;
            clearBtnColor();
            btnData.BackColor = Color.Teal;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            mainTab.SelectedTab = tabDataPlot;
            clearBtnColor();
            btnDisplay.BackColor = Color.Teal;
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if(btn.Text=="仪器连接")
            {
                if (cbxComPort.SelectedIndex > -1 && cbxPortBuad.SelectedIndex > -1)
                    deviceConnect(cbxComPort.SelectedItem.ToString(), cbxPortBuad.SelectedItem.ToString());
                else
                    MessageBox.Show("请检查仪器连接参数后重试");
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
            ofd.Filter = "XML文件|*.xml|文本文件|*.txt|表格文件|*.csv";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                DataSet data = new DataSet();
                if (data.LoadFromFile(ofd.FileName))
                {
                    strDataFile.Text = data.Name;
                    PlotMethod.ClearLines(_currentDisplay);
                    PlotMethod.ClearLines(_voletDisplay);
                    loadData2Plot(data);
                }
                else
                    MessageBox.Show("打开数据文件出错，请检查数据文件格式后重试！");
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbxComPort.Items.Clear();
            foreach (var v in SerialPort.GetPortNames())
            {
                cbxComPort.Items.Add(v);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML文件|*.xml|文本文件|*.txt|表格文件|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _data.Saved = _data.SaveToFile(sfd.FileName);
                if (_data.Saved)
                    MessageBox.Show("数据文件成功保存至"+sfd.FileName);
                else
                    MessageBox.Show("保存数据文件失败，请重新采集后再试");
            }
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            if(!_preview)
            {
                PlotMethod.formatLcuXY(_currentPlot, "电流采集", "电流(pA)", 0, 1e12);
                PlotMethod.formatLcuXY(_voletPlot, "电压采集", "电压(mV)", 0, 1000);
            }
            _preview = !_preview;
        }
        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (_data.TimeList.Count > 0 && !_data.Saved)
            {
                if (MessageBox.Show("再次记录会覆盖未保存的数据，是否继续？", "提示", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    _data.ClearData();
                    _data.Saved = false;
                }
            }
            _record = true;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_record)
                _record = !_record;
            if (_preview)
                _preview = !_preview;
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            strDataFile.Text = "---";
            PlotMethod.ClearLines(_currentDisplay);
            PlotMethod.ClearLines(_voletDisplay);
        }

        private void numVoletOffset_ValueChanged(object sender, EventArgs e)
        {
            _rsDevice.SetVoletOffset((double)(sender as NumericUpDown).Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainTab.SelectedTab = tabData;
            clearBtnColor();
            btnData.BackColor = Color.Teal;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainTab.SelectedTab = tabDevice;
            clearBtnColor();
            btnDevice.BackColor = Color.Teal;
        }
    }
}

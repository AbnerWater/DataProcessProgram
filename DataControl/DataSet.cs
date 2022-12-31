using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataControl
{
    public class DataSet
    {
        public List<DateTime> TimeList { get; set; }
        public List<double> Signal_I { get; set; }
        public List<double> Signal_V { get; set; }
        public string Name { get; set; }
        public int DataNum { get { return TimeList.Count; } }
        public DateTime Start { get { return TimeList[0]; } }
        public DateTime End { get { return TimeList.Last(); } }
        public DataSet()
        {
            TimeList = new List<DateTime>();
            Signal_I = new List<double>();
            Signal_V = new List<double>();
        }
        public DataSet(string file)
        {
            string ext = file.Split('.').Last().ToLower();
            switch (ext)
            {
                case "xml":
                    break;
                case "csv":
                    break;
                case "txt":
                    break;
                default:
                    throw(new Exception("不支持的文件格式"));
            }
        }
        public bool SaveToFile(string file)
        {
            string ext = file.Split('.').Last().ToLower();
            switch(ext)
            {
                case "xml":
                    break;
                case "csv":
                    break;
                case "txt":
                    break;
                default:
                    return false;
            }
            return true;
        }
        public void AddData(DateTime time,double i,double v)
        {
            TimeList.Add(time);
            Signal_I.Add(i);
            Signal_V.Add(v);
        }
        public void ClearData()
        {
            TimeList.Clear();
            Signal_I.Clear();
            Signal_V.Clear();
        }
    }
}

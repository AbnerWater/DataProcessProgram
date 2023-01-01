using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UtilControl;

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
        public bool Saved { get; set; }
        public DataSet()
        {
            TimeList = new List<DateTime>();
            Signal_I = new List<double>();
            Signal_V = new List<double>();
        }
        public bool LoadFromFile(string file)
        {
            string ext = file.Split('.').Last().ToLower();
            Name = System.IO.Path.GetFileNameWithoutExtension(file);
            switch (ext)
            {
                case "xml":
                    try
                    {
                        string xml = File.ReadAllText(file, System.Text.Encoding.UTF8);
                        DataSet data = (DataSet)(Utility.Deserialize(typeof(DataSet), xml));
                        if (data != null)
                        {
                            TimeList = data.TimeList;
                            Signal_I = data.Signal_I;
                            Signal_V = data.Signal_V;
                            return true;
                        }
                        else
                            return false;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                case "csv":
                    try
                    {
                        string temp;
                        StreamReader sr = new StreamReader(file);
                        sr.ReadLine();
                        ClearData();
                        while ((temp = sr.ReadLine()) != null)
                        {
                            if (temp != null)
                            {
                                try
                                {
                                    string[] strtmp = temp.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                                    string[] date = strtmp[0].Split('-');
                                    string[] time = strtmp[1].Split(new char[] { ':', '.' });
                                    TimeList.Add(new DateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]),
                                        int.Parse(time[0]), int.Parse(time[1]), int.Parse(time[2]), int.Parse(time[3]), DateTimeKind.Local));
                                    double i, v;
                                    i = double.Parse(strtmp[2]);
                                    v = double.Parse(strtmp[3]);
                                    Signal_I.Add(i);
                                    Signal_V.Add(v);
                                }
                                catch (Exception)
                                {
                                    continue;
                                }
                            }
                        }
                        sr.Close();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                case "txt":
                    try
                    {
                        string temp;
                        StreamReader sr = new StreamReader(file);
                        ClearData();
                        while ((temp = sr.ReadLine()) != null)
                        {
                            if (temp != null)
                            {
                                try
                                {
                                    string[] strtmp = temp.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                                    string[] date = strtmp[0].Split('-');
                                    string[] time = strtmp[1].Split(new char[] { ':', '.' });
                                    TimeList.Add(new DateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]),
                                        int.Parse(time[0]), int.Parse(time[1]), int.Parse(time[2]), int.Parse(time[3]), DateTimeKind.Local));
                                    double i, v;
                                    i = double.Parse(strtmp[2]);
                                    v = double.Parse(strtmp[3]);
                                    Signal_I.Add(i);
                                    Signal_V.Add(v);
                                }
                                catch (Exception)
                                {
                                    continue;
                                }
                            }
                        }
                        sr.Close();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                default:
                    throw (new Exception("不支持的文件格式"));
            }
        }
        public bool SaveToFile(string file)
        {
            string ext = file.Split('.').Last().ToLower();
            switch(ext)
            {
                case "xml":
                    try
                    {
                        string xml = Utility.Serializer(typeof(DataSet), this);
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(xml);
                        doc.Save(file);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                case "csv":
                    try
                    {
                        FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
                        StreamWriter writer = new StreamWriter(fs);
                        var str = string.Empty;
                        //1.输出表头
                        str += "Time,Data_I,Data_V";
                        writer.WriteLine(str);
                        //2.输出数据
                        for (int i = 0; i < TimeList.Count; i++)
                        {
                            str = string.Empty;
                            str += '"';
                            str += TimeList[i].ToString("yyyy-MM-dd HH:mm:ss.fff");
                            str += '"';
                            str += ',';
                            str += '"';
                            str += Signal_I[i].ToString("0.000");
                            str += '"';
                            str += ',';
                            str += '"';
                            str += Signal_V[i].ToString("0.000");
                            str += '"';
                            writer.WriteLine(str);
                        }
                        writer.Flush();
                        writer.Close();
                        fs.Close();
                        return true;
                    }
                    catch(Exception)
                    {
                        return false;
                    }
                case "txt":
                    try
                    {
                        FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        for (int i = 0; i < TimeList.Count; i++)
                        {
                            string strContent = "";
                            strContent += TimeList[i].ToString("yyyy-MM-dd HH:mm:ss.fff\t");
                            strContent += Signal_I[i].ToString("0.000\t");
                            strContent += Signal_V[i].ToString("0.000\t");
                            sw.WriteLine(strContent);
                        }
                        sw.Close();
                        fs.Close();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                default:
                    return false;
            }
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

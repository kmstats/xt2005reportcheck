using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace com.echo.dntj
{
    public static class Util
    {
        //public static IniFile chkFile;    //审核公式文件
        public static IniFile cfgFile;    //配置文件
        public static IniFile msgFile;    //消息文件
        public static IniFile smFile;     //说明文件
        public static string curPath;     //当前报表目录
        public static string comPath;     //对比报表目录
        public static string smFilePath;
        public static string chkFilePath;

        public static IniFile LicenseFile;
        private static string LicenseFilePath;

        public static IniFile tempChkFile;  //解密后的审核公式文件
        public static string tempChkFilePath;

        private static string sKey = "feel100%";

        static string[] op = { "<>", ">=", "<=", ">", "<", "=" };
        private static string path;         //程序运行目录

        public static void SetTmpChkFile()
        {
            StreamReader sr = new StreamReader(chkFilePath,System.Text.Encoding.Default);
            StreamWriter sw = new StreamWriter(tempChkFilePath,false,System.Text.Encoding.Default);
            string s = Decrypt(sr.ReadToEnd());
            string[] ss = s.Split('\n');
            foreach (string z in ss)
            {
                sw.WriteLine(z);
            }
            sw.Close();
            sr.Close();
            tempChkFile = new IniFile(tempChkFilePath);
        }

        public static void SetPath(string p)
        {
            path = p;
            //chkFile = new IniFile(path + "\\config\\chk.ini");
            cfgFile = new IniFile(path + "\\config\\db.ini");
            msgFile = new IniFile(path + "\\config\\msg.ini");
            
            curPath = path + cfgFile.ReadString("Path", cfgFile.ReadString("Comp", "cur", ""), "");
            comPath = path + cfgFile.ReadString("Path", cfgFile.ReadString("Comp", "com", ""), "");

            chkFilePath = path + "\\config\\chk.ini";
            tempChkFilePath = Path.GetTempPath() + "tempChk.ini";

            LicenseFilePath = path + "\\License.ini";
            LicenseFile = new IniFile(LicenseFilePath);
        }

        public static void SetSM()
        {
            smFilePath = path + "\\result\\" + GetOrg().Id + "_" + GetOrg().Name + ".ini";
            smFile = new IniFile(smFilePath);
        }

        /// <summary>
        /// 解压缩年报文件
        /// </summary>
        /// <param name="rarFileToDecompress">年报文件</param>
        /// <param name="directoryRar">WinRAR.exe目录</param>
        /// <param name="directoryToSave">解压缩目标目录</param>
        /// <returns></returns>
        public static Boolean DecompressRAR(string rarFileToDecompress, string directoryRar, string directoryToSave)
        {
            rarFileToDecompress = ExtractShortPathName(rarFileToDecompress);
            directoryRar = ExtractShortPathName(directoryRar);
            Directory.CreateDirectory(directoryToSave);
            directoryToSave = ExtractShortPathName(directoryToSave);

            if (new FileInfo(directoryRar).Exists)
            {
                try
                {
                    Process p = new Process();
                    p.StartInfo.FileName = directoryRar;
                    string arguments = @"e -IBCK -o+ -ep -y -hpn*7E[A,y5_Vp8N+H -inul";
                    arguments += " " + rarFileToDecompress + " " + directoryToSave;
                    p.StartInfo.Arguments = arguments;
                    p.Start();
                    while (!p.HasExited)
                    {
                        p.WaitForExit();
                    }

                    return true;
                }
                catch (Exception)
                {
                    throw new Exception("解压缩出现错误！请检查年报数据！");
                }
            }
            else
            {
                throw new Exception("没有找到WinRar.exe，请检查您的目录中是否存在Winrar.exe!");
            }
        }

        /// <summary>
        /// 取得文件的短文件名
        /// </summary>
        /// <param name="path"></param>
        /// <param name="shortPath"></param>
        /// <param name="shortPathLength"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll ", CharSet = CharSet.Auto)]
        private static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)]     string path, [MarshalAs(UnmanagedType.LPTStr)]     StringBuilder shortPath, int shortPathLength);
        private static string ExtractShortPathName(string longName)
        {
            StringBuilder shortNameBuffer = new StringBuilder(256);
            int bufferSize = shortNameBuffer.Capacity;
            int result = GetShortPathName(longName, shortNameBuffer, bufferSize);
            return shortNameBuffer.ToString();
        }

        /// <summary>
        /// 取得组织信息
        /// </summary>
        /// <param name="path">info.txt文件的全路径</param>
        /// <returns></returns>
        public static Org GetOrg()
        {
            Org o;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(curPath + "\\info.txt", Encoding.Default);
                string info = sr.ReadLine();
                string[] list = info.Split('\t');
                o = new Org();
                o.Id = list[0];
                o.Name = list[1];
                o.NbStart = list[2];
                o.NbEnd = list[3];
            }
            catch (Exception ex)
            {
                throw new Exception("读取党组织数据出错，请检查年报数据包文件！" + ex.Message);
            }
            finally
            {
                sr.Close();
            }
            return o;
        }

        /// <summary>
        /// 拆分审核公式为左、中、右三个部分
        /// </summary>
        /// <param name="s">审核公式字符串</param>
        /// <returns>List 0为左，1为中，2为右</returns>
        private static List<string> SplitChk(string s)
        {
            try
            {
                List<string> l = new List<string>();
                for (int i = 0; i < op.Length; i++)
                {
                    if (s.IndexOf(op[i]) > 0)
                    {
                        l.Add(s.Substring(0, s.IndexOf(op[i])));
                        l.Add(op[i]);
                        l.Add(s.Substring(s.IndexOf(op[i]) + op[i].Length));
                        break;
                    }
                }
                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("公式定义错！请检查公式！" + ex.Message);
            }
        }

        /// <summary>
        /// 取得每个定义公式的最小单元
        /// </summary>
        /// <param name="s">审核公式左或右部分字符串</param>
        /// <returns>List 公式最小单元</returns>
        private static List<string> SplitChkUnit(string s)
        {
            try
            {
                List<string> l = new List<string>();

                string pattern = @"[^+\-*/()]+";
                System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(s, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.Singleline);

                while (match.Success)
                {
                    l.Add(match.Value);
                    match = match.NextMatch();
                }
                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("公式定义错！请检查公式！" + ex.Message);
            }
        }

        /// <summary>
        /// 拆分公式最小单元，将最小单元转换为 报告期、表号、列号、行号
        /// </summary>
        /// <param name="s">公式最小单元</param>
        /// <returns>List 公式单元分析 0-报告期 1-表号 2-报表号 3-报表路径 4-列号 5-行号</returns>
        private static List<string> SplitUnit(string s)
        {
            List<string> listUnit = new List<string>(); //公式单元分析 0-报告期 1-表号 2-报表号 3-报表路径 4-列号 5-行号
            try
            {
                //取得年份
                string pattern = @"\[[^\]]+\]";
                Match match = Regex.Match(s, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                if (match.Success)
                {
                    listUnit.Add(match.Value.Substring(1, match.Value.Length - 2));
                    s = s.Substring(match.Value.Length);
                }
                else
                    listUnit.Add(GetOrg().NbEnd.Substring(0, 4));

                //取得表号
                listUnit.Add(s.Substring(0, s.IndexOf('!')));
                s = (s.Substring(s.IndexOf('!') + 1)).ToUpper();

                //取得报表ID
                listUnit.Add(GetReportID(listUnit[0], listUnit[1]));

                //取得报表路径
                listUnit.Add(GetNbPath(listUnit[0]));

                //取得列号
                listUnit.Add(((int)s[0] - 64).ToString());
                s = s.Substring(1);

                //取得行号
                listUnit.Add(s);
                return listUnit;
            }
            catch (Exception ex)
            {
                throw new Exception("公式定义错！" + ex.Message);
            }
        }

        /// <summary>
        /// 解析公式最小单元，取得数值
        /// </summary>
        /// <param name="s">公式最小单元</param>
        /// <returns>数值</returns>
        private static string GetUnitValue(string s)
        {
            string result = "";
            if (s.IndexOf('!') > 0)
            {
                List<string> listUnit = SplitUnit(s);
                result = GetData(path + listUnit[3] + "\\rptreportdata.txt",listUnit[2], listUnit[5], listUnit[4]);
                if (result == "")
                    result = "0";
            }
            else
            {
                result = s;
            }
            return result;
        }

        private static string GetData(string file,string repID, string row, string col)
        {
            StreamReader sr = new StreamReader(file , Encoding.Default);
            string str = "";
            string result = "";
            string[] list;

            while ((str = sr.ReadLine()) != null)
            {
                list = str.Split('\t');
                if (list[0] == repID & list[1] == row & list[2] == col)
                {
                    result = list[3];
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// 从定义公式返回值
        /// </summary>
        /// <param name="gs">公式str</param>
        /// <returns></returns>
        public static string GetValue(string gs)
        {
            string result = "";
            string left = "";
            string right = "";


            //拆分公式为左、中、右
            List<string> gsList = SplitChk(gs);
            left = gsList[0];
            right = gsList[2];


            //拆分公式左部分
            List<string> leftList = SplitChkUnit(gsList[0]);

            //拆分公式右部分
            List<string> rightList = SplitChkUnit(gsList[2]);

            //取得公式左部分各单元的报表值,并进行替换
            foreach (string s in leftList)
            {
                left = left.Replace(s, GetUnitValue(s));
            }

            //取得公式有部分各单元的报表值，并进行替换
            foreach (string s in rightList)
            {
                right = right.Replace(s, GetUnitValue(s));
            }

            //拼接公式
            result = left + gsList[1] + right;

            return result;
        }

        /// <summary>
        /// 从定义公式返回bool值
        /// </summary>
        /// <param name="gs"></param>
        /// <returns></returns>
        public static Boolean GetBooleanValue(string gs)
        {
            gs = gs.Replace("<>", "!=");
            return Evaluator.EvaluateToBool(gs);
        }

        /// <summary>
        /// 从表别名，取得表Id——内部方法
        /// </summary>
        /// <param name="nbAlias">年报别名</param>
        /// <param name="tId">表别名</param>
        /// <returns>表Id</returns>
        private static string GetReportTid(string nbAlias, string tableAliasId)
        {
            return cfgFile.ReadString(nbAlias, tableAliasId, "");
        }

        /// <summary>
        /// 从年报别名，取得年报文件解压缩目录——内部方法
        /// </summary>
        /// <param name="nbAlias">年报别名</param>
        /// <returns>路径</returns>
        private static string GetNbPath(string nbAlias)
        {
            return cfgFile.ReadString("path", nbAlias, "");
        }

        /// <summary>
        /// 从表Id，取得报表ID——内部方法
        /// </summary>
        /// <param name="nbAlias"></param>
        /// <param name="repID"></param>
        /// <returns></returns>
        private static string GetRepID(string nbAlias, string repID)
        {
            string result = "";

            string rptFile = path + GetNbPath(nbAlias) + "\\rptreport.txt";
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(rptFile, Encoding.Default);
                string info;
                while ((info = sr.ReadLine()) != null)
                {
                    string[] list = info.Split('\t');
                    if (list[3] == repID)
                    {
                        result = list[0];
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("读取党组织数据出错，请检查年报数据包文件！" + ex.Message);
            }
            finally
            {
                sr.Close();
            }
            return result;
        }

        /// <summary>
        /// 从表别名，取得报表ID
        /// </summary>
        /// <param name="nbAlias"></param>
        /// <param name="tableAliasID"></param>
        /// <returns></returns>
        public static string GetReportID(string nbAlias, string tableAliasID)
        {
            return GetRepID(nbAlias, GetReportTid(nbAlias, tableAliasID));
        }

        //加密开始
        public static string Encrypt(string pToEncrypt)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Encoding.Default.GetBytes(pToEncrypt);

            des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            ret.ToString();
            return ret.ToString();
        }

        public static string Decrypt(string pToDecrypt)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = new byte[pToDecrypt.Length / 2];
            for (int x = 0; x < pToDecrypt.Length / 2; x++)
            {
                int i = (Convert.ToInt32(pToDecrypt.Substring(x * 2, 2), 16));
                inputByteArray[x] = (byte)i;
            }
            des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            return System.Text.Encoding.Default.GetString(ms.ToArray());
        }

        /// <summary>
        /// 取得硬盘号
        /// </summary>
   [DllImport("kernel32.dll")]   
  private   static   extern   int   GetVolumeInformation(   
  string   lpRootPathName,   
  string   lpVolumeNameBuffer,   
  int   nVolumeNameSize,   
  ref   int   lpVolumeSerialNumber,   
  int   lpMaximumComponentLength,   
  int   lpFileSystemFlags,   
  string   lpFileSystemNameBuffer,   
  int   nFileSystemNameSize   
  );   
  ///   <summary>   
  ///   获得盘符为drvID的硬盘序列号，缺省为C   
  ///   </summary>   
  ///   <param   name="drvID"></param>   
  ///   <returns></returns>   
  public static string HDVal(string   drvID)   
  {   
  const   int   MAX_FILENAME_LEN   =   256;   
  int   retVal   =   0;   
  int   a   =0;   
  int   b   =0;   
  string   str1   =   null;   
  string   str2   =   null;   
  int   i   =   GetVolumeInformation(   
  drvID   +   @":\",   
  str1,   
  MAX_FILENAME_LEN,   
  ref   retVal,   
  a,   
  b,   
  str2,   
  MAX_FILENAME_LEN   
  );   
  return   retVal.ToString();   
  }   
  public static string  HDVal()   
  {   
  const   int   MAX_FILENAME_LEN   =   256;   
  int   retVal   =   0;   
  int   a   =0;   
  int   b   =0;   
  string   str1   =   null;   
  string   str2   =   null;   
  int   i   =   GetVolumeInformation(   
  "c:\\",   
  str1,   
  MAX_FILENAME_LEN,   
  ref   retVal,   
  a,   
  b,   
  str2,   
  MAX_FILENAME_LEN   
  );   
  return   retVal.ToString();   
  }

        public static string GetSN()
        {
            return (Convert.ToInt32(HDVal()) / 2 + 13769).ToString();
        }

        public static string GetSN2()
        {
            return (Convert.ToInt32(HDVal()) / 2 * 7 + 13769).ToString();
        }

        public static string GetLicense()
        {
            return LicenseFile.ReadString("sn", "user", "");
        }

        public static void SaveLicense(string lic)
        {
            LicenseFile.WriteString("sn", "user", lic);
        }

        //加密结束
        
        /// <summary>
        /// 创建结构Org
        /// </summary>
        public struct Org
        {
            public string Id;
            public string Name;
            public string NbStart;
            public string NbEnd;
        }
    }
}

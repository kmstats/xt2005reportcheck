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
        //public static IniFile chkFile;    //��˹�ʽ�ļ�
        public static IniFile cfgFile;    //�����ļ�
        public static IniFile msgFile;    //��Ϣ�ļ�
        public static IniFile smFile;     //˵���ļ�
        public static string curPath;     //��ǰ����Ŀ¼
        public static string comPath;     //�Աȱ���Ŀ¼
        public static string smFilePath;
        public static string chkFilePath;

        public static IniFile LicenseFile;
        private static string LicenseFilePath;

        public static IniFile tempChkFile;  //���ܺ����˹�ʽ�ļ�
        public static string tempChkFilePath;

        private static string sKey = "feel100%";

        static string[] op = { "<>", ">=", "<=", ">", "<", "=" };
        private static string path;         //��������Ŀ¼

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
        /// ��ѹ���걨�ļ�
        /// </summary>
        /// <param name="rarFileToDecompress">�걨�ļ�</param>
        /// <param name="directoryRar">WinRAR.exeĿ¼</param>
        /// <param name="directoryToSave">��ѹ��Ŀ��Ŀ¼</param>
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
                    throw new Exception("��ѹ�����ִ��������걨���ݣ�");
                }
            }
            else
            {
                throw new Exception("û���ҵ�WinRar.exe����������Ŀ¼���Ƿ����Winrar.exe!");
            }
        }

        /// <summary>
        /// ȡ���ļ��Ķ��ļ���
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
        /// ȡ����֯��Ϣ
        /// </summary>
        /// <param name="path">info.txt�ļ���ȫ·��</param>
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
                throw new Exception("��ȡ����֯���ݳ��������걨���ݰ��ļ���" + ex.Message);
            }
            finally
            {
                sr.Close();
            }
            return o;
        }

        /// <summary>
        /// �����˹�ʽΪ���С�����������
        /// </summary>
        /// <param name="s">��˹�ʽ�ַ���</param>
        /// <returns>List 0Ϊ��1Ϊ�У�2Ϊ��</returns>
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
                throw new Exception("��ʽ��������鹫ʽ��" + ex.Message);
            }
        }

        /// <summary>
        /// ȡ��ÿ�����幫ʽ����С��Ԫ
        /// </summary>
        /// <param name="s">��˹�ʽ����Ҳ����ַ���</param>
        /// <returns>List ��ʽ��С��Ԫ</returns>
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
                throw new Exception("��ʽ��������鹫ʽ��" + ex.Message);
            }
        }

        /// <summary>
        /// ��ֹ�ʽ��С��Ԫ������С��Ԫת��Ϊ �����ڡ���š��кš��к�
        /// </summary>
        /// <param name="s">��ʽ��С��Ԫ</param>
        /// <returns>List ��ʽ��Ԫ���� 0-������ 1-��� 2-����� 3-����·�� 4-�к� 5-�к�</returns>
        private static List<string> SplitUnit(string s)
        {
            List<string> listUnit = new List<string>(); //��ʽ��Ԫ���� 0-������ 1-��� 2-����� 3-����·�� 4-�к� 5-�к�
            try
            {
                //ȡ�����
                string pattern = @"\[[^\]]+\]";
                Match match = Regex.Match(s, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                if (match.Success)
                {
                    listUnit.Add(match.Value.Substring(1, match.Value.Length - 2));
                    s = s.Substring(match.Value.Length);
                }
                else
                    listUnit.Add(GetOrg().NbEnd.Substring(0, 4));

                //ȡ�ñ��
                listUnit.Add(s.Substring(0, s.IndexOf('!')));
                s = (s.Substring(s.IndexOf('!') + 1)).ToUpper();

                //ȡ�ñ���ID
                listUnit.Add(GetReportID(listUnit[0], listUnit[1]));

                //ȡ�ñ���·��
                listUnit.Add(GetNbPath(listUnit[0]));

                //ȡ���к�
                listUnit.Add(((int)s[0] - 64).ToString());
                s = s.Substring(1);

                //ȡ���к�
                listUnit.Add(s);
                return listUnit;
            }
            catch (Exception ex)
            {
                throw new Exception("��ʽ�����" + ex.Message);
            }
        }

        /// <summary>
        /// ������ʽ��С��Ԫ��ȡ����ֵ
        /// </summary>
        /// <param name="s">��ʽ��С��Ԫ</param>
        /// <returns>��ֵ</returns>
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
        /// �Ӷ��幫ʽ����ֵ
        /// </summary>
        /// <param name="gs">��ʽstr</param>
        /// <returns></returns>
        public static string GetValue(string gs)
        {
            string result = "";
            string left = "";
            string right = "";


            //��ֹ�ʽΪ���С���
            List<string> gsList = SplitChk(gs);
            left = gsList[0];
            right = gsList[2];


            //��ֹ�ʽ�󲿷�
            List<string> leftList = SplitChkUnit(gsList[0]);

            //��ֹ�ʽ�Ҳ���
            List<string> rightList = SplitChkUnit(gsList[2]);

            //ȡ�ù�ʽ�󲿷ָ���Ԫ�ı���ֵ,�������滻
            foreach (string s in leftList)
            {
                left = left.Replace(s, GetUnitValue(s));
            }

            //ȡ�ù�ʽ�в��ָ���Ԫ�ı���ֵ���������滻
            foreach (string s in rightList)
            {
                right = right.Replace(s, GetUnitValue(s));
            }

            //ƴ�ӹ�ʽ
            result = left + gsList[1] + right;

            return result;
        }

        /// <summary>
        /// �Ӷ��幫ʽ����boolֵ
        /// </summary>
        /// <param name="gs"></param>
        /// <returns></returns>
        public static Boolean GetBooleanValue(string gs)
        {
            gs = gs.Replace("<>", "!=");
            return Evaluator.EvaluateToBool(gs);
        }

        /// <summary>
        /// �ӱ������ȡ�ñ�Id�����ڲ�����
        /// </summary>
        /// <param name="nbAlias">�걨����</param>
        /// <param name="tId">�����</param>
        /// <returns>��Id</returns>
        private static string GetReportTid(string nbAlias, string tableAliasId)
        {
            return cfgFile.ReadString(nbAlias, tableAliasId, "");
        }

        /// <summary>
        /// ���걨������ȡ���걨�ļ���ѹ��Ŀ¼�����ڲ�����
        /// </summary>
        /// <param name="nbAlias">�걨����</param>
        /// <returns>·��</returns>
        private static string GetNbPath(string nbAlias)
        {
            return cfgFile.ReadString("path", nbAlias, "");
        }

        /// <summary>
        /// �ӱ�Id��ȡ�ñ���ID�����ڲ�����
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
                throw new Exception("��ȡ����֯���ݳ��������걨���ݰ��ļ���" + ex.Message);
            }
            finally
            {
                sr.Close();
            }
            return result;
        }

        /// <summary>
        /// �ӱ������ȡ�ñ���ID
        /// </summary>
        /// <param name="nbAlias"></param>
        /// <param name="tableAliasID"></param>
        /// <returns></returns>
        public static string GetReportID(string nbAlias, string tableAliasID)
        {
            return GetRepID(nbAlias, GetReportTid(nbAlias, tableAliasID));
        }

        //���ܿ�ʼ
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
        /// ȡ��Ӳ�̺�
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
  ///   ����̷�ΪdrvID��Ӳ�����кţ�ȱʡΪC   
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

        //���ܽ���
        
        /// <summary>
        /// �����ṹOrg
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

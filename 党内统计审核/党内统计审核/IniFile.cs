using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace com.echo.dntj
{
    public abstract class CustomIniFile
    {
        public CustomIniFile(string AFileName)
        {
            FFileName = AFileName;
        }
        private string FFileName;
        public string FileName
        {
            get { return FFileName; }
        }
        public virtual bool SectionExists(string Section)
        {
            List<string> vStrings = new List<string>();
            ReadSections(vStrings);
            return vStrings.Contains(Section);
        }
        public virtual bool ValueExists(string Section, string Ident)
        {
            List<string> vStrings = new List<string>();
            ReadSection(Section, vStrings);
            return vStrings.Contains(Ident);
        }
        public abstract string ReadString(string Section, string Ident, string Default);
        public abstract bool WriteString(string Section, string Ident, string Value);
        public abstract bool ReadSectionValues(string Section, List<string> Strings);
        public abstract bool ReadSection(string Section, List<string> Strings);
        public abstract bool ReadSections(List<string> Strings);
        public abstract bool EraseSection(string Section);
        public abstract bool DeleteKey(string Section, string Ident);
        public abstract bool UpdateFile();
    }

    ///   <summary> 
    ///   �洢����INI�ļ����ࡣ 
    ///   </summary> 
    public class IniFile : CustomIniFile
    {
        [DllImport("kernel32 ")]
        private static extern uint GetPrivateProfileString(
                string lpAppName, //   points   to   section   name   
                string lpKeyName, //   points   to   key   name   
                string lpDefault, //   points   to   default   string   
                byte[] lpReturnedString, //   points   to   destination   buffer   
                uint nSize, //   size   of   destination   buffer   
                string lpFileName   //   points   to   initialization   filename   
        );

        [DllImport("kernel32 ")]
        private static extern bool WritePrivateProfileString(
                string lpAppName, //   pointer   to   section   name   
                string lpKeyName, //   pointer   to   key   name   
                string lpString, //   pointer   to   string   to   add   
                string lpFileName   //   pointer   to   initialization   filename   
        );

        ///   <summary> 
        ///   ����IniFileʵ���� 
        ///   <param   name= "AFileName "> ָ���ļ��� </param> 
        ///   </summary> 
        public IniFile(string AFileName)
            : base(AFileName)
        {
        }

        ///   <summary> 
        ///   ����IniFileʵ���� 
        ///   </summary> 
        ~IniFile()
        {
            UpdateFile();
        }

        ///   <summary> 
        ///   ��ȡ�ַ���ֵ�� 
        ///   <param   name= "Ident "> ָ��������ʶ�� </param> 
        ///   <param   name= "Section "> ָ���������� </param> 
        ///   <param   name= "Default "> ָ��Ĭ��ֵ�� </param> 
        ///   <returns> ���ض�ȡ���ַ����������ȡʧ���򷵻ظ�ֵ�� </returns> 
        ///   </summary> 
        public override string ReadString(string Section, string Ident, string Default)
        {
            byte[] vBuffer = new byte[2048];
            uint vCount = GetPrivateProfileString(Section,
                    Ident, Default, vBuffer, (uint)vBuffer.Length, FileName);
            return Encoding.Default.GetString(vBuffer, 0, (int)vCount);
        }
        ///   <summary> 
        ///   д���ַ���ֵ�� 
        ///   </summary> 
        ///   <param   name= "Section "> ָ���������� </param> 
        ///   <param   name= "Ident "> ָ��������ʶ�� </param> 
        ///   <param   name= "Value "> ��Ҫд��ı���ֵ�� </param> 
        ///   <returns> ����д���Ƿ�ɹ��� </returns> 
        public override bool WriteString(string Section, string Ident, string Value)
        {
            return WritePrivateProfileString(Section, Ident, Value, FileName);
        }

        ///   <summary> 
        ///   �������������ı���(������=ֵ��ʽ)�� 
        ///   </summary> 
        ///   <param   name= "Section "> ָ�������ʶ�� </param> 
        ///   <param   name= "Strings "> ����������� </param> 
        ///   <returns> ���ض�ȡ�Ƿ�ɹ��� </returns> 
        public override bool ReadSectionValues(string Section, List<string> Strings)
        {
            List<string> vIdentList = new List<string>();
            if (!ReadSection(Section, vIdentList)) return false;
            foreach (string vIdent in vIdentList)
                Strings.Add(string.Format("{0}={1} ", vIdent, ReadString(Section, vIdent, " ")));
            return true;
        }

        ///   <summary> 
        ///   ��ȡ����������б� 
        ///   </summary> 
        ///   <param   name= "Section "> ָ���������� </param> 
        ///   <param   name= "Strings "> ָ������б� </param> 
        ///   <returns> ���ػ�ȡ�Ƿ�ɹ��� </returns> 
        public override bool ReadSection(string Section, List<string> Strings)
        {
            byte[] vBuffer = new byte[16384];
            uint vLength = GetPrivateProfileString(Section, null, null, vBuffer,
                    (uint)vBuffer.Length, FileName);
            int j = 0;
            for (int i = 0; i < vLength; i++)
                if (vBuffer[i] == 0)
                {
                    Strings.Add(Encoding.Default.GetString(vBuffer, j, i - j));
                    j = i + 1;
                }
            return true;
        }

        ///   <summary> 
        ///   ��ȡ�������б� 
        ///   </summary> 
        ///   <param   name= "Strings "> ָ������б� </param> 
        ///   <returns> </returns> 
        public override bool ReadSections(List<string> Strings)
        {
            byte[] vBuffer = new byte[16384];
            uint vLength = GetPrivateProfileString(null, null, null, vBuffer,
                    (uint)vBuffer.Length, FileName);
            int j = 0;
            for (int i = 0; i < vLength; i++)
                if (vBuffer[i] == 0)
                {
                    Strings.Add(Encoding.Default.GetString(vBuffer, j, i - j));
                    j = i + 1;
                }
            return true;
        }

        ///   <summary> 
        ///   ɾ��ָ������ 
        ///   </summary> 
        ///   <param   name= "Section "> ָ���������� </param> 
        ///   <returns> ����ɾ���Ƿ�ɹ��� </returns> 
        public override bool EraseSection(string Section)
        {
            return WritePrivateProfileString(Section, null, null, FileName);
        }

        ///   <summary> 
        ///   ɾ��ָ�������� 
        ///   </summary> 
        ///   <param   name= "Section "> ������������ </param> 
        ///   <param   name= "Ident "> ������ʶ�� </param> 
        ///   <returns> ����ɾ���Ƿ�ɹ��� </returns> 
        public override bool DeleteKey(string Section, string Ident)
        {
            return WritePrivateProfileString(Section, Ident, null, FileName);
        }

        ///   <summary> 
        ///   �����ļ��� 
        ///   </summary> 
        ///   <returns> ���ظ����Ƿ�ɹ��� </returns> 
        public override bool UpdateFile()
        {
            return WritePrivateProfileString(null, null, null, FileName);
        }
    }

}

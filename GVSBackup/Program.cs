using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace GVSBackup
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Options_save ops = new Options_save();

            ops.FilePath = "config.xml";

            int compareCode;
            int FileCount;
            //int QuantityOfDirectory;
            //int DelDirCount;
            //int DirCount;

            if (!File.Exists(ops.LogPath))
            {
                ops.LogPath = "log.txt";
                //File.Create(ops.LogPath);
            }

            ops.ReadConfig();

            if (!File.Exists(ops.FilePath))
            {   
                MessageBox.Show("Конфигурационный файл отсутствует либо утрачен, внесите новые данные");
                
                Form_Option dlg = new Form_Option();
                dlg.ShowDialog();                
            }

            if ((!Directory.Exists(ops.SDPBackupPath))||(!Directory.Exists(ops.OracleBackupPath))||(!Directory.Exists(ops.SudimostBackupPath)))
            {
                MessageBox.Show("Ошибка доступа к каталогу с резервными копиями, проверьте пути и права доступа, подробности в лог файле");

                Form_Option dlg = new Form_Option();
                dlg.LoadConfig();
                dlg.ShowDialog();
            }

            
            compareCode = int.Parse(ops.CountOfDays);//Насколько старая копия допустима
            FileCount = int.Parse(ops.CountOfFiles);//Сколько копий минимум должно хранится
            //DirectoryInfo DirInf = new DirectoryInfo(ops.SDPBackupPath);
            //List<string> DirList = new List<string>;
            try
            {
                string[] SDPDirectories = null;
                SDPDirectories = Directory.GetDirectories(ops.SDPBackupPath); 
                //QuantityOfDirectory = 0;

                foreach (string dir in SDPDirectories)
                {
                    string[] DelDirectories = null;
                    DelDirectories = Directory.GetDirectories(ops.SDPBackupPath);

                    if (((DateTime.Now.DayOfYear - Directory.GetCreationTime(dir).DayOfYear) > compareCode) && (DelDirectories.Count() > FileCount))
                    {
                        Directory.Delete(dir, true);
                    }
                }
            }
            catch
            {
                StreamWriter sw = File.AppendText(ops.LogPath);
                sw.WriteLine(DateTime.Now);
                sw.WriteLine("Каталог с резервными копиями ПИ <<СДП>> отсутствует или доступ к нему запрещён, укажите новый каталог");//В случе ошибки будет показанно это сообщение.
                sw.Close();
            }
            /*
            DelDirCount = DirList.Count();
            DirCount = SDPDirectories.Count();
            
            foreach (string dir in DirList)
            { 
              if(DirCount - DelDirCount > FileCount)
              {
                  Directory.Delete(dir, true);
              }
            }
            
            */
            try
            {
                string[] ORADirectories = null;
                ORADirectories = Directory.GetDirectories(ops.OracleBackupPath); 
                foreach (string dir in ORADirectories)
                {
                    string[] DelDirectories = null;
                    DelDirectories = Directory.GetDirectories(ops.OracleBackupPath);

                    if (((DateTime.Now.DayOfYear - Directory.GetCreationTime(dir).DayOfYear) > compareCode) && (DelDirectories.Count() > FileCount))
                    {
                        Directory.Delete(dir, true);
                    }
                }
            }
            catch
            {
                StreamWriter sw = File.AppendText(ops.LogPath);
                sw.WriteLine(DateTime.Now);
                sw.WriteLine("Каталог с резервными копиями ORACLE отсутствует или доступ к нему запрещён, укажите новый каталог");//В случе ошибки будет показанно это сообщение.
                sw.Close();
            }

            try
            {
                string[] SUDDirectories = null;
                SUDDirectories = Directory.GetDirectories(ops.SudimostBackupPath);
                foreach (string dir in SUDDirectories)
                {
                    string[] DelDirectories = null;
                    DelDirectories = Directory.GetDirectories(ops.SudimostBackupPath);

                    if (((DateTime.Now.DayOfYear - Directory.GetCreationTime(dir).DayOfYear) > compareCode) && (DelDirectories.Count() > FileCount))
                    {
                        Directory.Delete(dir, true);
                    }
                }
            }
            catch
            {
                StreamWriter sw = File.AppendText(ops.LogPath);
                sw.WriteLine(DateTime.Now);
                sw.WriteLine("Каталог с резервными копиями ПИ <<Судимость>> отсутствует или доступ к нему запрещён, укажите новый каталог");//В случе ошибки будет показанно это сообщение.
                sw.Close();
            }
        }
    }
}

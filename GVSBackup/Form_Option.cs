using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GVSBackup//Закомментировать.
{
    public partial class Form_Option : Form
    {
        public Form_Option()
        {
            InitializeComponent();
        }

        public void LoadConfig()
        {
            Options_save ops = new Options_save();
            ops.ReadConfig();
            textBoxSDP.Text = ops.SDPBackupPath;
            textBoxORA.Text = ops.OracleBackupPath;
            textBoxSUD.Text = ops.SudimostBackupPath;
            NumberOfDays.Value = int.Parse(ops.CountOfDays);
            NumberOfStoredFiles.Value = int.Parse(ops.CountOfFiles);
        }

        private void buttonSDP_Click(object sender, EventArgs e)
        {
            //string listAddres = "";//Пустая, незадействованная сейчас переменная, на случай, если хранить настройки буду не в самой форме.
            FolderBrowserDialog fdl = new FolderBrowserDialog();//Обявляем новый (new) экземпляр системного класса OpenFileDialog - fdl
            if (fdl.ShowDialog() == System.Windows.Forms.DialogResult.OK)//Если (if) метод (.ShowDialog()) экземпляра (fdl) ==(оператор сравнени на равенство) System.Windows.Forms.DialogResult.OK - возвращаемое значение диалогового окна - ок .....
            {
                textBoxSDP.Text = fdl.SelectedPath; //.....то, в PathTextBox(объект).Text(свойство получает или задаёт текущий текст в данном элементе) = (записываем) fdl(объект).FileName(свойство возвращает или задаёт имя файла выбранное в диалоговом окне)
            }
        }

        private void buttonORA_Click(object sender, EventArgs e)
        {
            //string listAddres = "";//Пустая, незадействованная сейчас переменная, на случай, если хранить настройки буду не в самой форме.
            FolderBrowserDialog fdl = new FolderBrowserDialog();//Обявляем новый (new) экземпляр системного класса OpenFileDialog - fdl
            if (fdl.ShowDialog() == System.Windows.Forms.DialogResult.OK)//Если (if) метод (.ShowDialog()) экземпляра (fdl) ==(оператор сравнени на равенство) System.Windows.Forms.DialogResult.OK - возвращаемое значение диалогового окна - ок .....
            {
                textBoxORA.Text = fdl.SelectedPath; //.....то, в PathTextBox(объект).Text(свойство получает или задаёт текущий текст в данном элементе) = (записываем) fdl(объект).FileName(свойство возвращает или задаёт имя файла выбранное в диалоговом окне)
            }

        }

        private void buttonSUD_Click(object sender, EventArgs e)
        {
            //string listAddres = "";//Пустая, незадействованная сейчас переменная, на случай, если хранить настройки буду не в самой форме.
            FolderBrowserDialog fdl = new FolderBrowserDialog();//Обявляем новый (new) экземпляр системного класса OpenFileDialog - fdl
            if (fdl.ShowDialog() == System.Windows.Forms.DialogResult.OK)//Если (if) метод (.ShowDialog()) экземпляра (fdl) ==(оператор сравнени на равенство) System.Windows.Forms.DialogResult.OK - возвращаемое значение диалогового окна - ок .....
            {
                textBoxSUD.Text = fdl.SelectedPath; //.....то, в PathTextBox(объект).Text(свойство получает или задаёт текущий текст в данном элементе) = (записываем) fdl(объект).FileName(свойство возвращает или задаёт имя файла выбранное в диалоговом окне)
            }
        }

        private void Applay_Click(object sender, EventArgs e)
        {
            Options_save ops = new Options_save();//Объявляем(посредством ключегого слова new) экземпляр созданного нами класса Options_save, ops.
            ops.FilePath = "config.xml";
            ops.LogPath = "log.txt";
            ops.OracleBackupPath = textBoxORA.Text;
            ops.SDPBackupPath = textBoxSDP.Text;
            ops.SudimostBackupPath = textBoxSUD.Text;
            ops.CountOfFiles = NumberOfStoredFiles.Value.ToString();
            ops.CountOfDays = NumberOfDays.Value.ToString();

            ops.saveConfig(ops.FilePath);//Применяем метод saveConfig() класса Options_save через экземпляр даннрого класса ops на текстовое поле(свойство .Text) нашего элемента PathTextBox.
            Close();//Закрываем нашу форму, посредством метода Close();
        }

        private void Discard_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

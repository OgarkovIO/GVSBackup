using System.Xml;
using System.Xml.Linq;
using System.Text;
using System.IO;
using System;

namespace GVSBackup//Закомментировать
{
    class Options_save //Создаём класс для сохранения данных  в конфиг файл.
    {
        private string _filePath;//Создаём приватную переменную для хранения данных о месте размещения файла.

        private string _logPath;//Создаём приватную переменную для хранения данных о месте размещения файла - лога.

        private string _sdpBackupPath;

        private string _sudimostBackupPath;

        private string _oracleBackupPath;

        private string _countOfFiles;

        private string _countOfDays;

        //private string _mounthBackupPath;

        public Options_save()//Создаём публичный конструктор класса
        {
            _filePath = "";//Содержащий команду на присвоение переменной  _filePath пустоно значения при инициализации экземпляра класса.
            _logPath = "";//Ок
            //_mounthBackupPath = "";
            _oracleBackupPath = "";
            _sdpBackupPath = "";
            _sudimostBackupPath = "";
            _countOfFiles = "";
            _countOfDays = "";
        }

        public void ReadConfig()//Создаём публичный метод для чтения конфигурационного XML файла.
        {
            //читаем данные из конфигурационного файла
            try//Добавляем обработчик исключений в котором вписываем запускаемый код.
            {
                XDocument xml = new XDocument();//Объявляем новый экземпляр класса XDocument - xml
                xml = XDocument.Load("config.xml");//Загружаем наш конфиг файл из папки приложения.
                string FilePath = xml.Element("config").Element("FilePath").Value;//Объявляем переменную типа string - FilePath куда запишем данные из конфиг файла, в.т.ч, из элемента FilePath вытаскиваем текстовое содержимое (.Value) и вбрасываем в переменную FilePath
                string LogPath = xml.Element("config").Element("LogPath").Value;
                //string MounthBackupPath = xml.Element("config").Element("MounthBackupPath").Value;
                string OracleBackupPath = xml.Element("config").Element("OracleBackupPath").Value;
                string SDPBackupPath = xml.Element("config").Element("SDPBackupPath").Value;
                string SudimostBackupPath = xml.Element("config").Element("SudimostBackupPath").Value;
                string CountOfFiles = xml.Element("config").Element("CountOfFiles").Value;//Объявляем переменную типа string - FilePath куда запишем данные из конфиг файла, в.т.ч, из элемента FilePath вытаскиваем текстовое содержимое (.Value) и вбрасываем в переменную FilePath
                string CountOfDays = xml.Element("config").Element("CountOfDays").Value;//Объявляем переменную типа string - FilePath куда запишем данные из конфиг файла, в.т.ч, из элемента FilePath вытаскиваем текстовое содержимое (.Value) и вбрасываем в переменную FilePath

                _filePath = FilePath;//Заносим значение в приватное поле для работы внутри класса
                _logPath = LogPath;
                _oracleBackupPath = OracleBackupPath;
                _sdpBackupPath = SDPBackupPath;
                _sudimostBackupPath = SudimostBackupPath;
                _countOfFiles = CountOfFiles;
                _countOfDays = CountOfDays;
            }
            catch//Перехватываем исключение и ......
            {
                StreamWriter sw = File.AppendText(_logPath);
                sw.WriteLine(DateTime.Now);
                sw.WriteLine("Не удалось загрузить настройки из файла config.xml");//В случе ошибки будет показанно это сообщение.
                sw.Close();
            }
        }

        public void saveConfig(string FilePath)//Создаём публичный метод для сохранения данных в конфиг файл, входным параметром которого будет строчная переменная FilePath.
        {
            XmlTextWriter textWriter = new XmlTextWriter("config.xml", null);//Объявляем новый экземпляр класса XmlTextWriter, наз. textWriter
            textWriter.Formatting = Formatting.Indented;//Задаём отступы всех элементо XML файла, по умолчанию - 2.

            textWriter.WriteStartDocument();//Записываем начало XML документа с номером версии <1.0>
            textWriter.WriteStartElement("config");//Открываем XML элемент с названием - <config>

            textWriter.WriteStartElement("FilePath");//Открываем внутри незакрытого жлемента <config>, элемент <FilePath>
            textWriter.WriteString(FilePath);//Записываем значение переменной FilePath в открытый элемент.
            textWriter.WriteEndElement();//Закрываем Элемент <FilePath>

            textWriter.WriteStartElement("LogPath");//Открываем внутри незакрытого жлемента <config>, элемент <FilePath>
            textWriter.WriteString(LogPath);//Записываем значение переменной FilePath в открытый элемент.
            textWriter.WriteEndElement();//Закрываем Элемент <FilePath>

            textWriter.WriteStartElement("OracleBackupPath");//Открываем внутри незакрытого жлемента <config>, элемент <FilePath>
            textWriter.WriteString(OracleBackupPath);//Записываем значение переменной FilePath в открытый элемент.
            textWriter.WriteEndElement();//Закрываем Элемент <FilePath>

            textWriter.WriteStartElement("SDPBackupPath");//Открываем внутри незакрытого жлемента <config>, элемент <FilePath>
            textWriter.WriteString(SDPBackupPath);//Записываем значение переменной FilePath в открытый элемент.
            textWriter.WriteEndElement();//Закрываем Элемент <FilePath>

            textWriter.WriteStartElement("SudimostBackupPath");//Открываем внутри незакрытого жлемента <config>, элемент <FilePath>
            textWriter.WriteString(SudimostBackupPath);//Записываем значение переменной FilePath в открытый элемент.
            textWriter.WriteEndElement();//Закрываем Элемент <FilePath>

            textWriter.WriteStartElement("CountOfFiles");//Открываем внутри незакрытого жлемента <config>, элемент <FilePath>
            textWriter.WriteString(CountOfFiles);//Записываем значение переменной FilePath в открытый элемент.
            textWriter.WriteEndElement();//Закрываем Элемент <FilePath>

            textWriter.WriteStartElement("CountOfDays");//Открываем внутри незакрытого жлемента <config>, элемент <FilePath>
            textWriter.WriteString(CountOfDays);//Записываем значение переменной FilePath в открытый элемент.
            textWriter.WriteEndElement();//Закрываем Элемент <FilePath>

            textWriter.WriteEndDocument();//Закрываем все открытые элементы XML(<config>)
            textWriter.Close();//Закрываем файл, сохраняем изменения.

            _filePath = FilePath;//Переменной FilePath присвоенно значение приватного поля _filePath
            _logPath = LogPath;
            _oracleBackupPath = OracleBackupPath;
            _sdpBackupPath = SDPBackupPath;
            _sudimostBackupPath = SudimostBackupPath;
            _countOfFiles = CountOfFiles;
            _countOfDays = CountOfDays;
        }

        public string FilePath    //Создаём свойство которое даёт возможность считывать и записывать в поле _FilePath значения.
        {
            get { return _filePath; }  //get - Возвращает значение _FilePath, return - принудительно завершает выполнение и возвращает значение
            set { _filePath = value; } //set - Присваевает значеия, value - хранит значение.
        }

        public string LogPath    //Создаём свойство которое даёт возможность считывать и записывать в поле _FilePath значения.
        {
            get { return _logPath; }  //get - Возвращает значение _FilePath, return - принудительно завершает выполнение и возвращает значение
            set { _logPath = value; } //set - Присваевает значеия, value - хранит значение.
        }


        public string OracleBackupPath 
        { 
            get { return _oracleBackupPath; }  //get - Возвращает значение _FilePath, return - принудительно завершает выполнение и возвращает значение
            set { _oracleBackupPath = value; } //set - Присваевает значеия, value - хранит значение.
        }

        public string SDPBackupPath
        {
            get { return _sdpBackupPath; }  //get - Возвращает значение _FilePath, return - принудительно завершает выполнение и возвращает значение
            set { _sdpBackupPath = value; } //set - Присваевает значеия, value - хранит значение.
        }

        public string SudimostBackupPath
        {
            get { return _sudimostBackupPath; }  //get - Возвращает значение _FilePath, return - принудительно завершает выполнение и возвращает значение
            set { _sudimostBackupPath = value; } //set - Присваевает значеия, value - хранит значение.
        }

        public string CountOfFiles    //Создаём свойство которое даёт возможность считывать и записывать в поле _FilePath значения.
        {
            get { return _countOfFiles; }  //get - Возвращает значение _FilePath, return - принудительно завершает выполнение и возвращает значение
            set { _countOfFiles = value; } //set - Присваевает значеия, value - хранит значение.
        }

        public string CountOfDays    //Создаём свойство которое даёт возможность считывать и записывать в поле _FilePath значения.
        {
            get { return _countOfDays; }  //get - Возвращает значение _FilePath, return - принудительно завершает выполнение и возвращает значение
            set { _countOfDays = value; } //set - Присваевает значеия, value - хранит значение.
        }
    }
}

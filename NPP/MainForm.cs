using NPP.Model;
using NPP.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPP
{
    public partial class MainForm : Form
    {
        private IRepository _repository;
        private string _csvFile = "papercut-print-log-all-time.csv";

        public MainForm(IRepository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            string FileUtf8 = "PrintLogUTF8.txt";
            ConvertWinCp2Utf8(_csvFile, FileUtf8);
            LoadFile2Db(FileUtf8);

        }

        private void LoadFile2Db(string fileUtf8)
        {
            try
            {
                using (StreamReader sr = new StreamReader(fileUtf8))
                {
                    string line;
                    int counter = 0;
                    while((line=sr.ReadLine())!=null)
                    {
                        counter++;
                        if(counter>2)
                        {
                            AddLine2Db(line);
                        }
                    }
                }
                File.Delete(fileUtf8);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AddLine2Db(string line)
        {
            string[] lineSplit = line.Split(',');
            try
            {
                DateTime fieldDate = Convert.ToDateTime(lineSplit[0]);
                string uid = lineSplit[1];
                int pages = int.Parse(lineSplit[2]);
                int copies = int.Parse(lineSplit[3]);
                string printer = lineSplit[4];
                string document = lineSplit[5];
                string computer = lineSplit[6];
                string paperSize = lineSplit[7];
                string printLanguage = lineSplit[8];
                string height = lineSplit[9];
                string width = lineSplit[10];
                bool duplex = (lineSplit[11].Equals("DUPLEX")) ? true : false;
                bool grayscale = (lineSplit[12].Equals("GRAYSCALE")) ? true : false;
                string documentSize = lineSplit[13];

                User user = _repository.GetUserByUid(uid);
                if (user == null)
                {
                    user = new User { Uid = uid };
                }

                Printer printerObj = _repository.GetPrinterByName(printer);
                if (printerObj == null)
                {
                    printerObj = new Printer { Name = printer };
                }

                Computer computerrObj = _repository.GetComputerByName(computer);
                if (computerrObj == null)
                {
                    computerrObj = new Computer { Name = computer };
                }

                PrintJob prinJob = new PrintJob(fieldDate, user, pages, copies, printerObj, document, computerrObj, paperSize,
                    printLanguage, height, width, duplex, grayscale, documentSize);
            }
            catch (Exception)
            {
                throw;
            }
            //_repository.AddComputer(new Model.Computer)
        }

        private void ConvertWinCp2Utf8(string csvFile, string fileUtf8)
        {
            try
            {
                using (StreamReader sr = new StreamReader(csvFile, Encoding.GetEncoding("windows-1250")))
                {
                    using (StreamWriter sw = new StreamWriter(fileUtf8, false, Encoding.GetEncoding("UTF-8")))
                    {
                        sw.Write(sr.ReadToEnd());
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}

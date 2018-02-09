using NPP.Aspects;
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
        private string _csvFile = "../../Files/papercut-print-log-all-time.csv";

        public MainForm(IRepository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            string FileUtf8 = "../../Files/PrintLogUTF8.txt";
            lblStatus.ForeColor = Color.Red;
            lblStatus.Text = "Konvertiram ulaz u UTF-8...";
            ConvertWinCp2Utf8(_csvFile, FileUtf8);
            lblStatus.Text = "Učitavam podatke iz datoteke u bazu...";
            LoadFile2Db(FileUtf8);
            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = "Svi podaci su učitani!";
        }

        [TimingAspect]
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
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace, "Neš' ne radi kako bi trebalo...!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [LogAspect]
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
                string document = lineSplit[5].Trim(new char[] { '"' });
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
                    _repository.AddUser(user);
                }

                Printer printerObj = _repository.GetPrinterByName(printer);
                if (printerObj == null)
                {
                    printerObj = new Printer { Name = printer };
                    _repository.AddPrinter(printerObj);
                }

                Computer computerObj = _repository.GetComputerByName(computer);
                if (computerObj == null)
                {
                    computerObj = new Computer { Name = computer };
                    _repository.AddComputer(computerObj);
                }

                PrintJob printJob = new PrintJob(user, pages, copies, printerObj, document, computerObj, paperSize,
                    printLanguage, height, width, duplex, grayscale, documentSize);

                _repository.AddPrintJob(printJob);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace, "Neš' ne radi kako bi trebalo...!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [LogAspect]
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
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace, "Neš' ne radi kako bi trebalo...!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

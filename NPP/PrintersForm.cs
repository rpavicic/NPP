using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPP.Model;
using NPP.Repository;
using NPP.Utils;

namespace NPP
{
    public partial class PrintersForm : Form
    {
        private IRepository _repository;

        public PrintersForm(IRepository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void PrintersForm_Load(object sender, EventArgs e)
        {
            dgViewPrinters.DataSource = _repository.GetAllPrinters();
            dgViewPrinters.Columns[0].ReadOnly = true;
        }

        private void dgViewPrinters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Printer printer = new Printer {
                Id = (int)dgViewPrinters.Rows[e.RowIndex].Cells[0].Value,
                Name = dgViewPrinters.Rows[e.RowIndex].Cells[0].Value.ToString() };
            _repository.EditPrinter(printer);
            Logger.Instance.Info($"Successfully edited printer {printer.Name}.");
        }
    }
}

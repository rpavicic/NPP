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
    public partial class ComputersForm : Form
    {
        private IRepository _repository;

        public ComputersForm(IRepository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void ComputersForm_Load(object sender, EventArgs e)
        {
            LoadComputersdgView();
        }

        private void LoadComputersdgView()
        {
            dgViewComputers.DataSource = _repository.GetAllComputers();
            dgViewComputers.Columns[0].ReadOnly = true;
        }

        private void dgViewComputers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Computer comp = new Computer {
                Id = (int)dgViewComputers.Rows[e.RowIndex].Cells[0].Value,
                Name = dgViewComputers.Rows[e.RowIndex].Cells[1].Value.ToString() };
            _repository.EditComputer(comp);
            Logger.Instance.Info($"Successfully edited computer {comp.Name}.");
        }
    }
}

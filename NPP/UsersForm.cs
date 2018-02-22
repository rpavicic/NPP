using NPP.Model;
using NPP.Repository;
using NPP.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPP
{
    public partial class UsersForm : Form
    {
        private IRepository _repository;

        public UsersForm(IRepository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadUsersdgView();
        }

        private void LoadUsersdgView()
        {
            dgViewUsers.DataSource = _repository.GetAllUsers();
            dgViewUsers.Columns[0].ReadOnly = true;
            dgViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgViewUsers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            User user = new User {
                Id = (int)dgViewUsers.Rows[e.RowIndex].Cells[0].Value,
                Uid = dgViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString() };
            _repository.EditUser(user);
            Logger.Instance.Info($"Successfully edited user {user.Uid}.");
        }
    }
}

using NPP.Repository;
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
    public partial class MainForm : Form
    {
        private IRepository _repository;

        public MainForm(IRepository repository)
        {
            InitializeComponent();
            _repository = repository;
        }
    }
}

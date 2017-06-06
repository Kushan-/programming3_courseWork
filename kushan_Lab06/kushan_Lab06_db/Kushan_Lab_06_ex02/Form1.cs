using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace Kushan_Lab_06_ex02
{
    public partial class Form1 : Form
    {
        private kushan_Lab06_db.BaseballEntities dbContext = new kushan_Lab06_db.BaseballEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void baseBall_dbView_Load(object sender, EventArgs e)
        {
            //dbContext.Players.Load();
            // specify DataSource for authorBindingSource
            playerBindingSource.DataSource = dbContext.Players.Local;
        }
    }
}

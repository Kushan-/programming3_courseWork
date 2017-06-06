using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace kushan_Lab06_ex01
{
    public partial class baseBall_dbView : Form
    {

        private kushan_Lab06_db.BaseballEntities dbContext = new kushan_Lab06_db.BaseballEntities();
        public baseBall_dbView()
        {
            InitializeComponent();
        }

        private void baseBall_dbView_Load(object sender, EventArgs e)
        {
            dbContext.Players.Load();
            // specify DataSource for authorBindingSource
            playerBindingSource.DataSource = dbContext.Players.Local;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerBindingSource.DataSource = (from player in dbContext.Players
                                              where player.LastName.Contains(textBox1.Text)
                                              orderby player.LastName select player).ToList();
                                              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playerBindingSource.DataSource = (from player in dbContext.Players
                                              
                                              orderby player.LastName
                                              select player).ToList();
        }
    }
}

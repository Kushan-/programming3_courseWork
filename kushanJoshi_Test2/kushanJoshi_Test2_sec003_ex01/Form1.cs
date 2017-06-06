using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using baseballLibrary;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace kushanJoshi_Test2_sec003_ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private baseballLibrary.BaseballEntities dbcontext = new baseballLibrary.BaseballEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            dbcontext.Players.Load();
            
            playerBindingSource.DataSource = dbcontext.Players.Local;
            //PlayersBindingSource.DataSource = dbcontext.Players.Local;
        }

        private void baseballEntitiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate(); // validate the input fields                       
            playerBindingSource.EndEdit(); // complete current edit, if any

            // try to save changes
            try
            {
                dbcontext.SaveChanges(); // write changes to database file
            }
            catch (DbEntityValidationException)
            {
                MessageBox.Show("FirstName and LastName must contain values",
                   "Entity Validation Exception");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = from player in dbcontext.Players
                        where player.FirstName == textBox1.Text
                        select player;

            playerBindingSource.DataSource = query.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbcontext.Players.Load();
            playerBindingSource.DataSource = dbcontext.Players.Local;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dbcontext.Players.OrderBy(Player => Player.FirstName).Load();

            playerBindingSource.DataSource = dbcontext.Players.Local;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            decimal minimum = Convert.ToDecimal(textBox2.Text);
            decimal maximum = Convert.ToDecimal(textBox3.Text);

            var queryRange = from player in dbcontext.Players
                             where player.BattingAverage >= minimum && player.BattingAverage <= maximum
                             select player;
            playerBindingSource.DataSource = queryRange.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // var queryRange = from player in dbcontext.Players where player.BattingAverage.Max() select player;
        }
    }
}

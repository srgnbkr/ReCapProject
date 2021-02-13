using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CarManager _carManager = new CarManager(new EfCarDal());
        private void LoadCars()
        {
            dataGridView1.DataSource = _carManager.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCars();
        }
    }
}

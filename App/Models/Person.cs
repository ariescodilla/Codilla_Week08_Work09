using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Models
{
    public partial class Person : Form
    {
        public Person()
        {
            InitializeComponent();
        }
    }

    public abstract class Person
    {
        protected int id;
        public string Lastname;
        public string Firstname;
        public string Middlename;
        public string Address;
        public DateTime Birthdate;
        public string Gender;

        public void setID(int id)
        {
            this.id = id;
        }

        public string GetFullName()
    }
}

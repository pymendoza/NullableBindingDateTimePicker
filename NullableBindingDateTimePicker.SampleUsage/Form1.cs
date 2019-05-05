using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NullableBindingDateTimePicker.SampleUsage
{
    public partial class Form1 : Form
    {
        public Person Person = new Person();

        public Form1()
        {
            InitializeComponent();

            nullableBindingDateTimePicker1.DataBindings.Add("Value", Person, "Birthdate", true, DataSourceUpdateMode.OnPropertyChanged);
            label2.DataBindings.Add("Text", Person, "Birthdate");
        }
    }
}

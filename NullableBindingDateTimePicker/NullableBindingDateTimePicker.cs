using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NullableBindingDateTimePicker
{
    [ToolboxBitmap(typeof(DateTimePicker))]
    public class NullableBindingDateTimePicker : DateTimePicker
    {
        private Container components = null;

        public NullableBindingDateTimePicker()
        {
            InitializeComponent();
            ShowCheckBox = true;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                   components.Dispose(); 
                }
            }

            base.Dispose(disposing);
        }

        [Bindable(true), Browsable(false)]
        public new object Value
        {
            get
            {
                if (Checked)
                {
                    return base.Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value == null || Convert.IsDBNull(value))
                {
                    Checked = false;
                }
                else
                {
                    Checked = true;
                    base.Value = Convert.ToDateTime(value);
                }
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Value = MinDate;
                Value = DateTime.Now;
                Value = null;
            }
        }

        private void InitializeComponent()
        {
            components = new Container();
        }
    }
}
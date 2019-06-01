using System;
using System.Windows.Forms;

namespace NullableBindingDateTimePicker
{
    public class DateTimePickerDataGridViewCell : DataGridViewTextBoxCell
    {
        public DateTimePickerDataGridViewCell()
            : base()
        {
            // Use the short date format.
            this.Style.Format = "d";
        }

        public override void InitializeEditingControl(int rowIndex, object
            initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            // Set the value of the editing control to the current cell value.
            base.InitializeEditingControl(rowIndex, initialFormattedValue,
                dataGridViewCellStyle);
            DateTimePickerEditingControl ctl =
                DataGridView.EditingControl as DateTimePickerEditingControl;

            ctl.ShowCheckBox = true;

            object val = null;
            try
            {
                val = this.Value;
            }
            catch (Exception ex)
            {
                return;
            }

            if (val != null)
            {
                ctl.Value = (DateTime)val;
            }
            else
            {
                ctl.Checked = false;
            }
        }

        public override Type EditType
        {
            get
            {
                // Return the type of the editing contol that DateTimePickerDataGridViewCell uses.
                return typeof(DateTimePickerEditingControl);
            }
        }

        public override Type ValueType
        {
            get
            {
                // Return the type of the value that CalendarCell contains.
                return typeof(DateTime?);
            }
        }

        public override object DefaultNewRowValue
        {
            get
            {
                return null;
            }
        }
    }
}
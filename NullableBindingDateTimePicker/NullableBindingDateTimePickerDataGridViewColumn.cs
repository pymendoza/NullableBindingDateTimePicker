using System;
using System.Windows.Forms;

namespace NullableBindingDateTimePicker
{
    /// <summary>
    /// Based on https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-host-controls-in-windows-forms-datagridview-cells
    /// </summary>
    public class NullableBindingDateTimePickerDataGridViewColumn : DataGridViewColumn
    {
        public NullableBindingDateTimePickerDataGridViewColumn()
            : base(new DateTimePickerDataGridViewCell())
        {
        }

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(DateTimePickerDataGridViewCell)))
                {
                    throw new InvalidCastException("Must be a DateTimePickerDataGridViewCell");
                }

                base.CellTemplate = value;
            }
        }
    }
}
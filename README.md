# NullableBindingDateTimePicker
Custom datetimepicker control for Windows Forms that allows databinding to a nullable DateTime field

How to use:

1. From Visual Studio Toolbox, drag and drop custom control to your form:

<img src="https://raw.githubusercontent.com/pymendoza/NullableBindingDateTimePicker/master/Screenshots/toolbox-capture.JPG"/>

2. Set the databindings to the Value property
<pre>
<code>
public partial class Form1 : Form
{
    public Person Person = new Person();

    public Form1()
    {
        InitializeComponent();

        nullableBindingDateTimePicker1.DataBindings
            .Add("Value", Person, "Birthdate", true, DataSourceUpdateMode.OnPropertyChanged);
        
        // Show underlying bound field value
        label2.DataBindings.Add("Text", Person, "Birthdate");
    }
}

public class Person
{
    public DateTime? BirthDate { get; set; }
}
</code>
</pre>

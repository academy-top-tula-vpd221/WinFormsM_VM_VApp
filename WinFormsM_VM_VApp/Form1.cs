namespace WinFormsM_VM_VApp
{
    public partial class Form1 : Form
    {
        Employee employee = new() { Name = "Bob", Age = 25 };
        public Form1()
        {
            InitializeComponent();

            textBox1.DataBindings.Add(new("Text", employee, "Name", false, DataSourceUpdateMode.OnPropertyChanged));
            label1.DataBindings.Add(new("Text", employee, "Name"));

            numericUpDown1.DataBindings.Add(new("Value", employee, "Age", false, DataSourceUpdateMode.OnPropertyChanged));
            label2.DataBindings.Add(new("Text", employee, "Age"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(employee.Name);
        }
    }
}
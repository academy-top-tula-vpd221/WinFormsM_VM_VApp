namespace WinFormsM_VM_VApp
{
    public partial class Form1 : Form
    {
        //Employee employee = new() { Name = "Bob", Age = 25 };
        public Form1()
        {
            InitializeComponent();

            this.DataContext = new MainViewModel();

            employesListBox.DataBindings.Add(new("DataSource", DataContext, "Employes", false, DataSourceUpdateMode.OnPropertyChanged));
            employesListBox.ValueMember = "Id";
            employesListBox.DisplayMember = "Name";
            employesListBox.DataBindings.Add(new("SelectedValue", DataContext, "SelectedId", false, DataSourceUpdateMode.OnPropertyChanged));

            nameTextBox.DataBindings.Add(new("Text", DataContext, "Name", false, DataSourceUpdateMode.OnPropertyChanged));
            birthDayPicker.DataBindings.Add(new("Value", DataContext, "BirthDay", false, DataSourceUpdateMode.OnPropertyChanged));
            addButton.DataBindings.Add(new("Command", DataContext, "AddCommand", true));
            removeButton.DataBindings.Add(new("Command", DataContext, "RemoveCommand", true));
            removeButton.DataBindings.Add(new("CommandParameter", employesListBox, "SelectedValue", true));
            editButton.DataBindings.Add(new("Command", DataContext, "EditCommand", true));
            editButton.DataBindings.Add(new("CommandParameter", employesListBox, "SelectedValue", true));
            //textBox1.DataBindings.Add(new("Text", this.DataContext, "Name", false, DataSourceUpdateMode.OnPropertyChanged));
            //label1.DataBindings.Add(new("Text", this.DataContext, "Name"));

            //numericUpDown1.DataBindings.Add(new("Value", this.DataContext, "Age", false, DataSourceUpdateMode.OnPropertyChanged));
            //label2.DataBindings.Add(new("Text", this.DataContext, "Age"));


        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show(employee.Name);
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    employee.Name = "Tom";
        //    employee.Age = 41;
        //}
    }
}
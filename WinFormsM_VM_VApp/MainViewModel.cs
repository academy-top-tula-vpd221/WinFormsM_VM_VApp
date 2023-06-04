using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WinFormsM_VM_VApp
{
    public class MainViewModel : INotifyPropertyChanged
    {
        bool isEdit = false;

        static int id = 0;
        string name;
        DateTime birthDay;

        public string Name
        {
            get => name;
            set
            {
                if(name != value)
                {
                    name = value;
                    OnPropertChanged();
                }
            }
        }

        public DateTime BirthDay
        {
            get => birthDay;
            set
            {
                if (birthDay != value)
                {
                    birthDay = value;
                    OnPropertChanged();
                }
            }
        }
        public Employee? SelectedEmploye 
        { 
            get => Employes.FirstOrDefault(e => e.Id == SelectedId); 
        }
        public int SelectedId { get; set; }
        public BindingList<Employee> Employes { get; }

        public ICommand AddCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand EditCommand { set; get; }
        public MainViewModel()
        {
            Employes = new BindingList<Employee>()
            {
                new(){ Id = ++id, Name = "Bob", BirthDay = new DateTime(2000, 05, 11)},
                new(){ Id = ++id, Name = "Leo", BirthDay = new DateTime(1989, 11, 23)},
                new(){ Id = ++id, Name = "Tom", BirthDay = new DateTime(1992, 03, 7)},
            };
            
            AddCommand = new MainCommand(_ =>
            {
                if(!isEdit)
                    Employes.Add(new Employee() { Id = ++id, Name = this.Name, BirthDay = this.BirthDay });
                else
                {
                    var employee = Employes.FirstOrDefault(e => e.Id == SelectedId);
                    int index = Employes.IndexOf(employee);
                    Employes[index].Name = this.Name;
                    Employes[index].BirthDay = this.BirthDay;
                }

                isEdit = false;
                this.Name = "";
                this.BirthDay = DateTime.Now;
            });

            RemoveCommand = new MainCommand(obj =>
            {
                if (obj is int id)
                {
                    var employee = Employes.FirstOrDefault(e => e.Id == id);
                    if (employee != null)
                        this.Employes.Remove(employee);
                }
            });

            EditCommand = new MainCommand(obj =>
            {
                if (obj is int id)
                {
                    isEdit = true;
                    var employee = Employes.FirstOrDefault(e => e.Id == id);
                    if (employee != null)
                    {
                        this.Name = employee.Name;
                        this.BirthDay = employee.BirthDay;
                    }
                }
                    
                
            });

            BirthDay = DateTime.Now;

            SelectedId = 1;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

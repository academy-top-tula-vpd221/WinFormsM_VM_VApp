using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsM_VM_VApp
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public override string ToString() => $"{Name} ({(int)DateTime.Now.Subtract(BirthDay).TotalDays/365})";
    }
}

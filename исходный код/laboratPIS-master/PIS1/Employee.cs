using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS1
{
    public class Employee : DataObject
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        public override string ToString()
        {
            return $"Имя: {Name}, Возраст: {Age}, Заработная плата: {Salary.ToString("C")}, " +
                $"Дата приема на работу: {HireDate.ToString("yyyy.MM.dd")}";
        }
    }
}

using GavanKennedy_S00180333;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GavanKennedy_S00180333
{
    public class Phone
    {
        public int PhoneID { get; set; }
        public string Name { get; set; }
        public string OperatingSystem { get; set; }
        public string OsImage { get; set; }

      

        public string PhoneImage { get; set; }
        public double Price { get; set; }
        
        public void IncreasePrice(double amount)
        {
            Price += amount * (1.1);
        }
    }
    public class PhoneData:DbContext
    {
        public PhoneData() : base("ExamData") { }
        public DbSet<Phone> Phones { get; set; }
    }
}

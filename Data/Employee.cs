using System.ComponentModel.DataAnnotations;

namespace BlazorWebAppCRUD.Data
{
    public class Employee
    {
        [Key]
        public int Id {  get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }

    }
}

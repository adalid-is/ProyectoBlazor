
namespace BlazorOE01.Common.OE01


{
    public class DTODSGeneral
    {
        public Dsgeneral dsEmployee { get; set; }
    }

    public class Dsgeneral
    {
        public TTEmployee[] ttEmployee { get; set; }
    }
    public class TTEmployee
    {
        public int EmpNum { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

    }
}
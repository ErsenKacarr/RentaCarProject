using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentACar.DAL
{
    public class RentACarProcess
    {
        public int RentACarProcessID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public int PickUpLocation { get; set; }
        public int DropOffLocation { get; set; }

        [Column(TypeName = "Date")]
        public DateTime PickUpDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DropOffDate { get; set; }
        public decimal TotalPrice { get; set; }

    }
}

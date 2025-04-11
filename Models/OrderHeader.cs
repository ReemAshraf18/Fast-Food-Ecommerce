using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderHeader
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public DateTime TimeOfPick { get; set; }
        public DateTime DateOfPick { get; set; }
        public double SubTotal { get; set; }
        public double OrderTotal { get; set; }
        public string CouponCode { get; set; }
        public string TransId { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentStatus { get; set; }
        public string CouponDis { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public double OrderDiscount { get; set; }
        //public double OrderTax { get; set; }
        //public string PaymentMethod { get; set; } = "CashOnDelivery";
        //public string ShippingAddress { get; set; }
        //public string City { get; set; }
        //public string PostalCode { get; set; }
    }
}

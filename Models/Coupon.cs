using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Coupon
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        //public string Code { get; set; }
        public double Discound { get; set; }
        public double minimumAmount { get; set; }
        public byte[] CouponPicture { get; set; }
        public bool IsActive { get; set; }
    }
    public enum CouponType
    {
        Percentage,
        Currancy,
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class clsStudentBookSale : clsBookSale
    {
        bool blnStudentDiscount;
        float sngStudentDiscount = 0.15f;
        public bool StudentDiscount
        {
            get { return blnStudentDiscount; }
            set { blnStudentDiscount = value; }
        }
        public clsStudentBookSale(string strTitle, int intQuantity, decimal decPrice, bool discount, bool student)
            :base(strTitle, intQuantity, decPrice, discount)
        {
            blnStudentDiscount = student;
        }
        public override decimal DiscountAmout()
        {
            decimal decDiscountAmount;
            decDiscountAmount = base.DiscountAmout();
            if (StudentDiscount)
            {
                decDiscountAmount += ExtendedPrice() * Convert.ToDecimal(sngStudentDiscount);
            }
            
            return decDiscountAmount;
        }
    }
}

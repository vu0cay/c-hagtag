using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class clsBookSale
    {
        // attributes
        string strTitle;
        int intQuantity;
        decimal decPrice;
        static decimal decSalesTotal = 0;
        static int intSalesCount = 0;
        const float sngDISCOUNT_RATE = 0.1f;
        bool blnDiscount;

        // constructor
        public clsBookSale(string strTitle, int intQuantity, decimal decPrice, bool blnDiscount)
        {
            this.strTitle = strTitle;
            this.intQuantity = intQuantity;
            this.decPrice = decPrice;
            this.blnDiscount = blnDiscount;

        }

        // properties
        public string Title {
            get { return strTitle;  } 
            set { strTitle = value; } 
        }
        public int Quantity
        {
            get { return intQuantity; }
            set { intQuantity = value; }
        }
        public decimal Price
        {
            get { return decPrice; }
            set { decPrice = value; }
        }

        public static decimal SalesTotal
        {
            get { return decSalesTotal; }
            
        }
        public static int SalesCount
        {
            get { return intSalesCount; }

        }
        public bool Discount
        {
            get { return blnDiscount; }
            set { blnDiscount = value; }
        }


        // methods
        public decimal ExtendedPrice()
        {
            decimal decExtendedPrice = intQuantity * decPrice;

            

            return decExtendedPrice;
        }

        public virtual decimal DiscountAmout()
        {
            decimal decDiscountAmount;
            if (blnDiscount)
            {
                decDiscountAmount = intQuantity * decPrice * Convert.ToDecimal(sngDISCOUNT_RATE);
            }
            else decDiscountAmount = 0M;
            return decDiscountAmount;
        }

        public decimal NetDue()
        {
            decimal decNetDue = ExtendedPrice() - DiscountAmout();
            intSalesCount += 1;
            decSalesTotal += decNetDue;
            return decNetDue;
        }

    }
}

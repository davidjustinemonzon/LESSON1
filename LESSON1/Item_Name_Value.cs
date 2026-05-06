using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON1
{
    internal class Item_Name_Value
    {
        public String price, itemname, discount_amount;

        public void SetPriceItemName(string itemname, string price)
        {
            this.itemname = itemname;
            this.price = price;
        }

        public String GetItemName()
        {
            return itemname;
        }

        public String GetPrice()
        {
            return price;
        }

        public void SetPriceDiscountAmountValue(string discount_amt, string priceItem)
        {
            this.price = priceItem;
            this.discount_amount = discount_amt;
        }

        public String GetPriceItem()
        {
            return price;
        }

        public String GetDiscountamount()
        {
            return discount_amount;
        }
    }


}

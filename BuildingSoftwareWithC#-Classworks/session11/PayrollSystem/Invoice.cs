namespace PayrollSystem {
    public class Invoice : IPayment {
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        private decimal price;
        private int quantity;

        public Invoice(string item, string desc, decimal itemPrice, int itemQuantity)
        {
            ItemName = item;
            ItemDesc = desc;
            Price = itemPrice;
            Quantity = itemQuantity;
        }
        public decimal Price {
            get { return price; }
            set {
                if (value > 0m) {
                    price = value;
                } else {
                    throw new System.ArgumentOutOfRangeException ("Price must be greater zero!");
                }
            }
        }
        public int Quantity {
            get { return quantity; }
            set {
                if (value > 0) {
                    quantity = value;
                } else {
                    throw new System.ArgumentOutOfRangeException ("quantity must be greater than zero!");
                }
            }
        }

        public decimal GetPaymentAmount()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"Invoice:\nItem: {ItemName} ({ItemDesc})\nQuanity: {Quantity}\nPrice: {Price}";
        }

    }
}
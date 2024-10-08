namespace ERP_Stock_Tablet.Data
{
    public class Order
    {

        public int OrderID { get; set; }//NO 
        public string? StockID { get; set; }//StockCode
        public string? StockDesc { get; set; }//StockDescription
        public double UPrice { get; set; }//UnitPrice
        public string? UOM { get; set; }//UnitOfMeasurement
        public double POQty { get; set; }//PurchaseOrderQuantity
        public double BalQty { get; set; }//BalanceQuantity
        public int RcvQty { get; set; }//ReceiveQuantity

       

    }

    
}

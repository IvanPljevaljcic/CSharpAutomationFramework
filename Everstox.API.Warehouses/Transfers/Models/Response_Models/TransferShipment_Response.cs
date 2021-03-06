namespace Everstox.API.Warehouses.Transfers.Models.Response_Models
{
    public class TransferShipment_Response
    {
        public DateTime ETA { get; set; }
        public DateTime creation_date { get; set; }
        public List<CustomAttribute_Transfer> custom_attributes { get; set; }
        public string destination { get; set; }
        public string destination_name { get; set; }
        public string id { get; set; }
        public string shop_id { get; set; }
        public string source { get; set; }
        public string state { get; set; }
        public List<TransferItem> transfer_items { get; set; }
        public string transfer_number { get; set; }
        public List<TransferShipment> transfer_shipments { get; set; }
    }

    public class CustomAttribute_Transfer
    {
        public string attribute_key { get; set; }
        public string attribute_value { get; set; }
    }

    public class Product_Transfer
    {
        public string id { get; set; }
        public string name { get; set; }
        public string sku { get; set; }
    }

    public class TransferItem
    {
        public List<CustomAttribute_Transfer> custom_attributes { get; set; }
        public string id { get; set; }
        public Product_Transfer product { get; set; }
        public string product_name { get; set; }
        public int quantity_announced { get; set; }
        public int quantity_received { get; set; }
        public int quantity_stocked { get; set; }
        public string sku { get; set; }
        public string state { get; set; }
    }

    public class TransferShipmentItem
    {
        public string id { get; set; }
        public Product_Transfer product { get; set; }
        public string product_name { get; set; }
        public double quantity_received { get; set; }
        public double quantity_stocked { get; set; }
        public string sku { get; set; }
        public string transfer_item_id { get; set; }
    }

    public class TransferShipment
    {
        public string id { get; set; }
        public DateTime shipment_received_date { get; set; }
        public List<TransferShipmentItem> transfer_shipment_items { get; set; }
    }
}

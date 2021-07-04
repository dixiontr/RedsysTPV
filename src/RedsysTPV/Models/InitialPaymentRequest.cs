
namespace RedsysTPV.Models
{
    public class InitialPaymentRequest : PaymentRequest
    {
        public string Ds_Merchant_Pan { get; set; }
        public string Ds_Merchant_EXPIRYDATE { get; set; }
        public string Ds_Merchant_CVV2 { get; set; }
        public string Ds_Merchant_EMV3DS { get; set; }
        public InitialPaymentRequest(
            string Ds_Merchant_Order,
            string Ds_Merchant_MerchantCode,
            string Ds_Merchant_Terminal,
            string Ds_Merchant_Currency,
            string Ds_Merchant_TransactionType,
            string Ds_Merchant_Amount,
            string Ds_Merchant_Pan,
            string Ds_Merchant_EMV3DS,
            string Ds_Merchant_EXPIRYDATE)
            :
            base(Ds_Merchant_MerchantCode, Ds_Merchant_Terminal, Ds_Merchant_TransactionType, Ds_Merchant_Amount, Ds_Merchant_Currency, Ds_Merchant_Order)
        {
            this.Ds_Merchant_Pan = Ds_Merchant_Pan;
            this.Ds_Merchant_EXPIRYDATE = Ds_Merchant_EXPIRYDATE;
            this.Ds_Merchant_CVV2 = Ds_Merchant_CVV2;
            this.Ds_Merchant_EMV3DS = Ds_Merchant_EMV3DS;

        }
    }
}
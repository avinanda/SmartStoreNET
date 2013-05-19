using System;
using SmartStore.Core.Domain.Catalog;

namespace SmartStore.Services.Payments
{
    /// <summary>
    /// Represents a payment info holder
    /// </summary>
    [Serializable]
    public partial class ProcessPaymentRequest
    {
        /// <summary>
        /// Gets or sets a customer
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets an order unique identifier. Used when order is not saved yet (payment gateways that do not redirect a customer to a third-party URL)
        /// </summary>
        public Guid OrderGuid { get; set; }

        /// <summary>
        /// Gets or sets an order total
        /// </summary>
        public decimal OrderTotal { get; set; }

        /// <summary>
        /// /// <summary>
        /// Gets or sets a payment method identifier
        /// </summary>
        /// </summary>
        public string PaymentMethodSystemName { get; set; }

        #region Payment method specific properties 

        /// <summary>
        /// Gets or sets a credit card type (Visa, Master Card, etc...)
        /// </summary>
        public string CreditCardType { get; set; }

        /// <summary>
        /// Gets or sets a credit card owner name
        /// </summary>
        public string CreditCardName { get; set; }

        /// <summary>
        /// Gets or sets a credit card number
        /// </summary>
        public string CreditCardNumber { get; set; }

        /// <summary>
        /// Gets or sets a credit card expire year
        /// </summary>
        public int CreditCardExpireYear { get; set; }

        /// <summary>
        /// Gets or sets a credit card expire month
        /// </summary>
        public int CreditCardExpireMonth { get; set; }

        /// <summary>
        /// Gets or sets a credit card CVV2 (Card Verification Value)
        /// </summary>
        public string CreditCardCvv2 { get; set; }

        /// <summary>
        /// Gets or sets a paypal payer token (required for Paypal payment methods)
        /// </summary>
        public string PaypalToken { get; set; }

        /// <summary>
        /// Gets or sets a paypal payer identifier (required for Paypal payment methods)
        /// </summary>
        public string PaypalPayerId { get; set; }

        /// <summary>
        /// Gets or sets a google order number (required for Google Checkout)
        /// </summary>
        public string GoogleOrderNumber { get; set; }

        /// <summary>
        /// Gets or sets a purchase order number (required for Purchase Order payment method)
        /// </summary>
        public string PurchaseOrderNumber { get; set; }

		//codehint: sm-add begin
		public int CreditCardStartYear { get; set; }
		public int CreditCardStartMonth { get; set; }
		public string CreditCardIssueNumber { get; set; }
		public string DirectDebitAccountHolder { get; set; }
		public string DirectDebitAccountNumber { get; set; }
		public string DirectDebitBankCode { get; set; }
		public string DirectDebitCountry { get; set; }
		public string DirectDebitBankName { get; set; }
		public string DirectDebitIban { get; set; }
		public string DirectDebitBic { get; set; }
		//codehint: sm-add end

        #endregion

        #region Recurring payments

        /// <summary>
        /// Gets or sets a value idicating whether it's a recurring payment (initial payment was already processed)
        /// </summary>
        public bool IsRecurringPayment { get; set; }

        /// <summary>
        /// Gets or sets an initial (parent) order identifier if order is recurring
        /// </summary>
        public int InitialOrderId { get; set; }
        
        /// <summary>
        /// Gets or sets the cycle length
        /// </summary>
        public int RecurringCycleLength { get; set; }

        /// <summary>
        /// Gets or sets the cycle period
        /// </summary>
        public RecurringProductCyclePeriod RecurringCyclePeriod { get; set; }

        /// <summary>
        /// Gets or sets the total cycles
        /// </summary>
        public int RecurringTotalCycles { get; set; }

        #endregion
    }
}

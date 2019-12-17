using QuickBuy.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.ObjectValues
{
    public class Payment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsBankSlip
        {
            get { return Id == (int)MethodPaymentEnum.BankSlip; }
        }
        public bool IsCreditCard
        {
            get { return Id == (int)MethodPaymentEnum.CreditCard; }
        }
        public bool IsDeposit
        {
            get { return Id == (int)MethodPaymentEnum.Deposit; }
        }
        public bool IsUndefined
        {
            get { return Id == (int)MethodPaymentEnum.Undefined; }
        }
    }
}

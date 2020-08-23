using System.Collections.Generic;


namespace Bank_Accounts.Models
{
    public class NewWithdrawWrapper
    {
        public User Form{get;set;}

        public Transcations Money {get;set;}

        public List<Transcations> Transcations{get;set;}
    }
}
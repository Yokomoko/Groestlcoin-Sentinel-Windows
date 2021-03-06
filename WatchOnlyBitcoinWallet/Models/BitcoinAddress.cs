﻿using MVVMLibrary;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WatchOnlyGroestlcoinWallet.Models
{
    public class GroestlcoinAddress : ValidatableBase
    {
        private string name;
        /// <summary>
        /// Name acts as a tag for the address
        /// </summary>
        public string Name
        {
            get { return name; }
            set { SetField(ref name, value); }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set
            {
                if (SetField(ref address, value))
                {
                    Validate(value);
                }
            }
        }

        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            set { SetField(ref balance, value); }
        }

        private decimal difference;
        [JsonIgnore]
        public decimal Difference
        {
            get { return difference; }
            set { SetField(ref difference, value); }
        }


        public List<Transaction> TransactionList { get; set; }

    }
}
namespace RxjhTool
{
    using System;
    using System.ComponentModel;

    [DefaultProperty("Name")]
    public class Customer
    {
        private string _Name;
        private int _Age;
        private string _SSN;
        private DateTime _DateOfBirth;
        private string _Address;
        private string _Email;
        private bool _FrequentBuyer;

        [Category("ID Settings"), Description("Address of the customer")]
        public string Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                this._Address = value;
            }
        }

        [Description("Age of the customer"), Category("ID Settings")]
        public int Age
        {
            get
            {
                return this._Age;
            }
            set
            {
                this._Age = value;
            }
        }

        [Category("ID Settings"), Description("Date of Birth of the Customer (optional)")]
        public DateTime DateOfBirth
        {
            get
            {
                return this._DateOfBirth;
            }
            set
            {
                this._DateOfBirth = value;
            }
        }

        [Description("Most current e-mail of the customer"), Category("Marketting Settings")]
        public string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                this._Email = value;
            }
        }

        [Category("Marketting Settings"), Description("If the customer has bought more than 10 times, this is set to true")]
        public bool FrequentBuyer
        {
            get
            {
                return this._FrequentBuyer;
            }
            set
            {
                this._FrequentBuyer = value;
            }
        }

        [Category("ID Settings"), Description("Name of the customer")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
            }
        }

        [Description("Social Security Number of the customer"), Category("ID Settings")]
        public string SSN
        {
            get
            {
                return this._SSN;
            }
            set
            {
                this._SSN = value;
            }
        }
    }
}


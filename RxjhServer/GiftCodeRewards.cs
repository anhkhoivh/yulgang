namespace RxjhServer
{
    using System;

    public class GiftCodeRewardsClass
    {
        private int _Type;
        private string _Rewards;



        public int Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public string Rewards
        {
            get { return _Rewards; }
            set { _Rewards = value; }
        }
    }
}


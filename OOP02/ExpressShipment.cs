using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class ExpressShipment : Shipment
    {
        #region ExpressShipment
        private decimal extraFee;

        public decimal ExtraFee
        {
            get { return extraFee; }
            set 
            { 
                if (value >= 0)
                {
                    extraFee = value;
                }
            }
        }

        public override decimal EstimatedCost
        {
            get { return (decimal)base.EstimatedCost + extraFee; }
        }
        #endregion
    }
}

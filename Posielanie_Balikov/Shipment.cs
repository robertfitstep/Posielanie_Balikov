using System;
using System.Collections.Generic;
using System.Text;

namespace Posielanie_Balikov
{
    class Shipment
    {
        private static int shipmentCouter;
        private int trackingNo;
        public int TrackingNo
        {
            private set
            {
                trackingNo = value;
                OnShipmentMade?.Invoke(shippedItem.GetName(),shippedItem.GetTotalPrice(), trackingNo);
            }
            get { return this.trackingNo; }
        }
        
        private Item shippedItem;

        public delegate void ShipmentHandler(string nazovZasielky, int cenaZasielky, int trackingNo);
        public event ShipmentHandler OnShipmentMade;

        public void AddItem(Item recievedItem)
        {
            shippedItem = recievedItem;
            TrackingNo = generateTrackingNo();
        }

        private int generateTrackingNo()
        {
            shipmentCouter++;
            return int.Parse(DateTime.UtcNow.ToString("ddMMyy") + shipmentCouter.ToString("000"));
        }
    }
}

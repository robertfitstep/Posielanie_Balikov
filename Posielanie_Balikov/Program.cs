using System;

namespace Posielanie_Balikov
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipment shipment1 = new Shipment();
            shipment1.OnShipmentMade += Notification.WriteNotificationToConsole;
            shipment1.AddItem(new Item("Item1", 1, 10));

            Shipment shipment2 = new Shipment();
            shipment2.OnShipmentMade += Notification.WriteNotificationToConsole;
            shipment2.OnShipmentMade += Notification.SendNotificationViaEmail;
            shipment2.AddItem(new Item("Item2", 2, 11));

            Console.ReadLine();
        }
    }
}

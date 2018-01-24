using System;
using System.Collections.Generic;
using System.Text;

namespace Posielanie_Balikov
{
    class Item
    {
        private string itemName;
        private int noOfPieces;
        private int pricePerPiece;
        
        public Item(string itemName, int noOfPieces, int pricePerPiece)
        {
            this.itemName = itemName;
            this.noOfPieces = noOfPieces;
            this.pricePerPiece = pricePerPiece;
        }

        public int GetTotalPrice()
        {
            return noOfPieces * pricePerPiece;
        }
        
        public string GetName()
        {
            return itemName;
        }
    }
}

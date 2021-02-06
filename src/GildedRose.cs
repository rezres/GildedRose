using System.Collections.Generic;

namespace csharpcore {
    public class GildedRose {
        private readonly IList<Item> _Items;
        private readonly UpdateProcessFactory _updateProcessFactory;
        public GildedRose(IList<Item> Items)
        {
            this._Items = Items;
            this._updateProcessFactory = new UpdateProcessFactory();
        }

        public void UpdateQuality()
        {
            foreach (var item in this._Items)
            {
               IUpdateProcess updateItem = this._updateProcessFactory.GetProcess(item);
               updateItem.Update(item);
            } 
        }
    }
}




using System.Collections.Generic;
using AICodingGame.Scripts.GameObjects.Interfaces;

namespace AICodingGame.Scripts.GameObjects;

public class Inventory: IItemStorage<Inventory.Item>
{
    //public Dictionary<String, int> Item = new();

    public class Item
    {
        public GameItem ItemObj { get; set; }
        public int ItemHashCode { get; set; }
        public int Count { get; set; }

        public Item(GameItem item, int count)
        {
            ItemObj = item;
            ItemHashCode = item.GetHashCode();
            Count = count;
        }

        public override string ToString()
        {
            return $"{ItemHashCode}: {ItemObj.Name}[{Count}]";
        }
    }
    
    private List<Item> ItemList { get; set; }
    
    public IEnumerable<Item> GetItems()
    {
        return ItemList;
    }

    public void PushItem()
    {
        throw new System.NotImplementedException();
    }

    public void DeleteItem()
    {
        throw new System.NotImplementedException();
    }

    public void UpdateItem()
    {
        throw new System.NotImplementedException();
    }
}
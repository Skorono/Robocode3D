using System.Collections.Generic;

namespace AviationAICode.GameObjects;

public interface IItemStorage<T>
{
     IEnumerable<T> GetItems();
     void PushItem();

     void DeleteItem();

     void UpdateItem();
}
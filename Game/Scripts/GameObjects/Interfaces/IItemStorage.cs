using System.Collections.Generic;

namespace AICodingGame.Scripts.GameObjects.Interfaces;

public interface IItemStorage<T>
{
     IEnumerable<T> GetItems();
     void PushItem();

     void DeleteItem();

     void UpdateItem();
}
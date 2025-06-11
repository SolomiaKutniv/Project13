using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Project13
{
    // Клас для роботи з колекцією об'єктів Wolf
    public class WolfCollection
    {
        // Колекція з простору імен System.Collections (неузагальнена)
        private ArrayList arrayList = new ArrayList();      // System.Collections

        // Узагальнена колекція з простору імен System.Collections.Generic
        private List<Wolf> list = new List<Wolf>();         // System.Collections.Generic

        // 🔸 Додавання елемента до ArrayList
        public void AddToArrayList(Wolf wolf)
        {
            arrayList.Add(wolf);
        }

        // 🔸 Додавання елемента до List<Wolf>
        public void AddToGenericList(Wolf wolf)
        {
            list.Add(wolf);
        }

        // 🔸 Відображення інформації про певний елемент у ArrayList
        public string GetFromArrayList(int index)
        {
            if (index >= 0 && index < arrayList.Count)
            {
                Wolf w = (Wolf)arrayList[index]; // Приведення типу з object до Wolf
                return w.Info();
            }
            return "Невірний індекс!";
        }

        // 🔸 Відображення інформації про певний елемент у List<Wolf>
        public string GetFromGenericList(int index)
        {
            if (index >= 0 && index < list.Count)
            {
                return list[index].Info();
            }
            return "Невірний індекс!";
        }

        // 🔹 Перебір елементів у ArrayList з поверненням Wolf
        public IEnumerable<Wolf> IterateArrayList()
        {
            foreach (Wolf w in arrayList)
                yield return w;
        }

        // 🔹 Перебір елементів у List<Wolf>
        public IEnumerable<Wolf> IterateGenericList()
        {
            foreach (Wolf w in list)
                yield return w;
        }

        // 🔸 Отримання кількості елементів у ArrayList
        public int CountArrayList() => arrayList.Count;

        // 🔸 Отримання кількості елементів у List<Wolf>
        public int CountGenericList() => list.Count;
    }

}

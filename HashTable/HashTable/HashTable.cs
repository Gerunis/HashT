using System;

namespace HashTable
{
    public class HashTable
    {
        private readonly HashTablePair[] table;
        private readonly int size;
        /// <summary>
        /// Конструктор контейнера
        /// summary>
        /// size">Размер хэ-таблицы
        public HashTable(int size)
        {
            this.size = size;
            table = new HashTablePair[size];
        }

        ///
        /// Метод складывающий пару ключь-значение в таблицу
        ///
        /// key">
        /// value">
        public void PutPair(object key, object value)
        {
            var hash = key.GetHashCode();
            var position = Math.Abs(hash) % size;
            for (; table[position] != null; position = (position + 1) % size)
                if (table[position].Key.Equals(key))
                    break;
            table[position] = new HashTablePair(key, value);
        }

        /// <summary>
        /// Поиск значения по ключу
        /// summary>
        /// key">Ключь
        /// <returns>Значение, null если ключ отсутствуетreturns>

        public object GetValueByKey(object key)
        {
            var hash = key.GetHashCode();
            var startPosition = Math.Abs(hash) % size;
            bool flag = true;
            for(var i = startPosition; table[i] != null && (i != startPosition || flag); i = (i + 1)%size)
            {
                flag = false;
                if (table[i].Key.Equals(key))
                    return table[i].Value;
            }
            return null;
        }

    }

    class HashTablePair
    {
        public object Key { get; private set; }
        public object Value { get; private set; }

        public HashTablePair(object key, object value)
        {
            Key = key;
            Value = value;
        }
    }
}

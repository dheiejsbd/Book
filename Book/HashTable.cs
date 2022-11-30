namespace MyHash
{
    public class SimpleHashTable
    {
        private const int INITIAL_SIZE = 16;
        private int size;
        private Node[] buckets;

        public SimpleHashTable()
        {
            this.size = INITIAL_SIZE;
            this.buckets = new Node[size];
        }

        public SimpleHashTable(int capacity)
        {
            this.size = capacity;
            this.buckets = new Node[size];
        }

        public new string ToString()
        {
            string returnValue = "";
            for (int i = 0; i < buckets.Length; i++)
            {
                Node node = buckets[i];
                while (true)
                {
                    if (node == null) break;
                    returnValue += $"{node.Key},";
                    node = node.Next;
                }
                returnValue += "\n";
            }
            return returnValue;
        }

        public void Put(string key)
        {
            if (key == "") return;
            int index = HashFunction(key);
            if (buckets[index] == null)
            {
                buckets[index] = new Node(key);
            }
            else
            {
                Node newNode = new Node(key);
                newNode.Next = buckets[index];
                buckets[index] = newNode;
            }
        }
        public void Out(string key)
        {
            if (!Contains(key)) return;
            int index = HashFunction(key);
            Node node = buckets[index];

            if(node.Key == key)
            {
                buckets[index] = node.Next;
                return;
            }
            while(true)
            {
                if(node.Next.Key == key)
                {
                    node.Next = node.Next.Next;
                    break;
                }
                node = node.Next;
            }
        }

        public object Get(string key)
        {
            int index = HashFunction(key);

            if (buckets[index] != null)
            {
                for (Node n = buckets[index]; n != null; n = n.Next)
                {
                    if (n.Key == key)
                    {
                        return n.Key;
                    }
                }
            }
            return null;
        }

        public System.Collections.Generic.List<string> GetAllItem()
        {
            System.Collections.Generic.List<string> result = new System.Collections.Generic.List<string>();


            for (int i = 0; i < buckets.Length; i++)
            {
                Node node = buckets[i];
                while(node != null)
                {
                    result.Add(node.Key);
                    node = node.Next;
                }
            }
            return result;
        }

        public bool Contains(string key)
        {
            int index = HashFunction(key);
            if (buckets[index] != null)
            {
                for (Node n = buckets[index]; n != null; n = n.Next)
                {
                    if (n.Key == key)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        protected virtual int HashFunction(object key)
        {
            return System.Math.Abs(key.GetHashCode() + 1 +
                (((key.GetHashCode() >> 5) + 1) % (size))) % size;
        }
        private class Node
        {
            public string Key { get; set; }
            public Node Next { get; set; }

            public Node(string key)
            {
                this.Key = key;
                this.Next = null;
            }
        }
    }
}
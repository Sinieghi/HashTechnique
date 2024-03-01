class HashTechniques
{
    public int hash(int key)
    {
        return key % 10;
    }
    public void Insert(Node[] H, int key)
    {
        int index = hash(key);
        InsertInSortedList(ref H[index], key);
    }
    public Node Search(Node First, int key)
    {
        if (First == null) throw new Exception("Has to be more at least 1 element");
        Node node = First;
        while (node != null)
        {
            if (node.data == key) return node;
            node = node.next;
        }
        return null;
    }
    public void InsertInSortedList(ref Node First, int data)
    {

        Node t, q = null, p = First;
        t = new()
        {
            data = data,
            next = null
        };
        if (First == null)
            First = t;
        else
        {
            while (p != null && p.data < data)
            {
                q = p;
                p = p.next;
            }
            if (p == First)
            {
                t.next = First;
                First = t;
            }
            else
            {
                t.next = q.next;
                q.next = t;
            }
        }
    }

}
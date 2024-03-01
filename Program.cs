class Program
{
    static void Main(string[] args)
    {
        Node[] HT = new Node[10];
        Node temp;
        HashTechniques hash = new();
        int i;
        for (i = 0; i < 10; i++)
            HT[i] = null;
        //basically you define an array of list and insert element on index 
        //and the address is given by hash.hash, in this example all those
        //Insert call will store in same index, so you need the hash.hash to
        //find their address
        hash.Insert(HT, 12);
        hash.Insert(HT, 22);
        hash.Insert(HT, 42);
        int key = 22;
        //like i'm using here
        temp = hash.Search(HT[hash.hash(key)], key);
        System.Console.WriteLine(temp.data);
    }
}
namespace BloomFilter
{
    internal interface IBloomFilter
    {
        bool Check(object target);
        void Add(object target);
    }
}
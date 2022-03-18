namespace BloomFilter
{
    internal interface IBloomFilter
    {
        bool Check(object target);
        bool Add(object target);
    }
}
namespace BloomFilter
{
    public interface IBloomFilter
    {
        bool Check(object target);
        void Add(object target);
    }
}
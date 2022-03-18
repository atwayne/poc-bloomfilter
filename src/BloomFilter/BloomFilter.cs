using System.Collections;

namespace BloomFilter
{
    public class BloomFilter : IBloomFilter
    {
        private const int hashSize = sizeof(int) * 8;
        private readonly BitArray currentBitArray = new(hashSize, false);

        public void Add(object target)
        {
            var hash = GetHashCodeAsBitArray(target);
            currentBitArray.Or(hash);
        }

        public bool Check(object target)
        {
            var targetHash = GetHashCodeAsBitArray(target);
            var hash = new BitArray(targetHash);
            hash.And(currentBitArray).Xor(targetHash);
            return hash.Cast<bool>().All(x => !x);
        }

        private static BitArray GetHashCodeAsBitArray(object input)
        {
            var result = new BitArray(new int[] { input.GetHashCode() });
            return result;
        }
    }
}
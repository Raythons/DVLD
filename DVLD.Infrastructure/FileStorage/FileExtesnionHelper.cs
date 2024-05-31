
namespace DVLD.Infrastructure.FileStorage
{
    public static  class FileExtesnionHelper
    {
        static readonly List<byte> jpg = new List<byte> { 0xFF, 0xD8 };
        static readonly List<byte> bmp = new List<byte> { 0x42, 0x4D };
        static readonly List<byte> gif = new List<byte> { 0x47, 0x49, 0x46 };
        static readonly List<byte> png = new List<byte> { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A };

        static readonly List<(List<byte> magic, string extension)> imageFormats = new()
        {
            (jpg, "jpg"),
            (bmp, "bmp"),
            (gif, "gif"),
            (png, "png"),  
        };

        public static string TryGetExtension(byte[] array)
        {
            // check for simple formats first
            foreach (var imageFormat in imageFormats)
            {
                if (array.IsImage(imageFormat.magic))
                {           
                      return imageFormat.extension;           
                }
            }
            return null;
        }

        private static bool IsImage(this byte[] array, List<byte> comparer, int offset = 0)
        {
            int arrayIndex = offset;
            foreach (byte c in comparer)
            {
                if (arrayIndex > array.Length - 1 || array[arrayIndex] != c)
                    return false;
                ++arrayIndex;
            }
            return true;
        }
    }
}

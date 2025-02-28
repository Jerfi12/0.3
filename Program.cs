using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int imagesInRow = 3;
            int totalImages = 52;
            int fullRow = totalImages/imagesInRow;
            Console.WriteLine($"Полных рядов: {fullRow}.");
            int remainingImages = totalImages - (fullRow * imagesInRow);
            Console.WriteLine($"Оставшихся изображений: {remainingImages}.");
        }
    }
}

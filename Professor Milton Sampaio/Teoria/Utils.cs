

namespace Teoria
{
    public static class Utils
    {
        public static void Imprimir<T>(this T[] array, string mensagem)
        {
            Console.WriteLine(mensagem);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}

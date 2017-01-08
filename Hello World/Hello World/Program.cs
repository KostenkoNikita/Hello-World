using System;
using System.Text;
using System.Threading;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<Thread, Func<char[], string>> a =
            (t, func) =>
            {
                t.Start(func); t.Join();
                typeof(Console).GetMethod((string)typeof(string).GetConstructor(new Type[]
                        { typeof(char[]) }).Invoke(new object[]
                        { Encoding.ASCII.GetChars(new byte[] { 82, 101, 97, 100, 75, 101, 121 }) }),
                        Type.EmptyTypes).Invoke(null, null);
            };
            a(new Thread(new ParameterizedThreadStart((argument) =>
            {
                char[] c = (char[])typeof(char[]).GetConstructor(new Type[]
                { typeof(int) }).Invoke(new object[] { 13 });
                for (int i = 0; i < 13; i++)
                {
                    typeof(char[]).GetMethod((string)typeof(string).GetConstructor(new Type[]
                    { typeof(char[]) }).Invoke(new object[] { Encoding.ASCII.GetChars(new byte[]
                            { 83,101,116 }) }), new Type[]
                    { typeof(int), typeof(char) }).Invoke(c, new object[] { i,
                                (char)(new Func<int, int>((j) => { switch (j) {
                                                            case 0: return 72;case 1: return 101;case 2: return 108;case 3: return 108;
                                                            case 4: return 111;case 5: return 44;case 6: return 32;case 7: return 119;
                                                            case 8: return 111;case 9: return 114;case 10: return 108;case 11: return 100;
                                                            case 12: return 33;default: return 0; } }))(i) });
                }
                typeof(Console).GetMethod((string)typeof(string).GetConstructor(new Type[]
                { typeof(char[]) }).Invoke(new object[] { Encoding.ASCII.GetChars(new byte[]
                    { 87, 114, 105, 116, 101, 76, 105, 110, 101 }) }), new Type[]
                { typeof(string) }).Invoke(null, new object[]
                { ((Func<char[], string>)argument)?.Invoke(c) });
            })),
            new Func<char[], string>((c) => { return new string(c); }));
        }
    }
}

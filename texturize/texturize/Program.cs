using System;
using System.IO;


namespace texturize
{
    class Create3DTex
    {
        static void Main()
        {

            using (BinaryReader b = new BinaryReader(File.Open("C:/Users/gram/Documents/cs/3d-texturizer/dat/strip.bin", FileMode.Open)))
            {
                int pos = 0;
                int length = (int)b.BaseStream.Length;
                while (pos < length)
                {
                    float v = b.ReadSingle();
                    Console.WriteLine(v);
                    pos += sizeof(Single);
                }
            }


        }
    }
}

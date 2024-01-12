using Newtonsoft.Json;
using Skylark.Enum;
using Skylark.Standard.Extension.Compression;
using Skylark.Standard.Extension.Decompression;
using Skylark.Struct.Compression;
using Skylark.Struct.Decompression;
using System.IO.Compression;
using System.Text;

namespace ConsoleDemoDecompression
{
    internal class Program
    {
        private const string Data = "{'squadName':'Super hero squad','homeTown':'Metro City','formed':2016,'secretBase':'Super tower','active':true,'members':[{'name':'Molecule Man','age':29,'secretIdentity':'Dan Jukes','powers':['Radiation resistance','Turning tiny','Radiation blast']},{'name':'Madame Uppercut','age':39,'secretIdentity':'Jane Wilson','powers':['Million tonne punch','Damage resistance','Superhuman reflexes']},{'name':'Eternal Flame','age':1000000,'secretIdentity':'Unknown','powers':['Immortality','Heat Immunity','Inferno','Teleportation','Interdimensional travel']}]}";

        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Data: {Data}");

            Console.WriteLine();

            CompressionStruct Result1 = CompressionExtension.Compress(Data, CompressionType.GZip, CompressionLevel.SmallestSize);
            DecompressionStruct Result2 = DecompressionExtension.Decompress(Result1.CompressedData, DecompressionType.GZip, CompressionMode.Decompress);
            Console.WriteLine(JsonConvert.SerializeObject(Result2, Formatting.Indented));

            Console.WriteLine();

            CompressionStruct Result3 = CompressionExtension.Compress(Data, CompressionType.Brotli, CompressionLevel.SmallestSize);
            DecompressionStruct Result4 = DecompressionExtension.Decompress(Result3.CompressedData, DecompressionType.Brotli, CompressionMode.Decompress);
            Console.WriteLine(JsonConvert.SerializeObject(Result4, Formatting.Indented));

            Console.WriteLine();

            CompressionStruct Result5 = CompressionExtension.Compress(Data, CompressionType.Deflate, CompressionLevel.SmallestSize);
            DecompressionStruct Result6 = DecompressionExtension.Decompress(Result5.CompressedData, DecompressionType.Deflate, CompressionMode.Decompress);
            Console.WriteLine(JsonConvert.SerializeObject(Result6, Formatting.Indented));

            Console.ReadKey();
        }
    }
}
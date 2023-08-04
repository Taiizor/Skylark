using Skylark.Helper;
using Skylark.Standard.Helper;
using Skylark.Standard.Interface;

namespace Delete
{
    internal class Program
    {
        static void Main()
        {
            //Console.WriteLine(GitHub.Contents("Taiizor", "Sucrose"));


            //Console.WriteLine(GitHub.ContentsObject("Taiizor", "Sucrose"));


            //Console.WriteLine(GitHub.ContentsJArray("Taiizor", "Sucrose"));


            foreach (IContents Contents in GitHub.ContentsList("Taiizor", "Sucrose"))
            {
                Console.WriteLine(Contents.Name);
            }


            //Console.WriteLine(GitHub.Releases("Taiizor", "Sucrose"));


            //Console.WriteLine(GitHub.ReleasesObject("Taiizor", "Sucrose"));


            //Console.WriteLine(GitHub.ReleasesJArray("Taiizor", "Sucrose"));


            //foreach (IReleases Releases in GitHub.ReleasesList("Taiizor", "Skylark"))
            //{
            //    foreach (IAssets Asset in Releases.Assets)
            //    {
            //        Console.WriteLine(Asset.Name);
            //        Console.WriteLine(Asset.Uploader.Login);
            //    }
            //}


            Version currentVersion = Versionly.Clear("1.0.0.5");
            Version latestVersion = Versionly.Clear(GitHub.ReleasesList("Taiizor", "Sucrose").FirstOrDefault().TagName);

            Console.WriteLine(currentVersion);
            Console.WriteLine(latestVersion);

            Console.WriteLine(Versionly.Compare(currentVersion, latestVersion));


            Console.ReadKey();
        }
    }
}
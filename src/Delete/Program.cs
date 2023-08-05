using Skylark.Helper;
using Skylark.Standard.Helper;
using Skylark.Standard.Interface;

namespace Delete
{
    internal class Program
    {
        static void Main()
        {
            string Owner = "Taiizor";
            string Repository = "Sucrose";
            string Token = string.Empty;

            //Console.WriteLine(GitHub.Contents(Owner, Repository, null, null, null, Token));


            //Console.WriteLine(GitHub.ContentsObject(Owner, Repository, null, null, null, Token));


            //Console.WriteLine(GitHub.ContentsJArray(Owner, Repository, null, null, null, Token));


            foreach (IContents Contents in GitHub.ContentsList(Owner, Repository, null, null, null, Token))
            {
                Console.WriteLine(Contents.Name);
            }


            //Console.WriteLine(GitHub.Releases(Owner, Repository, null, Token));


            //Console.WriteLine(GitHub.ReleasesObject(Owner, Repository, null, Token));


            //Console.WriteLine(GitHub.ReleasesJArray(Owner, Repository, null, Token));


            //foreach (IReleases Releases in GitHub.ReleasesList(Owner, "Skylark", null, Token))
            //{
            //    foreach (IAssets Asset in Releases.Assets)
            //    {
            //        Console.WriteLine(Asset.Name);
            //        Console.WriteLine(Asset.Uploader.Login);
            //    }
            //}


            Version currentVersion = Versionly.Clear("1.0.0.5");
            Version latestVersion = Versionly.Clear(GitHub.ReleasesList(Owner, Repository, null, Token).FirstOrDefault().TagName);

            Console.WriteLine(currentVersion);
            Console.WriteLine(latestVersion);

            Console.WriteLine(Versionly.Compare(currentVersion, latestVersion));


            Console.ReadKey();
        }
    }
}
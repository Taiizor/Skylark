using E = Skylark.Exception;
using MHHM = Skylark.Manage.Hash.HashManage;
using MI = Skylark.Manage.Internal;

namespace Skylark.Helper.Hash
{
    /// <summary>
    /// 
    /// </summary>
    internal static class HashHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        public static FileStream OpenRead(string Path)
        {
            return File.OpenRead(Path);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static void FileControl(string Path)
        {
            if (File.Exists(Path))
            {
                long Byte = new FileInfo(Path).Length;

                if (Byte > MI.FileLength)
                {
                    throw new E(MHHM.Length);
                }
            }
            else
            {
                throw new E(MHHM.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Bytes"></param>
        /// <param name="Split"></param>
        /// <returns></returns>
        public static string ToString(byte[] Bytes, string Split)
        {
            return BitConverter.ToString(Bytes).Replace("-", Split);
        }
    }
}
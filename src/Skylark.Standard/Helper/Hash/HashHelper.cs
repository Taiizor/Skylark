﻿using SE = Skylark.Exception;
using SMI = Skylark.Manage.Internal;
using SSMHHM = Skylark.Standard.Manage.Hash.HashManage;

namespace Skylark.Standard.Helper.Hash
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
        /// <exception cref="SE"></exception>
        public static void FileControl(string Path)
        {
            if (File.Exists(Path))
            {
                long Byte = new FileInfo(Path).Length;

                if (Byte > SMI.FileLength)
                {
                    throw new SE(SSMHHM.Length);
                }
            }
            else
            {
                throw new SE(SSMHHM.Error);
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
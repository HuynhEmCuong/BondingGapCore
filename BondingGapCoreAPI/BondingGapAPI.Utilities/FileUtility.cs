﻿using System;
using System.IO;
using System.Text;

namespace BondingGapAPI.Utilities
{
    public static class FileUtility
    {
        public static string ReadFile(string url, ref bool isSuccess, ref Exception error)
        {

            try
            {
                string result = File.ReadAllText(url);

                isSuccess = true;

                return result;
            }
            catch (Exception ex)
            {
                error = ex;

                isSuccess = false;

                return string.Empty;
            }
        }

        public static bool WriteFile(string value, string url, ref Exception error)
        {

            try
            {
                string addText = File.ReadAllText(url);
                File.WriteAllText(url, addText + value, Encoding.UTF8);

                return true;
            }
            catch (Exception ex)
            {
                error = ex;
                return false;
            }

        }

    }
}

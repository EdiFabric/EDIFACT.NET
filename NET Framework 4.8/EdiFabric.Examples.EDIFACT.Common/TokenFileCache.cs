using System;
using System.Diagnostics;
using System.IO;

namespace EdiFabric.Examples.EDIFACT.Common
{
    public class TokenFileCache
    {
        private static string _tokenFile = Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\token.txt";
       
        public static void Set()
        {           
            try
            {
                var token = ReadFromCache();
                SerialKey.SetToken(token);

                //  Refresh token before expiration
                Refresh();
            }
            catch 
            {
                //  Try one last time
                try
                {
                    var token = GetFromApi();
                    WriteToCache(token);
                    SerialKey.SetToken(token);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    //  Contact support@edifabric.com for assistance
                    throw;
                }                
            }
        }

        private static void Refresh()
        {
            try
            {
                //  Refresh the token two days before it expires
                if (SerialKey.DaysToExpiration < 3)
                    WriteToCache(GetFromApi());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                //  If can't get a token a day before the current expires - throw an exception
                //  Otherwise keep trying
                if (SerialKey.DaysToExpiration <= 1)
                    throw;
            }
        }

        private static string GetFromApi()
        {
            int retries = 3;
            int index = 0;

            //  Try to get a token with retries
            while (index < retries)
            {
                try
                {
                    return SerialKey.GetToken(Config.TrialSerialKey);
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    index++;
                    
                    if (index >= retries)
                        throw;                    
                }                
            }

            throw new Exception("Can't get a token.");
        }

        private static string ReadFromCache()
        {
            if (!File.Exists(_tokenFile))
            {
                var token = GetFromApi();
                WriteToCache(token);
                return token;
            }

            return File.ReadAllText(_tokenFile);
        }

        private static void WriteToCache(string token)
        {
            File.WriteAllText(_tokenFile, token);
        }
    }
}

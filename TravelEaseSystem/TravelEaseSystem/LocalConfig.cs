using System;
using System.IO;
using Newtonsoft.Json;

namespace TravelEaseSystem
{
    public class LocalConfig
    {
        public string ConnectionString { get; set; }

        public static LocalConfig LoadConfig(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonContent = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<LocalConfig>(jsonContent);
                }
                else
                {
                    Console.WriteLine($"Config file '{filePath}' not found.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading config: " + ex.Message);
                return null;
            }
        }
    }
}

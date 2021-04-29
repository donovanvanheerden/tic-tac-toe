using System;

namespace TicTacToe.Core.Infra.Config
{
    public class CORSSettings
    {
        public CORSSettings()
        {
            AllowHeaders = Array.Empty<string>();
            AllowOrigins = Array.Empty<string>();
            AllowMethods = Array.Empty<string>();
            ExposedHeaders = Array.Empty<string>();
        }

        public string[] AllowHeaders { get; set; }
        public string[] AllowOrigins { get; set; }
        public string[] AllowMethods { get; set; }
        public bool AllowCredentials { get; set; }
        public string[] ExposedHeaders { get; set; }
    }
}

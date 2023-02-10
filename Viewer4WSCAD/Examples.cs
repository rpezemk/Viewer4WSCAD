using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viewer4WSCAD
{
    internal static class Examples
    {
		public static string WSCADExample =
            @"[
				{
					""type"": ""line"",
					""a"": ""-1,5; 3,4"",
					""b"": ""2,2; 5,7"",
					""color"": ""127; 255; 255; 255""
				},
				{
					""type"": ""circle"",
					""center"": ""0; 0"",
					""radius"": 15.0,
					""filled"": false,
					""color"": ""127; 255; 0; 0""
				},
				{
					""type"": ""triangle"",
					""a"": ""-15; -20"",
					""b"": ""15; -20,3"",
					""c"": ""0; 21"",
					""filled"": true,
					""color"": ""127; 255; 0; 255""
				},
			]";

        public static string MyExample =
                    @"[
				{
					""type"": ""line"",
					""a"": ""-1,5; 3,4"",
					""b"": ""2,2; 5,7"",
					""color"": ""127; 255; 255; 255""
				},
				{
					""type"": ""circle"",
					""center"": ""0; 0"",
					""radius"": 15.0,
					""filled"": false,
					""color"": ""127; 255; 0; 0""
				},
				{
					""type"": ""triangle"",
					""a"": ""-15; -20"",
					""b"": ""15; -20,3"",
					""c"": ""0; 21"",
					""filled"": true,
					""color"": ""127; 255; 0; 255""
				},

				{
					""type"": ""line"",
					""a"": ""30; 0"",
					""b"": ""100; 100"",
					""color"": ""255; 0; 255; 0""
				},
				{
					""type"": ""line"",
					""a"": ""200; 0"",
					""b"": ""0; 200"",
					""color"": ""255; 0; 255; 0""
				},
				{
					""type"": ""circle"",
					""center"": ""300; 300"",
					""radius"": 10.0,
					""filled"": true,
					""color"": ""255; 0; 0; 255""
				},

				{
					""type"": ""circle"",
					""center"": ""100; 100"",
					""radius"": 10.0,
					""filled"": false,
					""color"": ""255; 0; 0; 255""
				},

				{
					""type"": ""circle"",
					""center"": ""100; 200"",
					""radius"": 10.0,
					""filled"": false,
					""color"": ""255; 0; 0; 255""
				},
				{
					""type"": ""circle"",
					""center"": ""0; 0"",
					""radius"": 2.0,
					""filled"": false,
					""color"": ""255; 0; 0; 255""
				},

				{
					""type"": ""triangle"",
					""a"": ""0; 0"",
					""b"": ""100; 200"",
					""c"": ""200; 0"",
					""filled"": false,
					""color"": ""255; 255; 0; 255""
				},
				{
					""type"": ""rectangle"",
					""a"": ""0; 0"",
					""b"": ""-100; 100"",
					""filled"": true,
					""color"": ""127; 255; 0; 255""
				}
			]";

    }
}

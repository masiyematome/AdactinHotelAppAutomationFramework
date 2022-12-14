using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdactinHotelAppAutomationFramework.Data
{
    class DataHandler
    {
        public static JObject ReadJsonFiles(string fileLocation)
        {

            string currentWorkingDirectory = Directory.GetCurrentDirectory();
            string actualWorkingDirectory = string
                .Concat(currentWorkingDirectory.Substring(0, currentWorkingDirectory.LastIndexOf("bin")),fileLocation);

            JObject jsonObject = JObject.Parse(File.ReadAllText(actualWorkingDirectory));

            return jsonObject;

        }

    }
}

using Newtonsoft.Json.Linq;
using Aspose.Cells;

namespace AdactinHotelAppAutomationFramework.Data
{
    class DataHandler
    {

        static string currentWorkingDirectory = Directory.GetCurrentDirectory();
        static string currentWorkingDirectoryUpToProjectName = currentWorkingDirectory.Substring(0, currentWorkingDirectory.LastIndexOf("bin"));
        public static JObject ReadJsonFiles(string fileLocation)
        {

            string jsonFile = string.Concat(currentWorkingDirectoryUpToProjectName,fileLocation);

            JObject jsonObject = JObject.Parse(File.ReadAllText(jsonFile));

            return jsonObject;

        }

        public static Dictionary<string,string> ReadExcelFiles(string fileLocation,int targetSheetIndex)
        {

            Dictionary<string, string> inputTypesAndObjectIds = new Dictionary<string, string>();

            string excelFile = string.Concat(currentWorkingDirectoryUpToProjectName, fileLocation);

            Workbook workBook = new Workbook(excelFile);

            Worksheet workSheet = workBook.Worksheets[targetSheetIndex];

            int rows = workSheet.Cells.MaxDataRow;
            int cols = workSheet.Cells.MaxDataColumn;

            for(int i = 0; i < rows; i++)
            {

                for(int j = 0; j < cols; j++)
                {

                    inputTypesAndObjectIds.Add(workSheet.Cells[i, j].Value.ToString(), workSheet.Cells[i, j + 1].Value.ToString());

                }

            }

            return inputTypesAndObjectIds;

        }

    }
}

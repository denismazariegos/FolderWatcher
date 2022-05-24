using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.IO;
using FolderWatcher.Enums;

namespace FolderWatcher.Clases
{
    public class FileOperations
    {
        /// <summary>
        /// Local variables
        /// </summary>
        private bool firtTime = false;
        private const string masterexcelfile = "Master.xlsx";

        /// <summary>
        /// Method to Process the excel files
        /// </summary>
        /// <param name="file"></param>
        public void ProcessExcelFile(string file)
        {
            //Declare variables
            int count = 0;
            string destinationfolder;
            Worksheet worksheet = null;

            try
            {
                Microsoft.Office.Interop.Excel.Application myapp = new Microsoft.Office.Interop.Excel.Application();
                destinationfolder = Path.Combine(Path.GetDirectoryName(file), "Processed");

                //Validate if processed destinationfolder exists
                if (!Directory.Exists(destinationfolder))
                    Directory.CreateDirectory(destinationfolder);

                //Load source excel file
                Workbook wb = myapp.Workbooks.Add(file);
                Workbook wbdestination;

                //Validate if master excel file exists
                if (File.Exists(Path.Combine(destinationfolder, masterexcelfile)))
                    wbdestination = myapp.Workbooks.Add(Path.Combine(destinationfolder, masterexcelfile));
                else
                {
                    wbdestination = myapp.Workbooks.Add();
                    firtTime = true;
                }

                //Gets "Sheet1" if is the firt time
                if (firtTime)
                {
                    if (wbdestination.Worksheets["Sheet1"] != null)
                        worksheet = wbdestination.Worksheets["Sheet1"];
                }

                //Iterate over all source excel file sheets
                foreach (Worksheet sheet in wb.Sheets)
                {
                    count++;
                    sheet.Copy(wbdestination.Worksheets[count]);
                }

                //Delete "Sheet1" if exists
                if (worksheet != null)
                    worksheet.Delete();

                //Save changes to master workbook
                myapp.DisplayAlerts = false;
                wbdestination.SaveAs(Path.Combine(destinationfolder, masterexcelfile));
                wbdestination.Close(true);
                myapp.Quit();
                firtTime = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Method to move files after the process
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filetype"></param>
        public void MoveFile(string file, CustomEnums.Filetype filetype)
        {
            string destinationfolder = string.Empty;
            if(filetype == CustomEnums.Filetype.Excel)
                destinationfolder = Path.Combine(Path.GetDirectoryName(file), "Processed");
            if(filetype == CustomEnums.Filetype.Other)
                destinationfolder = Path.Combine(Path.GetDirectoryName(file), "Not applicable");

            try
            {
                //Validate if destinationfolder exists
                if (!Directory.Exists(destinationfolder))
                    Directory.CreateDirectory(destinationfolder);

                //Move file to destination folder
                File.Move(file, Path.Combine(destinationfolder, Path.GetFileName(file)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
using System.Data;
using System.Web;
using Aspose.Cells;
using SyntacticSugar;

namespace ExportExcelDemo
{
    public class ExcelHelper
    {
        /// <summary>
        /// 导出Excel
        /// </summary>
        /// <param name="templatePath">模板位置</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="outFileName">导出文件名</param>
        public static void ExportExcel(string templatePath, DataTable dataSource, string outFileName)
        {
            string rootPath = HttpContext.Current.Server.MapPath(templatePath);
            Workbook wk = new Workbook(rootPath);
            WorkbookDesigner designer = new WorkbookDesigner(wk);
            designer.SetDataSource(dataSource);
            designer.Process();
            var extension = FileSugar.GetExtension(outFileName);   //后缀名
            designer.Workbook.Save(HttpContext.Current.Response, outFileName, ContentDisposition.Attachment,
                extension == ".xlsx"
                    ? new XlsSaveOptions(SaveFormat.Xlsx)
                    : new XlsSaveOptions(SaveFormat.Excel97To2003));
        }
    }
}
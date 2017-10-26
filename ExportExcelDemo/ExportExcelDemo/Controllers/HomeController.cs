using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExportExcelDemo.Dao;
using ExportExcelDemo.Entity;

namespace ExportExcelDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public void Export()
        {
            var db = SugarDao.GetInstance();
            var dt = db.Queryable<Sys_User>().ToDataTable();
            dt.TableName = "Sys_User"; //此处名称要和excel模板中的名称保持一致，不然导出的excel中无数据
            ExcelHelper.ExportExcel("/Template/userTemplate.xlsx", dt, "user.xlsx");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
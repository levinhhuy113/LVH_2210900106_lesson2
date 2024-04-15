using Lab2.ASPNET.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Lab2.ASPNET.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ViewResult TestViewResult()
        {
            return View();
        }
        public PartialViewResult TestPartialViewResult()
        {
            return PartialView();
        }
        public EmptyResult TestEmptyResult()
        {
            return new EmptyResult();
        }
        public RedirectResult TestRedirectResult()
        {
            return Redirect("index");
        }
        public JsonResult TestJsonResult()
        {
            List<Student> listStudent = new List<Student>();
            listStudent.Add(new Student() { ID = 001, Name = "Lê Vinh Huy", ClassName = "CNT1" });
            listStudent.Add(new Student() { ID = 002, Name = "Lê Vinh Hùng", ClassName = "CNT2" });
            listStudent.Add(new Student() { ID = 003, Name = "Lê Văn Huy", ClassName = "CNT2" });
            listStudent.Add(new Student() { ID = 004, Name = "Đỗ Trọng Huy", ClassName = "CNT3" });
            listStudent.Add(new Student() { ID = 005, Name = "Đỗ Trọng Heo", ClassName = "CNT1" });
            listStudent.Add(new Student() { ID = 006, Name = "Đỗ Trọng Lợn", ClassName = "CNT4" });
            listStudent.Add(new Student() { ID = 007, Name = "Nguyễn Văn Thạo", ClassName = "CNT1" });
            listStudent.Add(new Student() { ID = 008, Name = "Nguyễn Văn Thẹo", ClassName = "CNT2" });
            listStudent.Add(new Student() { ID = 009, Name = "Bùi Xuân Huấn", ClassName = "CNT3" });
            listStudent.Add(new Student() { ID = 010, Name = "Huấn Rose", ClassName = "CNT4" });


            return Json(listStudent, JsonRequestBehavior.AllowGet);
        }
        public JavaScriptResult TestJavaScriptResult()
        {
            string js = "funtion checkEMail(){var btloc=/^([w-]+(?:.[w-]+)*)@((?:[w -] +.) * w[w -]{ 0,66}).([a - z]{ 2,6} (?:.[a - z]{ 2})?)$/ iif (btloc.test(mail)) { kq = true; }else{alert(“Email address invalid”);kq = false;}return kq;}";
            return JavaScript(js);
        }
        public ContentResult TestContentResult()
        {
            XElement contentXML = new XElement("Students",
                new XElement("Student",
                new XElement("ID", "001"),
                new XElement("FullName", "Nguyễn Viết Nam"),
                new XElement("ClassName", "C1308H")),
                new XElement("Student",
                new XElement("ID", "002"),
                new XElement("FullName", "Nguyễn Hoàng Anh"),
                new XElement("ClassName", "C1411P")),
                new XElement("Student",
                new XElement("ID", "003"),
                new XElement("FullName", "Phạm Ngọc Anh"),
                new XElement("ClassName", "C1411L")),
                new XElement("Student",
                new XElement("ID", "004"),
                new XElement("FullName", "Trần Ngọc Linh"),
                new XElement("ClassName", "C1411H")),
                new XElement("Student",
                new XElement("ID", "005"),
                new XElement("FullName", "Nguyễn Hồng Anh"),
                new XElement("ClassName", "C1411L")));
            return Content(contentXML.ToString(), "text/xml",Encoding.UTF8);

        }
        public FileContentResult TestFileContentResult()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/Imagine.png"));
            string fileName = "Imagine.png";
            return File(fileBytes, "imagine/png", fileName);

        }
        public FileStreamResult TestFileStreamResult()
        {
            string pathFile = Server.MapPath("~/Content/Book1.xlsx");
            string fileName = "Book1.xlsx";
            return File(new FileStream(pathFile, FileMode.Open),"text/doc", fileName);
        }
        public FilePathResult TestFilePathResult()
        {
            string pathFile = Server.MapPath("~/Content/Book1.xlsx");
            string fileName = "Book1.xlsx";
            return File(pathFile, "text/doc", fileName);
        }
    }
}
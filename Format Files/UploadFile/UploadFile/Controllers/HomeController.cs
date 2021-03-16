using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UploadFile.Models;

namespace UploadFile.Controllers
{
    
    public class HomeController : Controller
    {
        ReadEntities1 db = new ReadEntities1();
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
        [HttpGet]
        public ActionResult addnewrecord()
        {
            ViewBag.Messsage = "Your contact page,";

            return View();
        }
        [HttpPost]

        public ActionResult addnewrecord(tbl_User d, string Admin, string Employee, HttpPostedFileBase file)
        {

            tbl_User di = new tbl_User();
            if (Admin == "true")
            {
                di.IsGroupAdmin = true;
            }
            else
            {
                di.IsGroupAdmin = false;
            }

            if (Employee == "true")
            {
                di.IsGroupEmployee = true;
            }
            else
            {
                di.IsGroupEmployee = false;
            }
        
            string path = uploadfile(file);
            if (path.Equals("-1"))
            {

            }
            else
            {
                di.Name = d.Name; 
                di.Description = d.Description;
                di.FileUpload = path;
                db.tbl_User.Add(di);      
                db.SaveChanges();
                ViewBag.msg = "data added Successfully....";
            }

            return View();
        }
        
public string uploadfile(HttpPostedFileBase file)
        {
            Random r = new Random();
            string path = "-1";
            int random = r.Next();
            if (file!=null&& file.ContentLength > 0)
            {
                string extension = Path.GetExtension(file.FileName);
                if (extension.ToLower().Equals(".jpg") || extension.ToLower().Equals(".jpeg") || extension.ToLower().Equals(".png")||
                     extension.ToLower().Equals(".pdf") || extension.ToLower().Equals(".doc") || extension.ToLower().Equals(".docx")||
                      extension.ToLower().Equals(".xml") || extension.ToLower().Equals(".gif")||extension.ToLower().Equals(".mp4")||extension.ToLower().Equals(".xlsx"))
                {
                    try
                    {
                        path = Path.Combine(Server.MapPath("~/Content/upload"), random + Path.GetFileName(file.FileName));
                        file.SaveAs(path);
                        path = "~/Content/upload" + random + Path.GetFileName(file.FileName);

                        @ViewBag.Message = "File uploaded successfully";
                    }
                    catch(Exception ex)
                    {
                        ViewBag.Message = "Error:" + ex.Message.ToString();
                        path = "-1";
                    }
                }
                else
                {
                    Response.Write("<script>alert('Only jpg,jpeg or png formats are acceptable....');</script>");
                   
                }
            }

            else
            {
                Response.Write("<script>alert('Please select a file');</script>");
                path = "-1";
            }



            return path;
        }
     
    }
}
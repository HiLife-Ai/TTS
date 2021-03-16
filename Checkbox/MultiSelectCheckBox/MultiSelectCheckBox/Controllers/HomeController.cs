using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultiSelectCheckBox.Models;
using MultiSelectCheckBox.ViewModel;

    

namespace MultiSelectCheckBox.Controllers
{
    public class HomeController : Controller
    {
        private SkillDBEntities objSkillDbEntities;

        public object JsonRequestBehaviour { get; set; }

        public HomeController()
        {
            objSkillDbEntities = new SkillDBEntities();
        }
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<SkillViewModel> listOSkillViewModels =
                (from objSkills in objSkillDbEntities.Skills
                 select new SkillViewModel()
                 {
                     SkillId = objSkills.SkillId,
                     SkillName = objSkills.SkillName,
                     IsChecked = false
                 }).ToList();
            return View(listOSkillViewModels);
        }
        [HttpPost]
       public JsonResult Index(List<int> listOfSkill,int userId)
        {
            foreach (var item in listOfSkill) {
                AssignSkill objAssignSkill = new AssignSkill()
                {
                    SkillId = item,
                    UserId = userId
                };
                objSkillDbEntities.AssignSkills.Add(objAssignSkill);
                objSkillDbEntities.SaveChanges();
                    }
            return Json(new { messsage = "Skill Successfully Assign",success=true },JsonRequestBehavior.AllowGet);
        }  
        
    }  
    
}
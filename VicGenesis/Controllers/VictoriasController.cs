using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VicGenesis;

namespace VicGenesis.Controllers
{
    public class VictoriasController : Controller
    {
        private regionalDatabaseEntities db = new regionalDatabaseEntities();
        public static string Style { get; set; }

        // GET: Victorias
        public ActionResult Index()
        {
            return View(db.Victorias.ToList());
        }

        // GET: Victorias/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Victoria victoria = db.Victorias.Find(id);
            if (victoria == null)
            {
                return HttpNotFound();
            }
            return View(victoria);
        }

        // GET: Victorias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Victorias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "COMM_CODE,Community_Name,Community_Type,DHS_Region,Map_Reference,Area_km_sq,Location,Road_distance_to_GPO_km,Local_Government_Area,Population_density,Primary_Care_Partnership,Number_of_localities,ABS_Remoteness_Area,Population_Difference,Funded_Activity_Types,Funded_Services,HACC_Services,Child_Protection_Services,Community_Health_Services,Homelessness,Disability_Services,Mental_Health_Services,Human_Health_Services_Sites,Human_Health_Services_Types,Dental_Sites,General_Practice_Sites,Pharmacy_Sites,Allied_Health_Sites,Complementary_Health_Sites,Child_Care_Sites,Residential_Aged_Care_Facilities,Licensed_Aged_Care_Places,Primary_Schools,Secondary_School,P12_schools,Other_Schools,Nearest_Health_Service,Distance_to_Nearest_Health_Service,Residential,Business,Industrial,Rural,Other,Number_Of_Households,Persons_Per_Household,Population_In_nonprivate_Dwellings,Public_Rental_Dwellings,Aboriginal_Or_Torres_Strait_Islander,Not_Completed_Year_12,Unemployed_Persons,Household_Income_Less_Than_650,Individual_Income_Less_Than_400,Household_Without_Motor_Vehicle,Household_With_Internet,One_Parent_Headed_Families,Persons_aged_75_Above_Living_Alone,Need_Assistance_With_Core_Activities,Born_Overseas,Non_Engisdh_Speaker_At_Home,Poor_English_Proficiency,Main_Cultural_group_1_Name,Main_cultural_group_1_Percentage,Main_cultural_group_2_Name,Main_cultural_group_2_Percentage,Main_cultural_group_3_Name,Main_cultural_group_3_Percentage")] Victoria victoria)
        {
            if (ModelState.IsValid)
            {
                db.Victorias.Add(victoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(victoria);
        }

        // GET: Victorias/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Victoria victoria = db.Victorias.Find(id);
            if (victoria == null)
            {
                return HttpNotFound();
            }
            return View(victoria);
        }

        // POST: Victorias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "COMM_CODE,Community_Name,Community_Type,DHS_Region,Map_Reference,Area_km_sq,Location,Road_distance_to_GPO_km,Local_Government_Area,Population_density,Primary_Care_Partnership,Number_of_localities,ABS_Remoteness_Area,Population_Difference,Funded_Activity_Types,Funded_Services,HACC_Services,Child_Protection_Services,Community_Health_Services,Homelessness,Disability_Services,Mental_Health_Services,Human_Health_Services_Sites,Human_Health_Services_Types,Dental_Sites,General_Practice_Sites,Pharmacy_Sites,Allied_Health_Sites,Complementary_Health_Sites,Child_Care_Sites,Residential_Aged_Care_Facilities,Licensed_Aged_Care_Places,Primary_Schools,Secondary_School,P12_schools,Other_Schools,Nearest_Health_Service,Distance_to_Nearest_Health_Service,Residential,Business,Industrial,Rural,Other,Number_Of_Households,Persons_Per_Household,Population_In_nonprivate_Dwellings,Public_Rental_Dwellings,Aboriginal_Or_Torres_Strait_Islander,Not_Completed_Year_12,Unemployed_Persons,Household_Income_Less_Than_650,Individual_Income_Less_Than_400,Household_Without_Motor_Vehicle,Household_With_Internet,One_Parent_Headed_Families,Persons_aged_75_Above_Living_Alone,Need_Assistance_With_Core_Activities,Born_Overseas,Non_Engisdh_Speaker_At_Home,Poor_English_Proficiency,Main_Cultural_group_1_Name,Main_cultural_group_1_Percentage,Main_cultural_group_2_Name,Main_cultural_group_2_Percentage,Main_cultural_group_3_Name,Main_cultural_group_3_Percentage")] Victoria victoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(victoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(victoria);
        }

        // GET: Victorias/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Victoria victoria = db.Victorias.Find(id);
            if (victoria == null)
            {
                return HttpNotFound();
            }
            return View(victoria);
        }

        // POST: Victorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Victoria victoria = db.Victorias.Find(id);
            db.Victorias.Remove(victoria);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SelectGroup()
        {
            List<SelectListItem> selection = new List<SelectListItem>();

            //selection.Add("AFRO-ARABIC MUSLIM");
            //selection.Add("BALKAN");
            //selection.Add("CENTRAL EUROPEAN");
            //selection.Add("DUTCH");
            //selection.Add("EAST ASIAN");
            //selection.Add("FRANCO-BELGIAN");
            //selection.Add("GERMAN");
            //selection.Add("GREEK");
            selection.Add(new SelectListItem() { Text = "---Please Select---", Value = "Test", Selected = true });
            selection.Add(new SelectListItem() { Text = "BALKAN", Value = "BALKAN", Selected = false });
            selection.Add(new SelectListItem() { Text = "AFRO-ARABIC MUSLIM", Value = "AFRO-ARABIC MUSLIM", Selected = false });
            selection.Add(new SelectListItem() { Text = "CENTRAL EUROPEAN", Value = "CENTRAL EUROPEAN", Selected = false });
            selection.Add(new SelectListItem() { Text = "DUTCH", Value = "DUTCH", Selected = false });
            selection.Add(new SelectListItem() { Text = "EAST ASIAN", Value = "EAST ASIAN", Selected = false });
            selection.Add(new SelectListItem() { Text = "GERMAN", Value = "GERMAN", Selected = false });
            selection.Add(new SelectListItem() { Text = "ITALIAN", Value = "ITALIAN", Selected = false });
            selection.Add(new SelectListItem() { Text = "GREEK", Value = "GREEK", Selected = false });

            ViewBag.Culture = selection;
            return View();
        }

        [HttpPost]
        public ActionResult SelectGroup(FormCollection form)
        {
            Style = form["Culture"];
            return RedirectToAction("ShowGroup");
        }

        public ActionResult ShowGroup()
        {
            ViewBag.Culture = Style;
            return View(db.Victorias.ToList());
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

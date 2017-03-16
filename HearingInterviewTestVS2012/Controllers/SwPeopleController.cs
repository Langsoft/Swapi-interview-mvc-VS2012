using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using HearingInterviewTest.Models;
using SharpTrooper.Core;
using System;

namespace HearingInterviewTest.Controllers
{
    public class SwPeopleController : Controller
    {
        // GET: SwPeople
        public ActionResult Index()
        {
            SharpTrooperCore st = new SharpTrooperCore();
            SwPersonVM objSwPersonVM = new SwPersonVM();
            objSwPersonVM.swPeopleObj = new List<SwPerson>();
            bool valid = true;
            int page = 1;
            int totalResults = 0;
            ///int personindex = 1; need to get Id from url!
            while (valid)
            {
                var swPeeps = st.GetAllPeople(page.ToString());

                for (int index = 0; index < swPeeps.results.Count; index++)
                {
                    // Get Character id from returned URL
                    int slashPos = swPeeps.results[index].url.LastIndexOf('/', swPeeps.results[index].url.Length - 2);
                    int noOfChars = swPeeps.results[index].url.LastIndexOf('/') - (slashPos + 1);
                    string id = swPeeps.results[index].url.Substring(slashPos + 1, noOfChars);

                    // Instantiate view model
                    SwPerson theSwPerson = new SwPerson()
                    {
                        PersonID = Convert.ToInt32(id),
                        SWName = swPeeps.results[index].name
                    };
                    objSwPersonVM.swPeopleObj.Add(theSwPerson);
                }

                totalResults += (swPeeps.results.Count);
                if (totalResults < swPeeps.count)
                    page++;
                else
                    valid = false;
            }

            return View(objSwPersonVM);
        }
    }
}
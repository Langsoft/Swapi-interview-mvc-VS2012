using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HearingInterviewTest.Models;
namespace HearingInterviewTest.Models
{
    public class SwPersonVM
    {
        public SwPerson  swPersonObj { get; set; }//contains single meeting details
        public List<SwPerson> swPeopleObj { get; set; }//list of meeting

        public string  Status {

            get
            {
                if (swPeopleObj.Count > 0)
                {
                    return "block";
                }
                else
                {
                    return "none";
                }

            }
                }//This will help us to handle the view logic

    }
}
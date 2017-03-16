using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HearingInterviewTest.Models
{
    public class SwPerson
    {
        public int PersonID { get; set; }
        public string SWName { get; set; }
    }
}
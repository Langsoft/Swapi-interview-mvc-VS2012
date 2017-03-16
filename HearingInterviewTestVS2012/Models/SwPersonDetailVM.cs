using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

/// <summary>
/// View model of Sw Person plagerised from Sharp Trooper for expediency
/// </summary>
namespace HearingInterviewTest.Models
{
    public class SwPersonDetailVM
    {
        /// <summary>
        /// An array of vehicle resources that this person has piloted
        /// </summary>
        /// 
        [DisplayName("Viehcles: ")]
        public List<string> vehicles
        {
            get;
            set;
        }

        /// <summary>
        /// The gender of this person (if known).
        /// </summary>
        [DisplayName("Gender: ")]
        public string gender
        {
            get;
            set;
        }

        /// <summary>
        /// The url of this resource
        /// </summary>
        [DisplayName("URL: ")]
        public string url
        {
            get;
            set;
        }

        /// <summary>
        /// The height of this person in meters.
        /// </summary>
        [DisplayName("Heigt: ")]
        public string height
        {
            get;
            set;
        }

        /// <summary>
        /// The hair color of this person.
        /// </summary>
        [DisplayName("Hair Colour: ")]
        public string hair_color
        {
            get;
            set;
        }

        /// <summary>
        /// The skin color of this person.
        /// </summary>
        [DisplayName("Skin Colour: ")]
        public string skin_color
        {
            get;
            set;
        }

        /// <summary>
        /// An array of starship resources that this person has piloted
        /// </summary>
        [DisplayName("Starhips: ")]
        public List<string> starships
        {
            get;
            set;
        }

        /// <summary>
        /// The name of this person.
        /// </summary>
        [DisplayName("Name: ")]
        public string name
        {
            get;
            set;
        }

        /// <summary>
        /// An array of urls of film resources that this person has been in.
        /// </summary>
        [DisplayName("Films: ")]
        public List<string> films
        {
            get;
            set;
        }

        /// <summary>
        /// The birth year of this person. BBY (Before the Battle of Yavin) or ABY (After the Battle of Yavin).
        /// </summary>
        [DisplayName("Birth Year: ")]
        public string birth_year
        {
            get;
            set;
        }

        /// <summary>
        /// The url of the planet resource that this person was born on.
        /// </summary>
        [DisplayName("Homeworld: ")]
        public string homeworld
        {
            get;
            set;
        }

        /// <summary>
        /// The url of the species resource that this person is.
        /// </summary>
        [DisplayName("Species: ")]
        public List<string> species
        {
            get;
            set;
        }

        /// <summary>
        /// The eye color of this person.
        /// </summary>
        [DisplayName("Eye Colour: ")]
        public string eye_color
        {
            get;
            set;
        }

        /// <summary>
        /// The mass of this person in kilograms.
        /// </summary>
        [DisplayName("Wheigt: ")]
        public string mass
        {
            get;
            set;
        }
    }
}

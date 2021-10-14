using BerkshireAssessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BerkshireAssessment.Data
{
    public class DAL
    {
        //-- Normally there would be connection strings to get out to the database OR this layer would be outside of this app entirely when using API. For simplicity sake I manually entered the strings. --//
        public static DataModel GetData()
        {
            DataModel data = new DataModel();
            //-- Inserted try/catch to illustrate what would be needed if this was actually connected to a database or if it was in its own API --//
            try
            {
                data.Question1 = "What Brought Me To Berkshire?";
                data.Question2 = "Why Work For Berkshire?";
                data.Question3 = "What Do I Hope To Get For Working For Berkshire?";
                data.Answer1 = "Tek Systems has informed me on the reputation you have built of the years and it impressed me. I have been told the team is highly professional and enjoy working at Berkshire.";
                data.Answer2 = "I hope to have the opportunity to learn new skills from a high level development shop, which what Berkshire is. Having the chance to work with a well established team that has been working long term within a company is a benefit that I would take advantage of to further my own development.";
                data.Answer3 = "My intention is to establish long term employment so that the team building process can be unhindered by short-timer mentality. Everything that I have heard points to Berkshire being able to enable that for myself. I hope to stay challenged and be able to have fun with the team as we build ourselves up.";
                
            } catch (Exception ex) {
                throw ex;
            }
            return data;
        }
    }
}

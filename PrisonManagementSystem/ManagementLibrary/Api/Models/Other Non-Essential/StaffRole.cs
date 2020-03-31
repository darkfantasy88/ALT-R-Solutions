using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLibrary.Api.Models.Other_Non_Essential
{
    public static class StaffRole
    {
        public static List<string> MedicalStaffRoles_ = new List<string>()
        {
            "Doctor","Psychiatrist","Psychologist"
        };
        public static List<string> TransportStaffRoles_ = new List<string>()
        {
            "Transport Staff"
        };
        public static List<string> CorrectionalStaffRoles_ = new List<string>()
        {
            "Warder"
        };
        public static List<string> ProbationalStaffRoles_ = new List<string>()
        {
            "Probation Officer","Parole Officer"
        };

        public static List<string> RehabStaffRoles_ = new List<string>()
        {
            "Instructors","Teachers"
        };
        public static List<string> ManagerialStaffRoles_ = new List<string>()
        {
            "Commissioner","Super Intendent","Human Resource Manager"
        };
        public static List<string> GeneralStaffRoles_ = new List<string>()
        {
            "Human Resource Manager Officer","Janitor","Data Entry Clerk"
        };
    }
}

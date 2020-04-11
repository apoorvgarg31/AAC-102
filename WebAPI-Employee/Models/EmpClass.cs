using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI_Employee.Models
{
    public class EmpClass
    {

        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }
       
        [Required]
        [Display(Name = "Name")]
        public string Empname { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Empemail { get; set; }
        [Required]
        [Display(Name = "Location")]
        public string emplocation { get; set; }
        [Required]
        [Display(Name = "Designation")]
        public string empdesignation { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Status")]
        public string IsActive { get; set; }
        [Required]
        [Display(Name = "Role")]
        public string Role { get; set; }
        [Required]
        [Display(Name = "Squad")]
        public string squad { get; set; }

    }

    public enum Desgination
    {
        Analyst,
        SeniorAnalyst,
        Associate,
        SeniorAssociate,
        Manager,
        SeniorManager,
        Director,
        SeniorDirector,
        EXCO

    }
    public enum IsActiveList
    {
        Active,
        Inactive

    }
    public enum RoleList
    {
        Admin,
        EngagementLead,
        SquadLead,
        SquadMember


    }
    public enum SquadList
    {
        MS1,
        PET,
        FLC,
        PPO,
        EXCO,
        UE1,
        SLS,
        MOP,
        CB1,
        DS6,



    }
    public enum Location
    {
        [Description("Enstoa US")]
        US,
        [Description("Enstoa UK")]
        UK,
        [Description("Enstoa China")]
        China,
        [Description("Enstoa India")]
        India,
        [Description("Enstoa Dubai")]
        Dubai,
        [Description("Enstoa Riyadh")]
        Riyadh,
        [Description("Enstoa S.Korea")]
        Korea,
        [Description("Enstoa Australia")]
        Australia


    }
}
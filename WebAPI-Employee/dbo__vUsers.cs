//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI_Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class dbo__vUsers
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
        Execo

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
        DS6
    }
}

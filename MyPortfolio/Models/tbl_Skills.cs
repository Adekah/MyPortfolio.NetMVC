//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPortfolio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Skills
    {
        public int Skill_id { get; set; }
        public Nullable<int> User_id { get; set; }
        public string SkillName { get; set; }
        public string SkillDetail { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tweet
    {
        public int Tweet_Id { get; set; }
        public string User_Id { get; set; }
        public string Message { get; set; }
        public System.DateTime Created { get; set; }
    
        public virtual Person Person { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registo_Prof_Ano
    {
        public int id { get; set; }
        public int prof { get; set; }
        public string uc { get; set; }
        public int ano { get; set; }
    
        public virtual Professor Professor { get; set; }
        public virtual UC UC1 { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JustynaKozbaLab8Zad1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class JustynaKozbaScore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JustynaKozbaScore()
        {
            this.JustynaKozbaScore1 = new HashSet<JustynaKozbaScore>();
        }
    
        public short Id { get; set; }
        public string Login { get; set; }
        public Nullable<int> Score { get; set; }
        public Nullable<short> UserId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JustynaKozbaScore> JustynaKozbaScore1 { get; set; }
        public virtual JustynaKozbaScore JustynaKozbaScore2 { get; set; }
    }
}

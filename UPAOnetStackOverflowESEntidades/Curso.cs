//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPAOnetStackOverflowESEntidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Curso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Curso()
        {
            this.EnlaceEstudianteCursoes = new HashSet<EnlaceEstudianteCurso>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }
        public Nullable<int> Capacidad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnlaceEstudianteCurso> EnlaceEstudianteCursoes { get; set; }
    }
}
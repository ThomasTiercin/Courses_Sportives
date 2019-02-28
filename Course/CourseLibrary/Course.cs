//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.POI = new HashSet<POI>();
            this.Utilisateur2 = new HashSet<Utilisateur>();
        }
    
        public int ID { get; set; }
        public string Nom { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> VilleID { get; set; }
        public Nullable<int> Organisateur { get; set; }
        public Nullable<int> SportID { get; set; }
    
        public virtual Utilisateur Utilisateur { get; set; }
        public virtual Utilisateur Utilisateur1 { get; set; }
        public virtual Sport Sport { get; set; }
        public virtual Ville Ville { get; set; }
        public virtual Ville Ville1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POI> POI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Utilisateur> Utilisateur2 { get; set; }
    }
}

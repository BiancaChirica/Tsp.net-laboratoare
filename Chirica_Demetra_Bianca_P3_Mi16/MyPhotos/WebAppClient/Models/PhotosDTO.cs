using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppClient.Models
{
    using System;
    using System.Runtime.Serialization;
    [DataContract(IsReference = true)]
    public class PhotosDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        public PhotosDTO()
        {
            this.Proprietates = new HashSet<ProprietatiDTO>();
        }
        public PhotosDTO(String path, DateTime data_creare, String descriere = "")
        {
            this.Proprietates = new HashSet<ProprietatiDTO>();


            this.Proprietates = new HashSet<ProprietatiDTO>();
            this.Path = path;
            Data_creare = data_creare;
            Descriere = descriere;
            Deleted = false;

        }
        [DataMember]
        public int PhotoId { get; set; }
        [DataMember]
        public string Path { get; set; }
        [DataMember]
        public System.DateTime Data_creare { get; set; }
        [DataMember]
        public string Descriere { get; set; }
        [DataMember]
        public bool Deleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<ProprietatiDTO> Proprietates { get; set; } 
}
}

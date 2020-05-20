using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppClient.Models
{
    using System;
    using System.Runtime.Serialization;
    [DataContract(IsReference = true)]
  
    public class ProprietatiDTO
    { 
        public ProprietatiDTO()
        {

        }

        public ProprietatiDTO(String numeP, String valoareP, PhotosDTO ph)
        {

            NumeProprietate = numeP;
            ValoareProprietate = valoareP;
            PhotoPhotoId = ph.PhotoId;
            Photo = ph;

        }
        [DataMember]
        public int ProprietateId { get; set; }
        [DataMember]
        public string NumeProprietate { get; set; }
        [DataMember]
        public string ValoareProprietate { get; set; }
        [DataMember]
        public int PhotoPhotoId { get; set; }
        [DataMember]
        public virtual PhotosDTO Photo { get; set; }
    }
}

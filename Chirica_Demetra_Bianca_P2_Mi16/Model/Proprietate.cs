//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPhotos
{
    using System;
    using System.Runtime.Serialization;

    [DataContract(IsReference = true)]
    public partial class Proprietate
    {
        public Proprietate()
        {

        }

        public Proprietate(String numeP, String valoareP, Photo ph)
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
        public virtual Photo Photo { get; set; }
    }
}

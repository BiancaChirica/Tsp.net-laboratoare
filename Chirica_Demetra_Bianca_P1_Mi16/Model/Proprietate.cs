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

        public int ProprietateId { get; set; }
        public string NumeProprietate { get; set; }
        public string ValoareProprietate { get; set; }
        public int PhotoPhotoId { get; set; }
    
        public virtual Photo Photo { get; set; }
    }
}
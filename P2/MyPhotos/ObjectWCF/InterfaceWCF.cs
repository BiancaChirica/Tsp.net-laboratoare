using MyPhotos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfacePhoto
    {
        [OperationContract]
        String AddPhotoWCF(String path, DateTime data_creare, String description);
        [OperationContract]
        String DeletePhotoWCF(int id);
        [OperationContract]
        List<Photo> GetAllPhotosWCF();

        [OperationContract]
        Photo EditPhotoWCF(int id, String path, DateTime data_creare, String description);
        [OperationContract]
        Photo GetPhotosByIdWCF(int id);
        [OperationContract]
        List<Photo> GetPhotosByDescriereWCF(String descriere);
        [OperationContract]
        List<Photo> GetPhotosByDateWCF(DateTime date);
        [OperationContract]
        String MarkDeletedWCF(int id);

    }
    [ServiceContract]
    interface InterfaceProperty
    {
        [OperationContract]
        string AddProprietateWCF(int photoid, string numeProp, string valoareProp);
        [OperationContract]
        String DeleteProprietateWCF(int idProp);
        [OperationContract]
        String EditProprietateWCF(int id, String numeP, String valoareP);
        [OperationContract]
        List<Proprietate> GetAllProprietatiWCF();
        [OperationContract]
        List<Proprietate> GetProprietatiByNameWCF(String numeP);
        [OperationContract]
        List<Proprietate> GetProprietatiByValueWCF(String valoareP);
        [OperationContract]
        List<Proprietate> GetProprietatiByNameAndValueWCF(String numeP, String valoareP);
        [OperationContract]
        List<Proprietate> GetProprietatiByIdWCF(int idPhoto);
    }
    [ServiceContract]
    interface IPhotoProperty: InterfacePhoto, InterfaceProperty
    {
    }
}

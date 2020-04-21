using MyPhotos;
using System;
using System.Collections.Generic;

namespace ObjectWCF
{
    public class PhotoProperty : IPhotoProperty
    {
        String InterfacePhoto.AddPhotoWCF(String path, DateTime data_creare, String description)
        {
            ApiPhoto apiPhoto = new ApiPhoto();
            return apiPhoto.AddPhoto(path, data_creare,description);
        }

        String InterfacePhoto.DeletePhotoWCF(int id)
        {
            ApiPhoto apiPhoto = new ApiPhoto();
            return apiPhoto.DeletePhoto(id);
        }

        List<Photo> InterfacePhoto.GetAllPhotosWCF()
        {
            ApiPhoto apiPhoto = new ApiPhoto();
            return apiPhoto.GetAllPhotos();
        }

        Photo InterfacePhoto.EditPhotoWCF(int id, String path, DateTime data_creare, String description)
        {
            ApiPhoto apiPhoto = new ApiPhoto();
            return apiPhoto.EditPhoto(id, path, data_creare, description);
        }

        Photo InterfacePhoto.GetPhotosByIdWCF(int id)
        {
            ApiPhoto apiPhoto = new ApiPhoto();
            return apiPhoto.GetPhotosById(id);
        }

        List<Photo> InterfacePhoto.GetPhotosByDescriereWCF(String descriere)
        {
            ApiPhoto apiPhoto = new ApiPhoto();
            return apiPhoto.GetPhotosByDescriere(descriere);
        }

        List<Photo> InterfacePhoto.GetPhotosByDateWCF(DateTime date)
        {
            ApiPhoto apiPhoto = new ApiPhoto();
            return apiPhoto.GetPhotosByDate(date);
        }

        String InterfacePhoto.MarkDeletedWCF(int id)
        {
            ApiPhoto apiPhoto = new ApiPhoto();
            return apiPhoto.MarkDeleted(id);
        }

        ///

        string InterfaceProperty.AddProprietateWCF(int photoid, string numeProp, string valoareProp)
        {
            apiProprietate apiProprietate = new apiProprietate();
            return apiProprietate.AddProprietate(photoid,numeProp,valoareProp);
        }

        String InterfaceProperty.DeleteProprietateWCF(int idProp)
        {
            apiProprietate apiProprietate = new apiProprietate();
            return apiProprietate.DeleteProprietate(idProp);
        }

        String InterfaceProperty.EditProprietateWCF(int id, String numeP, String valoareP)
        {
            apiProprietate apiProprietate = new apiProprietate();
            return apiProprietate.EditProprietate(id, numeP, valoareP);
        }

        List<Proprietate> InterfaceProperty.GetAllProprietatiWCF()
        {
            apiProprietate apiProprietate = new apiProprietate();
            return apiProprietate.GetAllProprietati();
        }
        List<Proprietate> InterfaceProperty.GetProprietatiByNameWCF(String numeP)
        {
            apiProprietate apiProprietate = new apiProprietate();
            return apiProprietate.GetProprietatiByName(numeP);
        }

        List<Proprietate> InterfaceProperty.GetProprietatiByValueWCF(String valoareP)
        {
            apiProprietate apiProprietate = new apiProprietate();
            return apiProprietate.GetProprietatiByValue(valoareP);
        }
        List<Proprietate> InterfaceProperty.GetProprietatiByNameAndValueWCF(String numeP, String valoareP)
        {
            apiProprietate apiProprietate = new apiProprietate();
            return apiProprietate.GetProprietatiByNameAndValue(numeP, valoareP);
        }

        List<Proprietate> InterfaceProperty.GetProprietatiByIdWCF(int idPhoto)
        {
            apiProprietate apiProprietate = new apiProprietate();
            return apiProprietate.GetProprietatiById(idPhoto);
        }

    }
}

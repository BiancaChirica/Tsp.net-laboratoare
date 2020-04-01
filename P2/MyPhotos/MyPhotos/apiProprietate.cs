using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPhotos
{
    public class apiProprietate
    {
        private ModelBDContainer ctx;

        public apiProprietate()
        {

        }

        // insert : adauga o proprietate nou la o poza existenta
        public string AddProprietate(int photoid, string numeProp, string valoareProp)
        {
            using (ctx = new ModelBDContainer())
            {

                // verificare parametri
                if (photoid == 0 || numeProp == null || valoareProp == null)
                {
                    return "Empty parameters.";
                }

                try
                {
                    Photo photo = ctx.Photos.Where(p => p.PhotoId == photoid).SingleOrDefault();
                    if (photo == null)
                    {
                        return "No photo with that id.";
                    }

                    if (photo.Deleted == true)
                    {
                        return "Photo marked as deleted.";
                    }

                    Proprietate propNew = new Proprietate(numeProp, valoareProp, photo);

                    //verificare daca exista deja
                 if (ctx.Proprietati.Where(p => p.NumeProprietate == propNew.NumeProprietate && p.ValoareProprietate == propNew.ValoareProprietate && p.Photo.PhotoId == propNew.Photo.PhotoId ).Any())
                    {
                        return "Already exists.";
                    }

                    ctx.Proprietati.Add(propNew);
                    var colectieProp = photo.Proprietates;
                    colectieProp.Add(propNew);
                    photo.Proprietates = colectieProp;
                    ctx.SaveChanges();
                    return "OK";

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return "More than one photo with that id.";
                }

            }
        }


        //delete Prop
        public String DeleteProprietate(int idProp)
        {
            using (ctx = new ModelBDContainer())
            {
                try
                { 
                    var number = ctx.Proprietati.Where(k => k.ProprietateId == idProp).Count();
                    if (number != 1)
                    {
                        return "Can't find property.";
                    }

                    var obj = ctx.Proprietati.Where(k => k.ProprietateId == idProp).SingleOrDefault();

                    if (obj == null)
                    {
                        return "Can't find property.";
                    }

                    obj.Photo.Proprietates.Remove(obj);
                    ctx.Proprietati.Remove(obj);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return "Unexpected exception.";
                }

                return "Ok";

            }
        }

        // edit Prop
        public String EditProprietate(int id, String numeP, String valoareP)
        {
            using (ctx = new ModelBDContainer())
            {
                try
                {
                    var number = ctx.Proprietati.Where(k => k.ProprietateId == id).Count();
                    if (number != 1)
                    {
                        Console.WriteLine("Can't find property or too many.");
                        return "Can't find property.";
                    }

                    var obj = ctx.Proprietati.Where(k => k.ProprietateId == id).SingleOrDefault();

                    if (obj == null)
                    {
                        return "Can't find property.";

                    }

                    obj.NumeProprietate = numeP;
                    obj.ValoareProprietate = valoareP;
                    ctx.SaveChanges();
                    return "OK";


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return "Unexpected exception.";
                }
            }
        }


        //get by id
        public List<Proprietate> GetAllProprietati()
        {
            using (ctx = new ModelBDContainer())
            {
                return ctx.Proprietati.ToList();
            }
        }

        //get by Propertyname
        public List<Proprietate> GetProprietatiByName(String numeP)
        {
            using (ctx = new ModelBDContainer())
            {
                return ctx.Proprietati.Where(p => p.NumeProprietate == numeP).ToList();
            }
        }

        //get by PropertyValue
        public List<Proprietate> GetProprietatiByValue(String valoareP)
        {
            using (ctx = new ModelBDContainer())
            {
                return ctx.Proprietati.Where(p => p.ValoareProprietate == valoareP).ToList();
            }
        }

        //get by PropertyValue and propertyName
        public List<Proprietate> GetProprietatiByNameAndValue(String numeP, String valoareP)
        {
            using (ctx = new ModelBDContainer())
            {
                return ctx.Proprietati.Where(p => p.ValoareProprietate == valoareP && p.NumeProprietate == numeP).ToList();
            }
        }

        //get by photo id
        public List<Proprietate> GetProprietatiById(int idPhoto)
        {
            using (ctx = new ModelBDContainer())
            {
                return ctx.Proprietati.Where(p => p.Photo.PhotoId == idPhoto).ToList();
            }
        }


    }
}

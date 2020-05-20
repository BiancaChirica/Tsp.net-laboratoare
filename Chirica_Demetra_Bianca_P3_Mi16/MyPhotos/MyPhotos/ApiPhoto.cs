using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyPhotos
{
    public class ApiPhoto
    {
        private ModelBDContainer ctx;
        public ApiPhoto()
        {
        }


        // insert : adauga in Photos o noua poza, doar fisier
        public String AddPhoto(String path, DateTime data_creare, String description)
        {

            using (ctx = new ModelBDContainer())
            {
                Photo new_photo;

                // verificare parametri
                if (path == null || data_creare == null || description == null)
                {
                    return "Empty parameters.";
                }

                // daca exista calea
                if (!File.Exists(path))
                {
                    return "File doesn't exist.";
                }

                // verificare sa nu fie deja salvata imaginea 
                if (ctx.Photos.Where(p => p.Path.Equals(path)).Any() == true)
                {
                    return "File already exists.";
                }

                //verificare data -> trecut
                if (data_creare >= DateTime.Now.AddDays(1))
                {
                    return "Date not good.";
                }

                new_photo = new Photo(path, data_creare, description);

                try
                {
                    ctx.Photos.Add(new_photo);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    return e.ToString();

                }


                return "OK";
            }
        }

        //delete MYPhotos
        public String DeletePhoto(int id)
        {
            using (ctx = new ModelBDContainer())
            {

                if (id <= 0)
                {
                    return "Empty parameters";
                }

                try
                {
                    var number = ctx.Photos.Where(k => k.PhotoId == id).Count();
                    if (number != 1)
                    {
                        return "Can't find file.";
                    }

                    Photo obj = ctx.Photos.Where(k => k.PhotoId == id).SingleOrDefault();
                    if (obj == null)
                    {
                        return "Can't find file.";
                    }

                    ctx.Entry(obj).Collection(d => d.Proprietates).Load();
                    var prop = obj.Proprietates;

                    // stergem proprietatile si apoi poza
                    foreach (Proprietate item in prop)
                    {
                        ctx.Proprietati.Remove(item);
                    }

  
                    ctx.Photos.Remove(obj);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return e.ToString();
                }

                return "Ok";
            }
        }

        // get all
        public List<Photo> GetAllPhotos()
        {
            using (ctx = new ModelBDContainer())
            {
                return ctx.Photos.Include("Proprietates").ToList();
            }
        }


        //edit MYPhotos
        public Photo EditPhoto(int id, String path, DateTime data_creare, String description)
        {
            using (ctx = new ModelBDContainer())
            {
                try
                {
                    var photoEdit = ctx.Photos.Where(p => p.PhotoId == id).SingleOrDefault();
                    if (photoEdit == null)
                    {
                        Console.WriteLine("Can't find photo to edit.");
                        return null;
                    }

                    photoEdit.Path = path;
                    photoEdit.Data_creare = data_creare;
                    photoEdit.Descriere = description;
                    ctx.SaveChanges();
                    return photoEdit;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    Console.WriteLine("More photos with the same id.");
                    return null;
                }
            }
        }

        // get by data
        public List<Photo> GetPhotosByDate(DateTime date)
        {
            using (ctx = new ModelBDContainer())
            {
                return ctx.Photos.Where(p => p.Data_creare == date).ToList();
            }
        }

        // get by id
        public Photo GetPhotosById(int id)
        {
            using (ctx = new ModelBDContainer())
            {
                return ctx.Photos.Include("Proprietates").Where(p => p.PhotoId == id).ToList().FirstOrDefault();
            }
        }

        // get by path
        public List<Photo> GetPhotosByPath(string path)
        {
            using (ctx = new ModelBDContainer())
            {
                if (path == null)
                {
                    return null;
                }
                return ctx.Photos.Where(p => p.Path == path).ToList();
            }
        }

        // get by descriere
        public List<Photo> GetPhotosByDescriere(String descriere)
        {
            using (ctx = new ModelBDContainer())
            {
                return ctx.Photos.Where(p => p.Descriere == descriere).ToList();
            }
        }

        // set deleted true
        public String MarkDeleted(int id)
        {
            using (ctx = new ModelBDContainer())
            {
                try
                {
                    var ph = ctx.Photos.Where(p => p.PhotoId == id).SingleOrDefault();
                    if (ph == null)
                    {
                        return "No file with that id to mark as deleted.";
                    }

                    ph.Deleted = true;
                    ctx.SaveChanges();
                    return "OK";
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return "More than one file with that id";
                }
            }
        }



    }
}

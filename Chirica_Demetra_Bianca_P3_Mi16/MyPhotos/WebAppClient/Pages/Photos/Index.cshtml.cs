using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppClient.Models;
using ServiceReferenceMyPhotos;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebAppClient.Pages.Photos
{
    public class IndexModel : PageModel
    {
        PhotoPropertyClient pcc = new PhotoPropertyClient();
        public List<PhotosDTO> Photos { get; set; }


        [Microsoft.AspNetCore.Mvc.BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList ProprietatiList { get; set; }


        [BindProperty(SupportsGet = true)]
        public string PhotoProp { get; set; }

        public IndexModel()
        {
            Photos = new List<PhotosDTO>();
        }
        public async Task OnGetAsync()
        {

            var posts = await pcc.GetAllPhotosWCFAsync();

            foreach (var item in posts)
            {
                bool containsProp = false;
                bool containsPropValue = false;
                // Trebuia folosit AutoMapper. Transform Post in PostDTO
                PhotosDTO pd = new PhotosDTO();
                pd.PhotoId = item.PhotoId;
                pd.Path = item.Path;
                pd.Data_creare = item.Data_creare;
                pd.Descriere = item.Descriere;
                pd.Deleted = item.Deleted;

                foreach (var cc in item.Proprietates)
                {
                    ProprietatiDTO cdto = new ProprietatiDTO();
                    cdto.ProprietateId = cc.ProprietateId;
                    cdto.NumeProprietate = cc.NumeProprietate;
                    cdto.ValoareProprietate = cc.ValoareProprietate;
                    cdto.PhotoPhotoId = cc.PhotoPhotoId;

                    pd.Proprietates.Add(cdto);


                    if (!string.IsNullOrEmpty(PhotoProp) && cdto.NumeProprietate.Equals(PhotoProp))
                    {
                        containsProp = true;
                    }


                    if (!string.IsNullOrEmpty(SearchString) && cdto.ValoareProprietate.Equals(SearchString))
                    {
                        containsPropValue = true;
                    }
                }

                //search by prop and value
                if (!string.IsNullOrEmpty(SearchString) && !string.IsNullOrEmpty(PhotoProp))
                {
                    if (containsProp && containsPropValue)
                        Photos.Add(pd);
                }
                else
                {      // search by nothing
                    if (string.IsNullOrEmpty(SearchString) && string.IsNullOrEmpty(PhotoProp))
                        Photos.Add(pd);
                    else
                    {
                        if (!string.IsNullOrEmpty(PhotoProp))
                        {
                            if (containsProp)
                                Photos.Add(pd);
                        }
                        else
                            if (containsPropValue)
                            Photos.Add(pd);
                    }
                }

                ViewData["PhotoFound"] = Photos.Count().ToString();
                ///search by prop list
                var Props = new List<string>();
                var proplst = await pcc.GetAllProprietatiWCFAsync();
                foreach (var pr in proplst)
                {
                    Props.Add(pr.NumeProprietate);
                }

                Props.Sort();
                Props = Props.Distinct().ToList();

                ProprietatiList = new SelectList(Props);
            }
        }
    }
}


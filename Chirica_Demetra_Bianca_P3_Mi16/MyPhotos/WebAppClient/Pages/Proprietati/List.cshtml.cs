using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppClient.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceMyPhotos;
using System.Collections;

namespace WebAppClient.Pages.Proprietati
{
    public class ListModel : PageModel
    {
        PhotoPropertyClient pcc = new PhotoPropertyClient();
        public List<ProprietatiDTO> Proprietati { get; set; }
        public ListModel()
        {
            Proprietati = new List<ProprietatiDTO>();
        }
        public async Task OnGetAsync(int? id)
        {
   

            if (!id.HasValue)
                return;
            var item = await pcc.GetPhotosByIdWCFAsync(id.Value);
            ViewData["Photo"] = item.PhotoId.ToString() + " : " + item.Descriere.Trim();

            foreach (var cc in item.Proprietates)
            {
                ProprietatiDTO cdto = new ProprietatiDTO();
                cdto.ProprietateId = cc.ProprietateId;
                cdto.NumeProprietate = cc.NumeProprietate;
                cdto.ValoareProprietate = cc.ValoareProprietate;
                cdto.PhotoPhotoId = cc.PhotoPhotoId;

                Proprietati.Add(cdto);
            }
            // o singura data si alfabetic

            Proprietati.Sort(new MyClassComparer());
            List<ProprietatiDTO> noDuplicates = Proprietati.Distinct().ToList();
            Proprietati = noDuplicates.ToList(); ;
        }
    }
    public class MyClassComparer : IComparer<ProprietatiDTO>
    {
        public int Compare(ProprietatiDTO _x, ProprietatiDTO _y)
        {
            return _x.NumeProprietate.CompareTo(_y.NumeProprietate);
        }
    }

}
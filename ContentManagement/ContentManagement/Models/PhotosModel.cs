using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SCM.CLL;
using SCM.DAL;

namespace ContentManagement.Models
{
    public class PhotosModel
    {
        public Guid PhotoId { get; set; }
        public Guid ParentId { get; set; }
        public string Title { get; set; }
        public string SmallDescription { get; set; }
        public string AlternativeText { get; set; }
        public string Photourl { get; set; }
        public List<PhotosModel> PhotosByParentId()
        {List<PhotosModel> Modelitems=new List<PhotosModel>();
            List<Photos> items = new PhotosRepository().ShowPhotosByParentId(new Guid("59ef2601-e4e4-423e-8bb7-d5b1d589f028"));
            foreach (Photos item in items)
            { PhotosModel modelitem =ClassToModel( item); Modelitems.Add(modelitem); }
            return Modelitems;
        }
      internal PhotosModel ClassToModel(Photos item)
      {
          PhotosModel  mitem=new PhotosModel();
          mitem.PhotoId = item.PhotoId;
          mitem.ParentId = item.ParentId;
          mitem.Title = item.Title;
          mitem.SmallDescription = item.SmallDescription;
          mitem.AlternativeText = item.AlternativeText;
          mitem.Photourl ="images/"+item.PhotoId+".jpg";
          return mitem;
      }
      // string url=@"<img src="\"images/2.jpg" alt="""second image""" width="""460""" height="""345"">";
               
    }
}
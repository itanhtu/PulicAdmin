using Source.Models.DBF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Models
{
    public class EFRepository : IRepository
    {
        private admin_hifivetestContext context;
        public EFRepository(admin_hifivetestContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Tbadmin> tbadmins => context.Tbadmin;
        public IQueryable<Tbbaivietuser> tbbaivietusers => context.Tbbaivietuser;
        public IQueryable<Tbbanggiachitietuser> tbbanggiachitietusers => context.Tbbanggiachitietuser;
        public IQueryable<Tbbanggiagoidichvu> tbbanggiagoidichvus => context.Tbbanggiagoidichvu;
        public IQueryable<Tbbanggiauser> tbbanggiausers => context.Tbbanggiauser;
        public IQueryable<Tbbanneruser> tbbannerusers => context.Tbbanneruser;
        public IQueryable<Tbbaogia> tbbaogias => context.Tbbaogia;
        public IQueryable<Tbbaogiachitiet> tbbaogiachitiets => context.Tbbaogiachitiet;
        public IQueryable<Tbbaogialienquan> tbbaogialienquans => context.Tbbaogialienquan;
        public IQueryable<Tbcategory> tbcategories => context.Tbcategory;
        public IQueryable<Tbcontact> tbcontacts => context.Tbcontact;
        public IQueryable<Tbform> tbforms => context.Tbform;
        public IQueryable<TbformAccess> tbformAccesses => context.TbformAccess;
        public IQueryable<Tbgiaproject> tbgiaprojects => context.Tbgiaproject;
        public IQueryable<Tbgroup> tbgroups => context.Tbgroup;
        public IQueryable<Tbgroupcate> tbgroupcates => context.Tbgroupcate;
        public IQueryable<Tbimageproject> tbimageprojects => context.Tbimageproject;
        public IQueryable<Tbintroduce> tbintroduces => context.Tbintroduce;
        public IQueryable<Tblanguage> tblanguages => context.Tblanguage;
        public IQueryable<Tblogo> tblogos => context.Tblogo;
        public IQueryable<Tbmodule> tbmodules => context.Tbmodule;
        public IQueryable<Tbnews> tbnews => context.Tbnews;
        public IQueryable<Tbnewscate> tbnewscates => context.Tbnewscate;
        public IQueryable<Tbproject> tbprojects => context.Tbproject;
        public IQueryable<Tbreviewscustome> tbreviewscustomes => context.Tbreviewscustome;
        public IQueryable<Tbseo> tbseos => context.Tbseo;
        public IQueryable<TbseoDetail> tbseoDetails => context.TbseoDetail;
        public IQueryable<Tbservice> tbservices => context.Tbservice;
        public IQueryable<Tbservicedetail> tbservicedetails => context.Tbservicedetail;
        public IQueryable<Tbslide> tbslides => context.Tbslide;
        public IQueryable<Tbvideo> tbvideos => context.Tbvideo;
        public IQueryable<abc> abcs => context.abcs;
        public void SaveNewsCate(Tbnewscate newscate)
        {
            if (newscate.NewscateId == 0)
            {
                context.Tbnewscate.Add(newscate);
            }
            else
            {
                Tbnewscate newcate = context.Tbnewscate
                    .FirstOrDefault(p => p.NewscateId == newscate.NewscateId);
                if (newcate != null)
                {
                    newcate.NewscateName = newscate.NewscateName;
                    newcate.NewscateNote = newscate.NewscateNote;
                }
            }
            context.SaveChanges();
        }
        public void NewsCateDelete(int newscate_id)
        {
            var newscate = context.Tbnewscate.FirstOrDefault(x => x.NewscateId == newscate_id);
            if(newscate!=null)
            {
                context.Tbnewscate.Remove(newscate);
                context.SaveChanges();
            }
        }
        public void SaveNews(Tbnews model)
        {
            if (model.NewsId == 0)
            {
                context.Tbnews.Add(model);
            }
            else
            {
                Tbnews news = context.Tbnews
                    .FirstOrDefault(p => p.NewsId == model.NewsId);
                if (news != null)
                {
                    news.NewsContent = model.NewsContent;
                    news.NewscateId = model.NewscateId;
                    news.Datecreated = model.Datecreated;
                    news.NewsSummary = model.NewsSummary;
                    news.NewsTitle = model.NewsTitle;
                    news.NewsImage = model.NewsImage;
                    news.Datemodified = DateTime.Now;
                }
            }
            context.SaveChanges();
        }
        public void NewsDelete(int news_id)
        {
            var news = context.Tbnews.FirstOrDefault(x => x.NewsId == news_id);
            if (news != null)
            {
                context.Tbnews.Remove(news);
                context.SaveChanges();
            }
        }
        public void SaveNhomLoai(Tbgroupcate model)
        {
            if (model.GroupcateId == 0)
            {
                context.Tbgroupcate.Add(model);
            }
            else
            {
                Tbgroupcate news = context.Tbgroupcate
                    .FirstOrDefault(p => p.GroupcateId == model.GroupcateId);
                if (news != null)
                {
                    news.GroupcateName = model.GroupcateName;
                    news.GroupcateIcon = model.GroupcateIcon;
                    news.Position = model.Position;
                    news.GroupcateDepcription = model.GroupcateDepcription;
                }
            }
            context.SaveChanges();
        }
        public void NhomLoaiDelete(int groupcate_id)
        {
            var groupcate = context.Tbgroupcate.FirstOrDefault(x => x.GroupcateId == groupcate_id);
            if (groupcate != null)
            {
                context.Tbgroupcate.Remove(groupcate);
                context.SaveChanges();
            }
        }
        public void SaveNhomDuAn(Tbcategory model)
        {
            if (model.CategoryId == 0)
            {
                context.Tbcategory.Add(model);
            }
            else
            {
                Tbcategory category = context.Tbcategory
                    .FirstOrDefault(p => p.CategoryId == model.CategoryId);
                if (category != null)
                {
                    category.CategoryName = model.CategoryName;
                    category.GroupcateId = model.GroupcateId;
                    category.CategoryIcon = model.CategoryIcon;
                    category.CategoryDepcription = model.CategoryDepcription;
                }
            }
            context.SaveChanges();
        }
        public void NhomDuAnDelete(int cate_id)
        {
            var category = context.Tbcategory.FirstOrDefault(x => x.CategoryId == cate_id);
            if (category != null)
            {
                context.Tbcategory.Remove(category);
                context.SaveChanges();
            }
        }
        public void SaveDichVu(Tbservice model)
        {
            if (model.ServiceId == 0)
            {
                context.Tbservice.Add(model);
            }
            else
            {
                //Tbservice service = context.Tbservice
                //    .FirstOrDefault(p => p.ServiceId == model.ServiceId);
                //if (service != null)
                //{
                //    service.CategoryName = model.CategoryName;
                //    service.GroupcateId = model.GroupcateId;
                //    service.CategoryIcon = model.CategoryIcon;
                //    service.CategoryDepcription = model.CategoryDepcription;
                //}
            }
            context.SaveChanges();
        }
        public void DichVuDelete(int cate_id)
        {
            var category = context.Tbcategory.FirstOrDefault(x => x.CategoryId == cate_id);
            if (category != null)
            {
                context.Tbcategory.Remove(category);
                context.SaveChanges();
            }
        }
        public void SaveDuAn(Tbproject model)
        {
            if (model.ProjectId == 0)
            {
                context.Tbproject.Add(model);
            }
            else
            {
                Tbproject project = context.Tbproject
                    .FirstOrDefault(p => p.ProjectId == model.ProjectId);
                if (project != null)
                {
                    project.ProjectName = model.ProjectName;
                    project.CategoryId = model.CategoryId;
                    project.ServiceId = model.ServiceId;
                    project.ProjectHidden = model.ProjectHidden;
                    project.ProjectLink = model.ProjectLink;
                    project.ProjectContent = model.ProjectContent;
                    project.ProjectImage = model.ProjectImage;
                }
            }
            context.SaveChanges();
        }
        public void DuAnDelete(int project_id)
        {
            var project = context.Tbproject.FirstOrDefault(x => x.ProjectId == project_id);
            if (project != null)
            {
                context.Tbproject.Remove(project);
                context.SaveChanges();
            }
        }
        public void SaveDichVuChiTiet(Tbservicedetail model)
        {
            if (model.ServicedetailId == 0)
            {
                context.Tbservicedetail.Add(model);
            }
            else
            {
                Tbservicedetail servicedetail = context.Tbservicedetail
                    .FirstOrDefault(p => p.ServicedetailId == model.ServicedetailId);
                if (servicedetail != null)
                {
                    servicedetail.ServicedetailTitle = model.ServicedetailTitle;
                    servicedetail.ServiceId = model.ServiceId;
                    servicedetail.ServicedetailContent = model.ServicedetailContent;
                }
            }
            context.SaveChanges();
        }
        public void DichVuChiTietDelete(int servicedetail_id)
        {
            var servicedetail = context.Tbservicedetail.FirstOrDefault(x => x.ServicedetailId == servicedetail_id);
            if (servicedetail != null)
            {
                context.Tbservicedetail.Remove(servicedetail);
                context.SaveChanges();
            }
        }

        public void SaveBaoGia(Tbbaogia model)
        {
            if (model.BaogiaId == 0)
            {
                context.Tbbaogia.Add(model);
            }
            else
            {
                Tbbaogia baogia = context.Tbbaogia
                    .FirstOrDefault(p => p.BaogiaId == model.BaogiaId);
                if (baogia != null)
                {
                    baogia.BaogiaTitle1 = model.BaogiaTitle1;
                    baogia.BaogiaTitle2 = model.BaogiaTitle2;
                    baogia.BaogiaTitle3 = model.BaogiaTitle3;
                    baogia.BaogiaTitle4 = model.BaogiaTitle4;
                    baogia.BaogiaTitle5 = model.BaogiaTitle5;
                    baogia.BaogiaTitle6 = model.BaogiaTitle6;
                    baogia.BaogiaTitle7 = model.BaogiaTitle7;
                    baogia.BaogiaTitle8 = model.BaogiaTitle8;
                    baogia.BaogiaTitle9 = model.BaogiaTitle9;
                    baogia.BaogiaContent = model.BaogiaContent;
                    baogia.Position = model.Position;
                }
            }
            context.SaveChanges();
        }
        public void BaoGiaDelete(int baogia_id)
        {
            var baogia = context.Tbbaogia.FirstOrDefault(x => x.BaogiaId == baogia_id);
            if (baogia != null)
            {
                context.Tbbaogia.Remove(baogia);
                context.SaveChanges();
            }
        }
        public void SaveBaoGiaChiTiet(Tbbaogiachitiet model)
        {
            if (model.BaogiachitietId == 0)
            {
                context.Tbbaogiachitiet.Add(model);
            }
            else
            {
                Tbbaogiachitiet baogia = context.Tbbaogiachitiet
                    .FirstOrDefault(p => p.BaogiachitietId == model.BaogiachitietId);
                if (baogia != null)
                {
                    baogia.BaogiachitietTitle1 = model.BaogiachitietTitle1;
                    baogia.BaogiachitietTitle2 = model.BaogiachitietTitle2;
                    baogia.BaogiachitietTitle3 = model.BaogiachitietTitle3;
                    baogia.BaogiachitietTitle4 = model.BaogiachitietTitle4;
                    baogia.BaogiachitietTitle5 = model.BaogiachitietTitle5;
                    baogia.BaogiachitietTitle6 = model.BaogiachitietTitle6;
                    baogia.BaogiachitietTitle7 = model.BaogiachitietTitle7;
                    baogia.BaogiachitietTitle8 = model.BaogiachitietTitle8;
                    baogia.BaogiachitietTitle9 = model.BaogiachitietTitle9;
                    baogia.BaogiachitietTitle10 = model.BaogiachitietTitle10;
                    baogia.BaogiachitietContent = model.BaogiachitietContent;
                    baogia.Position = model.Position;
                }
            }
            context.SaveChanges();
        }
        public void BaoGiaChiTietDelete(int baogia_id)
        {
            var baogia = context.Tbbaogiachitiet.FirstOrDefault(x => x.BaogiachitietId == baogia_id);
            if (baogia != null)
            {
                context.Tbbaogiachitiet.Remove(baogia);
                context.SaveChanges();
            }
        }
        public void SaveBaoGiaLienQuan(Tbbaogialienquan model)
        {
            if (model.BaogialienquanId == 0)
            {
                context.Tbbaogialienquan.Add(model);
            }
            else
            {
                Tbbaogialienquan baogia = context.Tbbaogialienquan
                    .FirstOrDefault(p => p.BaogialienquanId == model.BaogialienquanId);
                if (baogia != null)
                {
                    baogia.BaogialienquanTitle = model.BaogialienquanTitle;
                    baogia.BaogiaId = model.BaogiaId;
                    baogia.BaogialienquanDatemodified = model.BaogialienquanDatemodified;
                    baogia.BaogialienquanContent = model.BaogialienquanContent;
                }
            }
            context.SaveChanges();
        }
        public void BaoGiaLienQuanDelete(int baogia_id)
        {
            var baogia = context.Tbbaogialienquan.FirstOrDefault(x => x.BaogialienquanId == baogia_id);
            if (baogia != null)
            {
                context.Tbbaogialienquan.Remove(baogia);
                context.SaveChanges();
            }
        }
    }
}

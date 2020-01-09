using Source.Models.DBF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Models
{
    public interface IRepository
    {
        IQueryable<Tbadmin> tbadmins { get; }
        IQueryable<Tbbaivietuser> tbbaivietusers { get; }
        IQueryable<Tbbanggiachitietuser> tbbanggiachitietusers { get; }
        IQueryable<Tbbanggiagoidichvu> tbbanggiagoidichvus { get; }
        IQueryable<Tbbanggiauser> tbbanggiausers { get; }
        IQueryable<Tbbanneruser> tbbannerusers { get; }
        IQueryable<Tbbaogia> tbbaogias { get; }
        IQueryable<Tbbaogiachitiet> tbbaogiachitiets { get; }
        IQueryable<Tbbaogialienquan> tbbaogialienquans { get; }
        IQueryable<Tbcategory> tbcategories { get; }
        IQueryable<Tbcontact> tbcontacts { get; }
        IQueryable<Tbform> tbforms { get; }
        IQueryable<TbformAccess> tbformAccesses { get; }
        IQueryable<Tbgiaproject> tbgiaprojects { get; }
        IQueryable<Tbgroup> tbgroups { get; }
        IQueryable<Tbgroupcate> tbgroupcates { get; }
        IQueryable<Tbimageproject> tbimageprojects { get; }
        IQueryable<Tbintroduce> tbintroduces { get; }
        IQueryable<Tblanguage> tblanguages { get; }
        IQueryable<Tblogo> tblogos { get; }
        IQueryable<Tbmodule> tbmodules { get; }
        IQueryable<Tbnews> tbnews { get; }
        IQueryable<Tbnewscate> tbnewscates { get; }
        IQueryable<Tbproject> tbprojects { get; }
        IQueryable<Tbreviewscustome> tbreviewscustomes { get; }
        IQueryable<Tbseo> tbseos { get; }
        IQueryable<TbseoDetail> tbseoDetails { get; }
        IQueryable<Tbservice> tbservices { get; }
        IQueryable<Tbservicedetail> tbservicedetails { get; }
        IQueryable<Tbslide> tbslides { get; }
        IQueryable<Tbvideo> tbvideos { get; }
        IQueryable<abc> abcs { get; }
        void SaveNewsCate(Tbnewscate newscate);
        void NewsCateDelete(int newscate_id);
        void SaveNews(Tbnews news);
        void NewsDelete(int newscate_id);
        void SaveNhomLoai(Tbgroupcate groupcate);
        void NhomLoaiDelete(int newscate_id);
        void SaveNhomDuAn(Tbcategory category);
        void NhomDuAnDelete(int category_id);
        void SaveDichVu(Tbservice service);
        void DichVuDelete(int service_id);
        void SaveDichVuChiTiet(Tbservicedetail servicedetail);
        void DichVuChiTietDelete(int servicedetail_id);
        void SaveDuAn(Tbproject project);
        void DuAnDelete(int project_id);
        void SaveBaoGia(Tbbaogia baogia);
        void BaoGiaDelete(int baogia_id);
        void SaveBaoGiaChiTiet(Tbbaogiachitiet baogiachitiet);
        void BaoGiaChiTietDelete(int baogiachitiet_id);
        void SaveBaoGiaLienQuan(Tbbaogialienquan baogialienquan);
        void BaoGiaLienQuanDelete(int baogialienquan_id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreDelivery.Business
{
    public class Info
    {
        #region Constructors

        public Info()
        { }


        public Info(
            int infoId)
        {
            this.GetInfo(
                infoId);
        }

        #endregion

        #region Private Properties

        private int infoId = -1;
        private string sTT = string.Empty;
        private string hoten = string.Empty;
        private int sdt = -1;
        private int sdtkhac = -1;
        private string diachi = string.Empty;
        private int soHD = -1;
        private DateTime ngaykyHD = DateTime.Now;
        private string duan = string.Empty;
        private string solo = string.Empty;
        private int dotdadong = -1;
        private decimal tiendadong;
        private DateTime denngay = DateTime.Now;
        private decimal giatriHD;
        private DateTime thoigiangiao = DateTime.Now;
        private string phantramdadong = string.Empty;

        #endregion

        #region Public Properties

        public int InfoId
        {
            get { return infoId; }
            set { infoId = value; }
        }
        public string STT
        {
            get { return sTT; }
            set { sTT = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public int Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public int Sdtkhac
        {
            get { return sdtkhac; }
            set { sdtkhac = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public int SoHD
        {
            get { return soHD; }
            set { soHD = value; }
        }
        public DateTime NgaykyHD
        {
            get { return ngaykyHD; }
            set { ngaykyHD = value; }
        }
        public string Duan
        {
            get { return duan; }
            set { duan = value; }
        }
        public string Solo
        {
            get { return solo; }
            set { solo = value; }
        }
        public int Dotdadong
        {
            get { return dotdadong; }
            set { dotdadong = value; }
        }
        public decimal Tiendadong
        {
            get { return tiendadong; }
            set { tiendadong = value; }
        }
        public DateTime Denngay
        {
            get { return denngay; }
            set { denngay = value; }
        }
        public decimal GiatriHD
        {
            get { return giatriHD; }
            set { giatriHD = value; }
        }
        public DateTime Thoigiangiao
        {
            get { return thoigiangiao; }
            set { thoigiangiao = value; }
        }
        public string Phantramdadong
        {
            get { return phantramdadong; }
            set { phantramdadong = value; }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Gets an instance of Info.
        /// </summary>
        /// <param name="infoId"> infoId </param>
        private void GetInfo(
            int infoId)
        {
            using (IDataReader reader = DBInfo.GetOne(
                infoId))
            {
                if (reader.Read())
                {
                    this.infoId = Convert.ToInt32(reader["InfoId"]);
                    this.sTT = reader["STT"].ToString();
                    this.hoten = reader["Hoten"].ToString();
                    this.sdt = Convert.ToInt32(reader["Sdt"]);
                    this.sdtkhac = Convert.ToInt32(reader["Sdtkhac"]);
                    this.diachi = reader["Diachi"].ToString();
                    this.soHD = Convert.ToInt32(reader["SoHD"]);
                    this.ngaykyHD = Convert.ToDateTime(reader["NgaykyHD"]);
                    this.duan = reader["Duan"].ToString();
                    this.solo = reader["Solo"].ToString();
                    this.dotdadong = Convert.ToInt32(reader["Dotdadong"]);
                    this.tiendadong = Convert.ToDecimal(reader["Tiendadong"]);
                    this.denngay = Convert.ToDateTime(reader["Denngay"]);
                    this.giatriHD = Convert.ToDecimal(reader["GiatriHD"]);
                    this.thoigiangiao = Convert.ToDateTime(reader["Thoigiangiao"]);
                    this.phantramdadong = reader["Phantramdadong"].ToString();
                }
            }

        }

        /// <summary>
        /// Persists a new instance of Info. Returns true on success.
        /// </summary>
        /// <returns></returns>
        private bool Create()
        {
            int newID = 0;

            newID = DBInfo.Create(
                this.sTT,
                this.hoten,
                this.sdt,
                this.sdtkhac,
                this.diachi,
                this.soHD,
                this.ngaykyHD,
                this.duan,
                this.solo,
                this.dotdadong,
                this.tiendadong,
                this.denngay,
                this.giatriHD,
                this.thoigiangiao,
                this.phantramdadong);

            this.infoId = newID;

            return (newID > 0);

        }


        /// <summary>
        /// Updates this instance of Info. Returns true on success.
        /// </summary>
        /// <returns>bool</returns>
        private bool Update()
        {

            return DBInfo.Update(
                this.infoId,
                this.sTT,
                this.hoten,
                this.sdt,
                this.sdtkhac,
                this.diachi,
                this.soHD,
                this.ngaykyHD,
                this.duan,
                this.solo,
                this.dotdadong,
                this.tiendadong,
                this.denngay,
                this.giatriHD,
                this.thoigiangiao,
                this.phantramdadong);

        }





        #endregion

        #region Public Methods

        /// <summary>
        /// Saves this instance of Info. Returns true on success.
        /// </summary>
        /// <returns>bool</returns>
        public bool Save()
        {
            if (this.infoId > 0)
            {
                return this.Update();
            }
            else
            {
                return this.Create();
            }
        }




        #endregion

        #region Static Methods

        /// <summary>
        /// Deletes an instance of Info. Returns true on success.
        /// </summary>
        /// <param name="infoId"> infoId </param>
        /// <returns>bool</returns>
        public static bool Delete(
            int infoId)
        {
            return DBInfo.Delete(
                infoId);
        }


        /// <summary>
        /// Gets a count of Info. 
        /// </summary>
        public static int GetCount()
        {
            return DBInfo.GetCount();
        }

        private static List<Info> LoadListFromReader(IDataReader reader)
        {
            List<Info> infoList = new List<Info>();
            try
            {
                while (reader.Read())
                {
                    Info info = new Info();
                    info.infoId = Convert.ToInt32(reader["InfoId"]);
                    info.sTT = reader["STT"].ToString();
                    info.hoten = reader["Hoten"].ToString();
                    info.sdt = Convert.ToInt32(reader["Sdt"]);
                    info.sdtkhac = Convert.ToInt32(reader["Sdtkhac"]);
                    info.diachi = reader["Diachi"].ToString();
                    info.soHD = Convert.ToInt32(reader["SoHD"]);
                    info.ngaykyHD = Convert.ToDateTime(reader["NgaykyHD"]);
                    info.duan = reader["Duan"].ToString();
                    info.solo = reader["Solo"].ToString();
                    info.dotdadong = Convert.ToInt32(reader["Dotdadong"]);
                    info.tiendadong = Convert.ToDecimal(reader["Tiendadong"]);
                    info.denngay = Convert.ToDateTime(reader["Denngay"]);
                    info.giatriHD = Convert.ToDecimal(reader["GiatriHD"]);
                    info.thoigiangiao = Convert.ToDateTime(reader["Thoigiangiao"]);
                    info.phantramdadong = reader["Phantramdadong"].ToString();
                    infoList.Add(info);

                }
            }
            finally
            {
                reader.Close();
            }

            return infoList;

        }

        /// <summary>
        /// Gets an IList with all instances of Info.
        /// </summary>
        public static List<Info> GetAll()
        {
            IDataReader reader = DBInfo.GetAll();
            return LoadListFromReader(reader);

        }

        /// <summary>
        /// Gets an IList with page of instances of Info.
        /// </summary>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="totalPages">total pages</param>
        public static List<Info> GetPage(int pageNumber, int pageSize, out int totalPages)
        {
            totalPages = 1;
            IDataReader reader = DBInfo.GetPage(pageNumber, pageSize, out totalPages);
            return LoadListFromReader(reader);
        }



        #endregion

        #region Comparison Methods

        /// <summary>
        /// Compares 2 instances of Info.
        /// </summary>
        public static int CompareByInfoId(Info info1, Info info2)
        {
            return info1.InfoId.CompareTo(info2.InfoId);
        }
        /// <summary>
        /// Compares 2 instances of Info.
        /// </summary>
        public static int CompareBySTT(Info info1, Info info2)
        {
            return info1.STT.CompareTo(info2.STT);
        }
        /// <summary>
        /// Compares 2 instances of Info.
        /// </summary>
        public static int CompareByHoten(Info info1, Info info2)
        {
            return info1.Hoten.CompareTo(info2.Hoten);
        }
        /// <summary>
        /// Compares 2 instances of Info.
        /// </summary>
        public static int CompareBySdt(Info info1, Info info2)
        {
            return info1.Sdt.CompareTo(info2.Sdt);
        }
        /// <summary>
        /// Compares 2 instances of Info.
        /// </summary>
        public static int CompareBySdtkhac(Info info1, Info info2)
        {
            return info1.Sdtkhac.CompareTo(info2.Sdtkhac);
        }
        /// <summary>
        /// Compares 2 instances of Info.
        /// </summary>
        public static int CompareByDiachi(Info info1, Info info2)
        {
            return info1.Diachi.CompareTo(info2.Diachi);
        }
        /// <summary>
        /// Compares 2 instances of Info.
        /// </summary>
        public static int CompareBySoHD(Info info1, Info info2)
        {
            return info1.SoHD.CompareTo(info2.SoHD);
        }
        /// <summary>
        /// Compares 2 instances of Info.
        /// </summary>
        public static int CompareByNgaykyHD(Info info1, Info info2)
        {
            return info1.NgaykyHD.CompareTo(info2.NgaykyHD);
        }
        /// <summary>
        /// Compares 2 instances of Info.
        /// </summary>
        public static int CompareByDuan(Info info1, Info info2)
        {
            return info1.Duan.CompareTo(info2.Duan);
        }
        /// <summary>
        /// Compares 2 instances of Info.
        /// </summary>
        public static int CompareBySolo(Info info1, Info info2)
        {
            return info1.Solo.CompareTo(info2.Solo);
        }
        /// <summary>
        /// Compares 2 instances of Info.
        /// </summary>
        public static int CompareByDotdadong(Info info1, Info info2)
        {
            return info1.Dotdadong.CompareTo(info2.Dotdadong);
        }
        /// <summary>
        /// Compares 2 instances of Info.
        /// </summary>
        public static int CompareByDenngay(Info info1, Info info2)
        {
            return info1.Denngay.CompareTo(info2.Denngay);
        }
        /// <summary>
        /// Compares 2 instances of Info.
        /// </summary>
        public static int CompareByThoigiangiao(Info info1, Info info2)
        {
            return info1.Thoigiangiao.CompareTo(info2.Thoigiangiao);
        }
        /// <summary>
        /// Compares 2 instances of Info.
        /// </summary>
        public static int CompareByPhantramdadong(Info info1, Info info2)
        {
            return info1.Phantramdadong.CompareTo(info2.Phantramdadong);
        }

        #endregion


    }
}

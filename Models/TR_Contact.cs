//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_CRUD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TR_Contact
    {
        public int ContactId { get; set; }
        public string CustomerContactId { get; set; }
        public string ContactName { get; set; }
        public Nullable<int> ContactStatus { get; set; }
        public string ContactPhone { get; set; }
        public string BranchId { get; set; }
        public string BranchFullname { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string AgreementNo { get; set; }
        public string CustomerName { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<int> Usia { get; set; }
        public string KTP_Adress { get; set; }
        public string KTP_RT { get; set; }
        public string KTP_RW { get; set; }
        public string KTP_Kelurahan { get; set; }
        public string KTP_Kecamatan { get; set; }
        public string KTP_City { get; set; }
        public Nullable<int> KTP_Zipcode { get; set; }
        public string Residence_Adress { get; set; }
        public string Residence_Kelurahan { get; set; }
        public string Residence_Kecamatan { get; set; }
        public string Residence_City { get; set; }
        public Nullable<int> Residence_Zipcode { get; set; }
        public string Jenis_Pekerjaan { get; set; }
        public Nullable<int> MonthlyFixedIncome { get; set; }
        public Nullable<int> InstallmentAmount { get; set; }
        public string Status_Rumah { get; set; }
        public Nullable<int> JumlahTanggungan { get; set; }
        public Nullable<int> DownPayment { get; set; }
        public Nullable<System.DateTime> GoLiveDate { get; set; }
        public Nullable<System.DateTime> TglSelesaiAngsuran { get; set; }
        public Nullable<int> Tenor { get; set; }
        public Nullable<int> Odmax_Day_Final { get; set; }
        public Nullable<System.DateTime> LastPayment { get; set; }
        public Nullable<int> Payment { get; set; }
        public string CallStatus { get; set; }
        public string SubStatus { get; set; }
        public string Remarks { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
        public string Param3 { get; set; }
        public string Param4 { get; set; }
        public string Param5 { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CustProId { get; set; }
        public Nullable<System.DateTime> ExpiredDate { get; set; }
        public Nullable<int> UserId { get; set; }
    }
}

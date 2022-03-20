using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestAPI.Models
{
    public class StatementDetail1
    {
        [Key]
        public int StatementDetailId1 { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string OwnerName1 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string OwnerSurname1 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string OwnerPatronymic1 { get; set; }

        [Column(TypeName = "nvarchar(4)")]
        public string PasportSet1 { get; set; }

        [Column(TypeName = "nvarchar(6)")]
        public string PasportNumber1 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string PasportType1 { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        public string OwnerINN { get; set; }

        [Column(TypeName = "nvarchar(10)")]

        //dd.mm.yyyy
        public string OwnerBirthday1 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string EmailAdress { get; set; }

        [Column(TypeName = "nvarchar(100)")]

        public string KidName1 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string KidSurname1 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string KidPatronymic1 { get; set; }

        [Column(TypeName = "nvarchar(4)")]
        public string СertificateSet1 { get; set; }

        [Column(TypeName = "nvarchar(6)")]
        public string СertificateNumber1 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string СertificateType1 { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        //dd.mm.yyyy
        public string KidBirthday1 { get; set; }
    }
    public class StatementDetail2
    {
        [Key]
        public int StatementDetailId2 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string OwnerName2 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string OwnerSurname2 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string OwnerPatronymic2 { get; set; }

        [Column(TypeName = "nvarchar(4)")]
        public string PasportSet2 { get; set; }

        [Column(TypeName = "nvarchar(6)")]
        public string PasportNumber2 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string PasportType2 { get; set; }

        [Column(TypeName = "nvarchar(14)")]
        public string OwnerSnils { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        //dd.mm.yyyy
        public string OwnerBirthday2 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string KidName2 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string KidSurname2 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string KidPatronymic2 { get; set; }

        [Column(TypeName = "nvarchar(4)")]
        public string СertificateSet2 { get; set; }

        [Column(TypeName = "nvarchar(6)")]
        public string СertificateNumber2 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string СertificateType2 { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        //dd.mm.yyyy
        public string KidBirthday2 { get; set; }
    }
}

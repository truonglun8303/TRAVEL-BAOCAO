using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Travel_T7.Models.EF
{
    [Table("tb_Khachhang")]
    public class KhachHang
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(50)]
        
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email không được để trống")]
        [StringLength(250)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [StringLength(150)]
        public string Telephone { get; set; }
        [Required(ErrorMessage = "Số người không được để trống")]
        public int Number { get; set; }
        [Required(ErrorMessage = "Nơi đến không được để trống")]
        [StringLength(250)]
        public string Destination { get; set; }
    }
}
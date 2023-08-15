using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Travel_T7.Models.EF
{
    [Table("tb_Place")]
    public class Place
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên địa điểm du lịch không được để trống")]
        [StringLength(150)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Chi tiết không được để trống")]
        [StringLength(500)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Giá không được để trống")]
        [StringLength(150)]
        public string Price { get; set; }
        [StringLength(150)]
        public string PriceSale { get; set; }
        [Required(ErrorMessage = "Ảnh địa điểm du lịch không được để trống")]
        [StringLength(250)]
        public string Image { get; set; }
    }
}
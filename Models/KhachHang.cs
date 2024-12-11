﻿using System.ComponentModel.DataAnnotations;

namespace CuaHangWindowForm.Models
{
    public class ThongTinKhachHang
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string CustomerID { get; set; }

        [Required]
        [StringLength(255)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(15)]
        public string Phone { get; set; }

        public override string ToString()
        {
            return CustomerName;
        }
    }
}


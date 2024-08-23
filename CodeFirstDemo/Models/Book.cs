using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstDemo.Models
{
    /// <summary>
    /// 書本
    /// </summary>
    public class Book
    {
        /// <summary>
        /// 流水號
        /// </summary>
        [Key]
        [Comment("流水號")]
        public int Id { get; set; }

        /// <summary>
        /// 書名
        /// </summary>
        [Comment("書名")]
        public string Name { get; set; }
    }
}

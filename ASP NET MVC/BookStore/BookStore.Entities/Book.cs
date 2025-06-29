using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Entities
{
    public class Book : EntityBase
    {
        [DisplayName("Adı")]
        [required]
        [maxlengt]
        public strinng Name { get; set; }


        [DisplayName("Kategori Adı")]
        [required]
        public int CategoryId { get; set; }


        [DisplayName("Yazar Adı")]
        [required]
        public int WriterId { get; set; }

        [DisplayName("Sayfa Sayısı")]
        public int PageCount { get; set; }

        [DisplayName("Birim Fiyatı")]
        [required]
        public double Price { get; set; }


        [DisplayName("Yayın Tarihi")]
        public DateTime? PublisDate { get; set; }


        [DisplayName("Açıklama")]
        public string? Description { get; set; }



        [DisplayName("Resim")]
        [maxlengt]
        public string? ImageUrl { get; set; }


        [DisplayName("Büyük Resim")]
        [maxlengt]
        public string? BigImageUrl { get; set; }



        [DisplayName("Küçük Resim")]
        [maxlengt]
        public string? SmallImageUrl { get; set; }


    }
}

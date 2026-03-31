using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Core.Models
{
    public class Product
    {
        public Guid Id { get; set; }           // уникальный идентификатор
        public string Name { get; set; }       // название товара
        public string Definition { get; set; } // описание
        public decimal Price { get; set; }     // цена
        public string Image { get; set; }      // ссылка на изображение
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace WebMyPham.Data.Entities
{
    public class CategoryTranslation
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }

    }
}

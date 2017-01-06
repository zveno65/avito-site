using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class CategoriesListModel
    {
        public IEnumerable<Category> Categories { get; set; }
    }
}
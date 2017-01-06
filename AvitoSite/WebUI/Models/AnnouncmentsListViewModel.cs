using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class AnnouncmentsListViewModel
    {
        public IEnumerable<An> Announcments { get; set; }
        public Paginginfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
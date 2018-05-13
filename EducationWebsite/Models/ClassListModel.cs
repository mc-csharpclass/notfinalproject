using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducationWebsite.Models
{
    public class ClassListModel
    {
        public List<SelectListItem> Items { get; set; }
        public string SelectedItem { get; set; }
    }
}
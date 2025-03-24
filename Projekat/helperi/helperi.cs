using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekat.helperi
{
    public class helperi
    {
        public static MvcHtmlString popustCena(double cena, double popust)
        {
            double cenaSaPopustom;
            double popusti;
            var el = new TagBuilder("div");
            popusti = cena * popust / 100;
            cenaSaPopustom = cena - popusti;
            el.InnerHtml = "<p>Nova cena sa popustom od " + popust + "%: " + cenaSaPopustom + " dinara!!!</p>";
            return new MvcHtmlString(el.ToString());
        }
    }
}
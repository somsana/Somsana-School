using System;
using System.ComponentModel.DataAnnotations;

namespace Somsana_School.Areas.Identity.Pages.Account
{
    internal class DateTypeAttribute : Attribute
    {
        private DataType text;

        public DateTypeAttribute(DataType text)
        {
            this.text = text;
        }
    }
}
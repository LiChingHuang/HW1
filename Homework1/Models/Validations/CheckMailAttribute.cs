using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework1.Models.Validations
{
    public class CheckMailAttribute : DataTypeAttribute
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        public CheckMailAttribute():base(DataType.Text)
        {
            this.ErrorMessage = "mail重覆";
        }
        public override bool IsValid(object value)
        {
            string str = Convert.ToString(value);
            var mail = db.客戶聯絡人.Where(c => c.Email == str);

            if (mail != null)
            {
                return false;
            }
            return true;
            //return base.IsValid(value);
        }
    }
}
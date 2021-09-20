using Service.DataLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DataLayer.Repository
{
   public interface ISendEmail
    {
        public bool SendEmailToCustomer(EmailInfo emailInfo);
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service.DataLayer.Connection.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Service.DataLayer.Test
{
    [TestClass]
   public class CryptoTest
    {
        [TestMethod]
        public void TestProcessGeneralSurveyAppointments()
        {
            try
            {
                string username = "sa";
                string password = "123";
                string SecretKey = "Encrypti0nConnect0n@Username&K6yPassword";

                var testReturnUsername = Crypto.EncryptStringDES(username, SecretKey);
                var testReturnPassword = Crypto.EncryptStringDES(password, SecretKey);
                var passw = testReturnPassword;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
    }
}

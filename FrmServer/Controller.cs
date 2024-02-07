using Domen;
using System;
using System.Diagnostics;

namespace FrmServer
{
    internal class Controller
    {
        public Admin CurrentAdmin { get; set; }
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null) instance = new Controller();
                return instance;
            }
        }
        private Controller()
        {

        }
        public Admin Login(Admin admin)
        {
            try
            {
                DatabaseBroker.Instance.OpenConnection();
                return DatabaseBroker.Instance.Login(admin);
            }
            catch (System.Exception ex)
            {
                Debug.WriteLine("At Login: " +ex.Message);
                return null;
            }
            finally { 
                DatabaseBroker.Instance.CloseConnection();
            }
        }

        internal User LoginUser(User user)
        {
            try
            {
                DatabaseBroker.Instance.OpenConnection();
                return DatabaseBroker.Instance.LoginUser(user);
            }
            catch (System.Exception ex)
            {
                /*Debug.WriteLine("At LoginUser: " + ex.Message);
                return null;*/
                throw;
            }
            finally
            {
                DatabaseBroker.Instance.CloseConnection();
            }
        }
    }
}

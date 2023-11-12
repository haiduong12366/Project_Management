using company_management.View;
using FullScreenAppDemo.DAO;
using FullScreenAppDemo.DTO;
using Project_Management.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace Project_Management.DAO
{
    internal class CheckIn_CheckOutDAO
    {
        private static CheckIn_CheckOutDAO instance;
        public static CheckIn_CheckOutDAO Instance
        {
            get { if (instance == null) instance = new CheckIn_CheckOutDAO(); return CheckIn_CheckOutDAO.instance; }
            private set => CheckIn_CheckOutDAO.instance = value;
        }

        private CheckIn_CheckOutDAO() { }


        internal List<checkin_checkout> GetAllCICO(int thang)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                return entity.checkin_checkout.Where(c => c.date.Value.Month == thang).ToList<checkin_checkout>();
            }
        }

        internal List<checkin_checkout> GetCICOByIDUser(int id, int thang)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                return entity.checkin_checkout.Where(c => c.idUser.Equals(id) && c.date.Value.Month == thang).ToList<checkin_checkout>();
            }
        }

        internal checkin_checkout GetCICOByID(int lastCheckinCheckoutId)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                return entity.checkin_checkout.SingleOrDefault(c => c.id.Equals(lastCheckinCheckoutId));
            }
        }

        internal checkin_checkout GetCICOByDate(DateTime value)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                List<checkin_checkout> lists = entity.checkin_checkout.Where(c => c.idUser == UserSession.LoggedInUser.id).ToList<checkin_checkout>();
                foreach (checkin_checkout item in lists)
                {
                    if (item.date.Value.Year == value.Year && item.date.Value.Month == value.Month && item.date.Value.Day == value.Day)
                    {
                        return item;
                    }
                }
                return null;
            }
        }

        internal void AddCICO(checkin_checkout ci)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {

                try
                {
                    entity.checkin_checkout.Add(ci);
                    entity.SaveChanges();
                    Util.Instance.Alert("Checkin success", FormAlert.enmType.Success);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    Util.Instance.Alert("Checkin fail", FormAlert.enmType.Error);
                }
            }
        }

        internal void UpdateCICO(checkin_checkout cico)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                try
                {
                    entity.Entry(cico).State = EntityState.Modified;
                    entity.SaveChanges();
                    Util.Instance.Alert("Checkout completed", FormAlert.enmType.Success);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Util.Instance.Alert("Checkout fail", FormAlert.enmType.Error);
                }
            }
        }

        internal void DeleteCheckinCo(int lastCheckinCheckoutId)
        {
            using (company_management_Entities entity = new company_management_Entities())
            {
                try
                {
                    var cicoToDelete = entity.checkin_checkout.Find(lastCheckinCheckoutId);
                    if (cicoToDelete != null)
                    {
                        entity.checkin_checkout.Remove(cicoToDelete);
                        entity.SaveChanges();
                        Util.Instance.Alert("Delete checkin_checkout success", FormAlert.enmType.Success);
                    }
                    else
                    {
                        Util.Instance.Alert("Not found!", FormAlert.enmType.Warning);
                    }
                }
                catch (Exception)
                {
                    Util.Instance.Alert("Delete checkin_checkout fail!", FormAlert.enmType.Error);
                }
            }
        }
    }
}

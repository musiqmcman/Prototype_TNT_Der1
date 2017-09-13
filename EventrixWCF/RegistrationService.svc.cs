using EventrixWCF.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EventrixWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RegistrationService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RegistrationService.svc or RegistrationService.svc.cs at the Solution Explorer and start debugging.
    public class RegistrationService : IRegistrationService
    {
        public string RegisterGuest(EventGuest guest)
        {
            using (EventrixDBDataContext dbd = new EventrixDBDataContext())
            {
                try
                {
                    int MailChecker = (from gst in dbd.Guests where gst.Email.Equals(guest.EMAIL) select gst).Count();
                    if (MailChecker == 0)
                    {
                        Guest _guest = new Guest();
                        _guest.Name = guest.NAME;
                        _guest.Email = guest.EMAIL;
                        _guest.Surname = guest.SURNAME;
                        _guest.Type = guest.TYPE;
                        _guest.Password = guest.PASS;
                        dbd.Guests.InsertOnSubmit(_guest);
                        dbd.SubmitChanges();
                        return _guest.Name + " Registered successfully ^" + _guest.G_ID;;
                    }
                    else
                    {
                        return "Error: Account already taken";
                    }
                }
                catch (Exception e)
                {
                    return e.GetBaseException().ToString();
                }
            };
        }

        public string RegisterHost(Host host)
        {
            using (EventrixDBDataContext dbd = new EventrixDBDataContext())
            {
                try
                {
                    int MailChecker = (from eh in dbd.EventHosts where eh.Email.Equals(host.EMAIL) select eh).Count();
                    if (MailChecker == 0)
                    {
                        EventHost _host = new EventHost();
                        _host.Name = host.NAME;
                        _host.Email = host.EMAIL;
                        _host.Surname = host.SURNAME;
                        _host.Password = host.PASS;
                        dbd.EventHosts.InsertOnSubmit(_host);
                        dbd.SubmitChanges();
                        return "Registered " + _host.Name + "successfully";
                    }
                    else
                    {
                        return "Error: Account already taken";
                    }
                }
                catch (Exception e)
                {
                    return e.GetBaseException().ToString();
                }
            };
        }

        public string RegisterStaff(EventStaff _staff)
        {
            using (EventrixDBDataContext dbd = new EventrixDBDataContext())
            {
                try
                {
                    int MailChecker = (from eh in dbd.Staffs where eh.Email.Equals(_staff.EMAIL) select eh).Count();
                    if (MailChecker == 0)
                    {
                        int _id = Convert.ToInt32(_staff.EventID);
                        Staff staff = new Staff();
                        staff.Name = _staff.NAME;
                        staff.Email = _staff.EMAIL;
                        staff.Occupation = _staff.Occupation;
                        staff.Password = _staff.PASS;
                        staff.EventID = _id;
                        dbd.Staffs.InsertOnSubmit(staff);
                        dbd.SubmitChanges();
                        return "Registered " + staff.Name + " successfully";
                    }
                    else
                    {
                        return "Error: Account already taken";
                    }
                }
                catch (Exception e)
                {
                    return e.GetBaseException().ToString();
                }
            };
        }
    }
}

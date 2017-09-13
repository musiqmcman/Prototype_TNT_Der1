using EventrixWCF.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EventrixWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceStaff" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceStaff.svc or ServiceStaff.svc.cs at the Solution Explorer and start debugging.
    public class ServiceStaff : IServiceStaff
    {
        public bool createStaff(EventStaff _staff)
        {
            using (EventrixDBDataContext mde = new EventrixDBDataContext())
            {
                try
                {
                    Staff staff = new Staff();
                    staff.Name = _staff.NAME;
                    staff.EventID = _staff.EventID;
                    staff.Email = _staff.EMAIL;
                    staff.Password = _staff.PASS;
                    staff.Occupation = _staff.Occupation;
                    //mde.Staffs.Add(staff);
                    //mde.SaveChanges();
                    mde.Staffs.InsertOnSubmit(staff);
                    mde.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }

        public bool deleteStaff(EventStaff _staff)
        {
            using (EventrixDBDataContext mde = new EventrixDBDataContext())
            {
                try
                {
                    int _id = Convert.ToInt32(_staff.ID);
                    Staff staff = mde.Staffs.Single(p => p.StaffId == _id);
                    //mde.Staffs.Remove(staff);
                    //mde.SaveChanges();
                    mde.Staffs.DeleteOnSubmit(staff);
                    mde.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            };
        }

        public bool editStaff(EventStaff _staff)
        {
            using (EventrixDBDataContext mde = new EventrixDBDataContext())
            {
                try
                {
                    int _id = Convert.ToInt32(_staff.ID);
                    Staff staff = mde.Staffs.Single(p => p.StaffId == _id);
                    staff.Name = _staff.NAME;
                    staff.Password = _staff.PASS;
                    staff.Occupation = _staff.Occupation;
                    staff.Email = _staff.EMAIL;
                    //  mde.SaveChanges();
                    mde.Staffs.InsertOnSubmit(staff);
                    mde.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            };
        }

        public List<EventStaff> findallstaff()
        {
            using (EventrixDBDataContext mde = new EventrixDBDataContext())
            {
                try
                {
                    return mde.Staffs.Select(_staff => new EventStaff
                    {

                        ID = _staff.StaffId,
                        NAME = _staff.Name,
                        Occupation = _staff.Occupation,
                        PASS = _staff.Password,
                        EMAIL = _staff.Email,
                        EventID = Convert.ToInt32(_staff.EventID)
                    }).ToList();
                }
                catch
                {
                    return null;
                }
            };
        }

        public EventStaff findStaffbyID(string id)
        {
            try
            {
                using (EventrixDBDataContext mde = new EventrixDBDataContext())
                {
                    int _id = Convert.ToInt32(id);
                    return mde.Staffs.Where(staff => staff.StaffId == _id).Select(staff => new EventStaff
                    {
                        ID = staff.StaffId,
                        NAME = staff.Name,
                        EMAIL = staff.Email,
                        PASS = staff.Password,
                        Occupation = staff.Occupation,
                        EventID = Convert.ToInt32(staff.EventID)
                    }).First();
                };
            }
            catch
            {
                return null;
            }

        }

        public EventStaff staffLogin(string email)
        {
            using (EventrixDBDataContext mde = new EventrixDBDataContext())
            {
                try
                {
                    return mde.Staffs.Where(staff => staff.Email == email).Select(staff => new EventStaff
                    {
                        ID = staff.StaffId,
                        NAME = staff.Name,
                        EMAIL = staff.Email,
                        PASS = staff.Password,
                        Occupation = staff.Occupation,
                        EventID = Convert.ToInt32(staff.EventID)
                    }).First();
                }
                catch
                {
                    return null;
                }
            };
        }
    }
}

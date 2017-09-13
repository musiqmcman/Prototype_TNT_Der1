using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Eventrix_Client.Model;
using Eventrix_Client.Model.ClientDefinition;

namespace EventrixWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MappingService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MappingService.svc or MappingService.svc.cs at the Solution Explorer and start debugging.
    public class MappingService : IMappingService
    {
        public EventAddress getAddressById(string id)
        {
            try
            {
                using (EventrixDBDataContext db = new EventrixDBDataContext())
                {
                    var innerJoinQuery =
                    from address in db.Addresses
                    where address.AD_Id.Equals(Convert.ToInt32(id))
                    select new EventAddress
                    {
                        ID = address.AD_Id,
                        STREET = address.AD_Street,
                        CITY = address.AD_City,
                        TOWN = address.AD_Town,
                        CODE = Convert.ToInt32(address.AD_Postal_Code),
                        LATITUDE = address.AD_Latitude,
                        LONGITUDE = address.AD_Longitude,
                        URL = address.AD_URL_Info
                    };
                    foreach (EventAddress ca in innerJoinQuery)
                    {
                        return ca;
                    }

                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<EventAddress> getAllAddresses()
        {
            try
            {
                using (EventrixDBDataContext db = new EventrixDBDataContext())
                {
                    return db.Addresses.Select(address => new EventAddress
                    {
                        ID = address.AD_Id,
                        STREET = address.AD_Street,
                        CITY = address.AD_City,
                        TOWN = address.AD_Town,
                        CODE = Convert.ToInt32(address.AD_Postal_Code),
                        LATITUDE = address.AD_Latitude,
                        LONGITUDE = address.AD_Longitude,
                        URL = address.AD_URL_Info
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int insertAddress(EventAddress _address)
        {
            try
            {
                Address newAddress = new Address();

                using (EventrixDBDataContext db = new EventrixDBDataContext())
                {
                    //   addrLnq = ConvertToLinq.ConvertAddressToLinq(_address);

                    newAddress.AD_Id = _address.ID;
                    newAddress.AD_Street = _address.STREET;
                    newAddress.AD_Town = _address.TOWN;
                    newAddress.AD_City = _address.CITY;
                    newAddress.AD_Postal_Code = _address.CODE;
                    newAddress.AD_Longitude = _address.LONGITUDE;
                    newAddress.AD_Latitude = _address.LATITUDE;
                    newAddress.AD_URL_Info = _address.URL;

                    db.Addresses.InsertOnSubmit(newAddress);
                    db.SubmitChanges();
                    int ad_ID = newAddress.AD_Id;
                    return ad_ID;// "Adding Address was successful";
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}

using EventrixWCF.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EventrixWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceGuest" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceGuest.svc or ServiceGuest.svc.cs at the Solution Explorer and start debugging.
    public class ServiceGuest : IServiceGuest
    {


        //private bool ValidateHeaderColumns(ExcelWorksheet worksheet)
        //{
        //    int startColumn = 1;  //where the file in the class excel start
        //    int startRow = 1;
        //    int Hitscount = 0;  //Checks number of matching columns
        //    List<string> columnNames = new List<string>();
        //    //foreach (var startRowCell in worksheet.Cells[worksheet.Dimension.Start.Row, worksheet.Dimension.Start.Column, 1, worksheet.Dimension.End.Column])
        //    foreach (var startRowCell in worksheet.Cells[startRow, startColumn, 1, worksheet.Dimension.End.Column])
        //    {
        //        columnNames.Add(startRowCell.Text);
        //    }
        //    for (int i = 0; i < columnNames.Count; i++)
        //    {
        //        //check if column header contains name,surname, email attributes
        //        if (columnNames[i].Contains("Name") || columnNames[i].Contains("Surname") || columnNames[i].Contains("Email"))
        //        {
        //            Hitscount++; 
        //        }
        //    }
        //    if (Hitscount == 3)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public string ImportData(String path)
        //{
        //    //  int count = Convert.ToInt32(_count);
        //    List<EventGuest> _guest = new List<EventGuest>();
        //    bool isValidColumn = false;
        //    int count = 0;
        //    try
        //    {
        //        //String path = Server.MapPath("/") + "\\import\\Class.xlsx";

        //        var package = new ExcelPackage(new System.IO.FileInfo(path));
        //        //  package.Workbook.Worksheets["TABNAME"].View.TabSelected = true;
        //        int startColumn = 1;  //where the file in the class excel start
        //        int startRow = 2;
        //        ExcelWorksheet workSheet = package.Workbook.Worksheets[1]; //read sheet one
        //        isValidColumn = ValidateHeaderColumns(workSheet);
        //        // isValidColumn = true;
        //        object controler = null;
        //        object endColum = workSheet.Cells[workSheet.Dimension.End.Row, workSheet.Dimension.End.Column].Value;
        //        if (isValidColumn == true) //if valid spreadsheet
        //        {
        //          //  EventrixDBDataContext db = new EventrixDBDataContext();
        //            do
        //            {
        //                controler = workSheet.Cells[startRow, startColumn].Value; //column Number 
        //                                                               //read column class name
        //                object GuetsNames = workSheet.Cells[startRow, startColumn].Value;
        //                object GuestSurname = workSheet.Cells[startRow, startColumn + 1].Value;
        //                object GuestEmail = workSheet.Cells[startRow, startColumn + 1].Value;
        //               if (controler != null && GuetsNames != null && GuestSurname != null && GuestEmail != null)
        //              {
        //                    //import db
        //                    //    result = AddToDB(GuetsNames.ToString(), GuestSurname.ToString(), GuestEmail.ToString());

        //                    //check exists
        //                    using (EventrixDBDataContext db = new EventrixDBDataContext())
        //                    {

        //                            if (db.Guests.Where(g => g.Email.Equals(GuestEmail.ToString())).Count() == 0)
        //                            {
        //                                Guest gst = new Guest();
        //                                gst.Name = GuetsNames.ToString();
        //                                gst.Surname = GuestSurname.ToString();
        //                                gst.Password = "1212";
        //                                gst.Email = GuestEmail.ToString();
        //                                gst.Type = "Private";
        //                                db.Guests.InsertOnSubmit(gst);
        //                                db.SubmitChanges();

        //                            //EventGuest _newGuest = new EventGuest();
        //                            //_newGuest.ID = gst.G_ID;
        //                            //_newGuest.NAME = gst.Name;
        //                            //_newGuest.SURNAME = gst.Surname;
        //                            //_newGuest.EMAIL = gst.Email;
        //                            //_newGuest.PASS = gst.Password;
        //                            //_guest.Add(_newGuest);
        //                            count++;
        //                      //      return "Success";
        //                        }
        //                            else
        //                            {
        //                                //guest exist
        //                                Guest gst = db.Guests.Single(p => p.Email.Equals(GuestEmail.ToString()));
        //                                gst.Name = GuetsNames.ToString();
        //                                   gst.Surname = GuestSurname.ToString();
        //                                    gst.Password = "1212";
        //                                 gst.Email = GuestEmail.ToString();
        //                                gst.Type = "Private";
        //                                db.Guests.InsertOnSubmit(gst);
        //                                db.SubmitChanges();
        //                            //EventGuest _newGuest = new EventGuest();
        //                            //_newGuest.ID = gst.G_ID;
        //                            //_newGuest.NAME = gst.Name;
        //                            //_newGuest.SURNAME = gst.Surname;
        //                            //_newGuest.EMAIL = gst.Email;
        //                            //_newGuest.PASS = gst.Password;
        //                            //_guest.Add(_newGuest);
        //                            count++;
        //                          //  return "Success";
        //                        }


        //                    }

        //                    //if (result)
        //                    //{
        //                    //    count++;
        //                    //}
        //                }
        //                startRow++;
        //                startColumn++;
        //            } while (controler != endColum);
        //            return "Done";
        //        }
        //        else
        //        {
        //            return "Fail: Check Clumn";
        //        }
        //    }
        //    catch
        //    {
        //        return "Fail";
        //    }
        //}

        //private bool AddToDB(string name,string surname, string email)
        //{
        //    try
        //    {
        //        //check exists
        //        using (EventrixDBDataContext db = new EventrixDBDataContext())
        //        {
        //            try
        //            {

        //                if(db.Guests.Where(g => g.Email.Equals(email)).Count() == 0)
        //                {
        //                    Guest gst = new Guest();
        //                    gst.Name = name;
        //                    gst.Surname = surname;
        //                    gst.Password = "1212";
        //                    gst.Email = email;
        //                    gst.Type = "Private";
        //                    db.Guests.InsertOnSubmit(gst);
        //                    db.SubmitChanges();  

        //                    return true;
        //                }
        //                else
        //                {
        //                    //guest exist
        //                    Guest gst = db.Guests.Single(p => p.Email.Equals(email));
        //                    gst.Name = name;
        //                    gst.Surname = surname;
        //                    gst.Password = "1212";
        //                    gst.Email = email;
        //                    gst.Type = "Private";
        //                    db.Guests.InsertOnSubmit(gst);
        //                    db.SubmitChanges();

        //                    return true;
        //                }
        //            }
        //            catch
        //            {
        //                return false;
        //            }

        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}



        public bool createGuest(EventGuest _guest)
        {
            using (EventrixDBDataContext mde = new EventrixDBDataContext())
            {
                try
                {
                    Guest gst = new Guest();
                    gst.Name = _guest.NAME;
                    gst.Surname = _guest.SURNAME;
                    gst.Email = _guest.EMAIL;
                    gst.Password = _guest.PASS;
                    gst.Type = "Public";
                    mde.Guests.InsertOnSubmit(gst);
                    //mde.Guests.Add(gst);
                    //mde.SaveChanges();
                    mde.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }



        public bool deleteGuest(EventGuest _guest)
        {
            using (EventrixDBDataContext mde = new EventrixDBDataContext())
            {
                try
                {
                    int _id = Convert.ToInt32(_guest.ID);
                    Guest gst = mde.Guests.Single(p => p.G_ID == _id);
                    mde.Guests.DeleteOnSubmit(gst);
                    //mde.Guests.Remove(gst);
                    //mde.SaveChanges();
                    mde.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            };
        }

        public bool editGuest(EventGuest _guest)
        {
            using (EventrixDBDataContext mde = new EventrixDBDataContext())
            {
                try
                {
                    int _id = Convert.ToInt32(_guest.ID);
                    Guest gst = mde.Guests.Single(p => p.G_ID == _id);
                    gst.Name = _guest.NAME;
                    gst.Surname = _guest.SURNAME;
                    gst.Password = _guest.PASS;
                    gst.Email = _guest.EMAIL;
                    mde.Guests.InsertOnSubmit(gst);
                    //mde.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            };
        }

        public List<EventGuest> findallguest()
        {
            using (EventrixDBDataContext mde = new EventrixDBDataContext())
            {
                return mde.Guests.Select(gst => new EventGuest
                {
                    ID = gst.G_ID,
                    NAME = gst.Name,
                    SURNAME = gst.Surname,
                    PASS = gst.Password,
                    TYPE = gst.Type
                }).ToList();
            };
        }

        public EventGuest findGuestbyID(string id)
        {
            using (EventrixDBDataContext mde = new EventrixDBDataContext())
            {
                int _id = Convert.ToInt32(id);
                try
                {

                    return mde.Guests.Where(gst => gst.G_ID == _id).Select(gst => new EventGuest
                    {
                        ID = gst.G_ID,
                        NAME = gst.Name,
                        SURNAME = gst.Surname,
                        PASS = gst.Password,
                        TYPE = gst.Type
                    }).First();
                }
                catch
                {
                    return null;
                }
            };
        }

        public EventGuest GuestLogin(string email)
        {
            using (EventrixDBDataContext mde = new EventrixDBDataContext())
            {
                try
                {
                    return mde.Guests.Where(gst => gst.Email == email).Select(gst => new EventGuest
                    {
                        ID = gst.G_ID,
                        NAME = gst.Name,
                        SURNAME = gst.Surname,
                        PASS = gst.Password,
                        TYPE = gst.Type
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

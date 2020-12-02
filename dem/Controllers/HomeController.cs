using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Data;
using MySql.Data.MySqlClient;
using dem.Models;


namespace dem.Controllers
{
    public class HomeController : Controller
    {
       

        public ActionResult Order()
        {
            List<Order> list = new List<Order>();
            try
            {

                using (MySqlConnection con = new MySqlConnection())
                {
                    String mysql = @"select * from clickeystore_dev.order_details,sellerorder_details where (deliverystatus = 'Ready for Delivery' AND sellerorder_status = 'Ready for pickup');";
                    con.ConnectionString = @"Server=dev.c71am30pjzpd.ap-south-1.rds.amazonaws.com;Database=clickeystore_dev;User Id=root;Password=Welcome123;";


                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = new MySqlCommand(mysql, con);

                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        var ord = new Order();
                        ord.OrderDate = Convert.ToDateTime(row["orderdate"]).ToString(@"dd MMMM yyyy hh:mm:ss tt");
                        ord.DeliveryAddress = Convert.ToString(row["deliveryaddress"]);
                        ord.OrderQuantity = Convert.ToInt32(row["orderquantity"]);
                        ord.OrderWeight = Convert.ToInt32(row["OrderWeight"]);



                        list.Add(ord);
                    }
                }
                return View(list);
            }
            catch
            {
                return View("Error");
            }
        }

        public JsonResult GetData()
        {
            try
            {
                VehicleList vehicleList = null;
                using (MySqlConnection con = new MySqlConnection())
                {
                    String mysql = @"SELECT * FROM clickeystore_dev.vechicle_details";
                    con.ConnectionString = @"Server=dev.c71am30pjzpd.ap-south-1.rds.amazonaws.com;Database=clickeystore_dev;User Id=root;Password=Welcome123;";


                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = new MySqlCommand(mysql, con);
                    
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        vehicleList = new VehicleList();
                        vehicleList.vehicles = dt.AsEnumerable()
                            .Select(row => new Vehicle()
                            {
                                vechicletype = Convert.ToString(row["vechicletype"]),
                                vechiclecapacity = Convert.ToInt32(row["vechiclecapacity"])

                            }).ToList();
                       
                    }

                }
                
                return Json(vehicleList, JsonRequestBehavior.AllowGet);
            }
           
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Vehicle(string id)
        {
            return View();
        }
    }
}
    
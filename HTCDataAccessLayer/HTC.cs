using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTCDTO;

namespace HTCDataAccessLayer
{
    class HTC
    {
        public HTC()
        {

        }
     
                public List<Customer> GetCustomers()
            {
            try
            {
                List<Customer> lst = new List<Customer>();
                ResultString obC = new ResultStringy();
                var lis = obC.Customer.ToList(); ;
                foreach(var item in lis)
                {
                    lst.Add(
                        new Customer
                        {
                            CName = item.Cname,
                            CNum = item.CNum,
                            Area = item.Area,
                            NumberofVisit = item.NumberofVisit


                        });
                    
                         
                }
                return lst;

            }
        }
        public int Delete(Customer obj)
        {
            try
            {
                using(var obContext = new ResultString)
                {
                    Customer fb = obContext.Customer.Find(obj.CName);
                    fb.CName = obj.CName;
                    obContext.Customer.Remove(fb);
                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("oops");
                return 0;
            }
        }
    }
}

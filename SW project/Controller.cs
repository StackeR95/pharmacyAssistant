using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace SW_project
{
    public class Controller
    {
        DBManager dbMan;
        private static Controller myController = new Controller();
        private Controller()
        {
            dbMan = DBManager.getDBManagerInstance();
        }
        public static Controller getControllerInstance()
        {
            return myController;
        }
        public void TerminateConnection() // Close the connection between the application and the database
        {
            dbMan.CloseConnection();
        }
        public int CheckAccountPassword(string id, string password) // check user name & password validity
        {
            String StoredProcedureName = StoredProcedures.CheckAccountPassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>(); // used for stored procedures that need parameters to be passed by
            Parameters.Add("@username", id);
            Parameters.Add("@password", password);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public Double getMedicinePrice(int medicineBarCode) // return each medicines price
        {
            String StoredProcedureName = StoredProcedures.getMedicineByPrice;
            Dictionary<string, object> Parameters = new Dictionary<string, object>(); // used for stored procedures that need parameters to be passed by
            Parameters.Add("@medicineBarCode", medicineBarCode);

            return (Double)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int ChangePassword(string username, string newpassword) // Changes username password with the newpassword
        {
            String StoredProcedureName = StoredProcedures.ChangePassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>(); // used for stored procedures that need parameters to be passed by
            Parameters.Add("@username", username);
            Parameters.Add("@newpassword", newpassword);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertMedicine(int barcode, string Tradename, string Active_ing, string Concentration, string Category, float Price) //Insert new medicine passed to the function
        {

            string StoredProcedureName = StoredProcedures.IncertMedicine;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Code", barcode);
            Parameters.Add("@Tradename", Tradename);
            Parameters.Add("@concentration", Concentration);
            Parameters.Add("@Active_ing", Active_ing);
            Parameters.Add("@Category", Category);
            Parameters.Add("@Price", Price);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int EditMedicine(int barcode, string Tradename, string Active_ing, string Concentration, string Category, float Price) // Edit medicine details 
        {

            string StoredProcedureName = StoredProcedures.EditMedicine;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@code", barcode);
            Parameters.Add("@Tradename", Tradename);
            Parameters.Add("@concentration", Concentration);
            Parameters.Add("@Active_ing", Active_ing);
            Parameters.Add("@Category", Category);
            Parameters.Add("@Price", Price);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertCustomer(string cname, string caddress, string comments, string telephone) //Insert new customer 
        {

            string StoredProcedureName = StoredProcedures.IncertCustomer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@cname", cname);
            Parameters.Add("@caddress", caddress);
            Parameters.Add("@comments", comments);
            Parameters.Add("@telephone", telephone);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int EditCustomer(int code, string cname, string caddress, string comments, string telephone) // Edit customer information
        {

            string StoredProcedureName = StoredProcedures.EditCustomer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@cust_code", code);
            Parameters.Add("@cname", cname);
            Parameters.Add("@caddress", caddress);
            Parameters.Add("@comments", comments);
            Parameters.Add("@telephone", telephone);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable get_all_medicine() // get all medicine details 
        {
            String StoredProcedureName = StoredProcedures.get_all_medicine;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable get_all_customers() // get all customer details
        {
            String StoredProcedureName = StoredProcedures.get_all_customers;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable getCustomerByCode(int custCode) // get customer information by the primary key Customer code
        {
            String StoredProcedureName = StoredProcedures.getCustomersByCode;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@cust_code", custCode);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int DeleteCustomer(int c) // Delete customer by given customer code
        {
            String StoredProcedureName = StoredProcedures.DeleteCustomer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@cust_code", c);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable stockavailable() // Check if all medicine in stock
        {
            String StoredProcedureName = StoredProcedures.stockavailable;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public int lastorderno() // return last order number 
        {
            String StoredProcedureName = StoredProcedures.lastorderno;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public DataTable Orderreceipt(int transaction_number)
        {
            String StoredProcedureName = StoredProcedures.orderreceipt;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@orderno", transaction_number);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int insertorders() // insert new order number + snapchot time
        {

            string StoredProcedureName = StoredProcedures.insertorder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int insertordercon(int q, int br, int trans) // insert order details quantity , trans no and order primary key
        {
            string StoredProcedureName = StoredProcedures.insertordercon;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@quan", q);
            Parameters.Add("@transno", trans);
            Parameters.Add("@pcode", br);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int getoutofstockcount()  // Get number of medicines out of stock
        {
            String StoredProcedureName = StoredProcedures.outofstockcount;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int InsertPurchases(string date) // insert new purchase 
        {

            string StoredProcedureName = StoredProcedures.InsertPurchases;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@date", date);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertPurchasesContent(int trans_no, int prcode, int quan) // insert new purchase contents to purchases content table
        {

            string StoredProcedureName = StoredProcedures.InsertPurchasescon;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@transno", trans_no);
            Parameters.Add("@prcode", prcode);
            Parameters.Add("@quan", quan);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int getlasttransnopur() // get last Transaction number in purchases table
        {
            String StoredProcedureName = StoredProcedures.getlasttransnoinpurchases;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int DeleteOrder(int c) // delete selected order number
        {
            String StoredProcedureName = StoredProcedures.Deleteorder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@transaction_no", c);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable get_all_orders() // get all orders information
        {
            String StoredProcedureName = StoredProcedures.get_orders;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable SearchIng(string ing, string category) // search medicine by ingredient
        {
            String StoredProcedureName = StoredProcedures.SearchIng;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@activeing", ing);
            Parameters.Add("@cat", category);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable SearchName(string name, string category) // search medicine by name
        {
            String StoredProcedureName = StoredProcedures.SearchName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@tradename", name);
            Parameters.Add("@cat", category);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable SearchCustomers(string tel) // search for all customers
        {
            String StoredProcedureName = StoredProcedures.search_all_customers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@tel", tel);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable OutofStock() // get all medicines out of stock
        {
            String StoredProcedureName = StoredProcedures.Outofstock;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable purchasesinperiod(string d1, string d2) // get purchases period between two dates from date 1 to date 2
        {
            String StoredProcedureName = StoredProcedures.purchasesinperiod;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@date1", d1);
            Parameters.Add("@date2", d2);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable salesinperiod(string d1, string d2) // get sales of orders from date 1 to date 2s
        {
            String StoredProcedureName = StoredProcedures.salesinperiod;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@date1", d1);
            Parameters.Add("@date2", d2);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable AllStock() // get all medicines in stock
        {
            String StoredProcedureName = StoredProcedures.Allstock;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
    }
}

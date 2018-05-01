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
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public int CheckAccountPassword(string id, string password)
        {
            String StoredProcedureName = StoredProcedures.CheckAccountPassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", id);
            Parameters.Add("@password", password);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int ChangePassword(string username, string newpassword)
        {
            String StoredProcedureName = StoredProcedures.ChangePassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@username", username);
            Parameters.Add("@newpassword", newpassword);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertMedicine(int barcode, string Tradename, string Active_ing, string Concentration, string Category, float Price)
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
        public int EditMedicine(int barcode, string Tradename, string Active_ing, string Concentration, string Category, float Price)
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
        public int InsertCustomer(string cname, string caddress, string comments, string telephone)
        {

            string StoredProcedureName = StoredProcedures.IncertCustomer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@cname", cname);
            Parameters.Add("@caddress", caddress);
            Parameters.Add("@comments", comments);
            Parameters.Add("@telephone", telephone);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int EditCustomer(int code, string cname, string caddress, string comments, string telephone)
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
        public DataTable get_all_medicine()
        {
            String StoredProcedureName = StoredProcedures.get_all_medicine;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable get_all_customers()
        {
            String StoredProcedureName = StoredProcedures.get_all_customers;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable getCustomerByCode(int custCode)
        {
            String StoredProcedureName = StoredProcedures.getCustomersByCode;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@cust_code", custCode);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int DeleteCustomer(int c)
        {
            String StoredProcedureName = StoredProcedures.DeleteCustomer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@cust_code", c);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable stockavailable()
        {
            String StoredProcedureName = StoredProcedures.stockavailable;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public int lastorderno()
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
        public int insertorders()
        {

            string StoredProcedureName = StoredProcedures.insertorder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int insertordercon(int q, int br, int trans)
        {
            string StoredProcedureName = StoredProcedures.insertordercon;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@quan", q);
            Parameters.Add("@transno", trans);
            Parameters.Add("@pcode", br);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int getoutofstockcount()
        {
            String StoredProcedureName = StoredProcedures.outofstockcount;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int InsertPurchases(string date)
        {

            string StoredProcedureName = StoredProcedures.InsertPurchases;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@date", date);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertPurchasesContent(int trans_no, int prcode, int quan)
        {

            string StoredProcedureName = StoredProcedures.InsertPurchasescon;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@transno", trans_no);
            Parameters.Add("@prcode", prcode);
            Parameters.Add("@quan", quan);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int getlasttransnopur()
        {
            String StoredProcedureName = StoredProcedures.getlasttransnoinpurchases;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int DeleteOrder(int c)
        {
            String StoredProcedureName = StoredProcedures.Deleteorder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@transaction_no", c);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable get_all_orders()
        {
            String StoredProcedureName = StoredProcedures.get_orders;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable SearchIng(string ing, string category)
        {
            String StoredProcedureName = StoredProcedures.SearchIng;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@activeing", ing);
            Parameters.Add("@cat", category);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable SearchName(string name, string category)
        {
            String StoredProcedureName = StoredProcedures.SearchName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@tradename", name);
            Parameters.Add("@cat", category);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable SearchCustomers(string tel)
        {
            String StoredProcedureName = StoredProcedures.search_all_customers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@tel", tel);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable OutofStock()
        {
            String StoredProcedureName = StoredProcedures.Outofstock;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable purchasesinperiod(string d1, string d2)
        {
            String StoredProcedureName = StoredProcedures.purchasesinperiod;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@date1", d1);
            Parameters.Add("@date2", d2);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable salesinperiod(string d1, string d2)
        {
            String StoredProcedureName = StoredProcedures.salesinperiod;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@date1", d1);
            Parameters.Add("@date2", d2);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable AllStock()
        {
            String StoredProcedureName = StoredProcedures.Allstock;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
    }
}

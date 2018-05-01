using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SW_project
{
    public class StoredProcedures
    {
        public static string ChangePassword = "ChangePassword";
        public static string CheckAccountPassword = "CheckAccountPassword";
        public static string IncertMedicine = "Insert_medicine";
        public static string EditMedicine = "Update_medicine"; 
        public static string EditCustomer = "Update_customer";
        public static string IncertCustomer = "Insert_customer";
        public static string get_all_medicine = "getallmedicine";
        public static string get_all_customers = "getcustomers";
        public static string search_all_customers = "searchcustomers";
        public static string DeleteCustomer = "Delete_customer";
        public static string stockavailable = "stock";
        public static string orderreceipt = "orderreceipt";
        public static string lastorderno = "getlasttransnoinorders";
        public static string insertordercon = "Insert_ordercont";
        public static string insertorder = "Insert_order";
        public static string outofstockcount = "stockthresholdcount"; 
        public static string InsertPurchases = "Insert_purch"; 
        public static string InsertPurchasescon = "Insert_purch_cont"; 
        public static string getlasttransnoinpurchases = "getlasttransnoinpurchases";
        public static string get_orders = "getorders";
        public static string Deleteorder = "Delete_order";
        public static string SearchIng = "Search_activeing";
        public static string SearchName = "Search_tradename";
        public static string Outofstock = "stockthreshold";
        public static string salesinperiod = "salesinperiod";
        public static string purchasesinperiod = "purchasesinperiod";
        public static string Allstock = "All_Stock";
        public static string getCustomersByCode = "getCustomersByCustomerCode";
    }

}

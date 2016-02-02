using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;


namespace BarcodeWebService
{
    
    [WebService(Namespace = "http://SRV-WEB-03/Barcode")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    
    public class BarcodeWebService : System.Web.Services.WebService
    {
        public SqlConnection connection = new SqlConnection("Data Source=\\\\SRV-DIV-02\\TOS;Integrated Security=SSPI;Initial Catalog=streg");

        [WebMethod(Description = "Returns Barcodes", EnableSession = false)]
        public DataSet GetBarcodes()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Barcode, Item, Variant FROM Barcodes", connection);

            DataSet BarcodesDS = new DataSet();
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(BarcodesDS, "Barcodes");

            return BarcodesDS;
        }

        [WebMethod(Description = "Updates Barcodes", EnableSession = false)]
        public DataSet UpdateBarcodes(DataSet custDS)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.InsertCommand = new SqlCommand(
              "INSERT INTO Customers (CustomerID, CompanyName) " +
              "Values(@CustomerID, @CompanyName)", connection);
            adapter.InsertCommand.Parameters.Add(
              "@CustomerID", SqlDbType.NChar, 5, "CustomerID");
            adapter.InsertCommand.Parameters.Add(
              "@CompanyName", SqlDbType.NChar, 15, "CompanyName");

            adapter.UpdateCommand = new SqlCommand(
              "UPDATE Customers Set CustomerID = @CustomerID, " +
              "CompanyName = @CompanyName WHERE CustomerID = " +
              "@OldCustomerID", connection);
            adapter.UpdateCommand.Parameters.Add(
              "@CustomerID", SqlDbType.NChar, 5, "CustomerID");
            adapter.UpdateCommand.Parameters.Add(
              "@CompanyName", SqlDbType.NChar, 15, "CompanyName");
            SqlParameter parameter = adapter.UpdateCommand.Parameters.Add(
              "@OldCustomerID", SqlDbType.NChar, 5, "CustomerID");
            parameter.SourceVersion = DataRowVersion.Original;

            adapter.DeleteCommand = new SqlCommand(
            "DELETE FROM Customers WHERE CustomerID = @CustomerID",
             connection);
            parameter = adapter.DeleteCommand.Parameters.Add(
              "@CustomerID", SqlDbType.NChar, 5, "CustomerID");
            parameter.SourceVersion = DataRowVersion.Original;

            adapter.Update(custDS, "Customers");

            return custDS;
        }
    }
}

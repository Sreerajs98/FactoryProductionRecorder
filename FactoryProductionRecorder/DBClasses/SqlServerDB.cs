using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Collections.Generic;
using System.Data.Common;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace DBClasses
{
    class SqlServerDB
    {
        public bool saved;

        public static SqlConnection connection1;
        public static SqlConnection connection2;
        public static SqlConnection connection3;
        public static SqlConnection connection5;

        public static string connectionString1;
        public static string connectionString2;
        public static string connectionString3;
        public static string connectionString5;


        public SqlDataReader dataReader1;
        public SqlDataReader dataReader2;
        public SqlDataReader dataReader3;

        public SqlDataAdapter dataAdapter1;
        public SqlDataAdapter dataAdapter2;
        public SqlDataAdapter dataAdapter3;
        public SqlDataAdapter dataAdapter5;


        public string dbName = "";

        public static void setInstance(string dbName)
        {

            //
            if (dbName == "PROD")
            {
                //eEngineering
                connectionString1 = Prm_EncryptionDecryption.Prm_Pass.DecryptString(AppCode.Cart.MySplkey, "6eMZ0rZ5xAXFgM41BhkfJsVmRvxu869tvZmTATI9pwYuBo5On9tBYNT/qN+uBQFXGQ4zymuTYPbCGQybC568j2jzDUZWLbb4LBI0uuzLy07QwQMp2sC74wdTZ4ACDknByC7jgV6NkQY3M52yz3Prxg==");

                //EMPLOYEE DATA [biometric]
                connectionString2 = Prm_EncryptionDecryption.Prm_Pass.DecryptString(AppCode.Cart.MySplkey, "6eMZ0rZ5xAXFgM41BhkfJsVmRvxu869tvZmTATI9pwaXTGezzYiPIH5+WruPrTqNLzVB21WUWb57S9I93fvNPHlg9KCwcoZKk43nn0UcXK0W0Kbm657a17s2/nwKdGWXhO9L3qiVpE6KsiW3YIUYzg==");

                //AJM/PIM
                connectionString3 = Prm_EncryptionDecryption.Prm_Pass.DecryptString(AppCode.Cart.MySplkey, "6eMZ0rZ5xAXFgM41BhkfJsVmRvxu869tvZmTATI9pwY0tO/N5dRkQen7lp60rVcPW+QTYY+oUbFytVuZOFNGcsPxTTpB6QTf0oU5NiaxG2mlWJ611Ikn74vkU8GY+3odU0cibbbZYOUj0EcTN+4Okg==");

                //ProductionDB // 
                connectionString5 = Prm_EncryptionDecryption.Prm_Pass.DecryptString(AppCode.Cart.MySplkey, "6eMZ0rZ5xAXFgM41BhkfJsVmRvxu869tvZmTATI9pwa6+uVlItFqPBcf+1DjkBePpLo7/HpW7+ZoO5dhEcCG3udhHLheshbx3qF2+4ukiyGZ6PzJEGKj+5FnNkFSjK2tJz9Ql7JM7LW+CSTkNDEvtA==");

            }
            else if (dbName == "DEV")
            {
                //inhouseapps
                //connectionString1 = @"Data Source=ABS-RND-PRAMOD\SQLEXPRESS;Initial Catalog=InHouseApps_Dev;Persist Security Info=True;User ID=sa;Password=PrmPrm@9098";

                //eEngineering
                //connectionString1 = @"Data Source=10.20.21.145;Initial Catalog=eEngineering_Dev;Persist Security Info=True;User ID=sa;Password=PrmPrm@9098";
                connectionString1 = @"Data Source=ABS-RND-PRAMOD\SQLEXPRESS;Initial Catalog=eEngineering_Dev;Persist Security Info=True;User ID=sa;Password=PrmPrm@9098";
                //connectionString1 = @"Data Source=10.20.21.145;Initial Catalog=eEngineering_Dev;Persist Security Info=True;User ID=sa;Password=PrmPrm@9098";


                //EMPLOYEE DATA [biometric]
                //connectionString2 = @"Data Source=10.20.21.145;Initial Catalog=Biometric_Dev;Persist Security Info=True;User ID=sa;Password=PrmPrm@9098";
                connectionString2 = @"Data Source=ABS-RND-PRAMOD\SQLEXPRESS;Initial Catalog=Biometric_Dev;Persist Security Info=True;User ID=sa;Password=PrmPrm@9098";
                //connectionString2 = @"Data Source=10.20.21.145;Initial Catalog=Biometric_Dev;Persist Security Info=True;User ID=sa;Password=PrmPrm@9098";


                //AJM/PIM
                connectionString3 = @"Data Source=ABS-RND-PRAMOD\SQLEXPRESS;Initial Catalog=PimProd_Dev;Persist Security Info=True;User ID=sa;Password=PrmPrm@9098";


                //ProductionDB
                connectionString5 = @"Data Source=ABS-RND-PRAMOD\SQLEXPRESS;Initial Catalog=eProduction_Dev;Persist Security Info=True;User ID=sa;Password=PrmPrm@9098";


            }
            else //TEST 
            {

            }

        }


        public SqlServerDB()
        {

            connection1 = null;
            connection2 = null;
            connection3 = null;
            connection5 = null;


            dataReader1 = null;
            dataReader2 = null;
            saved = false;
        }


        public bool openConnection1()
        {
            connection1 = new SqlConnection(connectionString1);
            try
            {
                connection1.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

                if (connection1.State != ConnectionState.Closed)
                {
                    connection1.Close();
                    connection1.Dispose();
                    connection1 = null;
                }
            }

            return false;
        }
        public bool openConnection2()
        {
            connection2 = new SqlConnection(connectionString2);
            try
            {
                connection2.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

                if (connection2.State != ConnectionState.Closed)
                {
                    connection2.Close();
                    connection2.Dispose();
                    connection2 = null;
                }
            }

            return false;
        }
        public bool openConnection3()
        {
            connection3 = new SqlConnection(connectionString3);
            try
            {
                connection3.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

                if (connection3.State != ConnectionState.Closed)
                {
                    connection3.Close();
                    connection3.Dispose();
                    connection3 = null;
                }
            }

            return false;
        }

        public bool openConnection5()
        {
            connection5 = new SqlConnection(connectionString5);
            try
            {
                connection5.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

                if (connection5.State != ConnectionState.Closed)
                {
                    connection5.Close();
                    connection5.Dispose();
                    connection5 = null;
                }
            }

            return false;
        }

        public void closeConnection1()
        {
            try
            {
                if (connection1.State == ConnectionState.Open)
                {
                    connection1.Close();
                    connection1.Dispose();
                    connection1 = null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void closeConnection2()
        {
            try
            {
                if (connection2.State == ConnectionState.Open)
                {
                    connection2.Close();
                    connection2.Dispose();
                    connection2 = null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void closeConnection3()
        {
            try
            {
                if (connection3.State == ConnectionState.Open)
                {
                    connection3.Close();
                    connection3.Dispose();
                    connection3 = null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void closeConnection5()
        {
            try
            {
                if (connection5.State == ConnectionState.Open)
                {
                    connection5.Close();
                    connection5.Dispose();
                    connection5 = null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


        public SqlDataAdapter getAdapter1(string sqlStatement)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection1);
            try
            {
                dataAdapter1 = new SqlDataAdapter(sqlCommand);
                return dataAdapter1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                if (connection1.State != ConnectionState.Closed)
                {
                    connection1.Close();
                    connection1.Dispose();
                }
                return null;
            }
        }
        public SqlDataAdapter getAdapter2(string sqlStatement)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection2);
            try
            {
                dataAdapter2 = new SqlDataAdapter(sqlCommand);
                return dataAdapter2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                if (connection2.State != ConnectionState.Closed)
                {
                    connection2.Close();
                    connection2.Dispose();
                }
                return null;
            }
        }
        public SqlDataAdapter getAdapter3(string sqlStatement)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection3);
            try
            {
                dataAdapter3 = new SqlDataAdapter(sqlCommand);
                return dataAdapter3;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                if (connection3.State != ConnectionState.Closed)
                {
                    connection3.Close();
                    connection3.Dispose();
                }
                return null;
            }
        }
        public SqlDataAdapter getAdapter5(string sqlStatement)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection5);
            try
            {
                dataAdapter5 = new SqlDataAdapter(sqlCommand);
                return dataAdapter5;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                if (connection5.State != ConnectionState.Closed)
                {
                    connection5.Close();
                    connection5.Dispose();
                }
                return null;
            }
        }

        public SqlDataReader getReader1(string sqlStatement)
        {

            SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection1);

            try
            {
                closeReader1();
                dataReader1 = null;
                dataReader1 = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return dataReader1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                if (connection1.State != ConnectionState.Closed)
                {
                    connection1.Close();
                    connection1.Dispose();
                }
                return null;
            }
        }
        public SqlDataReader getReader2(string sqlStatement)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection2);
            try
            {
                closeReader2();
                dataReader2 = null;
                dataReader2 = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return dataReader2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                if (connection2.State != ConnectionState.Closed)
                {
                    connection2.Close();
                    connection2.Dispose();
                }
                return null;
            }
        }
        public SqlDataReader getReader3(string sqlStatement)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection3);
            try
            {
                closeReader3();
                dataReader3 = null;
                dataReader3 = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return dataReader3;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                if (connection3.State != ConnectionState.Closed)
                {
                    connection3.Close();
                    connection3.Dispose();
                }
                return null;
            }
        }


        public void closeReader1()
        {
            if (dataReader1 != null)
            {
                if (!dataReader1.IsClosed)
                {
                    dataReader1.Close();
                    closeConnection1();
                }
            }
        }
        public void closeReader2()
        {
            if (dataReader2 != null)
            {
                if (!dataReader2.IsClosed)
                {
                    dataReader2.Close();
                    closeConnection1();
                }
            }
        }
        public void closeReader3()
        {
            if (dataReader3 != null)
            {
                if (!dataReader3.IsClosed)
                {
                    dataReader3.Close();
                    closeConnection1();
                }
            }
        }


        //public bool ExecuteStoredProcedure(string storedProcedureName, int enquiryID)
        //{
        //    SqlCommand sqlCommand = new SqlCommand(storedProcedureName, connection);
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlCommand.Parameters.AddWithValue("@EnquiryID", enquiryID);

        //    try
        //    {
        //        closeReader();
        //        dataReader = null;
        //        dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //        if (connection.State != ConnectionState.Closed)
        //        {
        //            connection.Close(); connection.Dispose();
        //        }
        //        return false;
        //    }
        //}

        //public bool ExecuteStoredProcedure(string storedProcedureName, int enquiryID, int buildingID, int areaID)
        //{
        //    SqlCommand sqlCommand = new SqlCommand(storedProcedureName, connection);
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlCommand.Parameters.AddWithValue("@EnquiryID", enquiryID);
        //    sqlCommand.Parameters.AddWithValue("@BuildingID", buildingID);
        //    sqlCommand.Parameters.AddWithValue("@AreaID", areaID);

        //    try
        //    {
        //        closeReader();
        //        dataReader = null;
        //        dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //        if (connection.State != ConnectionState.Closed)
        //        {
        //            connection.Close(); connection.Dispose();
        //        }
        //        return false;
        //    }
        //}

        //public bool ExecuteSPForUpdateFramedOpeningTag(string storedProcedureName, int enquiryID, int buildingID, string openingFor, double openingWdith, double openingHeight, string Tag)
        //{
        //    SqlCommand sqlCommand = new SqlCommand(storedProcedureName, connection);
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlCommand.Parameters.AddWithValue("@EnquiryID", enquiryID);
        //    sqlCommand.Parameters.AddWithValue("@BuildingID", buildingID);
        //    sqlCommand.Parameters.AddWithValue("@OpeningFor", openingFor);
        //    sqlCommand.Parameters.AddWithValue("@OpeningWidth", openingWdith);
        //    sqlCommand.Parameters.AddWithValue("@OpeningHeight", openingHeight);
        //    sqlCommand.Parameters.AddWithValue("@Tag", Tag);
        //    try
        //    {
        //        closeReader();
        //        dataReader = null;
        //        dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //        if (connection.State != ConnectionState.Closed)
        //        {
        //            connection.Close(); connection.Dispose();
        //        }
        //        return false;
        //    }
        //}

        //public SqlDataReader getReaderFromStoredProcedure(string storedProcedureName, int enquiryID, int buildingID)
        //{
        //    SqlCommand sqlCommand = new SqlCommand(storedProcedureName, connection);
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlCommand.Parameters.AddWithValue("@EnquiryID", enquiryID);
        //    sqlCommand.Parameters.AddWithValue("@BuildingID", buildingID);

        //    try
        //    {
        //        closeReader();
        //        dataReader = null;
        //        dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
        //        return dataReader;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //        if (connection.State != ConnectionState.Closed)
        //        {
        //            connection.Close(); connection.Dispose();
        //        }
        //        return null;
        //    }
        //}

        //public SqlDataReader getReaderFromStoredProcedure1(string storedProcedureName, int enquiryID, int buildingID, string openingFor, double openingWidth, double openingHieght)
        //{
        //    SqlCommand sqlCommand = new SqlCommand(storedProcedureName, connection);
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlCommand.Parameters.AddWithValue("@EnquiryID", enquiryID);
        //    sqlCommand.Parameters.AddWithValue("@BuildingID", buildingID);
        //    sqlCommand.Parameters.AddWithValue("@OpeningFor", openingFor);
        //    sqlCommand.Parameters.AddWithValue("@OpeningWidth", openingWidth);
        //    sqlCommand.Parameters.AddWithValue("OpeningHeight", openingHieght);

        //    try
        //    {
        //        closeReader();
        //        dataReader = null;
        //        dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
        //        return dataReader;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //        if (connection.State != ConnectionState.Closed)
        //        {
        //            connection.Close(); connection.Dispose();
        //        }
        //        return null;
        //    }
        //}

        //public SqlDataReader getReaderFromStoredProcedure2(string storedProcedureName, int enquiryID, int buildingID, int areaID)
        //{
        //    SqlCommand sqlCommand = new SqlCommand(storedProcedureName, connection);
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlCommand.Parameters.AddWithValue("@EnquiryID", enquiryID);
        //    sqlCommand.Parameters.AddWithValue("@BuildingID", buildingID);
        //    sqlCommand.Parameters.AddWithValue("@AreaID", areaID);

        //    try
        //    {
        //        closeReader();
        //        dataReader = null;
        //        dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
        //        return dataReader;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //        if (connection.State != ConnectionState.Closed)
        //        {
        //            connection.Close(); connection.Dispose();
        //        }
        //        return null;
        //    }
        //}

        //public bool ExecuteStoredProcedureToAddNewProposalRevision(string storedProcedureName, int enquiryID, int lastRevisionID, int newRevisionID, DateTime quotationRevDate)
        //{
        //    SqlCommand sqlCommand = new SqlCommand(storedProcedureName, connection);
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlCommand.Parameters.AddWithValue("@EnquiryID", enquiryID);
        //    sqlCommand.Parameters.AddWithValue("@LastRevisionID", lastRevisionID);
        //    sqlCommand.Parameters.AddWithValue("@NewRevisionID", newRevisionID);
        //    sqlCommand.Parameters.AddWithValue("@QuotationRevDate", quotationRevDate);


        //    try
        //    {
        //        closeReader();
        //        dataReader = null;
        //        dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //        if (connection.State != ConnectionState.Closed)
        //        {
        //            connection.Close(); connection.Dispose();
        //        }
        //        return false;
        //    }
        //}

        //public bool ExecuteStoredProcedureToAddNewGDSRevision(string storedProcedureName, int enquiryID, int lastRevisionID, int newRevisionID)
        //{
        //    SqlCommand sqlCommand = new SqlCommand(storedProcedureName, connection);
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlCommand.Parameters.AddWithValue("@EnquiryID", enquiryID);
        //    sqlCommand.Parameters.AddWithValue("@LastRevisionID", lastRevisionID);
        //    sqlCommand.Parameters.AddWithValue("@NewRevisionID", newRevisionID);


        //    try
        //    {
        //        closeReader();
        //        dataReader = null;
        //        dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //        if (connection.State != ConnectionState.Closed)
        //        {
        //            connection.Close(); connection.Dispose();
        //        }
        //        return false;
        //    }
        //}

        //public bool ExecuteStoredProcedureToCopyFramedOpening(string storedProcedureName, int enquiryID, int buildingID, int areaID, int wallID)
        //{
        //    SqlCommand sqlCommand = new SqlCommand(storedProcedureName, connection);
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlCommand.Parameters.AddWithValue("@EnquiryID", enquiryID);
        //    sqlCommand.Parameters.AddWithValue("@BuildingID", buildingID);
        //    sqlCommand.Parameters.AddWithValue("@AreaID", areaID);
        //    sqlCommand.Parameters.AddWithValue("@WallID", wallID);

        //    try
        //    {
        //        closeReader();
        //        dataReader = null;
        //        dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //        if (connection.State != ConnectionState.Closed)
        //        {
        //            connection.Close(); connection.Dispose();
        //        }
        //        return false;
        //    }
        //}

        //public bool ExecuteStoredProcedureToCopyPaintSystem(string storedProcedureName, int enquiryID, int buildingID, int areaID, int fromAreaID)
        //{
        //    SqlCommand sqlCommand = new SqlCommand(storedProcedureName, connection);
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlCommand.Parameters.AddWithValue("@EnquiryID", enquiryID);
        //    sqlCommand.Parameters.AddWithValue("@BuildingID", buildingID);
        //    sqlCommand.Parameters.AddWithValue("@AreaID", areaID);
        //    sqlCommand.Parameters.AddWithValue("@FromAreaID", fromAreaID);

        //    try
        //    {
        //        closeReader();
        //        dataReader = null;
        //        dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //        if (connection.State != ConnectionState.Closed)
        //        {
        //            connection.Close(); connection.Dispose();
        //        }
        //        return false;
        //    }
        //}

        //public bool ExecuteStoredProcedureForDeleteQuickEst(string storedProcedureName, int enquiryID, int optionID)
        //{
        //    SqlCommand sqlCommand = new SqlCommand(storedProcedureName, connection);
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlCommand.Parameters.AddWithValue("@EnquiryID", enquiryID);
        //    sqlCommand.Parameters.AddWithValue("@OptionID", optionID);

        //    try
        //    {
        //        closeReader();
        //        dataReader = null;
        //        dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //        if (connection.State != ConnectionState.Closed)
        //        {
        //            connection.Close(); connection.Dispose();
        //        }
        //        return false;
        //    }
        //}

        //public bool ExecuteStoredProcedureToInsertPaintSystemSummary(string storedProcedureName, int enquiryID, int count)
        //{
        //    SqlCommand sqlCommand = new SqlCommand(storedProcedureName, connection);
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    sqlCommand.Parameters.AddWithValue("@EnquiryID", enquiryID);
        //    sqlCommand.Parameters.AddWithValue("@Count", count);

        //    try
        //    {
        //        closeReader();
        //        dataReader = null;
        //        dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //        if (connection.State != ConnectionState.Closed)
        //        {
        //            connection.Close(); connection.Dispose();
        //        }
        //        return false;
        //    }
        //}



        //public int executeSQLNonQuery(string sqlStatement)
        //{
        //    SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection);
        //    int RowAffected = -1;

        //    try
        //    {
        //        RowAffected = sqlCommand.ExecuteNonQuery();
        //        saved = true;
        //    }
        //    catch (Exception e)
        //    {
        //        RowAffected = -1;
        //        Console.WriteLine(e.ToString());
        //    }
        //    finally
        //    {
        //        if (connection.State != ConnectionState.Closed)
        //        {
        //            connection.Close();
        //            connection.Dispose();
        //        }
        //    }
        //    return RowAffected;
        //}
        //public int array_ExecuteSQLNonQuery(string[] Queries)
        //{
        //    int TotRowAffected = -1;
        //    SqlTransaction trans = connection.BeginTransaction();

        //    try
        //    {
        //        foreach (string sqlStatement in Queries)
        //        {
        //            SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection);
        //            sqlCommand.Transaction = trans;
        //            int RowAffected = sqlCommand.ExecuteNonQuery();
        //            TotRowAffected = TotRowAffected + RowAffected;
        //        }
        //        trans.Commit();
        //        TotRowAffected = TotRowAffected + 1; // -1 value need to cover
        //        saved = true;
        //    }
        //    catch (Exception e)
        //    {

        //        TotRowAffected = -1;
        //        trans.Rollback();
        //        Console.WriteLine(e.ToString());
        //    }
        //    finally
        //    {
        //        if (connection.State != ConnectionState.Closed)
        //        {
        //            connection.Close();
        //            connection.Dispose();
        //        }
        //    }

        //    return TotRowAffected;
        //}

        //public int array_ExecuteSQLNonQuery(string[] Queries, ref SqlTransaction trans)
        //{
        //    int TotRowAffected = -1;

        //    try
        //    {
        //        trans = connection.BeginTransaction(IsolationLevel.ReadCommitted);

        //        foreach (string sqlStatement in Queries)
        //        {
        //            SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection);
        //            sqlCommand.Transaction = trans;
        //            int RowAffected = sqlCommand.ExecuteNonQuery();
        //            TotRowAffected = TotRowAffected + RowAffected;
        //        }

        //        TotRowAffected = TotRowAffected + 1; // -1 value need to cover
        //        saved = true;
        //    }
        //    catch (Exception e)
        //    {
        //        TotRowAffected = -1;
        //        Console.WriteLine(e.ToString());
        //    }
        //    //finally
        //    //{
        //    //    if (connection.State != ConnectionState.Closed)
        //    //    {
        //    //        connection.Close();
        //    //        connection.Dispose();
        //    //    }
        //    //}

        //    return TotRowAffected;
        //}


       

        //public bool tableExists(string tableName)
        //{
        //    bool has = false;
        //    bool openConn = openConnectionTemporaryTable();
        //    if (openConn == true)
        //    {
        //        DataTable dt = connection.GetSchema("Tables");
        //        foreach (DataRow row in dt.Rows)
        //        {
        //            DataColumn column = dt.Columns[2];

        //            if (row[column].ToString() == tableName)
        //            {
        //                has = true;
        //            }
        //        }
        //        closeConnection(); connection.Dispose();
        //    }
        //    return has;
        //}

        //public void dropTable(string tableName)
        //{
        //    string sqlString = "DROP TABLE " + tableName;
        //    bool openConn = openConnection();
        //    if (openConn == true)
        //    {
        //        executeSQLNonQuery(sqlString);
        //        closeConnection(); connection.Dispose();
        //    }
        //}

        //public void uploadBLOB(string tableName, string columnName, string fileName, string pkey1name, string pkey2name, int pkey1value, int pkey2value)
        //{
        //    SqlConnection sqlConn = null;
        //    SqlParameter sqlParam = null;
        //    SqlCommand sqlCommand = null;
        //    FileStream fs = null;
        //    string sqlstr = "UPDATE [" + tableName + "] SET [" + columnName + "] = @File WHERE [" + pkey1name + "] = " + pkey1value + " AND [" + pkey2name + "] = " + pkey2value;

        //    try
        //    {
        //        sqlConn = new SqlConnection(connectionString);
        //        sqlCommand = new SqlCommand(sqlstr, sqlConn);
        //        fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        //        Byte[] blob = new Byte[fs.Length];
        //        fs.Read(blob, 0, blob.Length);
        //        fs.Close();
        //        sqlParam = new SqlParameter("@File", SqlDbType.Image, blob.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, blob);
        //        sqlCommand.Parameters.Add(sqlParam);
        //        sqlConn.Open();
        //        sqlCommand.ExecuteNonQuery();

        //    }
        //    catch (SqlException e)
        //    {
        //        Console.WriteLine("SQL Exception: " + e.Message);
        //    }

        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Exception: " + e.Message);
        //    }
        //}

        //public void downloadBLOB(string tableName, string columnName, string fileName, string pkey1name, string pkey2name, int pkey1value, int pkey2value)
        //{
        //    Byte[] blob = null;
        //    FileStream fs = null;
        //    string sqlstr = "SELECT [" + columnName + "] FROM [" + tableName + "] WHERE [" + pkey1name + "] = " + pkey1value + " AND [" + pkey2name + "] = " + pkey2value;

        //    try
        //    {

        //        SqlConnection sqlConn = new SqlConnection(connectionString);
        //        sqlConn.Open();
        //        SqlCommand sqlCommand = new SqlCommand(sqlstr, sqlConn);
        //        SqlDataReader sqlDR = sqlCommand.ExecuteReader();
        //        sqlDR.Read();

        //        blob = new Byte[(sqlDR.GetBytes(0, 0, null, 0, int.MaxValue))];
        //        sqlDR.GetBytes(0, 0, blob, 0, blob.Length);
        //        sqlDR.Close();
        //        sqlConn.Close();

        //        fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
        //        fs.Write(blob, 0, blob.Length);
        //        fs.Close();
        //    }

        //    catch (SqlException e)
        //    {
        //        Console.WriteLine("SQL Exception: " + e.Message);
        //    }

        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Exception: " + e.Message);
        //    }
        //}


        public static int array_ExecuteSQLNonQuery1(string[] Queries, ref SqlTransaction trans)
        {
            int TotRowAffected = -1;

            try
            {
                trans = connection1.BeginTransaction(IsolationLevel.ReadCommitted);

                foreach (string sqlStatement in Queries)
                {
                    //MessageBox.Show(sqlStatement);

                    SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection1);
                    sqlCommand.Transaction = trans;
                    int RowAffected = sqlCommand.ExecuteNonQuery();
                    TotRowAffected = TotRowAffected + RowAffected;

                    //MessageBox.Show("OK");
                }

                TotRowAffected = TotRowAffected + 1; // -1 value need to cover
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message + " #error");

                TotRowAffected = -1;
                Console.WriteLine(e.ToString());
            }

            return TotRowAffected;
        }
        public static int array_ExecuteSQLNonQuery2(string[] Queries, ref SqlTransaction trans)
        {
            int TotRowAffected = -1;

            try
            {
                trans = connection2.BeginTransaction(IsolationLevel.ReadCommitted);

                foreach (string sqlStatement in Queries)
                {
                    SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection2);
                    sqlCommand.Transaction = trans;
                    int RowAffected = sqlCommand.ExecuteNonQuery();
                    TotRowAffected = TotRowAffected + RowAffected;
                }

                TotRowAffected = TotRowAffected + 1; // -1 value need to cover
            }
            catch (Exception e)
            {
                TotRowAffected = -1;
                Console.WriteLine(e.ToString());
            }

            return TotRowAffected;
        }
        public static int array_ExecuteSQLNonQuery3(string[] Queries, ref SqlTransaction trans)
        {
            int TotRowAffected = -1;

            try
            {
                trans = connection3.BeginTransaction(IsolationLevel.ReadCommitted);

                foreach (string sqlStatement in Queries)
                {
                    SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection3);
                    sqlCommand.Transaction = trans;
                    int RowAffected = sqlCommand.ExecuteNonQuery();
                    TotRowAffected = TotRowAffected + RowAffected;
                }

                TotRowAffected = TotRowAffected + 1; // -1 value need to cover
            }
            catch (Exception e)
            {
                TotRowAffected = -1;
                Console.WriteLine(e.ToString());
            }

            return TotRowAffected;
        }
        public static int array_ExecuteSQLNonQuery5(string[] Queries, ref SqlTransaction trans)
        {
            int TotRowAffected = -1;

            try
            {
                trans = connection5.BeginTransaction(IsolationLevel.ReadCommitted);

                foreach (string sqlStatement in Queries)
                {
                    SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection5);
                    sqlCommand.Transaction = trans;
                    int RowAffected = sqlCommand.ExecuteNonQuery();
                    TotRowAffected = TotRowAffected + RowAffected;
                }

                TotRowAffected = TotRowAffected + 1; // -1 value need to cover
            }
            catch (Exception e)
            {
                TotRowAffected = -1;
                Console.WriteLine(e.ToString());
            }

            return TotRowAffected;
        }

        public static bool ExecuteTheQuery1(string[] sqlQueries)
        {
            bool isSuccess = false;
            SqlTransaction sqlTrans = null;

            try
            {
                DBClasses.SqlServerDB newSql = new DBClasses.SqlServerDB();
                newSql.openConnection1();

                int msSqlResult = array_ExecuteSQLNonQuery1(sqlQueries, ref sqlTrans);

                if (msSqlResult != -1)
                {
                    sqlTrans.Commit();
                    isSuccess = true;
                }
                else
                {
                    sqlTrans.Rollback();
                    isSuccess = false;
                }
            }
            catch (Exception ep)
            {
                sqlTrans.Rollback();
                isSuccess = false;
                MessageBox.Show(ep.Message);
            }

            return isSuccess;
        }

        public static bool ExecuteTheQuery2(string[] sqlQueries)
        {
            bool isSuccess = false;
            SqlTransaction sqlTrans = null;

            try
            {
                DBClasses.SqlServerDB newSql = new DBClasses.SqlServerDB();
                newSql.openConnection2();

                int msSqlResult = array_ExecuteSQLNonQuery2(sqlQueries, ref sqlTrans);

                if (msSqlResult != -1)
                {
                    sqlTrans.Commit();
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                    sqlTrans.Rollback();
                }

            }
            catch (Exception ep)
            {
                sqlTrans.Rollback();
                isSuccess = false;
                MessageBox.Show(ep.Message);
            }

            return isSuccess;
        }

        public static bool ExecuteTheQueryAJM(string[] sqlQueries)
        {
            bool isSuccess = false;
            SqlTransaction sqlTrans = null;

            try
            {
                DBClasses.SqlServerDB newSql = new DBClasses.SqlServerDB();
                newSql.openConnection3();

                int msSqlResult = array_ExecuteSQLNonQuery3(sqlQueries, ref sqlTrans);

                if (msSqlResult != -1)
                {
                    sqlTrans.Commit();
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                    sqlTrans.Rollback();
                }
            }
            catch (Exception ep)
            {
                sqlTrans.Rollback();
                isSuccess = false;
                MessageBox.Show(ep.Message);
            }

            return isSuccess;
        }

        public static bool ExecuteTheQuery5(string[] sqlQueries)
        {
            bool isSuccess = false;
            SqlTransaction sqlTrans = null;

            try
            {
                DBClasses.SqlServerDB newSql = new DBClasses.SqlServerDB();
                newSql.openConnection5();
                
                int msSqlResult = array_ExecuteSQLNonQuery5(sqlQueries, ref sqlTrans);

                if (msSqlResult != -1)
                {
                    sqlTrans.Commit();
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                    sqlTrans.Rollback();
                }

                newSql.closeConnection5();

            }
            catch (Exception ep)
            {
                sqlTrans.Rollback();
                isSuccess = false;
                MessageBox.Show(ep.Message);
            }

            return isSuccess;
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3082
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dbSyncTest {
    
    
    public partial class LocalDataCache1ClientSyncProvider : Microsoft.Synchronization.Data.SqlServerCe.SqlCeClientSyncProvider {
        
        public LocalDataCache1ClientSyncProvider() {
            this.ConnectionString = global::dbSyncTest.Properties.Settings.Default.ClientstregConnectionString;
        }
        
        public LocalDataCache1ClientSyncProvider(string connectionString) {
            this.ConnectionString = connectionString;
        }
    }
    
    public partial class LocalDataCache1SyncAgent : Microsoft.Synchronization.SyncAgent {
        
        private BarcodesSyncTable _barcodesSyncTable;
        
        partial void OnInitialized();
        
        public LocalDataCache1SyncAgent() {
            this.InitializeSyncProviders();
            this.InitializeSyncTables();
            this.OnInitialized();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public BarcodesSyncTable Barcodes {
            get {
                return this._barcodesSyncTable;
            }
            set {
                this.Configuration.SyncTables.Remove(this._barcodesSyncTable);
                this._barcodesSyncTable = value;
                this.Configuration.SyncTables.Add(this._barcodesSyncTable);
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeSyncProviders() {
            // Create SyncProviders.
            this.RemoteProvider = new LocalDataCache1ServerSyncProvider();
            this.LocalProvider = new LocalDataCache1ClientSyncProvider();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeSyncTables() {
            // Create SyncTables.
            this._barcodesSyncTable = new BarcodesSyncTable();
            this._barcodesSyncTable.SyncGroup = new Microsoft.Synchronization.Data.SyncGroup("BarcodesSyncTableSyncGroup");
            this.Configuration.SyncTables.Add(this._barcodesSyncTable);
        }
        
        public partial class BarcodesSyncTable : Microsoft.Synchronization.Data.SyncTable {
            
            partial void OnInitialized();
            
            public BarcodesSyncTable() {
                this.InitializeTableOptions();
                this.OnInitialized();
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private void InitializeTableOptions() {
                this.TableName = "Barcodes";
                this.CreationOption = Microsoft.Synchronization.Data.TableCreationOption.DropExistingOrCreateNewTable;
            }
        }
    }
}
namespace dbSyncTest {
    
    
    public partial class BarcodesSyncAdapter : Microsoft.Synchronization.Data.Server.SyncAdapter {
        
        partial void OnInitialized();
        
        public BarcodesSyncAdapter() {
            this.InitializeCommands();
            this.InitializeAdapterProperties();
            this.OnInitialized();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeCommands() {
            // BarcodesSyncTableInsertCommand command.
            this.InsertCommand = new System.Data.SqlClient.SqlCommand();
            this.InsertCommand.CommandText = "INSERT INTO dbo.Barcodes ([Barcode], [Size], [Number], [Variant], [Item], [Test]," +
                " [BatType], [LastEditDate], [CreationDate]) VALUES (@Barcode, @Size, @Number, @V" +
                "ariant, @Item, @Test, @BatType, @LastEditDate, @CreationDate) SET @sync_row_coun" +
                "t = @@rowcount";
            this.InsertCommand.CommandType = System.Data.CommandType.Text;
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Barcode", System.Data.SqlDbType.NChar));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Size", System.Data.SqlDbType.NVarChar));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Number", System.Data.SqlDbType.NVarChar));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Variant", System.Data.SqlDbType.NVarChar));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Item", System.Data.SqlDbType.NVarChar));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Test", System.Data.SqlDbType.NVarChar));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@BatType", System.Data.SqlDbType.NVarChar));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@LastEditDate", System.Data.SqlDbType.DateTime));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CreationDate", System.Data.SqlDbType.DateTime));
            System.Data.SqlClient.SqlParameter insertcommand_sync_row_countParameter = new System.Data.SqlClient.SqlParameter("@sync_row_count", System.Data.SqlDbType.Int);
            insertcommand_sync_row_countParameter.Direction = System.Data.ParameterDirection.Output;
            this.InsertCommand.Parameters.Add(insertcommand_sync_row_countParameter);
            // BarcodesSyncTableDeleteCommand command.
            this.DeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.DeleteCommand.CommandText = "DELETE FROM dbo.Barcodes WHERE ([Barcode] = @Barcode) AND (@sync_force_write = 1 " +
                "OR ([LastEditDate] <= @sync_last_received_anchor)) SET @sync_row_count = @@rowco" +
                "unt";
            this.DeleteCommand.CommandType = System.Data.CommandType.Text;
            this.DeleteCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Barcode", System.Data.SqlDbType.NChar));
            this.DeleteCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_force_write", System.Data.SqlDbType.Bit));
            this.DeleteCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_last_received_anchor", System.Data.SqlDbType.DateTime));
            System.Data.SqlClient.SqlParameter deletecommand_sync_row_countParameter = new System.Data.SqlClient.SqlParameter("@sync_row_count", System.Data.SqlDbType.Int);
            deletecommand_sync_row_countParameter.Direction = System.Data.ParameterDirection.Output;
            this.DeleteCommand.Parameters.Add(deletecommand_sync_row_countParameter);
            // BarcodesSyncTableUpdateCommand command.
            this.UpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.UpdateCommand.CommandText = @"UPDATE dbo.Barcodes SET [Size] = @Size, [Number] = @Number, [Variant] = @Variant, [Item] = @Item, [Test] = @Test, [BatType] = @BatType, [LastEditDate] = @LastEditDate, [CreationDate] = @CreationDate WHERE ([Barcode] = @Barcode) AND (@sync_force_write = 1 OR ([LastEditDate] <= @sync_last_received_anchor)) SET @sync_row_count = @@rowcount";
            this.UpdateCommand.CommandType = System.Data.CommandType.Text;
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Size", System.Data.SqlDbType.NVarChar));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Number", System.Data.SqlDbType.NVarChar));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Variant", System.Data.SqlDbType.NVarChar));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Item", System.Data.SqlDbType.NVarChar));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Test", System.Data.SqlDbType.NVarChar));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@BatType", System.Data.SqlDbType.NVarChar));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@LastEditDate", System.Data.SqlDbType.DateTime));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CreationDate", System.Data.SqlDbType.DateTime));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Barcode", System.Data.SqlDbType.NChar));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_force_write", System.Data.SqlDbType.Bit));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_last_received_anchor", System.Data.SqlDbType.DateTime));
            System.Data.SqlClient.SqlParameter updatecommand_sync_row_countParameter = new System.Data.SqlClient.SqlParameter("@sync_row_count", System.Data.SqlDbType.Int);
            updatecommand_sync_row_countParameter.Direction = System.Data.ParameterDirection.Output;
            this.UpdateCommand.Parameters.Add(updatecommand_sync_row_countParameter);
            // BarcodesSyncTableSelectConflictDeletedRowsCommand command.
            this.SelectConflictDeletedRowsCommand = new System.Data.SqlClient.SqlCommand();
            this.SelectConflictDeletedRowsCommand.CommandText = "SELECT [Barcode], [DeletionDate] FROM [Barcodes_Tombstone] WHERE ([Barcode] = @Ba" +
                "rcode)";
            this.SelectConflictDeletedRowsCommand.CommandType = System.Data.CommandType.Text;
            this.SelectConflictDeletedRowsCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Barcode", System.Data.SqlDbType.NChar));
            // BarcodesSyncTableSelectConflictUpdatedRowsCommand command.
            this.SelectConflictUpdatedRowsCommand = new System.Data.SqlClient.SqlCommand();
            this.SelectConflictUpdatedRowsCommand.CommandText = "SELECT [Barcode], [Size], [Number], [Variant], [Item], [Test], [BatType], [LastEd" +
                "itDate], [CreationDate] FROM dbo.Barcodes WHERE ([Barcode] = @Barcode)";
            this.SelectConflictUpdatedRowsCommand.CommandType = System.Data.CommandType.Text;
            this.SelectConflictUpdatedRowsCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Barcode", System.Data.SqlDbType.NChar));
            // BarcodesSyncTableSelectIncrementalInsertsCommand command.
            this.SelectIncrementalInsertsCommand = new System.Data.SqlClient.SqlCommand();
            this.SelectIncrementalInsertsCommand.CommandText = "SELECT [Barcode], [Size], [Number], [Variant], [Item], [Test], [BatType], [LastEd" +
                "itDate], [CreationDate] FROM dbo.Barcodes WHERE ([CreationDate] > @sync_last_rec" +
                "eived_anchor AND [CreationDate] <= @sync_new_received_anchor)";
            this.SelectIncrementalInsertsCommand.CommandType = System.Data.CommandType.Text;
            this.SelectIncrementalInsertsCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_last_received_anchor", System.Data.SqlDbType.DateTime));
            this.SelectIncrementalInsertsCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_new_received_anchor", System.Data.SqlDbType.DateTime));
            // BarcodesSyncTableSelectIncrementalDeletesCommand command.
            this.SelectIncrementalDeletesCommand = new System.Data.SqlClient.SqlCommand();
            this.SelectIncrementalDeletesCommand.CommandText = "SELECT [Barcode], [DeletionDate] FROM [Barcodes_Tombstone] WHERE (@sync_initializ" +
                "ed = 1 AND [DeletionDate] > @sync_last_received_anchor AND [DeletionDate] <= @sy" +
                "nc_new_received_anchor)";
            this.SelectIncrementalDeletesCommand.CommandType = System.Data.CommandType.Text;
            this.SelectIncrementalDeletesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_initialized", System.Data.SqlDbType.Bit));
            this.SelectIncrementalDeletesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_last_received_anchor", System.Data.SqlDbType.DateTime));
            this.SelectIncrementalDeletesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_new_received_anchor", System.Data.SqlDbType.DateTime));
            // BarcodesSyncTableSelectIncrementalUpdatesCommand command.
            this.SelectIncrementalUpdatesCommand = new System.Data.SqlClient.SqlCommand();
            this.SelectIncrementalUpdatesCommand.CommandText = @"SELECT [Barcode], [Size], [Number], [Variant], [Item], [Test], [BatType], [LastEditDate], [CreationDate] FROM dbo.Barcodes WHERE ([LastEditDate] > @sync_last_received_anchor AND [LastEditDate] <= @sync_new_received_anchor AND [CreationDate] <= @sync_last_received_anchor)";
            this.SelectIncrementalUpdatesCommand.CommandType = System.Data.CommandType.Text;
            this.SelectIncrementalUpdatesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_last_received_anchor", System.Data.SqlDbType.DateTime));
            this.SelectIncrementalUpdatesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_new_received_anchor", System.Data.SqlDbType.DateTime));
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeAdapterProperties() {
            this.TableName = "Barcodes";
        }
    }
    
    public partial class LocalDataCache1ServerSyncProvider : Microsoft.Synchronization.Data.Server.DbServerSyncProvider {
        
        private BarcodesSyncAdapter _barcodesSyncAdapter;
        
        partial void OnInitialized();
        
        public LocalDataCache1ServerSyncProvider() {
            string connectionString = global::dbSyncTest.Properties.Settings.Default.ServerstregConnectionString;
            this.InitializeConnection(connectionString);
            this.InitializeSyncAdapters();
            this.InitializeNewAnchorCommand();
            this.OnInitialized();
        }
        
        public LocalDataCache1ServerSyncProvider(string connectionString) {
            this.InitializeConnection(connectionString);
            this.InitializeSyncAdapters();
            this.InitializeNewAnchorCommand();
            this.OnInitialized();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public BarcodesSyncAdapter BarcodesSyncAdapter {
            get {
                return this._barcodesSyncAdapter;
            }
            set {
                this._barcodesSyncAdapter = value;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeConnection(string connectionString) {
            this.Connection = new System.Data.SqlClient.SqlConnection(connectionString);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeSyncAdapters() {
            // Create SyncAdapters.
            this._barcodesSyncAdapter = new BarcodesSyncAdapter();
            this.SyncAdapters.Add(this._barcodesSyncAdapter);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeNewAnchorCommand() {
            // selectNewAnchorCmd command.
            this.SelectNewAnchorCommand = new System.Data.SqlClient.SqlCommand();
            this.SelectNewAnchorCommand.CommandText = "Select @sync_new_received_anchor = GETUTCDATE()";
            this.SelectNewAnchorCommand.CommandType = System.Data.CommandType.Text;
            System.Data.SqlClient.SqlParameter selectnewanchorcommand_sync_new_received_anchorParameter = new System.Data.SqlClient.SqlParameter("@sync_new_received_anchor", System.Data.SqlDbType.DateTime);
            selectnewanchorcommand_sync_new_received_anchorParameter.Direction = System.Data.ParameterDirection.Output;
            this.SelectNewAnchorCommand.Parameters.Add(selectnewanchorcommand_sync_new_received_anchorParameter);
        }
    }
}
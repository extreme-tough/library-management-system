//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace LibrarySystem {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class dsInventory : DataSet {
        
        private tblBooksDataTable tabletblBooks;
        
        public dsInventory() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected dsInventory(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tblBooks"] != null)) {
                    this.Tables.Add(new tblBooksDataTable(ds.Tables["tblBooks"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public tblBooksDataTable tblBooks {
            get {
                return this.tabletblBooks;
            }
        }
        
        public override DataSet Clone() {
            dsInventory cln = ((dsInventory)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["tblBooks"] != null)) {
                this.Tables.Add(new tblBooksDataTable(ds.Tables["tblBooks"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tabletblBooks = ((tblBooksDataTable)(this.Tables["tblBooks"]));
            if ((this.tabletblBooks != null)) {
                this.tabletblBooks.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "dsInventory";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/dsInventory.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletblBooks = new tblBooksDataTable();
            this.Tables.Add(this.tabletblBooks);
        }
        
        private bool ShouldSerializetblBooks() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tblBooksRowChangeEventHandler(object sender, tblBooksRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tblBooksDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnTotalBooks;
            
            private DataColumn columnTotalPrice;
            
            private DataColumn columnTotalBarrowed;
            
            private DataColumn columnTotalAvailable;
            
            internal tblBooksDataTable() : 
                    base("tblBooks") {
                this.InitClass();
            }
            
            internal tblBooksDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn TotalBooksColumn {
                get {
                    return this.columnTotalBooks;
                }
            }
            
            internal DataColumn TotalPriceColumn {
                get {
                    return this.columnTotalPrice;
                }
            }
            
            internal DataColumn TotalBarrowedColumn {
                get {
                    return this.columnTotalBarrowed;
                }
            }
            
            internal DataColumn TotalAvailableColumn {
                get {
                    return this.columnTotalAvailable;
                }
            }
            
            public tblBooksRow this[int index] {
                get {
                    return ((tblBooksRow)(this.Rows[index]));
                }
            }
            
            public event tblBooksRowChangeEventHandler tblBooksRowChanged;
            
            public event tblBooksRowChangeEventHandler tblBooksRowChanging;
            
            public event tblBooksRowChangeEventHandler tblBooksRowDeleted;
            
            public event tblBooksRowChangeEventHandler tblBooksRowDeleting;
            
            public void AddtblBooksRow(tblBooksRow row) {
                this.Rows.Add(row);
            }
            
            public tblBooksRow AddtblBooksRow(System.Double TotalBooks, System.Double TotalPrice, System.Double TotalBarrowed, System.Double TotalAvailable) {
                tblBooksRow rowtblBooksRow = ((tblBooksRow)(this.NewRow()));
                rowtblBooksRow.ItemArray = new object[] {
                        TotalBooks,
                        TotalPrice,
                        TotalBarrowed,
                        TotalAvailable};
                this.Rows.Add(rowtblBooksRow);
                return rowtblBooksRow;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tblBooksDataTable cln = ((tblBooksDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tblBooksDataTable();
            }
            
            internal void InitVars() {
                this.columnTotalBooks = this.Columns["TotalBooks"];
                this.columnTotalPrice = this.Columns["TotalPrice"];
                this.columnTotalBarrowed = this.Columns["TotalBarrowed"];
                this.columnTotalAvailable = this.Columns["TotalAvailable"];
            }
            
            private void InitClass() {
                this.columnTotalBooks = new DataColumn("TotalBooks", typeof(System.Double), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTotalBooks);
                this.columnTotalPrice = new DataColumn("TotalPrice", typeof(System.Double), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTotalPrice);
                this.columnTotalBarrowed = new DataColumn("TotalBarrowed", typeof(System.Double), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTotalBarrowed);
                this.columnTotalAvailable = new DataColumn("TotalAvailable", typeof(System.Double), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTotalAvailable);
            }
            
            public tblBooksRow NewtblBooksRow() {
                return ((tblBooksRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tblBooksRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tblBooksRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tblBooksRowChanged != null)) {
                    this.tblBooksRowChanged(this, new tblBooksRowChangeEvent(((tblBooksRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tblBooksRowChanging != null)) {
                    this.tblBooksRowChanging(this, new tblBooksRowChangeEvent(((tblBooksRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tblBooksRowDeleted != null)) {
                    this.tblBooksRowDeleted(this, new tblBooksRowChangeEvent(((tblBooksRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tblBooksRowDeleting != null)) {
                    this.tblBooksRowDeleting(this, new tblBooksRowChangeEvent(((tblBooksRow)(e.Row)), e.Action));
                }
            }
            
            public void RemovetblBooksRow(tblBooksRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tblBooksRow : DataRow {
            
            private tblBooksDataTable tabletblBooks;
            
            internal tblBooksRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletblBooks = ((tblBooksDataTable)(this.Table));
            }
            
            public System.Double TotalBooks {
                get {
                    try {
                        return ((System.Double)(this[this.tabletblBooks.TotalBooksColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tabletblBooks.TotalBooksColumn] = value;
                }
            }
            
            public System.Double TotalPrice {
                get {
                    try {
                        return ((System.Double)(this[this.tabletblBooks.TotalPriceColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tabletblBooks.TotalPriceColumn] = value;
                }
            }
            
            public System.Double TotalBarrowed {
                get {
                    try {
                        return ((System.Double)(this[this.tabletblBooks.TotalBarrowedColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tabletblBooks.TotalBarrowedColumn] = value;
                }
            }
            
            public System.Double TotalAvailable {
                get {
                    try {
                        return ((System.Double)(this[this.tabletblBooks.TotalAvailableColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tabletblBooks.TotalAvailableColumn] = value;
                }
            }
            
            public bool IsTotalBooksNull() {
                return this.IsNull(this.tabletblBooks.TotalBooksColumn);
            }
            
            public void SetTotalBooksNull() {
                this[this.tabletblBooks.TotalBooksColumn] = System.Convert.DBNull;
            }
            
            public bool IsTotalPriceNull() {
                return this.IsNull(this.tabletblBooks.TotalPriceColumn);
            }
            
            public void SetTotalPriceNull() {
                this[this.tabletblBooks.TotalPriceColumn] = System.Convert.DBNull;
            }
            
            public bool IsTotalBarrowedNull() {
                return this.IsNull(this.tabletblBooks.TotalBarrowedColumn);
            }
            
            public void SetTotalBarrowedNull() {
                this[this.tabletblBooks.TotalBarrowedColumn] = System.Convert.DBNull;
            }
            
            public bool IsTotalAvailableNull() {
                return this.IsNull(this.tabletblBooks.TotalAvailableColumn);
            }
            
            public void SetTotalAvailableNull() {
                this[this.tabletblBooks.TotalAvailableColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tblBooksRowChangeEvent : EventArgs {
            
            private tblBooksRow eventRow;
            
            private DataRowAction eventAction;
            
            public tblBooksRowChangeEvent(tblBooksRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tblBooksRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}

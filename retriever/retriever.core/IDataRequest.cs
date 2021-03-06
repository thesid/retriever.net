﻿using System.Collections.Generic;

namespace Retriever.Core
{
    public interface IDataRequest
    {
        string ConnectionString { get; set; }
        string Fetch(string storedProcedureName, string jsonFetchParams = null);
        string Fetch(string storedProcedureName, dynamic paramsObject);
        int Hurl(string storedProcedureName, string jsonData, TransactionMode transMode);
        int Hurl(string storedProcedureName, string jsonData);
        int Hurl(string storedProcedureName, dynamic obj);
        int Hurl(string storedProcedureName, dynamic obj, TransactionMode transMode);
        int Hurl(string storedProcedureName, List<dynamic> objects, TransactionMode transMode);
        int Hurl(string storedProcedureName, List<dynamic> objects);

    }
}

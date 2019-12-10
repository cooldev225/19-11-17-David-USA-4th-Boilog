using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPowerBIReportsApi
    {
        /// <summary>
        /// Creates a new PowerBIReport CatalogItem. 
        /// </summary>
        /// <param name="powerBIReport">The definition of the new PowerBIReport CatalogItem.</param>
        /// <returns>PowerBIReport</returns>
        PowerBIReport AddPowerBIReport (PowerBIReport powerBIReport);
        /// <summary>
        /// Creates a new Comment associated to the specified PowerBIReport. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="comment">The Comment to be created</param>
        /// <returns></returns>
        void AddPowerBIReportComment (string id, Comment comment);
        /// <summary>
        /// Checks the status of the specified DataSource connection. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="dataSourceName">The name of the DataSource to check.</param>
        /// <returns>DataSourceCheckResult</returns>
        DataSourceCheckResult CheckPowerBIReportDataSourceConnection (string id, string dataSourceName);
        /// <summary>
        /// Deletes the specified PowerBIReport. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns></returns>
        void DeletePowerBIReport (string id);
        /// <summary>
        /// Deletes the specified Comment associated to the PowerBIReport. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="commentId">The Id of the Comment.</param>
        /// <returns></returns>
        void DeletePowerBIReportComment (string id, string commentId);
        /// <summary>
        /// Gets the CacheRefreshPlans for a given Power BI Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>ODataCacheRefreshPlans</returns>
        ODataCacheRefreshPlans GetPowerBICacheRefreshPlans (string id);
        /// <summary>
        /// Gets a PowerBIReport CatalogItem specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>PowerBIReport</returns>
        PowerBIReport GetPowerBIReport (string id);
        /// <summary>
        /// Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>ODataAllowedActions</returns>
        ODataAllowedActions GetPowerBIReportAllowedActions (string id);
        /// <summary>
        /// Gets the Comments for a PowerBIReport specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>ODataComments</returns>
        ODataComments GetPowerBIReportComments (string id);
        /// <summary>
        /// Gets the content of the specified PowerBIReport CatalogItem. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream GetPowerBIReportContent (string id);
        /// <summary>
        /// Gets the data model role assignments that are associated with the specified PowerBIReport. Added in January 2019 Release
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>ODataDataModelRoleAssignments</returns>
        ODataDataModelRoleAssignments GetPowerBIReportDataModelRoleAssignments (string id);
        /// <summary>
        /// Gets the data model roles that are associated with the specified PowerBIReport. Added in January 2019 Release
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>ODataDataModelRoles</returns>
        ODataDataModelRoles GetPowerBIReportDataModelRoles (string id);
        /// <summary>
        /// Gets the DataSources that are associated with the specified PowerBIReport. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>ODataDataSources</returns>
        ODataDataSources GetPowerBIReportDataSources (string id);
        /// <summary>
        /// Gets ItemPolicies associated with the specified PowerBIReport CatalogItem. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>List&lt;ItemPolicy&gt;</returns>
        List<ItemPolicy> GetPowerBIReportPolicies (string id);
        /// <summary>
        /// Gets PowerBIReports Properties (takes list of Property names to retrieve the values) 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="properties">Names for the Properties to be returned.</param>
        /// <returns>ODataProperties</returns>
        ODataProperties GetPowerBIReportProperties (string id, List<string> properties);
        /// <summary>
        /// Gets an array of PowerBIReport CatalogItems. 
        /// </summary>
        /// <param name="top">Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630)</param>
        /// <param name="skip">Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631)</param>
        /// <param name="filter">Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625)</param>
        /// <param name="count">Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632)</param>
        /// <param name="orderBy">Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629)</param>
        /// <param name="select">Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620)</param>
        /// <returns>ODataPowerBIReports</returns>
        ODataPowerBIReports GetPowerBIReports (int? top, int? skip, string filter, string count, string orderBy, string select);
        /// <summary>
        /// Replaces the data model role assignments that are associated with the specified PowerBIReport. Added in January 2019 Release
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="dataModelRoleAssignments">Updated data model role assignments associated with the specified PowerBIReport.</param>
        /// <returns></returns>
        void ReplacePowerBIReportDataModelRoleAssignments (string id, List<DataModelRoleAssignment> dataModelRoleAssignments);
        /// <summary>
        /// Replaces ItemPolicies associated with the specified PowerBIReport item. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="itemPolicies">The ItemPolicy definitions that will be replaced.</param>
        /// <returns></returns>
        void SetPowerBIReportPolicies (string id, List<ItemPolicy> itemPolicies);
        /// <summary>
        /// Updates the specified PowerBIReport CatalogItem using the provided definition. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="powerBIReport">Definition of the PowerBIReport item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.</param>
        /// <returns>PowerBIReport</returns>
        PowerBIReport UpdatePowerBIReport (string id, PowerBIReport powerBIReport);
        /// <summary>
        /// Updates the Comment specified by CommentId in the associated PowerBIReport. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="commentId">The Id of the Comment.</param>
        /// <param name="comment">The Comment to be updated</param>
        /// <returns></returns>
        void UpdatePowerBIReportComment (string id, string commentId, Comment comment);
        /// <summary>
        /// Updates the DataSource definition associated with the PowerBIReport specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="dataSources">Updated definition for the DataSource associated with the PowerBIReport specified by the Id.</param>
        /// <returns></returns>
        void UpdatePowerBIReportDataSource (string id, List<DataSource> dataSources);
        /// <summary>
        /// Updates the PowerBIReport Properties included in the given list. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="properties">The Properties that will be updated.</param>
        /// <returns></returns>
        void UpdatePowerBIReportProperties (string id, List<Property> properties);
        /// <summary>
        /// Does an efficient binary upload of a new or existing PowerBIReport CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="file">The file contents.</param>
        /// <returns>PowerBIReport</returns>
        PowerBIReport UploadPowerBIReport (string id, System.IO.Stream file);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PowerBIReportsApi : IPowerBIReportsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PowerBIReportsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PowerBIReportsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PowerBIReportsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PowerBIReportsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Creates a new PowerBIReport CatalogItem. 
        /// </summary>
        /// <param name="powerBIReport">The definition of the new PowerBIReport CatalogItem.</param> 
        /// <returns>PowerBIReport</returns>            
        public PowerBIReport AddPowerBIReport (PowerBIReport powerBIReport)
        {
            
            // verify the required parameter 'powerBIReport' is set
            if (powerBIReport == null) throw new ApiException(400, "Missing required parameter 'powerBIReport' when calling AddPowerBIReport");
            
    
            var path = "/PowerBIReports";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(powerBIReport); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddPowerBIReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddPowerBIReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PowerBIReport) ApiClient.Deserialize(response.Content, typeof(PowerBIReport), response.Headers);
        }
    
        /// <summary>
        /// Creates a new Comment associated to the specified PowerBIReport. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="comment">The Comment to be created</param> 
        /// <returns></returns>            
        public void AddPowerBIReportComment (string id, Comment comment)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AddPowerBIReportComment");
            
            // verify the required parameter 'comment' is set
            if (comment == null) throw new ApiException(400, "Missing required parameter 'comment' when calling AddPowerBIReportComment");
            
    
            var path = "/PowerBIReports({Id})/Comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(comment); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddPowerBIReportComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddPowerBIReportComment: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Checks the status of the specified DataSource connection. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="dataSourceName">The name of the DataSource to check.</param> 
        /// <returns>DataSourceCheckResult</returns>            
        public DataSourceCheckResult CheckPowerBIReportDataSourceConnection (string id, string dataSourceName)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CheckPowerBIReportDataSourceConnection");
            
            // verify the required parameter 'dataSourceName' is set
            if (dataSourceName == null) throw new ApiException(400, "Missing required parameter 'dataSourceName' when calling CheckPowerBIReportDataSourceConnection");
            
    
            var path = "/PowerBIReports({Id})/Model.CheckDataSourceConnection";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(dataSourceName); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckPowerBIReportDataSourceConnection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckPowerBIReportDataSourceConnection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DataSourceCheckResult) ApiClient.Deserialize(response.Content, typeof(DataSourceCheckResult), response.Headers);
        }
    
        /// <summary>
        /// Deletes the specified PowerBIReport. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns></returns>            
        public void DeletePowerBIReport (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeletePowerBIReport");
            
    
            var path = "/PowerBIReports({Id})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePowerBIReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePowerBIReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes the specified Comment associated to the PowerBIReport. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="commentId">The Id of the Comment.</param> 
        /// <returns></returns>            
        public void DeletePowerBIReportComment (string id, string commentId)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeletePowerBIReportComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling DeletePowerBIReportComment");
            
    
            var path = "/PowerBIReports({Id})/Comments({CommentId})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "CommentId" + "}", ApiClient.ParameterToString(commentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePowerBIReportComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePowerBIReportComment: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the CacheRefreshPlans for a given Power BI Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>ODataCacheRefreshPlans</returns>            
        public ODataCacheRefreshPlans GetPowerBICacheRefreshPlans (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetPowerBICacheRefreshPlans");
            
    
            var path = "/PowerBIReports({Id})/CacheRefreshPlans";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBICacheRefreshPlans: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBICacheRefreshPlans: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataCacheRefreshPlans) ApiClient.Deserialize(response.Content, typeof(ODataCacheRefreshPlans), response.Headers);
        }
    
        /// <summary>
        /// Gets a PowerBIReport CatalogItem specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>PowerBIReport</returns>            
        public PowerBIReport GetPowerBIReport (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetPowerBIReport");
            
    
            var path = "/PowerBIReports({Id})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PowerBIReport) ApiClient.Deserialize(response.Content, typeof(PowerBIReport), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>ODataAllowedActions</returns>            
        public ODataAllowedActions GetPowerBIReportAllowedActions (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetPowerBIReportAllowedActions");
            
    
            var path = "/PowerBIReports({Id})/AllowedActions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReportAllowedActions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReportAllowedActions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataAllowedActions) ApiClient.Deserialize(response.Content, typeof(ODataAllowedActions), response.Headers);
        }
    
        /// <summary>
        /// Gets the Comments for a PowerBIReport specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>ODataComments</returns>            
        public ODataComments GetPowerBIReportComments (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetPowerBIReportComments");
            
    
            var path = "/PowerBIReports({Id})/Comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReportComments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReportComments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataComments) ApiClient.Deserialize(response.Content, typeof(ODataComments), response.Headers);
        }
    
        /// <summary>
        /// Gets the content of the specified PowerBIReport CatalogItem. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream GetPowerBIReportContent (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetPowerBIReportContent");
            
    
            var path = "/PowerBIReports({Id})/Content/$value";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReportContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReportContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (System.IO.Stream) ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }
    
        /// <summary>
        /// Gets the data model role assignments that are associated with the specified PowerBIReport. Added in January 2019 Release
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>ODataDataModelRoleAssignments</returns>            
        public ODataDataModelRoleAssignments GetPowerBIReportDataModelRoleAssignments (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetPowerBIReportDataModelRoleAssignments");
            
    
            var path = "/PowerBIReports({Id})/DataModelRoleAssignments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReportDataModelRoleAssignments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReportDataModelRoleAssignments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataDataModelRoleAssignments) ApiClient.Deserialize(response.Content, typeof(ODataDataModelRoleAssignments), response.Headers);
        }
    
        /// <summary>
        /// Gets the data model roles that are associated with the specified PowerBIReport. Added in January 2019 Release
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>ODataDataModelRoles</returns>            
        public ODataDataModelRoles GetPowerBIReportDataModelRoles (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetPowerBIReportDataModelRoles");
            
    
            var path = "/PowerBIReports({Id})/DataModelRoles";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReportDataModelRoles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReportDataModelRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataDataModelRoles) ApiClient.Deserialize(response.Content, typeof(ODataDataModelRoles), response.Headers);
        }
    
        /// <summary>
        /// Gets the DataSources that are associated with the specified PowerBIReport. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>ODataDataSources</returns>            
        public ODataDataSources GetPowerBIReportDataSources (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetPowerBIReportDataSources");
            
    
            var path = "/PowerBIReports({Id})/DataSources";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReportDataSources: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReportDataSources: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataDataSources) ApiClient.Deserialize(response.Content, typeof(ODataDataSources), response.Headers);
        }
    
        /// <summary>
        /// Gets ItemPolicies associated with the specified PowerBIReport CatalogItem. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>List&lt;ItemPolicy&gt;</returns>            
        public List<ItemPolicy> GetPowerBIReportPolicies (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetPowerBIReportPolicies");
            
    
            var path = "/PowerBIReports({Id})/Policies";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReportPolicies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReportPolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ItemPolicy>) ApiClient.Deserialize(response.Content, typeof(List<ItemPolicy>), response.Headers);
        }
    
        /// <summary>
        /// Gets PowerBIReports Properties (takes list of Property names to retrieve the values) 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="properties">Names for the Properties to be returned.</param> 
        /// <returns>ODataProperties</returns>            
        public ODataProperties GetPowerBIReportProperties (string id, List<string> properties)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetPowerBIReportProperties");
            
    
            var path = "/PowerBIReports({Id})/Properties";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (properties != null) queryParams.Add("properties", ApiClient.ParameterToString(properties)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReportProperties: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReportProperties: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataProperties) ApiClient.Deserialize(response.Content, typeof(ODataProperties), response.Headers);
        }
    
        /// <summary>
        /// Gets an array of PowerBIReport CatalogItems. 
        /// </summary>
        /// <param name="top">Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630)</param> 
        /// <param name="skip">Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631)</param> 
        /// <param name="filter">Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625)</param> 
        /// <param name="count">Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632)</param> 
        /// <param name="orderBy">Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629)</param> 
        /// <param name="select">Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620)</param> 
        /// <returns>ODataPowerBIReports</returns>            
        public ODataPowerBIReports GetPowerBIReports (int? top, int? skip, string filter, string count, string orderBy, string select)
        {
            
    
            var path = "/PowerBIReports";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (top != null) queryParams.Add("$top", ApiClient.ParameterToString(top)); // query parameter
 if (skip != null) queryParams.Add("$skip", ApiClient.ParameterToString(skip)); // query parameter
 if (filter != null) queryParams.Add("$filter", ApiClient.ParameterToString(filter)); // query parameter
 if (count != null) queryParams.Add("$count", ApiClient.ParameterToString(count)); // query parameter
 if (orderBy != null) queryParams.Add("$orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (select != null) queryParams.Add("$select", ApiClient.ParameterToString(select)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReports: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPowerBIReports: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataPowerBIReports) ApiClient.Deserialize(response.Content, typeof(ODataPowerBIReports), response.Headers);
        }

        public string GetPowerBIReportsString(int? top, int? skip, string filter, string count, string orderBy, string select, string username, string password, string url)
        {


            var path = "/PowerBIReports";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (top != null) queryParams.Add("$top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("$skip", ApiClient.ParameterToString(skip)); // query parameter
            if (filter != null) queryParams.Add("$filter", ApiClient.ParameterToString(filter)); // query parameter
            if (count != null) queryParams.Add("$count", ApiClient.ParameterToString(count)); // query parameter
            if (orderBy != null) queryParams.Add("$orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
            if (select != null) queryParams.Add("$select", ApiClient.ParameterToString(select)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApiNew(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings, username, password, url);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetPowerBIReports: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetPowerBIReports: " + response.ErrorMessage, response.ErrorMessage);

            return response.Content;
        }

        /// <summary>
        /// Replaces the data model role assignments that are associated with the specified PowerBIReport. Added in January 2019 Release
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="dataModelRoleAssignments">Updated data model role assignments associated with the specified PowerBIReport.</param> 
        /// <returns></returns>            
        public void ReplacePowerBIReportDataModelRoleAssignments (string id, List<DataModelRoleAssignment> dataModelRoleAssignments)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReplacePowerBIReportDataModelRoleAssignments");
            
            // verify the required parameter 'dataModelRoleAssignments' is set
            if (dataModelRoleAssignments == null) throw new ApiException(400, "Missing required parameter 'dataModelRoleAssignments' when calling ReplacePowerBIReportDataModelRoleAssignments");
            
    
            var path = "/PowerBIReports({Id})/DataModelRoleAssignments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(dataModelRoleAssignments); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplacePowerBIReportDataModelRoleAssignments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplacePowerBIReportDataModelRoleAssignments: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Replaces ItemPolicies associated with the specified PowerBIReport item. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="itemPolicies">The ItemPolicy definitions that will be replaced.</param> 
        /// <returns></returns>            
        public void SetPowerBIReportPolicies (string id, List<ItemPolicy> itemPolicies)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SetPowerBIReportPolicies");
            
            // verify the required parameter 'itemPolicies' is set
            if (itemPolicies == null) throw new ApiException(400, "Missing required parameter 'itemPolicies' when calling SetPowerBIReportPolicies");
            
    
            var path = "/PowerBIReports({Id})/Policies";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(itemPolicies); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetPowerBIReportPolicies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetPowerBIReportPolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the specified PowerBIReport CatalogItem using the provided definition. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="powerBIReport">Definition of the PowerBIReport item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.</param> 
        /// <returns>PowerBIReport</returns>            
        public PowerBIReport UpdatePowerBIReport (string id, PowerBIReport powerBIReport)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdatePowerBIReport");
            
            // verify the required parameter 'powerBIReport' is set
            if (powerBIReport == null) throw new ApiException(400, "Missing required parameter 'powerBIReport' when calling UpdatePowerBIReport");
            
    
            var path = "/PowerBIReports({Id})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(powerBIReport); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePowerBIReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePowerBIReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PowerBIReport) ApiClient.Deserialize(response.Content, typeof(PowerBIReport), response.Headers);
        }
    
        /// <summary>
        /// Updates the Comment specified by CommentId in the associated PowerBIReport. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="commentId">The Id of the Comment.</param> 
        /// <param name="comment">The Comment to be updated</param> 
        /// <returns></returns>            
        public void UpdatePowerBIReportComment (string id, string commentId, Comment comment)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdatePowerBIReportComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling UpdatePowerBIReportComment");
            
            // verify the required parameter 'comment' is set
            if (comment == null) throw new ApiException(400, "Missing required parameter 'comment' when calling UpdatePowerBIReportComment");
            
    
            var path = "/PowerBIReports({Id})/Comments({CommentId})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "CommentId" + "}", ApiClient.ParameterToString(commentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(comment); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePowerBIReportComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePowerBIReportComment: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the DataSource definition associated with the PowerBIReport specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="dataSources">Updated definition for the DataSource associated with the PowerBIReport specified by the Id.</param> 
        /// <returns></returns>            
        public void UpdatePowerBIReportDataSource (string id, List<DataSource> dataSources)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdatePowerBIReportDataSource");
            
            // verify the required parameter 'dataSources' is set
            if (dataSources == null) throw new ApiException(400, "Missing required parameter 'dataSources' when calling UpdatePowerBIReportDataSource");
            
    
            var path = "/PowerBIReports({Id})/DataSources";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(dataSources); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePowerBIReportDataSource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePowerBIReportDataSource: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the PowerBIReport Properties included in the given list. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="properties">The Properties that will be updated.</param> 
        /// <returns></returns>            
        public void UpdatePowerBIReportProperties (string id, List<Property> properties)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdatePowerBIReportProperties");
            
            // verify the required parameter 'properties' is set
            if (properties == null) throw new ApiException(400, "Missing required parameter 'properties' when calling UpdatePowerBIReportProperties");
            
    
            var path = "/PowerBIReports({Id})/Properties";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(properties); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePowerBIReportProperties: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePowerBIReportProperties: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Does an efficient binary upload of a new or existing PowerBIReport CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="file">The file contents.</param> 
        /// <returns>PowerBIReport</returns>            
        public PowerBIReport UploadPowerBIReport (string id, System.IO.Stream file)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UploadPowerBIReport");
            
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling UploadPowerBIReport");
            
    
            var path = "/PowerBIReports({Id})/Model.Upload";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (file != null) fileParams.Add("File", ApiClient.ParameterToFile("File", file));
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UploadPowerBIReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UploadPowerBIReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PowerBIReport) ApiClient.Deserialize(response.Content, typeof(PowerBIReport), response.Headers);
        }
    
    }
}

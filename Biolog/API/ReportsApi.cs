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
    public interface IReportsApi
    {
        /// <summary>
        /// Creates a new Report CatalogItem. 
        /// </summary>
        /// <param name="report">The definition of the new Report CatalogItem.</param>
        /// <returns>Report</returns>
        Report AddReport (Report report);
        /// <summary>
        /// Creates a new Comment associated to the specified Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="comment">The Comment to be created</param>
        /// <returns></returns>
        void AddReportComment (string id, Comment comment);
        /// <summary>
        /// Creates new HistorySnapshot 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>bool?</returns>
        bool? AddReportHistorySnapshot (string id);
        /// <summary>
        /// Checks the status of the specified Reports DataSource connection. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="dataSourceName">The name of the DataSource to check.</param>
        /// <returns>DataSourceCheckResult</returns>
        DataSourceCheckResult CheckReportDataSourceConnection (string id, string dataSourceName);
        /// <summary>
        /// Deletes the specified Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns></returns>
        void DeleteReport (string id);
        /// <summary>
        /// Deletes the specified Comment associated to the Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="commentId">The Id of the Comment.</param>
        /// <returns></returns>
        void DeleteReportComment (string id, string commentId);
        /// <summary>
        /// Deletes the requested Reports HistorySnapshot specified by HistoryId. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="historyId">The ID property of the HistorySnapshot</param>
        /// <returns>bool?</returns>
        bool? DeleteReportHistorySnapshot (string id, string historyId);
        /// <summary>
        /// Gets a Report CatalogItem specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>Report</returns>
        Report GetReport (string id);
        /// <summary>
        /// Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>ODataAllowedActions</returns>
        ODataAllowedActions GetReportAllowedActions (string id);
        /// <summary>
        /// Gets the content of CacheOptions for the Report specified by the Id 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>CacheOptions</returns>
        CacheOptions GetReportCacheOptions (string id);
        /// <summary>
        /// Gets the CacheRefreshPlans for the Report specified by the Id 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>ODataCacheRefreshPlans</returns>
        ODataCacheRefreshPlans GetReportCacheRefreshPlans (string id);
        /// <summary>
        /// Gets the Comments for a Report specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>ODataComments</returns>
        ODataComments GetReportComments (string id);
        /// <summary>
        /// Gets the content of the specified Report CatalogItem specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream GetReportContent (string id);
        /// <summary>
        /// Gets the DataSources associated with the Report specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>ODataDataSources</returns>
        ODataDataSources GetReportDataSources (string id);
        /// <summary>
        /// Returns a list of CatalogItems that reference the Report specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>ODataDependentItems</returns>
        ODataDependentItems GetReportDependentItems (string id);
        /// <summary>
        /// Gets the requested Reports HistorySnapshot specified by HistoryId. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="historyId">The ID property of the HistorySnapshot</param>
        /// <returns>HistorySnapshot</returns>
        HistorySnapshot GetReportHistorySnapshot (string id, string historyId);
        /// <summary>
        /// Gets the HistorySnapshotOptions for the specified Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>HistorySnapshotOptions</returns>
        HistorySnapshotOptions GetReportHistorySnapshotOptions (string id);
        /// <summary>
        /// Get a list of HistorySnapshots for the specified Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>List&lt;HistorySnapshot&gt;</returns>
        List<HistorySnapshot> GetReportHistorySnapshots (string id);
        /// <summary>
        /// Gets the ParameterDefinitions associated with the Report specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>ODataReportParameterDefinitions</returns>
        ODataReportParameterDefinitions GetReportParameterDefinitions (string id);
        /// <summary>
        /// Gets policies associated with the specified Report CatalogItem. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>List&lt;ItemPolicy&gt;</returns>
        List<ItemPolicy> GetReportPolicies (string id);
        /// <summary>
        /// Gets the specified Reports Properties (takes list of Property names to retrieve the values) 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="properties">Names for the Properties to be returned.</param>
        /// <returns>ODataProperties</returns>
        ODataProperties GetReportProperties (string id, List<string> properties);
        /// <summary>
        /// Gets the shared DataSets for the specified Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>List&lt;DataSet&gt;</returns>
        List<DataSet> GetReportSharedDataSets (string id);
        /// <summary>
        /// Gets the Subscriptions for the specified Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="top">Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630)</param>
        /// <param name="skip">Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631)</param>
        /// <param name="filter">Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625)</param>
        /// <param name="count">Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632)</param>
        /// <param name="orderBy">Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629)</param>
        /// <param name="expand">Expand related entities, see [OData Expand](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374621)</param>
        /// <param name="select">Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620)</param>
        /// <returns>List&lt;Subscription&gt;</returns>
        List<Subscription> GetReportSubscriptions (string id, int? top, int? skip, string filter, string count, string orderBy, string expand, string select);
        /// <summary>
        /// Gets an array of Report CatalogItems. 
        /// </summary>
        /// <param name="top">Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630)</param>
        /// <param name="skip">Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631)</param>
        /// <param name="filter">Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625)</param>
        /// <param name="count">Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632)</param>
        /// <param name="orderBy">Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629)</param>
        /// <param name="select">Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620)</param>
        /// <returns>ODataReports</returns>
        ODataReports GetReports (int? top, int? skip, string filter, string count, string orderBy, string select);
        /// <summary>
        /// Replaces the CacheOptions content for a given Report using the provided definition. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="cacheOptions">Updated definition for the CacheOptions content associated with the given Report.</param>
        /// <returns></returns>
        void SetReportCacheOptions (string id, CacheOptions cacheOptions);
        /// <summary>
        /// Updates the DataSource definition associated with the Report specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="dataSource">Updated definition for the DataSource associated with the Report specified by the Id.</param>
        /// <returns></returns>
        void SetReportDataSource (string id, DataSource dataSource);
        /// <summary>
        /// Updates HistorySnapshotOptions for the specified Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="historySnapshotOptions">Modified HistorySnapshotOptions object.</param>
        /// <returns></returns>
        void SetReportHistorySnapshotOptions (string id, HistorySnapshotOptions historySnapshotOptions);
        /// <summary>
        /// Replaces ItemPolicies associated with the Report specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="itemPolicies">The ItemPolicy definitions that will be replaced.</param>
        /// <returns></returns>
        void SetReportPolicies (string id, List<ItemPolicy> itemPolicies);
        /// <summary>
        /// Updates the DataSet definitions associated with the specified Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="dataSets">Updated DataSet definitions for the specified Report.</param>
        /// <returns></returns>
        void SetReportSharedDataSets (string id, List<DataSet> dataSets);
        /// <summary>
        /// Updates the execution cache snapshot for the specified report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>UpdateCacheSnapshotResult</returns>
        UpdateCacheSnapshotResult UpdateCacheSnapshot (string id);
        /// <summary>
        /// Updates the specified Report CatalogItem using the provided definition. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="report">Definition of the Report item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.</param>
        /// <returns></returns>
        void UpdateReport (string id, Report report);
        /// <summary>
        /// Updates the Comment specified by CommentId in the associated Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="commentId">The Id of the Comment.</param>
        /// <param name="comment">The Comment to be updated</param>
        /// <returns></returns>
        void UpdateReportComment (string id, string commentId, Comment comment);
        /// <summary>
        /// Updates report to use the specificed shared datasets. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="dataSets">Shared datasets to be used by specified report</param>
        /// <returns></returns>
        void UpdateReportDataSets (string id, SharedDataSets dataSets);
        /// <summary>
        /// Updates the ParameterDefinitions associated with the Report specified by Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="parameterDefinitions">Updated definitions for the ParameterDefinitions associated with the Report, represented as ParameterDefinitionsPatch object. It is only necessary to include properties to be updated. All other property values will be left unchanged.</param>
        /// <returns></returns>
        void UpdateReportParameterDefinitions (string id, List<ReportParameterDefinitionPatch> parameterDefinitions);
        /// <summary>
        /// Updates the Report Properties included in the given list. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="properties">The Properties that will be updated.</param>
        /// <returns></returns>
        void UpdateReportProperties (string id, List<Property> properties);
        /// <summary>
        /// Does an efficient binary upload of a new or existing Report CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="file">The file contents.</param>
        /// <returns>Report</returns>
        Report UploadReport (string id, System.IO.Stream file);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReportsApi : IReportsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReportsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportsApi(String basePath)
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
        /// Creates a new Report CatalogItem. 
        /// </summary>
        /// <param name="report">The definition of the new Report CatalogItem.</param> 
        /// <returns>Report</returns>            
        public Report AddReport (Report report)
        {
            
            // verify the required parameter 'report' is set
            if (report == null) throw new ApiException(400, "Missing required parameter 'report' when calling AddReport");
            
    
            var path = "/Reports";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(report); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Report) ApiClient.Deserialize(response.Content, typeof(Report), response.Headers);
        }
    
        /// <summary>
        /// Creates a new Comment associated to the specified Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="comment">The Comment to be created</param> 
        /// <returns></returns>            
        public void AddReportComment (string id, Comment comment)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AddReportComment");
            
            // verify the required parameter 'comment' is set
            if (comment == null) throw new ApiException(400, "Missing required parameter 'comment' when calling AddReportComment");
            
    
            var path = "/Reports({Id})/Comments";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddReportComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddReportComment: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Creates new HistorySnapshot 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>bool?</returns>            
        public bool? AddReportHistorySnapshot (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AddReportHistorySnapshot");
            
    
            var path = "/Reports({Id})/HistorySnapshots";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddReportHistorySnapshot: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddReportHistorySnapshot: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
        /// <summary>
        /// Checks the status of the specified Reports DataSource connection. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="dataSourceName">The name of the DataSource to check.</param> 
        /// <returns>DataSourceCheckResult</returns>            
        public DataSourceCheckResult CheckReportDataSourceConnection (string id, string dataSourceName)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CheckReportDataSourceConnection");
            
            // verify the required parameter 'dataSourceName' is set
            if (dataSourceName == null) throw new ApiException(400, "Missing required parameter 'dataSourceName' when calling CheckReportDataSourceConnection");
            
    
            var path = "/Reports({Id})/Model.CheckDataSourceConnection";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CheckReportDataSourceConnection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckReportDataSourceConnection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DataSourceCheckResult) ApiClient.Deserialize(response.Content, typeof(DataSourceCheckResult), response.Headers);
        }
    
        /// <summary>
        /// Deletes the specified Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns></returns>            
        public void DeleteReport (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteReport");
            
    
            var path = "/Reports({Id})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes the specified Comment associated to the Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="commentId">The Id of the Comment.</param> 
        /// <returns></returns>            
        public void DeleteReportComment (string id, string commentId)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteReportComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling DeleteReportComment");
            
    
            var path = "/Reports({Id})/Comments({CommentId})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteReportComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteReportComment: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes the requested Reports HistorySnapshot specified by HistoryId. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="historyId">The ID property of the HistorySnapshot</param> 
        /// <returns>bool?</returns>            
        public bool? DeleteReportHistorySnapshot (string id, string historyId)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteReportHistorySnapshot");
            
            // verify the required parameter 'historyId' is set
            if (historyId == null) throw new ApiException(400, "Missing required parameter 'historyId' when calling DeleteReportHistorySnapshot");
            
    
            var path = "/Reports({Id})/HistorySnapshots({HistoryId})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "HistoryId" + "}", ApiClient.ParameterToString(historyId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteReportHistorySnapshot: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteReportHistorySnapshot: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
        /// <summary>
        /// Gets a Report CatalogItem specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>Report</returns>            
        public Report GetReport (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetReport");
            
    
            var path = "/Reports({Id})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Report) ApiClient.Deserialize(response.Content, typeof(Report), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>ODataAllowedActions</returns>            
        public ODataAllowedActions GetReportAllowedActions (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetReportAllowedActions");
            
    
            var path = "/Reports({Id})/AllowedActions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportAllowedActions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportAllowedActions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataAllowedActions) ApiClient.Deserialize(response.Content, typeof(ODataAllowedActions), response.Headers);
        }
    
        /// <summary>
        /// Gets the content of CacheOptions for the Report specified by the Id 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>CacheOptions</returns>            
        public CacheOptions GetReportCacheOptions (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetReportCacheOptions");
            
    
            var path = "/Reports({Id})/CacheOptions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportCacheOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportCacheOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CacheOptions) ApiClient.Deserialize(response.Content, typeof(CacheOptions), response.Headers);
        }
    
        /// <summary>
        /// Gets the CacheRefreshPlans for the Report specified by the Id 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>ODataCacheRefreshPlans</returns>            
        public ODataCacheRefreshPlans GetReportCacheRefreshPlans (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetReportCacheRefreshPlans");
            
    
            var path = "/Reports({Id})/CacheRefreshPlans";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportCacheRefreshPlans: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportCacheRefreshPlans: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataCacheRefreshPlans) ApiClient.Deserialize(response.Content, typeof(ODataCacheRefreshPlans), response.Headers);
        }
    
        /// <summary>
        /// Gets the Comments for a Report specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>ODataComments</returns>            
        public ODataComments GetReportComments (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetReportComments");
            
    
            var path = "/Reports({Id})/Comments";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportComments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportComments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataComments) ApiClient.Deserialize(response.Content, typeof(ODataComments), response.Headers);
        }
    
        /// <summary>
        /// Gets the content of the specified Report CatalogItem specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream GetReportContent (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetReportContent");
            
    
            var path = "/Reports({Id})/Content/$value";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (System.IO.Stream) ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }
    
        /// <summary>
        /// Gets the DataSources associated with the Report specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>ODataDataSources</returns>            
        public ODataDataSources GetReportDataSources (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetReportDataSources");
            
    
            var path = "/Reports({Id})/DataSources";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportDataSources: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportDataSources: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataDataSources) ApiClient.Deserialize(response.Content, typeof(ODataDataSources), response.Headers);
        }
    
        /// <summary>
        /// Returns a list of CatalogItems that reference the Report specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>ODataDependentItems</returns>            
        public ODataDependentItems GetReportDependentItems (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetReportDependentItems");
            
    
            var path = "/Reports({Id})/DependentItems";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportDependentItems: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportDependentItems: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataDependentItems) ApiClient.Deserialize(response.Content, typeof(ODataDependentItems), response.Headers);
        }
    
        /// <summary>
        /// Gets the requested Reports HistorySnapshot specified by HistoryId. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="historyId">The ID property of the HistorySnapshot</param> 
        /// <returns>HistorySnapshot</returns>            
        public HistorySnapshot GetReportHistorySnapshot (string id, string historyId)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetReportHistorySnapshot");
            
            // verify the required parameter 'historyId' is set
            if (historyId == null) throw new ApiException(400, "Missing required parameter 'historyId' when calling GetReportHistorySnapshot");
            
    
            var path = "/Reports({Id})/HistorySnapshots({HistoryId})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "HistoryId" + "}", ApiClient.ParameterToString(historyId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportHistorySnapshot: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportHistorySnapshot: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HistorySnapshot) ApiClient.Deserialize(response.Content, typeof(HistorySnapshot), response.Headers);
        }
    
        /// <summary>
        /// Gets the HistorySnapshotOptions for the specified Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>HistorySnapshotOptions</returns>            
        public HistorySnapshotOptions GetReportHistorySnapshotOptions (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetReportHistorySnapshotOptions");
            
    
            var path = "/Reports({Id})/HistorySnapshotOptions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportHistorySnapshotOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportHistorySnapshotOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HistorySnapshotOptions) ApiClient.Deserialize(response.Content, typeof(HistorySnapshotOptions), response.Headers);
        }
    
        /// <summary>
        /// Get a list of HistorySnapshots for the specified Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>List&lt;HistorySnapshot&gt;</returns>            
        public List<HistorySnapshot> GetReportHistorySnapshots (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetReportHistorySnapshots");
            
    
            var path = "/Reports({Id})/HistorySnapshots";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportHistorySnapshots: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportHistorySnapshots: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<HistorySnapshot>) ApiClient.Deserialize(response.Content, typeof(List<HistorySnapshot>), response.Headers);
        }
    
        /// <summary>
        /// Gets the ParameterDefinitions associated with the Report specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>ODataReportParameterDefinitions</returns>            
        public ODataReportParameterDefinitions GetReportParameterDefinitions (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetReportParameterDefinitions");
            
    
            var path = "/Reports({Id})/ParameterDefinitions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportParameterDefinitions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportParameterDefinitions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataReportParameterDefinitions) ApiClient.Deserialize(response.Content, typeof(ODataReportParameterDefinitions), response.Headers);
        }
    
        /// <summary>
        /// Gets policies associated with the specified Report CatalogItem. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>List&lt;ItemPolicy&gt;</returns>            
        public List<ItemPolicy> GetReportPolicies (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetReportPolicies");
            
    
            var path = "/Reports({Id})/Policies";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportPolicies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportPolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ItemPolicy>) ApiClient.Deserialize(response.Content, typeof(List<ItemPolicy>), response.Headers);
        }
    
        /// <summary>
        /// Gets the specified Reports Properties (takes list of Property names to retrieve the values) 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="properties">Names for the Properties to be returned.</param> 
        /// <returns>ODataProperties</returns>            
        public ODataProperties GetReportProperties (string id, List<string> properties)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetReportProperties");
            
    
            var path = "/Reports({Id})/Properties";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportProperties: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportProperties: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataProperties) ApiClient.Deserialize(response.Content, typeof(ODataProperties), response.Headers);
        }
    
        /// <summary>
        /// Gets the shared DataSets for the specified Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>List&lt;DataSet&gt;</returns>            
        public List<DataSet> GetReportSharedDataSets (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetReportSharedDataSets");
            
    
            var path = "/Reports({Id})/SharedDataSets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportSharedDataSets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportSharedDataSets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DataSet>) ApiClient.Deserialize(response.Content, typeof(List<DataSet>), response.Headers);
        }
    
        /// <summary>
        /// Gets the Subscriptions for the specified Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="top">Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630)</param> 
        /// <param name="skip">Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631)</param> 
        /// <param name="filter">Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625)</param> 
        /// <param name="count">Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632)</param> 
        /// <param name="orderBy">Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629)</param> 
        /// <param name="expand">Expand related entities, see [OData Expand](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374621)</param> 
        /// <param name="select">Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620)</param> 
        /// <returns>List&lt;Subscription&gt;</returns>            
        public List<Subscription> GetReportSubscriptions (string id, int? top, int? skip, string filter, string count, string orderBy, string expand, string select)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetReportSubscriptions");
            
    
            var path = "/Reports({Id})/Subscriptions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
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
 if (expand != null) queryParams.Add("$expand", ApiClient.ParameterToString(expand)); // query parameter
 if (select != null) queryParams.Add("$select", ApiClient.ParameterToString(select)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportSubscriptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetReportSubscriptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Subscription>) ApiClient.Deserialize(response.Content, typeof(List<Subscription>), response.Headers);
        }
    
        /// <summary>
        /// Gets an array of Report CatalogItems. 
        /// </summary>
        /// <param name="top">Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630)</param> 
        /// <param name="skip">Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631)</param> 
        /// <param name="filter">Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625)</param> 
        /// <param name="count">Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632)</param> 
        /// <param name="orderBy">Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629)</param> 
        /// <param name="select">Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620)</param> 
        /// <returns>ODataReports</returns>            
        public ODataReports GetReports (int? top, int? skip, string filter, string count, string orderBy, string select)
        {
            
    
            var path = "/Reports";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetReports: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetReports: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataReports) ApiClient.Deserialize(response.Content, typeof(ODataReports), response.Headers);
        }


        public string GetReportsString(int? top, int? skip, string filter, string count, string orderBy, string select, string username, string password, string url)
        {


            var path = "/Reports";
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
                throw new ApiException((int)response.StatusCode, "Error calling GetReports: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetReports: " + response.ErrorMessage, response.ErrorMessage);

            return response.Content;
        }

        /// <summary>
        /// Replaces the CacheOptions content for a given Report using the provided definition. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="cacheOptions">Updated definition for the CacheOptions content associated with the given Report.</param> 
        /// <returns></returns>            
        public void SetReportCacheOptions (string id, CacheOptions cacheOptions)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SetReportCacheOptions");
            
            // verify the required parameter 'cacheOptions' is set
            if (cacheOptions == null) throw new ApiException(400, "Missing required parameter 'cacheOptions' when calling SetReportCacheOptions");
            
    
            var path = "/Reports({Id})/CacheOptions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(cacheOptions); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetReportCacheOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetReportCacheOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the DataSource definition associated with the Report specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="dataSource">Updated definition for the DataSource associated with the Report specified by the Id.</param> 
        /// <returns></returns>            
        public void SetReportDataSource (string id, DataSource dataSource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SetReportDataSource");
            
            // verify the required parameter 'dataSource' is set
            if (dataSource == null) throw new ApiException(400, "Missing required parameter 'dataSource' when calling SetReportDataSource");
            
    
            var path = "/Reports({Id})/DataSources";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(dataSource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetReportDataSource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetReportDataSource: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates HistorySnapshotOptions for the specified Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="historySnapshotOptions">Modified HistorySnapshotOptions object.</param> 
        /// <returns></returns>            
        public void SetReportHistorySnapshotOptions (string id, HistorySnapshotOptions historySnapshotOptions)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SetReportHistorySnapshotOptions");
            
            // verify the required parameter 'historySnapshotOptions' is set
            if (historySnapshotOptions == null) throw new ApiException(400, "Missing required parameter 'historySnapshotOptions' when calling SetReportHistorySnapshotOptions");
            
    
            var path = "/Reports({Id})/HistorySnapshotOptions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(historySnapshotOptions); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetReportHistorySnapshotOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetReportHistorySnapshotOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Replaces ItemPolicies associated with the Report specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="itemPolicies">The ItemPolicy definitions that will be replaced.</param> 
        /// <returns></returns>            
        public void SetReportPolicies (string id, List<ItemPolicy> itemPolicies)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SetReportPolicies");
            
            // verify the required parameter 'itemPolicies' is set
            if (itemPolicies == null) throw new ApiException(400, "Missing required parameter 'itemPolicies' when calling SetReportPolicies");
            
    
            var path = "/Reports({Id})/Policies";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SetReportPolicies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetReportPolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the DataSet definitions associated with the specified Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="dataSets">Updated DataSet definitions for the specified Report.</param> 
        /// <returns></returns>            
        public void SetReportSharedDataSets (string id, List<DataSet> dataSets)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SetReportSharedDataSets");
            
            // verify the required parameter 'dataSets' is set
            if (dataSets == null) throw new ApiException(400, "Missing required parameter 'dataSets' when calling SetReportSharedDataSets");
            
    
            var path = "/Reports({Id})/SharedDataSets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(dataSets); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetReportSharedDataSets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetReportSharedDataSets: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the execution cache snapshot for the specified report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>UpdateCacheSnapshotResult</returns>            
        public UpdateCacheSnapshotResult UpdateCacheSnapshot (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateCacheSnapshot");
            
    
            var path = "/Reports({Id})/Model.UpdateCacheSnapshot";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCacheSnapshot: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCacheSnapshot: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UpdateCacheSnapshotResult) ApiClient.Deserialize(response.Content, typeof(UpdateCacheSnapshotResult), response.Headers);
        }
    
        /// <summary>
        /// Updates the specified Report CatalogItem using the provided definition. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="report">Definition of the Report item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.</param> 
        /// <returns></returns>            
        public void UpdateReport (string id, Report report)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateReport");
            
            // verify the required parameter 'report' is set
            if (report == null) throw new ApiException(400, "Missing required parameter 'report' when calling UpdateReport");
            
    
            var path = "/Reports({Id})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(report); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the Comment specified by CommentId in the associated Report. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="commentId">The Id of the Comment.</param> 
        /// <param name="comment">The Comment to be updated</param> 
        /// <returns></returns>            
        public void UpdateReportComment (string id, string commentId, Comment comment)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateReportComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling UpdateReportComment");
            
            // verify the required parameter 'comment' is set
            if (comment == null) throw new ApiException(400, "Missing required parameter 'comment' when calling UpdateReportComment");
            
    
            var path = "/Reports({Id})/Comments({CommentId})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateReportComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateReportComment: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates report to use the specificed shared datasets. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="dataSets">Shared datasets to be used by specified report</param> 
        /// <returns></returns>            
        public void UpdateReportDataSets (string id, SharedDataSets dataSets)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateReportDataSets");
            
            // verify the required parameter 'dataSets' is set
            if (dataSets == null) throw new ApiException(400, "Missing required parameter 'dataSets' when calling UpdateReportDataSets");
            
    
            var path = "/Reports({Id})/Model.UpdateReportDataSets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(dataSets); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateReportDataSets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateReportDataSets: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the ParameterDefinitions associated with the Report specified by Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="parameterDefinitions">Updated definitions for the ParameterDefinitions associated with the Report, represented as ParameterDefinitionsPatch object. It is only necessary to include properties to be updated. All other property values will be left unchanged.</param> 
        /// <returns></returns>            
        public void UpdateReportParameterDefinitions (string id, List<ReportParameterDefinitionPatch> parameterDefinitions)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateReportParameterDefinitions");
            
            // verify the required parameter 'parameterDefinitions' is set
            if (parameterDefinitions == null) throw new ApiException(400, "Missing required parameter 'parameterDefinitions' when calling UpdateReportParameterDefinitions");
            
    
            var path = "/Reports({Id})/ParameterDefinitions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(parameterDefinitions); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateReportParameterDefinitions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateReportParameterDefinitions: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the Report Properties included in the given list. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="properties">The Properties that will be updated.</param> 
        /// <returns></returns>            
        public void UpdateReportProperties (string id, List<Property> properties)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateReportProperties");
            
            // verify the required parameter 'properties' is set
            if (properties == null) throw new ApiException(400, "Missing required parameter 'properties' when calling UpdateReportProperties");
            
    
            var path = "/Reports({Id})/Properties";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateReportProperties: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateReportProperties: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Does an efficient binary upload of a new or existing Report CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="file">The file contents.</param> 
        /// <returns>Report</returns>            
        public Report UploadReport (string id, System.IO.Stream file)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UploadReport");
            
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling UploadReport");
            
    
            var path = "/Reports({Id})/Model.Upload";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UploadReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UploadReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Report) ApiClient.Deserialize(response.Content, typeof(Report), response.Headers);
        }
    
    }
}

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
    public interface IKpisApi
    {
        /// <summary>
        /// Creates a new Kpi CatalogItem. 
        /// </summary>
        /// <param name="kpi">The definition of the new KPI CatalogItem.</param>
        /// <returns>Kpi</returns>
        Kpi AddKpi (Kpi kpi);
        /// <summary>
        /// Deletes the specified Kpi. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns></returns>
        void DeleteKpi (string id);
        /// <summary>
        /// Gets a Kpi CatalogItem specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>Kpi</returns>
        Kpi GetKpi (string id);
        /// <summary>
        /// Gets a list of actions allowed in the current session, user permissions and product edition capabilities are considered when querying. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>ODataAllowedActions</returns>
        ODataAllowedActions GetKpiAllowedActions (string id);
        /// <summary>
        /// Gets ItemPolicies associated with the Kpi CatalogItem specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>List&lt;ItemPolicy&gt;</returns>
        List<ItemPolicy> GetKpiPolicies (string id);
        /// <summary>
        /// Gets Kpi Properties (takes list of Property names to retrieve the values) 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="properties">Names for the Properties to be returned.</param>
        /// <returns>ODataProperties</returns>
        ODataProperties GetKpiProperties (string id, List<string> properties);
        /// <summary>
        /// Gets an array of Kpi CatalogItems. 
        /// </summary>
        /// <param name="top">Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630)</param>
        /// <param name="skip">Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631)</param>
        /// <param name="filter">Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625)</param>
        /// <param name="count">Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632)</param>
        /// <param name="orderBy">Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629)</param>
        /// <param name="select">Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620)</param>
        /// <returns>ODataKpis</returns>
        ODataKpis GetKpis (int? top, int? skip, string filter, string count, string orderBy, string select);
        /// <summary>
        /// Replaces ItemPolicies associated with the Kpi specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="itemPolicies">The ItemPolicy definitions that will be replaced.</param>
        /// <returns></returns>
        void SetKpiPolicies (string id, List<ItemPolicy> itemPolicies);
        /// <summary>
        /// Updates the specified Kpi CatalogItem using the provided definition. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="kpi">Definition of the KPI item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values will be left unchanged.</param>
        /// <returns></returns>
        void UpdateKpi (string id, Kpi kpi);
        /// <summary>
        /// Updates the Kpi Properties included in the given list. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="properties">The Properties that will be updated.</param>
        /// <returns></returns>
        void UpdateKpiProperties (string id, List<Property> properties);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class KpisApi : IKpisApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KpisApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public KpisApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="KpisApi"/> class.
        /// </summary>
        /// <returns></returns>
        public KpisApi(String basePath)
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
        /// Creates a new Kpi CatalogItem. 
        /// </summary>
        /// <param name="kpi">The definition of the new KPI CatalogItem.</param> 
        /// <returns>Kpi</returns>            
        public Kpi AddKpi (Kpi kpi)
        {
            
            // verify the required parameter 'kpi' is set
            if (kpi == null) throw new ApiException(400, "Missing required parameter 'kpi' when calling AddKpi");
            
    
            var path = "/Kpis";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(kpi); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddKpi: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddKpi: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Kpi) ApiClient.Deserialize(response.Content, typeof(Kpi), response.Headers);
        }
    
        /// <summary>
        /// Deletes the specified Kpi. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns></returns>            
        public void DeleteKpi (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteKpi");
            
    
            var path = "/Kpis({Id})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteKpi: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteKpi: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets a Kpi CatalogItem specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>Kpi</returns>            
        public Kpi GetKpi (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetKpi");
            
    
            var path = "/Kpis({Id})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetKpi: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKpi: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Kpi) ApiClient.Deserialize(response.Content, typeof(Kpi), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of actions allowed in the current session, user permissions and product edition capabilities are considered when querying. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>ODataAllowedActions</returns>            
        public ODataAllowedActions GetKpiAllowedActions (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetKpiAllowedActions");
            
    
            var path = "/Kpis({Id})/AllowedActions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetKpiAllowedActions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKpiAllowedActions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataAllowedActions) ApiClient.Deserialize(response.Content, typeof(ODataAllowedActions), response.Headers);
        }
    
        /// <summary>
        /// Gets ItemPolicies associated with the Kpi CatalogItem specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>List&lt;ItemPolicy&gt;</returns>            
        public List<ItemPolicy> GetKpiPolicies (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetKpiPolicies");
            
    
            var path = "/Kpis({Id})/Policies";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetKpiPolicies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKpiPolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ItemPolicy>) ApiClient.Deserialize(response.Content, typeof(List<ItemPolicy>), response.Headers);
        }
    
        /// <summary>
        /// Gets Kpi Properties (takes list of Property names to retrieve the values) 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="properties">Names for the Properties to be returned.</param> 
        /// <returns>ODataProperties</returns>            
        public ODataProperties GetKpiProperties (string id, List<string> properties)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetKpiProperties");
            
    
            var path = "/Kpis({Id})/Properties";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (properties != null) queryParams.Add("Properties", ApiClient.ParameterToString(properties)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKpiProperties: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKpiProperties: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataProperties) ApiClient.Deserialize(response.Content, typeof(ODataProperties), response.Headers);
        }
    
        /// <summary>
        /// Gets an array of Kpi CatalogItems. 
        /// </summary>
        /// <param name="top">Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630)</param> 
        /// <param name="skip">Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631)</param> 
        /// <param name="filter">Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625)</param> 
        /// <param name="count">Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632)</param> 
        /// <param name="orderBy">Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629)</param> 
        /// <param name="select">Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620)</param> 
        /// <returns>ODataKpis</returns>            
        public ODataKpis GetKpis (int? top, int? skip, string filter, string count, string orderBy, string select)
        {
            
    
            var path = "/Kpis";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetKpis: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetKpis: " + response.ErrorMessage, response.ErrorMessage);
            
             
            return (ODataKpis) ApiClient.Deserialize(response.Content, typeof(ODataKpis), response.Headers);
        }


        public string GetKpisString(int? top, int? skip, string filter, string count, string orderBy, string select, string username, string password, string url)
        {


            var path = "/Kpis";
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
            IRestResponse response = (IRestResponse)ApiClient.CallApiNew(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings, username, password,url);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetKpis: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetKpis: " + response.ErrorMessage, response.ErrorMessage);

            return response.Content;
           // return (ODataKpis) ApiClient.Deserialize(response.Content, typeof(ODataKpis), response.Headers);
        }
        /// <summary>
        /// Replaces ItemPolicies associated with the Kpi specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="itemPolicies">The ItemPolicy definitions that will be replaced.</param> 
        /// <returns></returns>            
        public void SetKpiPolicies (string id, List<ItemPolicy> itemPolicies)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SetKpiPolicies");
            
            // verify the required parameter 'itemPolicies' is set
            if (itemPolicies == null) throw new ApiException(400, "Missing required parameter 'itemPolicies' when calling SetKpiPolicies");
            
    
            var path = "/Kpis({Id})/Policies";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SetKpiPolicies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetKpiPolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the specified Kpi CatalogItem using the provided definition. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="kpi">Definition of the KPI item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values will be left unchanged.</param> 
        /// <returns></returns>            
        public void UpdateKpi (string id, Kpi kpi)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateKpi");
            
            // verify the required parameter 'kpi' is set
            if (kpi == null) throw new ApiException(400, "Missing required parameter 'kpi' when calling UpdateKpi");
            
    
            var path = "/Kpis({Id})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(kpi); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateKpi: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateKpi: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the Kpi Properties included in the given list. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="properties">The Properties that will be updated.</param> 
        /// <returns></returns>            
        public void UpdateKpiProperties (string id, List<Property> properties)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateKpiProperties");
            
            // verify the required parameter 'properties' is set
            if (properties == null) throw new ApiException(400, "Missing required parameter 'properties' when calling UpdateKpiProperties");
            
    
            var path = "/Kpis({Id})/Properties";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateKpiProperties: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateKpiProperties: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}

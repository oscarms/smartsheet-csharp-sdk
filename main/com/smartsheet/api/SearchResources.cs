﻿namespace com.smartsheet.api
{

	/*
	 * #[license]
	 * Smartsheet SDK for C#
	 * %%
	 * Copyright (C) 2014 Smartsheet
	 * %%
	 * Licensed under the Apache License, Version 2.0 (the "License");
	 * you may not use this file except in compliance with the License.
	 * You may obtain a copy of the License at
	 * 
	 *      http://www.apache.org/licenses/LICENSE-2.0
	 * 
	 * Unless required by applicable law or agreed to in writing, software
	 * distributed under the License is distributed on an "AS IS" BASIS,
	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
	 * See the License for the specific language governing permissions and
	 * limitations under the License.
	 * %[license]
	 */



	using SearchResult = com.smartsheet.api.models.SearchResult;

	/// <summary>
	/// This interface provides methods to access search resources.
	/// 
	/// Thread Safety: Implementation of this interface must be thread safe.
	/// </summary>
	public interface SearchResources
	{

		/// <summary>
		/// <para>Performs a search across all Sheets to which user has access.</para>
		/// 
		/// <para>It mirrors to the following Smartsheet REST API method: GET /search</para>
		/// </summary>
		/// <param name="query"> the query text </param>
		/// <returns> the search result (note that if there is no such resource, this method will throw 
		/// ResourceNotFoundException rather than returning null). </returns>
		/// <exception cref="InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		SearchResult Search(string query);

		/// <summary>
		/// <para>Performs a search within a sheet.</para>
		/// 
		/// <para>It mirrors to the following Smartsheet REST API method: GET /search/sheet/{sheetId}</para>
		/// </summary>
		/// <param name="sheetId"> the sheet id </param>
		/// <param name="query"> the query text </param>
		/// <returns> the search result (note that if there is no such resource, this method will throw 
		/// ResourceNotFoundException rather than returning null). </returns>
		/// <exception cref="InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		SearchResult SearchSheet(long sheetId, string query);
	}

}
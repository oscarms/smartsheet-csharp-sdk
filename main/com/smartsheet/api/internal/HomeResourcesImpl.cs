﻿namespace com.smartsheet.api.@internal
{

    using System.Collections.Generic;
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



    using Home = com.smartsheet.api.models.Home;
    using ObjectInclusion = com.smartsheet.api.models.ObjectInclusion;

	/// <summary>
	/// This is the implementation of the HomeResources.
	/// 
	/// Thread Safety: This class is thread safe because it is immutable and its base class is thread safe.
	/// </summary>
	public class HomeResourcesImpl : AbstractResources, HomeResources
	{
		/// <summary>
		/// Represents the HomeFolderResources.
		/// 
		/// It will be initialized in constructor and will not change afterwards.
		/// </summary>
		private HomeFolderResources folders;

		/// <summary>
		/// Constructor.
		/// 
		/// Exceptions: - IllegalArgumentException : if any argument is null
		/// </summary>
		/// <param name="smartsheet"> the smartsheet </param>
		public HomeResourcesImpl(SmartsheetImpl smartsheet) : base(smartsheet)
		{
			this.folders = new HomeFolderResourcesImpl(smartsheet);
		}

		/// <summary>
		/// Get a nested list of all Home objects, including sheets, workspaces and folders, and optionally reports and/or
		/// templates, as shown on the Home tab..
		/// 
		/// It mirrors to the following Smartsheet REST API method: GET /home
		/// 
		/// Exceptions:
		///   InvalidRequestException : if there is any problem with the REST API request
		///   AuthorizationException : if there is any problem with the REST API authorization(access token)
		///   ResourceNotFoundException : if the resource can not be found
		///   ServiceUnavailableException : if the REST API service is not available (possibly due to rate limiting)
		///   SmartsheetRestException : if there is any other REST API related error occurred during the operation
		///   SmartsheetException : if there is any other error occurred during the operation
		/// </summary>
		/// <param name="includes"> used to specify the optional objects to include, currently TEMPLATES is supported. </param>
		/// <returns> the resource (note that if there is no such resource, this method will throw ResourceNotFoundException
		/// rather than returning null). </returns>
		/// <exception cref="SmartsheetException"> the smartsheet exception </exception>
		public virtual Home GetHome(IEnumerable<ObjectInclusion> includes)
		{
			string path = "home";

			if (includes != null)
			{
				path += "?include=";
				foreach (ObjectInclusion oi in includes)
				{
					path += oi.ToString().ToLower() + ",";
				}
                path.TrimEnd(',');
			}

			return this.GetResource<Home>(path, typeof(Home));
		}

		/// <summary>
		/// Return the WorkspaceFolderResources object that provides access to Folder resources under home.
		/// </summary>
		/// <returns> the home folder resources </returns>
		public virtual HomeFolderResources Folders()
		{
			return this.folders;
		}
	}

}
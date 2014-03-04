﻿using System.Collections.Generic;

namespace com.smartsheet.api
{

    using System.IO;
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




    using ObjectInclusion = com.smartsheet.api.models.ObjectInclusion;
    using PaperSize = com.smartsheet.api.models.PaperSize;
    using Sheet = com.smartsheet.api.models.Sheet;
    using SheetEmail = com.smartsheet.api.models.SheetEmail;
    using SheetPublish = com.smartsheet.api.models.SheetPublish;

	/// <summary>
	/// <para>This interface provides methods to access Sheet resources.</para>
	/// 
	/// <para>Thread Safety: Implementation of this interface must be thread safe.</para>
	/// </summary>
	public interface SheetResources
	{

		/// <summary>
		/// <para>List all sheets.</para>
		/// 
		/// <para>It mirrors to the following Smartsheet REST API method: GET /sheets</para>
		/// </summary>
		/// <returns> A list of all sheets (note that an empty list will be returned if there are none). </returns>
		/// <exception cref="InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		IList<Sheet> ListSheets();

		/// <summary>
		/// <para>List all sheets in the organization.</para>
		/// 
		/// <para>It mirrors to the following Smartsheet REST API method: GET /users/sheets</para>
		/// </summary>
		/// <returns> the list of all sheets (note that an empty list will be returned if there are none) </returns>
		/// <exception cref="InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		IList<Sheet> ListOrganizationSheets();

		/// <summary>
		/// <para>Get a sheet.</para>
		/// 
		/// <para>It mirrors to the following Smartsheet REST API method: GET /sheet/{id}</para>
		/// </summary>
		/// <param name="id"> the id of the sheet </param>
		/// <param name="includes"> used to specify the optional objects to include. </param>
		/// <returns> the sheet resource (note that if there is no such resource, this method will throw 
		/// ResourceNotFoundException rather than returning null). </returns>
		/// <exception cref="InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		Sheet GetSheet(long id, IEnumerable<ObjectInclusion> includes);

		/// <summary>
		/// <para>Get a sheet as an Excel file.</para>
		/// 
		/// <para>It mirrors to the following Smartsheet REST API method:<br />
		/// GET /sheet/{id} with "application/vnd.ms-excel" Accept HTTP header</para>
		/// </summary>
		/// <param name="id"> the id of the sheet </param>
		/// <param name="outputStream"> the output stream to which the Excel file will be written. </param>
		/// <exception cref="InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		void GetSheetAsExcel(long id, StreamWriter outputStream);

		/// <summary>
		/// <para>Get a sheet as a PDF file.</para>
		/// 
		/// <para>It mirrors to the following Smartsheet REST API method:<br />
		/// GET /sheet/{id} with "application/pdf" Accept HTTP header</para>
		/// </summary>
		/// <param name="id"> the id of the sheet </param>
		/// <param name="outputStream"> the output stream to which the PDF file will be written. </param>
		/// <param name="paperSize"> the paper size </param>
		/// <exception cref="InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		void GetSheetAsPDF(long id, StreamWriter outputStream, PaperSize? paperSize);

		/// <summary>
		/// <para>Create a sheet in default "Sheets" collection.</para>
		/// 
		/// <para>It mirrors to the following Smartsheet REST API method:<br />
		///  POST /sheets</para>
		/// </summary>
		/// <param name="sheet"> the sheet to created </param>
		/// <returns> the created sheet </returns>
		/// <exception cref="InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		Sheet CreateSheet(Sheet sheet);

		/// <summary>
		/// <para>Create a sheet (from existing sheet or template) in default "Sheets" collection.</para>
		/// 
		/// <para>It mirrors to the following Smartsheet REST API method: POST /sheets</para>
		/// </summary>
		/// <param name="sheet"> the sheet to create </param>
		/// <param name="includes"> used to specify the optional objects to include. </param>
		/// <returns> the created sheet </returns>
		/// <exception cref="InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		Sheet CreateSheetFromExisting(Sheet sheet, IEnumerable<ObjectInclusion> includes);

		/// <summary>
		/// <para>Create a sheet in given folder.</para>
		/// 
		/// <para>It mirrors to the following Smartsheet REST API method: POST /folder/{folderId}/sheets</para>
		/// </summary>
		/// <param name="folderId"> the folder id </param>
		/// <param name="sheet"> the sheet to create </param>
		/// <returns> the created sheet </returns>
		/// <exception cref="InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		Sheet CreateSheetInFolder(long folderId, Sheet sheet);

		/// <summary>
		/// <para>Create a sheet (from existing sheet or template) in given folder.</para>
		/// 
		/// <para>It mirrors to the following Smartsheet REST API method: POST /folder/{folderId}/sheets</para>
		/// </summary>
		/// <param name="folderID"> the folder id </param>
		/// <param name="sheet"> the sheet to create </param>
		/// <param name="used"> to specify the optional objects to include. </param>
		/// <returns> the created sheet </returns>
		/// <exception cref="InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		Sheet CreateSheetInFolderFromExisting(long folderID, Sheet sheet, IEnumerable<ObjectInclusion> includes);

		/// <summary>
		/// <para>Create a sheet in given workspace.</para>
		/// 
		/// <para>It mirrors to the following Smartsheet REST API method: POST /workspace/{workspaceId}/sheets</para>
		/// </summary>
		/// <param name="workspaceId"> the workspace id </param>
		/// <param name="sheet"> the sheet to create </param>
		/// <returns> the created sheet </returns>
		/// <exception cref="InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		Sheet CreateSheetInWorkspace(long workspaceId, Sheet sheet);

		/// <summary>
		/// <para>Create a sheet (from existing sheet or template) in given workspace.</para>
		/// 
		/// <para>It mirrors to the following Smartsheet REST API method: POST /workspace/{workspaceId}/sheets</para>
		/// </summary>
		/// <param name="workspaceId"> the workspace id </param>
		/// <param name="sheet"> the sheet to create </param>
		/// <param name="includes"> used to specify the optional objects to include </param>
		/// <returns> the created sheet </returns>
		/// <exception cref="InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		Sheet CreateSheetInWorkspaceFromExisting(long workspaceId, Sheet sheet, IEnumerable<ObjectInclusion> includes);

		/// <summary>
		/// <para>Delete a sheet.</para>
		/// 
		/// <para>It mirrors to the following Smartsheet REST API method: DELETE /sheet{id}</para>
		/// 
		/// Parameters: - id : the ID of the sheet
		/// 
		/// Returns: None
		/// 
		/// </summary>
		/// <param name="id"> the id </param>
		/// <exception cref="InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		void DeleteSheet(long id);

		/// <summary>
		/// <para>Update a sheet.</para>
		/// 
		/// <para>It mirrors to the following Smartsheet REST API method: PUT /sheet/{id}</para>
		/// </summary>
		/// <param name="sheet"> the sheet to update </param>
		/// <returns> the updated sheet </returns>
		/// <exception cref="InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		Sheet UpdateSheet(Sheet sheet);

		/// <summary>
		/// <para>Get a sheet version.</para>
		/// 
		/// <para>It mirrors to the following Smartsheet REST API method: GET /sheet/{id}/version</para>
		/// </summary>
		/// <param name="id"> the id </param>
		/// <returns> the sheet version (note that if there is no such resource, this method will throw
		/// ResourceNotFoundException) </returns>
		/// <exception cref="InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		int? GetSheetVersion(long id);

		/// <summary>
		/// <para>Send a sheet as a PDF attachment via email to the designated recipients.</para>
		/// 
		/// <para>It mirrors to the following Smartsheet REST API method: POST /sheet/{sheetId}/emails</para>
		/// </summary>
		/// <param name="id"> the id </param>
		/// <param name="email"> the email </param>
		/// <exception cref="InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		void SendSheet(long id, SheetEmail email);

		/// <summary>
		/// <para>Return the ShareResources object that provides access to Share resources associated with Sheet resources.</para>
		/// </summary>
		/// <returns> the share resources object </returns>
		ShareResources Shares();

		/// <summary>
		/// <para>Return the SheetRowResources object that provides access to Row resources associated with Sheet resources.</para>
		/// </summary>
		/// <returns> the sheet row resources </returns>
		SheetRowResources Rows();

		/// <summary>
		/// <para>Return the SheetColumnResources object that provides access to Column resources associated with Sheet resources.</para>
		/// </summary>
		/// <returns> the sheet column resources </returns>
		SheetColumnResources Columns();

		/// <summary>
		/// <para>Return the AssociatedAttachmentResources object that provides access to attachment resources associated with
		/// Sheet resources.</para>
		/// </summary>
		/// <returns> the associated attachment resources </returns>
		AssociatedAttachmentResources Attachments();

		/// <summary>
		/// <para>Return the AssociatedDiscussionResources object that provides access to discussion resources associated with
		/// Sheet resources.</para>
		/// </summary>
		/// <returns> the associated discussion resources </returns>
		AssociatedDiscussionResources Discussions();

		/// <summary>
		/// <para>Get the status of the Publish settings of the sheet, including the URLs of any enabled publishings.</para>
		/// 
		/// <para>It mirrors to the following Smartsheet REST API method: GET /sheet/{sheetId}/publish</para>
		/// </summary>
		/// <param name="id"> the id </param>
		/// <returns> the publish status (note that if there is no such resource, this method will throw ResourceNotFoundException rather than returning null) </returns>
		/// <exception cref="InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		SheetPublish GetPublishStatus(long id);

		/// <summary>
		/// <para>Sets the publish status of a sheet and returns the new status, including the URLs of any enabled publishings.</para>
		/// 
		/// <para>It mirrors to the following Smartsheet REST API method: PUT /sheet/{sheetId}/publish</para>
		/// </summary>
		/// <param name="id"> the id </param>
		/// <param name="publish"> the SheetPublish object limited. </param>
		/// <returns> the update SheetPublish object (note that if there is no such resource, this method will throw a 
		/// ResourceNotFoundException rather than returning null). </returns>
		/// <exception cref="InvalidOperationException"> if any argument is null or empty string </exception>
		/// <exception cref="InvalidRequestException"> if there is any problem with the REST API request </exception>
		/// <exception cref="AuthorizationException"> if there is any problem with  the REST API authorization (access token) </exception>
		/// <exception cref="ResourceNotFoundException"> if the resource cannot be found </exception>
		/// <exception cref="ServiceUnavailableException"> if the REST API service is not available (possibly due to rate limiting) </exception>
		/// <exception cref="SmartsheetException"> if there is any other error during the operation </exception>
		SheetPublish UpdatePublishStatus(long id, SheetPublish publish);
	}

}
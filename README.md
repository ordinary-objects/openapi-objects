# Ordinary.Core.PenpotApi - the C# library for the Ordinary Objects Penpot API

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 0.0
- SDK version: 1.0.0
- Generator version: 7.8.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a id="version-support"></a>
## Version support
This generator should support all current LTS versions of Unity
- Unity 2020.3 (LTS) and up
- .NET Standard 2.1 / .NET Framework

<a id="dependencies"></a>
## Dependencies

- [Newtonsoft.Json](https://docs.unity3d.com/Packages/com.unity.nuget.newtonsoft-json@3.0/manual/index.html) - 3.0.2 or later
- [Unity Test Framework](https://docs.unity3d.com/Packages/com.unity.test-framework@1.1/manual/index.html) - 1.1.33 or later

<a id="installation"></a>
## Installation
Add the dependencies to `Packages/manifest.json`
```
{
  "dependencies": {
    ...
    "com.unity.nuget.newtonsoft-json": "3.0.2",
    "com.unity.test-framework": "1.1.33",
  }
}
```

Then use the namespaces:
```csharp
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Collections.Generic;
using UnityEngine;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Ordinary.Core.PenpotApiExample
{

    public class CommandAnalyticsEventPostExample : MonoBehaviour
    {
        async void Start()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.ApiKey.Add("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var analyticsEvent = new AnalyticsEvent(); // AnalyticsEvent | 

            try
            {
                AnalyticsResponse result = await apiInstance.CommandAnalyticsEventPostAsync(analyticsEvent);
                Debug.Log(result);
                Debug.Log("Done!");
            }
            catch (ApiException e)
            {
                Debug.LogError("Exception when calling DefaultApi.CommandAnalyticsEventPost: " + e.Message );
                Debug.LogError("Status Code: "+ e.ErrorCode);
                Debug.LogError(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost:3449/api/rpc*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**CommandAnalyticsEventPost**](DefaultApi.md#commandanalyticseventpost) | **POST** /command/analytics-event | 
*DefaultApi* | [**CommandCloneTemplatePost**](DefaultApi.md#commandclonetemplatepost) | **POST** /command/clone-template | 
*DefaultApi* | [**CommandCreateFilePost**](DefaultApi.md#commandcreatefilepost) | **POST** /command/create-file | 
*DefaultApi* | [**CommandCreateFileThumbnailPost**](DefaultApi.md#commandcreatefilethumbnailpost) | **POST** /command/create-file-thumbnail | 
*DefaultApi* | [**CommandCreateProjectPost**](DefaultApi.md#commandcreateprojectpost) | **POST** /command/create-project | 
*DefaultApi* | [**CommandCreateTeamInvitationsPost**](DefaultApi.md#commandcreateteaminvitationspost) | **POST** /command/create-team-invitations | 
*DefaultApi* | [**CommandCreateTeamPost**](DefaultApi.md#commandcreateteampost) | **POST** /command/create-team | 
*DefaultApi* | [**CommandCreateTeamWithInvitationsPost**](DefaultApi.md#commandcreateteamwithinvitationspost) | **POST** /command/create-team-with-invitations | 
*DefaultApi* | [**CommandDeleteFilePost**](DefaultApi.md#commanddeletefilepost) | **POST** /command/delete-file | 
*DefaultApi* | [**CommandDeleteProjectPost**](DefaultApi.md#commanddeleteprojectpost) | **POST** /command/delete-project | 
*DefaultApi* | [**CommandDeleteTeamMemberPost**](DefaultApi.md#commanddeleteteammemberpost) | **POST** /command/delete-team-member | 
*DefaultApi* | [**CommandDuplicateFilePost**](DefaultApi.md#commandduplicatefilepost) | **POST** /command/duplicate-file | 
*DefaultApi* | [**CommandExportBinfilePost**](DefaultApi.md#commandexportbinfilepost) | **POST** /command/export-binfile | 
*DefaultApi* | [**CommandGetBuiltinTemplatesPost**](DefaultApi.md#commandgetbuiltintemplatespost) | **POST** /command/get-builtin-templates | 
*DefaultApi* | [**CommandGetFilePost**](DefaultApi.md#commandgetfilepost) | **POST** /command/get-file | 
*DefaultApi* | [**CommandGetProfilePost**](DefaultApi.md#commandgetprofilepost) | **POST** /command/get-profile | 
*DefaultApi* | [**CommandGetProjectFilesPost**](DefaultApi.md#commandgetprojectfilespost) | **POST** /command/get-project-files | 
*DefaultApi* | [**CommandGetProjectsPost**](DefaultApi.md#commandgetprojectspost) | **POST** /command/get-projects | 
*DefaultApi* | [**CommandGetTeamInvitationsPost**](DefaultApi.md#commandgetteaminvitationspost) | **POST** /command/get-team-invitations | 
*DefaultApi* | [**CommandGetTeamMembersPost**](DefaultApi.md#commandgetteammemberspost) | **POST** /command/get-team-members | 
*DefaultApi* | [**CommandGetTeamsPost**](DefaultApi.md#commandgetteamspost) | **POST** /command/get-teams | 
*DefaultApi* | [**CommandImportBinfilePost**](DefaultApi.md#commandimportbinfilepost) | **POST** /command/import-binfile | 
*DefaultApi* | [**CommandLoginWithPasswordPost**](DefaultApi.md#commandloginwithpasswordpost) | **POST** /command/login-with-password | 
*DefaultApi* | [**CommandLogoutPost**](DefaultApi.md#commandlogoutpost) | **POST** /command/logout | 
*DefaultApi* | [**CommandMoveFilesPost**](DefaultApi.md#commandmovefilespost) | **POST** /command/move-files | 
*DefaultApi* | [**CommandPrepareRegisterProfilePost**](DefaultApi.md#commandprepareregisterprofilepost) | **POST** /command/prepare-register-profile | 
*DefaultApi* | [**CommandPushAuditEventsPost**](DefaultApi.md#commandpushauditeventspost) | **POST** /command/push-audit-events | 
*DefaultApi* | [**CommandRecoverProfilePost**](DefaultApi.md#commandrecoverprofilepost) | **POST** /command/recover-profile | 
*DefaultApi* | [**CommandRegisterProfilePost**](DefaultApi.md#commandregisterprofilepost) | **POST** /command/register-profile | 
*DefaultApi* | [**CommandRenameFilePost**](DefaultApi.md#commandrenamefilepost) | **POST** /command/rename-file | 
*DefaultApi* | [**CommandRenameProjectPost**](DefaultApi.md#commandrenameprojectpost) | **POST** /command/rename-project | 
*DefaultApi* | [**CommandRequestProfileRecoveryPost**](DefaultApi.md#commandrequestprofilerecoverypost) | **POST** /command/request-profile-recovery | 
*DefaultApi* | [**CommandUpdateFilePost**](DefaultApi.md#commandupdatefilepost) | **POST** /command/update-file | 
*DefaultApi* | [**CommandUpdateProfilePasswordPost**](DefaultApi.md#commandupdateprofilepasswordpost) | **POST** /command/update-profile-password | 
*DefaultApi* | [**CommandUpdateProfilePost**](DefaultApi.md#commandupdateprofilepost) | **POST** /command/update-profile | 
*DefaultApi* | [**CommandUpdateTeamPost**](DefaultApi.md#commandupdateteampost) | **POST** /command/update-team | 
*DefaultApi* | [**CommandUploadFileMediaObjectPost**](DefaultApi.md#commanduploadfilemediaobjectpost) | **POST** /command/upload-file-media-object | 
*DefaultApi* | [**CommandVerifyTokenPost**](DefaultApi.md#commandverifytokenpost) | **POST** /command/verify-token | 


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddColorChange](AddColorChange.md)
 - [Model.AddComponentChange](AddComponentChange.md)
 - [Model.AddMediaChange](AddMediaChange.md)
 - [Model.AddObjChange](AddObjChange.md)
 - [Model.AddPageChange](AddPageChange.md)
 - [Model.AddRecentColorChange](AddRecentColorChange.md)
 - [Model.AddTypogrphyChange](AddTypogrphyChange.md)
 - [Model.AnalyticsEvent](AnalyticsEvent.md)
 - [Model.AnalyticsResponse](AnalyticsResponse.md)
 - [Model.AppCommonFilesChangesChange](AppCommonFilesChangesChange.md)
 - [Model.AppCommonTypesColorColor](AppCommonTypesColorColor.md)
 - [Model.AppCommonTypesColorRecentColor](AppCommonTypesColorRecentColor.md)
 - [Model.AppCommonTypesFileMediaObject](AppCommonTypesFileMediaObject.md)
 - [Model.AppCommonTypesTypographyTypography](AppCommonTypesTypographyTypography.md)
 - [Model.AppRpcPermissionsPermissions](AppRpcPermissionsPermissions.md)
 - [Model.AssignOperation](AssignOperation.md)
 - [Model.BuiltinTemplate](BuiltinTemplate.md)
 - [Model.CloneTemplate](CloneTemplate.md)
 - [Model.CloneTemplateResult](CloneTemplateResult.md)
 - [Model.CommandCreateFileThumbnailPostDefaultResponse](CommandCreateFileThumbnailPostDefaultResponse.md)
 - [Model.CommandExportBinfilePostRequest](CommandExportBinfilePostRequest.md)
 - [Model.CommandUpdateFilePostDefaultResponseInner](CommandUpdateFilePostDefaultResponseInner.md)
 - [Model.CommandUploadFileMediaObjectPostDefaultResponse](CommandUploadFileMediaObjectPostDefaultResponse.md)
 - [Model.CreateFile](CreateFile.md)
 - [Model.CreateProject](CreateProject.md)
 - [Model.CreateProjectResult](CreateProjectResult.md)
 - [Model.CreateTeam](CreateTeam.md)
 - [Model.CreateTeamInvitations](CreateTeamInvitations.md)
 - [Model.CreateTeamWithInvitations](CreateTeamWithInvitations.md)
 - [Model.DelColorChange](DelColorChange.md)
 - [Model.DelComponentChange](DelComponentChange.md)
 - [Model.DelMediaChange](DelMediaChange.md)
 - [Model.DelObjChange](DelObjChange.md)
 - [Model.DelPageChange](DelPageChange.md)
 - [Model.DelTypogrphyChange](DelTypogrphyChange.md)
 - [Model.DeleteFile](DeleteFile.md)
 - [Model.DeleteProject](DeleteProject.md)
 - [Model.DeleteTeamMember](DeleteTeamMember.md)
 - [Model.DuplicateFile](DuplicateFile.md)
 - [Model.DuplicateFileResult](DuplicateFileResult.md)
 - [Model.Event](Event.md)
 - [Model.File](File.md)
 - [Model.FixObjChange](FixObjChange.md)
 - [Model.GetFile](GetFile.md)
 - [Model.GetProjectFiles](GetProjectFiles.md)
 - [Model.GetProjects](GetProjects.md)
 - [Model.GetTeamInvitations](GetTeamInvitations.md)
 - [Model.GetTeamMembers](GetTeamMembers.md)
 - [Model.Gradient](Gradient.md)
 - [Model.GradientStop](GradientStop.md)
 - [Model.ImageColor](ImageColor.md)
 - [Model.LoginWithPassword](LoginWithPassword.md)
 - [Model.Logout](Logout.md)
 - [Model.ModColorChange](ModColorChange.md)
 - [Model.ModCompoenentChange](ModCompoenentChange.md)
 - [Model.ModMediaChange](ModMediaChange.md)
 - [Model.ModObjChange](ModObjChange.md)
 - [Model.ModPageChange](ModPageChange.md)
 - [Model.ModPagePluginData](ModPagePluginData.md)
 - [Model.ModTypogrphyChange](ModTypogrphyChange.md)
 - [Model.MovObjectsChange](MovObjectsChange.md)
 - [Model.MovPageChange](MovPageChange.md)
 - [Model.MoveFiles](MoveFiles.md)
 - [Model.Operation](Operation.md)
 - [Model.PrepareRegisterProfile](PrepareRegisterProfile.md)
 - [Model.Profile](Profile.md)
 - [Model.Project](Project.md)
 - [Model.PurgeComponentChange](PurgeComponentChange.md)
 - [Model.PushAuditEvents](PushAuditEvents.md)
 - [Model.RecoverProfile](RecoverProfile.md)
 - [Model.RegObjectsChange](RegObjectsChange.md)
 - [Model.RegisterProfile](RegisterProfile.md)
 - [Model.RenameFileParams](RenameFileParams.md)
 - [Model.RenameProject](RenameProject.md)
 - [Model.ReorderChildrenChange](ReorderChildrenChange.md)
 - [Model.RequestProfileRecovery](RequestProfileRecovery.md)
 - [Model.RestoreComponentChange](RestoreComponentChange.md)
 - [Model.SetOperation](SetOperation.md)
 - [Model.SetOptionChange](SetOptionChange.md)
 - [Model.SetOptionChangeOption](SetOptionChangeOption.md)
 - [Model.SetRemoteSyncedOperation](SetRemoteSyncedOperation.md)
 - [Model.SetTouchedOperation](SetTouchedOperation.md)
 - [Model.SimplifiedFile](SimplifiedFile.md)
 - [Model.Team](Team.md)
 - [Model.UpdateFile](UpdateFile.md)
 - [Model.UpdateFileChangesWithMetadataInner](UpdateFileChangesWithMetadataInner.md)
 - [Model.UpdateProfile](UpdateProfile.md)
 - [Model.UpdateProfilePassword](UpdateProfilePassword.md)
 - [Model.UpdateTeam](UpdateTeam.md)
 - [Model.VerifyToken](VerifyToken.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="CookieAuth"></a>
### CookieAuth

- **Type**: API key
- **API key parameter name**: auth-token
- **Location**: 

<a id="AccessToken"></a>
### AccessToken

- **Type**: Bearer Authentication


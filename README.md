# blazor-static-web-app

## Introduction

Example Blazor Wasm application, with Azure Function API

This application is the same as built in my talk [Deploying Client Side Blazor to a Static Web App](https://sessionize.com/s/stacy-cashmore/deploying_client_side_blazor_to_a_s/37319).

The talks can be found here:
 * [.NET Frontend Day 2021](https://www.youtube.com/watch?v=1VzG0PIcfq8)
 * [4DotNet Conf](https://www.youtube.com/watch?v=PLEi7UUs4N8&trk)

## Running the application locally

The application will compile and run locally, and can be extended as wished.

But there are steps needed to do so

* Set both `Api` and `Client` projects to startup
  * Open the solution
  * Right click on the solution to bring up the context menu
  * Click on `Properties` <br /> ![Solution context menu](images\solution-context-menu.png)
  * In the window that opens <br /> ![Solution properties window](images\solution-properties.png)

* Create localSettings for Api project
  * Create a new file in the root of the Api project
  * Add this json to the file

``` json
{
    "IsEncrypted": false,
    "Values": {
        "AzureWebJobsStorage": "UseDevelopmentStorage=true",
        "FUNCTIONS_WORKER_RUNTIME": "dotnet"
    }
}
```

## Deploying the application

The github workflow file is included for completeness, but not usable.

To deploy the application it needs to be removed, and a new workflow file should be created. To do this create a new [Azure Static Web App](https://docs.microsoft.com/en-us/azure/static-web-apps?WT.mc_id=AZ-MVP-5003925) in the portal.
